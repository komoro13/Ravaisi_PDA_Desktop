using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RavaisiDesktop
{
    public partial class orderForm : Form
    {
        string orderId;
        string orderString;
        string price;
        string orderTable;
        public string dbconnect = "server=127.0.0.1; User=root; password=;database=ravaisi";
        Font font = new Font(FontFamily.GenericMonospace, 15);
        String stringToPrint;
        public orderForm(string orderString, string price, string orderId)
        {
            InitializeComponent();
            this.orderString = orderString;
            this.price = price;
            this.orderId = orderId;
            orderIdLabel.Text = "Order id: " + orderId;
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            ordersTabsControl.TabPages.Clear();
        }

        private void tableLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void checkLabel_Click(object sender, EventArgs e)
        {

        }
        public void addOrderTab(String orderString, String text)
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

        private void printBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order(this.orderString, this.price, this.orderId);
            if (ordersTabsControl.SelectedIndex == 0)
            {
                order.print("ALL");
                return;
            }
            order.print(((TabPage)ordersTabsControl.TabPages[ordersTabsControl.SelectedIndex]).Text.Split(':')[1]);
        }
       
        private void closeOrderBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order(this.orderString, this.price, this.orderId);
            order.closeOrder();
            MessageBox.Show("Το τραπεζι " + this.orderTable + "ειναι ελεθερο");
            
            Close();
        }
       

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order order = new Order(this.orderString, this.price, this.orderId);
            if (ordersTabsControl.SelectedIndex == 0)
            {
                order.preview("ALL");
                return;
            }
            order.preview(ordersTabsControl.SelectedIndex.ToString());
        }

        private void thermalPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage;
            int linesPerPage;
           

            e.Graphics.MeasureString(stringToPrint, this.font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, this.font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);//
            e.HasMorePages = (stringToPrint.Length > 0);


        }
    }
}
