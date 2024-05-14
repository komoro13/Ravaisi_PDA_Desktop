using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using PrinterUtility;
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
        private String current_sql_cmd;
        private bool autoprint;
        private int ordersCount;
        private int loadedOrders;
        private int activeOrders;

        List<Order> orders;
        
        private void TablesForm_Load(object sender, EventArgs e)
        {
            
            openOrdersRdBtn.PerformClick();
            ipLabel.Text = "Machine IP Address: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            this.lastIndex = 0;

            Task.Run(() => checkForChanges());

            //initializePrinter();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getOrdersBtn_Click(object sender, EventArgs e)
        {
            getOrders(current_sql_cmd);
            showOrders(false);
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

        private void showOrders(bool loaded)
        {
            int ButtonX = 100;
            int ButtonY = 50;
            int StandardButtonX = 100;
            int ButtonWidth = 200;
            int ButtonHeight = 150;
            if (!loaded)
                TablesPanel.Controls.Clear();           
            foreach (Order order in orders)
            {
                Button button = createButton(order.table, order.table + "Btn", new Point(ButtonX, ButtonY), ButtonWidth, ButtonHeight, (s, e) => orderButtonClick(s, e, order));
                TablesPanel.Controls.Add(button);
                
                if ((button.Location.X + 10 + 2*ButtonWidth) > Screen.PrimaryScreen.Bounds.Width)
                {
                    ButtonX = StandardButtonX;
                    ButtonY = ButtonY + 10 + ButtonHeight;
                }
                else
                {
                    ButtonX += ButtonWidth + 10;
                }
            }
            updateReadOrderButtons();
        }
        void orderButtonClick(object sender, EventArgs e, Order order)
        {
            order.Show();
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
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
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
        
        
        //private void initializePrinter()
        //{
          //  PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            //var BytesValue = Encoding.ASCII.GetBytes("Ραβαΐσι");
            //BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Test"));
           // BytesValue = PrintExtensions.AddBytes(BytesValue, cut_page());
            //MessageBox.Show(RavaisiDesktop.Properties.Settings.Default.PrinterPath);
           // PrinterUtility.PrintExtensions.Print(BytesValue, Properties.Settings.Default.PrinterPath);            
            //}

        public byte[] cut_page()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            oby.Add(Convert.ToByte('V'));
            oby.Add((byte)66);
            oby.Add((byte)3);
            return oby.ToArray();
        }
        private bool checkForNewOrder()
        {
            if (this.lastIndex < getLastIndex())
            {
                this.lastIndex = getLastIndex();
                return true;
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
        private int getOpenRowsCount()
        {
            String sql_command = "SELECT COUNT(*) FROM orders WHERE closed=0";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = dbconnect;
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql_command);
            command.Connection = conn;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
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
                conn.Close();
            }
            return int.Parse(result);
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
                    this.Invoke(new Action (()=>getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders(false)));   
                }
                if (checkForLoadedOrders())
                {
                    this.Invoke(new Action(() => getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders(true)));                    
                }
                
                if (checkForActiveOrders())
                {
                    this.Invoke(new Action(() => getOrders(current_sql_cmd)));
                    this.Invoke(new Action(() => showOrders(false)));
                }
            }
            
        }
        
        private Order[] getNewOrders()
        {
            return null;
        }

        private void autoPrint()
        { }
      
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
                Order order = new Order(row.Cells["order_String"].Value.ToString(), row.Cells["price"].Value.ToString(), row.Cells["id"].Value.ToString(), ((Boolean)row.Cells["loaded"].Value));

                orders.Add(order);

            }

        
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Order order = new Order(ordersGridView.Rows[e.RowIndex].Cells["order_string"].Value.ToString(), ordersGridView.Rows[e.RowIndex].Cells["price"].Value.ToString(), ordersGridView.Rows[e.RowIndex].Cells["id"].Value.ToString(), ((Boolean)ordersGridView.Rows[e.RowIndex].Cells["loaded"].Value));
                //order.mergeOrders();
                order.Show();
            }
            catch
            {

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
            current_sql_cmd = OPEN_ORDERS_SQL_CMD;
            getOrders(current_sql_cmd);
            showOrders(false);
        }

        private void newOrders_CheckedChanged(object sender, EventArgs e)
        {
            current_sql_cmd = NEW_ORDERS_SQL_CMD;
            getOrders(current_sql_cmd);
            showOrders(false);
        }
        

        private void allOrdersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            current_sql_cmd = ALL_ORDERS_SQL_CMD;
            getOrders(current_sql_cmd);
            showOrders(false);
        }

        private void autoPrintChBox_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void TablesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    