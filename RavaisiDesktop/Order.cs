using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RavaisiDesktop
{
    internal class Order
    {
        string dbconnect = "server=127.0.0.1; User=root; password=;database=ravaisi";
        String orderString;
        public String table;
        ArrayList products = new ArrayList();
        String price;
        String products_string;
        String current_order;
        public ArrayList order = new ArrayList();
        public ArrayList orderStrings = new ArrayList();
        public String orderId;
        String content = "";
        public String orderIndex;
        Product product1;
        public Boolean loaded;
        public Boolean printed;
        public Boolean mergedOrders;
        String stringToPrint;
        Font font = new Font(FontFamily.GenericMonospace, 8);
        Boolean setHeader = false;
        PrintDocument printDocument = new PrintDocument();
        class Product
        {
            public String name;
            public String price;
            public String quantity;
            public String toppings;
            public String comments;
           
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
            
        }

        public Order(String orderString, String price, String orderId, Boolean loaded, Boolean printed, String orderIndex)
        {
            this.orderString = orderString;
            this.table = this.orderString.Split('|')[0].Split('{')[1].Split('}')[0].Split(':')[1].Trim();
            this.price = price; 
            this.orderId = orderId;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            this.loaded = loaded;
            this.printed = printed;
            this.orderIndex = orderIndex;
            
        }
        
        
        int getOrderStrings()
        {
            orderStrings.Clear();
            String sql_command = "SELECT * FROM orders WHERE closed=0 AND order_table=" + "'" + this.table + "'" + "ORDER BY order_index DESC";
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = dbconnect;
            connect.Open();
            MySqlCommand command = new MySqlCommand(sql_command);
            command.Connection = connect;
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            DataRow[] rows = dt.AsEnumerable().ToArray(); 
            foreach (DataRow row in rows)
            {
                orderStrings.Add(row["order_string"].ToString() + "#" + row["order_index"]);
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
            mergedOrders = true;
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

        public ArrayList getAddedOrder(string ordStr)
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
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 235 + ((int)(getOrderLines() * (font.Size * 2))));
                printDocument.DocumentName = CreateDocument(this.table, this.order, tab);
                stringToPrint = getOrderString(this.order);
                setHeader = false;
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                printDocument.Print(); 
                setPrintedAsTrue(tab);
                return;
            }
            String sql_command = "SELECT order_string FROM orders WHERE closed=0 AND order_table='" + this.table + "'";
            if (!tab.Equals("ALL"))
                sql_command += " AND order_index=" + tab;
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
            reader.Read();
            result += reader.GetString(0);
            reader.Close();
            connect.Close();
            this.order = getAddedOrder(result);
            stringToPrint = getOrderString(this.order);         
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 195 + (int)(getOrderLines() * font.Size));   
            printDocument.DocumentName = CreateDocument(this.table, this.order, tab);
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printDocument.Print();
            setPrintedAsTrue(tab);
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
                String sql_command = "SELECT order_string FROM orders WHERE closed=0 AND order_table='" + this.table + "'" + " AND order_index=" + tab;
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

            //e.Graphics.DrawString(stringToPrint, font, Brushes.Black, new Point(5, 200));

            
            int y = 200;
            int line_offset = 25;

            foreach (Product product in order)
            {
                e.Graphics.DrawString(product.quantity + " " + product.name,new Font("Arial", 15, FontStyle.Bold),Brushes.Black, new Point(5, y ));
                y += line_offset;
                if (!product.toppings.Equals(""))
                {
                    e.Graphics.DrawString(product.toppings, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(5, y));
                    y += line_offset;
                }
                if (!product.comments.Equals(""))
                {
                    e.Graphics.DrawString("Σχολια:" + product.comments, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, y));
                    y += line_offset*2;
                }
            }
            //e.Graphics.MeasureString(stringToPrint, this.font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
          
           //  e.Graphics.DrawString(stringToPrint, this.font, Brushes.Black, e.MarginBounds.Left-90, e.MarginBounds.Right, StringFormat.GenericTypographic);

//            stringToPrint = stringToPrint.Substring(charactersOnPage);//
            e.HasMorePages = false;
            setHeader = false;
            
        }
       
        private void setPrintedAsTrue(String order_id)
        {
            String sql_command = "UPDATE orders SET printed=1 where closed=0 AND order_table='" + this.table + "'";
            if (order_id != "ALL")
                sql_command += " AND order_index=" + order_id;   
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