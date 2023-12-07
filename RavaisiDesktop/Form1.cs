using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using PrinterUtility;
namespace RavaisiDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public string dbconnect = "server=127.0.0.1; User=root; password=;database=ravaisi";
        private int lastIndex;
        private int openRowsCount;
        private String sql_cmd = "SELECT * FROM orders WHERE closed=0 AND order_index=1";
        private bool autoprint;
        private void Form1_Load(object sender, EventArgs e)
        {
            openOrdersRdBtn.PerformClick();
            ipLabel.Text = "Machine IP: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            this.lastIndex = 0;
            Task.Run(() => checkForChanges());
            //initializePrinter();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getOrdersBtn_Click(object sender, EventArgs e)
        {
            getOrders();
        }
        private int getLastIndex()
        {
            String sql_command = "SELECT id FROM orders ORDER BY id DESC LIMIT 1";
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = dbconnect;
            connect.Open();
            MySqlCommand command = new MySqlCommand(sql_command);
            command.Connection = connect;
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
                connect.Close();
            }
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
                    this.Invoke(new Action (()=>getOrders()));
                }
                if(DeletedOrderCheck())
                {
                    this.Invoke(new Action(() => getOrders()));
                }
            }
        }
        
        private Order[] getNewOrders()
        {
            return null;
        }

        private void autoPrint()
        { }
        private bool DeletedOrderCheck()
        {
            if (this.openRowsCount > getOpenRowsCount())
            {
                this.openRowsCount = getOpenRowsCount();
                return true;
            }
            //this.openRowsCount = getOpenRowsCount();
            return false;

        }
   
        public void getOrders()
        {
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = dbconnect;
            connect.Open();
            MySqlCommand command = new MySqlCommand(sql_cmd);
            command.Connection = connect;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            ordersGridView.DataSource = bindingSource;
            ordersGridView.Columns["order_string"].Visible = false;
            ordersGridView.Columns["loaded"].Visible = false;
            ordersGridView.Columns["price"].Visible = false;


            foreach (DataGridViewRow row in ordersGridView.Rows)
            {
                if (row.Cells["id"].Value == null)
                    break;
                Order order = new Order(row.Cells["order_String"].Value.ToString(), row.Cells["price"].Value.ToString(), row.Cells["id"].Value.ToString());
            }
        
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Order order = new Order(ordersGridView.Rows[e.RowIndex].Cells["order_string"].Value.ToString(), ordersGridView.Rows[e.RowIndex].Cells["price"].Value.ToString(), ordersGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                //order.mergeOrders();
                order.Show();
            }
            catch
            {

            }
        }


        private void openOrdersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            sql_cmd = "SELECT * FROM orders WHERE closed=0 AND order_index=1";
            getOrders();
        }

        private void newOrders_CheckedChanged(object sender, EventArgs e)
        {
            sql_cmd = "SELECT * FROM orders WHERE closed=0 AND loaded=0";
            getOrders();
        }

        

        private void allOrdersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            sql_cmd = "SELECT * FROM orders";
            getOrders();
        }

        private void autoPrintChBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
    