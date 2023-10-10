using Aspose.Words.Drawing.Ole;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RavaisiDesktop
{
    internal class Order
    {
        string dbconnect = "server=127.0.0.1; User=root; password=;database=ravaisi";
        String orderString;
        String table;
        ArrayList products = new ArrayList();
        String price;
        String products_string;
        ArrayList order = new ArrayList();
        orderForm orderForm1;
        ArrayList orderStrings = new ArrayList();
        String orderId;
        String content = "";
        Product product1;
        String stringToPrint;
        Font font = new Font(FontFamily.GenericMonospace, 8);
        Boolean setHeader = false;
        PrintDocument printDocument = new PrintDocument();
        class Product
        {
            String name;
            String price;
            String quantity;
            String toppings;
            String comments;
            
            public Product(String name, String price, String quantity, String toppings, String comments)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.toppings = toppings;
                this.comments = comments;
            }
            public String GetString()
            {
                String result;
                if (this.toppings.Equals(String.Empty))
                {
                    result = this.quantity + " " + this.name; // + " " + this.toppings;
                    for (int j = 0; j <= (30 - this.name.Length); j++)
                    {
                        result += "-";
                    }
                }
                else
                {
                    result = this.quantity + " " + this.name;
                    for (int j = 0; j <= (30 - this.name.Length); j++)
                    {
                        result += "-";
                    }
                }
                result += (float.Parse(this.price)) / 10;
                if ((float.Parse(this.price) / 10).ToString().Contains(","))
                    result += "0";
                else result += ",00";
                result += " €";
                if (!this.toppings.Equals(String.Empty))
                    result += "\nΥλικα: " + this.toppings;
                result += "\nΣχολια: " + alignComments(this.comments);
                return result;
            }

            public string alignComments(string comments)
            {
                String str = comments;
                
                if (str.Length > 30)
                {
                    str = str.Insert(30, "\n");
                    if (str.Length > 67)
                        str = str.Insert(68, "\n");
                    return str;
                }
                return str;
            }
            public String GetStringForThermal()
            {
                String result;
                if (this.toppings.Equals(String.Empty))
                {
                    result = this.quantity + " " + this.name; // + " " + this.toppings;
                    for (int j = 0; j <= (40 - this.name.Length); j++)
                    {
                        result += "-";
                    }
                }
                else
                {
                    result = this.quantity + " " + this.name;
                    for (int j = 0; j <= (40 - this.name.Length); j++)
                    {
                        result += "-";
                    }
                }
                result += ((float.Parse(this.price)) / 10).ToString();
                MessageBox.Show(((float.Parse(this.price)) / 10).ToString());
                if (this.price.Contains(","))
                    result += "0";
                result += "€";
                if (!this.toppings.Equals(String.Empty))
                    result += "\nΥλικα: " + this.toppings;
                result += "\nΣχολια: " + this.comments;
                return result;
            }

        }

        public Order(String orderString, String price, String orderId)
        {
            this.orderString = orderString;
            this.table = this.orderString.Split('|')[0].Split('{')[1].Split('}')[0].Split(':')[1].Trim();
            this.price = price; 
            this.orderId = orderId;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

        }
        
        int getOrderStrings()
        {
            this.orderStrings.Clear();
            String sql_command = "SELECT * FROM orders WHERE closed=0 AND order_table=" + "'" + this.table + "'" + "ORDER BY order_index DESC";
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = this.dbconnect;
            connect.Open();
            MySqlCommand command = new MySqlCommand(sql_command);
            command.Connection = connect;
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            DataRow[] rows = dt.AsEnumerable().ToArray(); 
            foreach (DataRow row in rows)
            {
                this.orderStrings.Add(row["order_string"].ToString() + "#" + row["order_index"]);
            }
            return rows.Length;
        }
        
        public void mergeOrders()
        {
            getOrderStrings();
            string pdString;
            ArrayList prods = new ArrayList();
            foreach(string ordString in this.orderStrings)
            {
                prods = new ArrayList();
                pdString = ordString.Split('|')[1].Split('#')[0];
                foreach (string prod in pdString.Split('}'))
                {
                    if (prod.Equals("&amp;"))
                        break;
                    prods.Add(prod.Split('{')[1].Replace("&amp;", "+").Replace("&lt;", "<").Replace("&gt;", ">"));
             
                }

                foreach (String pd in prods)
                {
                    if (pd.Split('[')[1].Split(']')[0].Equals(String.Empty))
                        if (pd.Split('<')[1].Split('>')[0].Equals(String.Empty))
                            this.order.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], pd.Split('+')[3].Split(':')[1], "", ""));
                        else this.order.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], pd.Split('+')[3].Split(':')[1], "", pd.Split('<')[1].Split('>')[0]));

                    else
                    {
                        foreach (String item in pd.Split('[')[1].Split(']')[0].Split('_'))
                        {
                            if (item == String.Empty)
                                break;
                            if (item.Split('<')[1].Split('>')[0] != String.Empty)
                                this.order.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], item.Split('(')[1].Split(')')[0], item.Split('<')[0], pd.Split('<')[1].Split('>')[0]));
                            else
                                this.order.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], item.Split('(')[1].Split(')')[0], item.Split('<')[0], ""));
                        }
                    }
                }

            }

        }
        public String getOrderString(ArrayList ord)
        {
            double price;
            price = 0;
            String orderStr = "";
            foreach (Product pr in ord)
            {
                orderStr = orderStr + pr.GetString() + "\n";

                price += double.Parse(pr.GetString().Split('-')[pr.GetString().Split('-').Length - 1].Split(' ')[0]);
            }
            orderStr += "Συνολο: ";
            orderStr += price.ToString();
            if (price.ToString().Contains(","))
                orderStr += "0";
            orderStr += " €";
            return orderStr;
        }
        ArrayList getAddedOrder(string ordStr)
        {
            string ordString = ordStr.Split('#')[0];
            string prodString;
            string result = "";
            ArrayList order1 = new ArrayList();
            ArrayList prods = new ArrayList();
            prodString = ordString.Split('|')[1];
            foreach (string prod in prodString.Split('}'))
            {

                if (prod.Equals("&amp;"))
                    break;
                prods.Add(prod.Split('{')[1].Replace("&amp;", "+").Replace("&lt;", "<").Replace("&gt;", ">"));
            }

            foreach (String pd in prods)
            {
                if (pd.Split('[')[1].Split(']')[0].Equals(String.Empty))
                    if (pd.Split('<')[1].Split('>')[0].Equals(String.Empty))
                        order1.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], pd.Split('+')[3].Split(':')[1], "", ""));
                    else order1.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], pd.Split('+')[3].Split(':')[1], "", pd.Split('<')[1].Split('>')[0]));

                else
                {
                    foreach (String item in pd.Split('[')[1].Split(']')[0].Split('_'))
                    {
                        if (item == String.Empty)
                            break;
                        if (item.Split('<')[1].Split('>')[0] != String.Empty)
                            order1.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], item.Split('(')[1].Split(')')[0], item.Split('<')[0], pd.Split('<')[1].Split('>')[0]));
                        else
                            order1.Add(new Product(pd.Split('+')[0].Split(':')[1], pd.Split('+')[1].Split(':')[1], item.Split('(')[1].Split(')')[0], item.Split('<')[0], ""));
                    }
                }
            }
            return order1;
        }
        public void Show()
        {
            setOrderAsLoaded(true);
            this.orderForm1 = new orderForm(this.orderString, this.price, this.orderId);
            this.orderForm1.Show();
            mergeOrders();
            this.orderForm1.addOrderTab(getOrderString(this.order), "Ολη η παραγγελια");
            this.orderForm1.tableLabel.Text = "Τραπεζι: " + this.table;
            foreach (string orderSt in this.orderStrings)
            {   
                this.orderForm1.addOrderTab(getOrderString(getAddedOrder(orderSt)), "Παραγγελια: " + orderSt.Split('#')[1]);
            }

        }


        
        private string CreateDocument(string orderTable, ArrayList order, string index)
        {
           
            return "C:\\Users\\tbogi\\Desktop\\orders\\" + orderTable + "_" + index + ".docx";
                
        }
       
        public void print(String tab)
        {
            String filename;
            PrintDialog printDialog = new PrintDialog();
            if (tab.Equals("ALL"))
            {
                mergeOrders();
                stringToPrint = getOrderString(this.order);
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 235 + ((int)(getOrderLines() * (font.Size * 2))));
                printDocument.DocumentName = CreateDocument(this.table, this.order, tab);
                //printDocument.Print();
                //printDialog.Document = printDocument;
                //printDialog.AllowSelection = true;
                //printDialog.AllowSomePages = true;
                stringToPrint = getOrderString(this.order);
                setHeader = false;
              //  if (printDialog.ShowDialog() == DialogResult.OK)
                //{
                    printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                    printDocument.Print();
                //}
                return;
            }
            String sql_command = "SELECT order_string FROM orders WHERE closed=0 AND order_table=" + "'" + this.table + "'" + " AND order_index=" + tab;
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
            this.order = getAddedOrder(result);
            stringToPrint = getOrderString(this.order);
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 195 + (int) (getOrderLines()*font.Size));
            printDocument.DocumentName = CreateDocument(this.table, this.order, tab);
            //printDialog.Document = printDocument;
            //printDialog.AllowSelection = true;
            //printDialog.AllowSomePages = true;

            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                printDocument.Print();
            //}
            return;

        }

        public void preview(String tab)
        {
            if (tab.Equals("ALL"))
            {
                mergeOrders();
                stringToPrint = getOrderString(this.order);
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 245 + ((int)(getOrderLines() * (font.Size * 2))));
            }
            else
            {
                String sql_command = "SELECT order_string FROM orders WHERE closed=0 AND order_table=" + "'" + this.table + "'" + " AND order_index=" + tab;
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

                this.order = getAddedOrder(result);
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 245 + ((int)(getOrderLines() * (font.Size * 2))));
                stringToPrint = getOrderString(this.order);
            }
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }
        public int getOrderLines()
        {
            int lines = 0;
            for (int x = 0; x < getOrderString(this.order).ToCharArray().Length;x++)
            {
                if (getOrderString(this.order).ToCharArray()[x] == '\n') 
                    lines = lines + 1;
            }
            return lines;
        }
        private void printDocument_PrintPage(Object sender, PrintPageEventArgs e)
        
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
          
            if (!setHeader)
            {

                e.Graphics.DrawString("Ραβαΐσι", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(90, 20));
                e.Graphics.DrawString("Καλλιμασια, Χίος", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(20, 55));
                e.Graphics.DrawString("Τηλεφωνο: 2271103598", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(20, 80));
                e.Graphics.DrawString("Αριθμος παραγγελιας: " + orderId.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 125));
                e.Graphics.DrawString("Τραπεζι: " + table, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 160));
                setHeader = true;
            }

            e.Graphics.DrawString(stringToPrint, font, Brushes.Black, new Point(5, 200));
            //e.Graphics.MeasureString(stringToPrint, this.font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
          
           //  e.Graphics.DrawString(stringToPrint, this.font, Brushes.Black, e.MarginBounds.Left-90, e.MarginBounds.Right, StringFormat.GenericTypographic);

//            stringToPrint = stringToPrint.Substring(charactersOnPage);//
            e.HasMorePages = false;
    
            
        }
        public void  printThermal()
        {

        }
        private void setPrintedAsTrue()
        {

        }
        public void closeOrder()
        {
            String sql_command = "UPDATE orders SET closed=1 where closed=0 AND order_table=" + "'" + this.table + "'";
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
        }

        public void setOrderAsLoaded(bool loaded)
        {
            String sql_command;
            if (loaded)
            {
                sql_command = "UPDATE orders SET loaded=1 where closed=0 AND order_table=" + "'" + this.table + "'";
            }
            else
            {
                sql_command = "UPDATE orders SET loaded=0 where closed=0 AND order_table=" + "'" + this.table + "'";
            }
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
        }
    }

}   