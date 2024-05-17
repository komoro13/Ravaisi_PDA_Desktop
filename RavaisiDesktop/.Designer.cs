namespace RavaisiDesktop
{
    partial class TablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            this.getOrdersBtn = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.ipLabel = new System.Windows.Forms.Label();
            this.openOrdersRdBtn = new System.Windows.Forms.RadioButton();
            this.newOrders = new System.Windows.Forms.RadioButton();
            this.allOrdersRdBtn = new System.Windows.Forms.RadioButton();
            this.autoPrintChBox = new System.Windows.Forms.CheckBox();
            this.TablesPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.previewBtn = new System.Windows.Forms.Button();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.ordersTabsControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printBtn = new System.Windows.Forms.Button();
            this.closeOrderBtn = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.OrderPanel.SuspendLayout();
            this.ordersTabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getOrdersBtn
            // 
            this.getOrdersBtn.Location = new System.Drawing.Point(1266, 934);
            this.getOrdersBtn.Name = "getOrdersBtn";
            this.getOrdersBtn.Size = new System.Drawing.Size(151, 45);
            this.getOrdersBtn.TabIndex = 1;
            this.getOrdersBtn.Text = "Get orders";
            this.getOrdersBtn.UseVisualStyleBackColor = true;
            this.getOrdersBtn.Click += new System.EventHandler(this.getOrdersBtn_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(1222, 79);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(84, 40);
            this.ordersGridView.TabIndex = 2;
            this.ordersGridView.Visible = false;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(1616, 884);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(76, 16);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Machine IP:";
            // 
            // openOrdersRdBtn
            // 
            this.openOrdersRdBtn.AutoSize = true;
            this.openOrdersRdBtn.Location = new System.Drawing.Point(1266, 830);
            this.openOrdersRdBtn.Name = "openOrdersRdBtn";
            this.openOrdersRdBtn.Size = new System.Drawing.Size(161, 20);
            this.openOrdersRdBtn.TabIndex = 5;
            this.openOrdersRdBtn.TabStop = true;
            this.openOrdersRdBtn.Text = "Ανοιχτες παραγγελιες";
            this.openOrdersRdBtn.UseVisualStyleBackColor = true;
            this.openOrdersRdBtn.CheckedChanged += new System.EventHandler(this.openOrdersRdBtn_CheckedChanged);
            // 
            // newOrders
            // 
            this.newOrders.AutoSize = true;
            this.newOrders.Location = new System.Drawing.Point(1610, 830);
            this.newOrders.Name = "newOrders";
            this.newOrders.Size = new System.Drawing.Size(172, 20);
            this.newOrders.TabIndex = 6;
            this.newOrders.TabStop = true;
            this.newOrders.Text = "Καινουριες παραγγελιες";
            this.newOrders.UseVisualStyleBackColor = true;
            this.newOrders.CheckedChanged += new System.EventHandler(this.newOrders_CheckedChanged);
            // 
            // allOrdersRdBtn
            // 
            this.allOrdersRdBtn.AutoSize = true;
            this.allOrdersRdBtn.Location = new System.Drawing.Point(1451, 830);
            this.allOrdersRdBtn.Name = "allOrdersRdBtn";
            this.allOrdersRdBtn.Size = new System.Drawing.Size(153, 20);
            this.allOrdersRdBtn.TabIndex = 8;
            this.allOrdersRdBtn.TabStop = true;
            this.allOrdersRdBtn.Text = "Ολες οι παραγγελιες";
            this.allOrdersRdBtn.UseVisualStyleBackColor = true;
            this.allOrdersRdBtn.CheckedChanged += new System.EventHandler(this.allOrdersRdBtn_CheckedChanged);
            // 
            // autoPrintChBox
            // 
            this.autoPrintChBox.AutoSize = true;
            this.autoPrintChBox.Location = new System.Drawing.Point(1266, 884);
            this.autoPrintChBox.Name = "autoPrintChBox";
            this.autoPrintChBox.Size = new System.Drawing.Size(152, 20);
            this.autoPrintChBox.TabIndex = 9;
            this.autoPrintChBox.Text = "Αυτοματη Εκτυπωση";
            this.autoPrintChBox.UseVisualStyleBackColor = true;
            this.autoPrintChBox.CheckedChanged += new System.EventHandler(this.autoPrintChBox_CheckedChanged);
            // 
            // TablesPanel
            // 
            this.TablesPanel.AutoScroll = true;
            this.TablesPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TablesPanel.Location = new System.Drawing.Point(22, 139);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Size = new System.Drawing.Size(1165, 840);
            this.TablesPanel.TabIndex = 10;
            this.TablesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(937, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 58);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderPanel.Controls.Add(this.previewBtn);
            this.OrderPanel.Controls.Add(this.orderIdLabel);
            this.OrderPanel.Controls.Add(this.ordersTabsControl);
            this.OrderPanel.Controls.Add(this.printBtn);
            this.OrderPanel.Controls.Add(this.closeOrderBtn);
            this.OrderPanel.Controls.Add(this.tableLabel);
            this.OrderPanel.Location = new System.Drawing.Point(1202, 139);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(710, 675);
            this.OrderPanel.TabIndex = 16;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(527, 234);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(180, 38);
            this.previewBtn.TabIndex = 13;
            this.previewBtn.Text = "Προεπισκοπηση";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(157, 60);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(58, 16);
            this.orderIdLabel.TabIndex = 12;
            this.orderIdLabel.Text = "Order id:";
            // 
            // ordersTabsControl
            // 
            this.ordersTabsControl.Controls.Add(this.tabPage1);
            this.ordersTabsControl.Controls.Add(this.tabPage2);
            this.ordersTabsControl.Location = new System.Drawing.Point(7, 120);
            this.ordersTabsControl.Name = "ordersTabsControl";
            this.ordersTabsControl.SelectedIndex = 0;
            this.ordersTabsControl.Size = new System.Drawing.Size(491, 495);
            this.ordersTabsControl.TabIndex = 11;
            this.ordersTabsControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(6, 29);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(60, 16);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "Products";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(527, 145);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 38);
            this.printBtn.TabIndex = 10;
            this.printBtn.Text = "Εκτυπωση παραγγελιας";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // closeOrderBtn
            // 
            this.closeOrderBtn.Location = new System.Drawing.Point(527, 319);
            this.closeOrderBtn.Name = "closeOrderBtn";
            this.closeOrderBtn.Size = new System.Drawing.Size(180, 38);
            this.closeOrderBtn.TabIndex = 9;
            this.closeOrderBtn.Text = "Κλεισιμο παραγγελιας";
            this.closeOrderBtn.UseVisualStyleBackColor = true;
            this.closeOrderBtn.Click += new System.EventHandler(this.closeOrderBtn_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(8, 60);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(49, 16);
            this.tableLabel.TabIndex = 8;
            this.tableLabel.Text = "Table: ";
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablesPanel);
            this.Controls.Add(this.autoPrintChBox);
            this.Controls.Add(this.allOrdersRdBtn);
            this.Controls.Add(this.newOrders);
            this.Controls.Add(this.openOrdersRdBtn);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.getOrdersBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TablesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ραβαΐσι PDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ordersTabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getOrdersBtn;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.RadioButton openOrdersRdBtn;
        private System.Windows.Forms.RadioButton newOrders;
        private System.Windows.Forms.RadioButton allOrdersRdBtn;
        private System.Windows.Forms.CheckBox autoPrintChBox;
        private System.Windows.Forms.Panel TablesPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TabControl ordersTabsControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button closeOrderBtn;
        public System.Windows.Forms.Label tableLabel;
    }
}

