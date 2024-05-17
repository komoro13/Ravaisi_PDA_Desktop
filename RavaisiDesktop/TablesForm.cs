using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace RavaisiDesktop
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }
        public string dbconnect = "server=127.0.0.1; User=root; password=;database=ravaisi";
        private int lastIndex;
        private int openRowsCount;
        private String OPEN_ORDERS_SQL_CMD = "SELECT * FROM orders WHERE closed=0 AND order_index=1";
        private String NEW_ORDERS_SQL_CMD = "SELECT * FROM orders WHERE closed=0 AND loaded=0";
        private String ALL_ORDERS_SQL_CMD = "SELECT * FROM orders";
        private String COUNT_OPEN_ORDERS_SQL_CMD = "SELECT COUNT(*) FROM orders WHERE closed=0 AND order_index=1";
        private String COUNT_NEW_ORDERS_SQL_CMD = "SELECT COUNT(*) FROM orders WHERE closed=0 AND loaded=0";
        private String ALL_ORDERS_FOR_PRINTING_SQL_CMD = "SELECT * FROM orders WHERE closed=0 AND printed=0";
        private String current_sql_cmd;
        private int ordersCount;
        private int loadedOrders;
        private int activeOrders;

        Order loadedOrder;

        Font font = new Font(FontFamily.GenericMonospace, 15);
        String stringToPrint;

        List<Order> orders;
        
        private void TablesForm_Load(object sender, EventArgs e)
        {
            
            openOrdersRdBtn.PerformClick();
            ipLabel.Text = "Machine IP Address: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            this.lastIndex = 0;
            Task.Run(() => checkForChanges());

            //initializePrinter();
        }
        
        private void getOrdersBtn_Click(object sender, EventArgs e)
        {
            getOrders(current_sql_cmd);
            showOrders();
        }

        private Button createButton(string text,string name,Point location,int width, int height , Action <object, EventArgs> click)
        {
            Button b = new Button()
            {
                Text = text,
                Name = name,
                Location = location,
                Width = width,
                Height = height
               
            };
            b.Click += new EventHandler(click);
            return b;
        }

        private void showOrders()
        {

            int ButtonX = 15;
            int ButtonY = 15;
            int StandardButtonX = 15;
            int ButtonWidth = 200;
            int ButtonHeight = 150;
            
            TablesPanel.Controls.Clear();  
            
            foreach (Order order in orders)
            {
                Button button = createButton(order.table, order.table + "Btn", new Point(ButtonX, ButtonY), ButtonWidth, ButtonHeight, (s, e) => orderButtonClick(s, e, order));
                TablesPanel.Controls.Add(button);

                if ((button.Location.X + 100 + ButtonWidth) > TablesPanel.Bounds.Width)
                {
                    ButtonX = StandardButtonX;
                    ButtonY = ButtonY + 10 + ButtonHeight;
                }
                else
                {
                    ButtonX += ButtonWidth + StandardButtonX;
                }
            }        
          
            updateReadOrderButtons(); 
        }

        void orderButtonClick(object sender, EventArgs e, Order order)
        {
            showOrder(order);
        }
     
        private MySqlCommand sql_query(string cmd)
        {
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = dbconnect;
            connect.Open();
            MySqlCommand command = new MySqlCommand(cmd);
            command.Connection = connect;
            return command;
        }

        private String readResult(MySqlCommand command)
        {
            String result = "";
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    result = result + reader.GetString(0);
                }
            }
            finally
            {
                reader.Close();
                command.Connection.Close();
            }
            return result;
        }

        private int getLastIndex()
        {
            String sql_command = "SELECT id FROM orders ORDER BY id DESC LIMIT 1";
            MySqlCommand command = sql_query(sql_command);
            string result = readResult(command);

            if (!result.Equals(""))
                return int.Parse(result);
            else return 0;
        }

        private int getActiveOrders()
        {
            MySqlCommand command = sql_query(COUNT_OPEN_ORDERS_SQL_CMD);
            string result = readResult(command);       
            if (!result.Equals(""))
                return int.Parse(result);
            else return 0;

        }

        private int getLoadedOrders()
        {
            MySqlCommand command = sql_query(COUNT_NEW_ORDERS_SQL_CMD);
            string result = readResult(command);
            if (!result.Equals(""))
                return int.Parse(result);
            else return 0;

        }  

        private bool checkForNewOrder()
        {
            if (this.lastIndex < getLastIndex())
            {
                this.lastIndex = getLastIndex();
                {
                    return true;
                }
            }
            //this.lastIndex = getLastIndex();
            return false;
          
        }

        private bool checkForActiveOrders()
        {               
            if (this.activeOrders != getActiveOrders())
            {                
                this.activeOrders = getActiveOrders();
                return true;
            }         
            return false;
        }

        private bool checkForLoadedOrders()
        {
            if (this.loadedOrders != getLoadedOrders())
            {              
                this.loadedOrders = getLoadedOrders();
                return true;
            }
            return false;
        }       

        private void printNewOrders()
        {
            getOrders(ALL_ORDERS_FOR_PRINTING_SQL_CMD);
            foreach (Order order in orders)
            {
                if (!order.printed)
                {            
                    order.print(order.orderIndex);             
                }
            }
            getOrders(current_sql_cmd);
        }

        private bool checkForChanges()
        {
            while (true)
            {
                if (checkForNewOrder())
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("bell.wav");
                    player.Play();
                    //MessageBox.Show("Νεα παραγγελια!");
                    this.Invoke(new Action(() => getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders()));
                }
                if (checkForLoadedOrders())
                {
                    this.Invoke(new Action(() => getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders()));
                }
                if (autoPrintChBox.Checked) printNewOrders();
                if (checkForActiveOrders())
                {
                    this.Invoke(new Action(() => getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders()));
                }
                    
                    
            }

        }

        private void addOrderTab(String orderString, String text)
        {
            { 
                TabPage tabPage = new TabPage();
                tabPage.Text = text;
                Label label = new Label();
                label.Text = orderString;
                tabPage.AutoScroll = true;
                tabPage.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new Font(FontFamily.GenericMonospace, label.Font.Size);
                ordersTabsControl.TabPages.Add(tabPage);
            }
        }

        private void showOrder(Order order)
        {
            loadedOrder = order;
            order.setOrderAsLoaded(true);
            ordersTabsControl.TabPages.Clear();
            if (!order.mergedOrders)
                order.mergeOrders();          
            addOrderTab(order.getOrderString(order.order), "Ολη η παραγγελια");
            tableLabel.Text = "Τραπεζι " + order.table;
            foreach(String orderString in order.orderStrings)
            {
                addOrderTab(order.getOrderString(order.getAddedOrder(orderString)), "Παραγγελια: " + orderString.Split('#')[1]);
            }


        }

        public void getOrders(string cmd)
        {
            MySqlCommand command = sql_query(cmd);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(); 
            adapter.SelectCommand = command;
            adapter.Fill(dt);
   
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            ordersGridView.DataSource = bindingSource;
            ordersGridView.Columns["order_string"].Visible = false;
            ordersGridView.Columns["loaded"].Visible = false;
            ordersGridView.Columns["price"].Visible = false;           
            orders = new List<Order>();
            foreach (DataGridViewRow row in ordersGridView.Rows)
            {
                if (row.Cells["id"].Value == null)
                    break;
                Order order = new Order(row.Cells["order_String"].Value.ToString(), row.Cells["price"].Value.ToString(), row.Cells["id"].Value.ToString(), ((Boolean)row.Cells["loaded"].Value), ((Boolean)row.Cells["printed"].Value), row.Cells["order_index"].Value.ToString());
                orders.Add(order);
            }
            
        
        }

        private void updateReadOrderButtons()
        {
            
            getOrders(NEW_ORDERS_SQL_CMD);
            
            foreach (Control control in TablesPanel.Controls)
           {
                Button btn = ((Button)control);
                btn.BackColor = Color.Green;
                foreach (Order order in orders)
                {                   
                    if (btn.Text == order.table)
                    {
                        if (!order.loaded)
                            btn.BackColor = Color.Red;                                   
                    }
                }
            }
            getOrders(current_sql_cmd);
        }

        private void openOrdersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (openOrdersRdBtn.Checked)
            {
                current_sql_cmd = OPEN_ORDERS_SQL_CMD;
                getOrders(current_sql_cmd);
                showOrders();
            }
        }

        private void newOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (newOrders.Checked)
            {
                current_sql_cmd = NEW_ORDERS_SQL_CMD;
                getOrders(current_sql_cmd);
                showOrders();
            }
        }
        
        private void allOrdersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (allOrdersRdBtn.Checked)
            {
                current_sql_cmd = ALL_ORDERS_SQL_CMD;
                getOrders(current_sql_cmd);
                showOrders();
            }
        }

        private void autoPrintChBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TablesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (ordersTabsControl.SelectedIndex == 0)
            {
                loadedOrder.print("ALL");
                return;
            }
            loadedOrder.print(((TabPage)ordersTabsControl.TabPages[ordersTabsControl.SelectedIndex]).Text.Split(':')[1]);
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            if (ordersTabsControl.SelectedIndex == 0)
            {
                loadedOrder.preview("ALL");
                return;
            }
            loadedOrder.preview(ordersTabsControl.SelectedIndex.ToString());
        }

        private void closeOrderBtn_Click(object sender, EventArgs e)
        {
            loadedOrder.closeOrder();
        }
    }
}
    