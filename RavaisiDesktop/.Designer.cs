﻿namespace RavaisiDesktop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablesFormBtn = new System.Windows.Forms.Button();
            this.productFormBtn = new System.Windows.Forms.Button();
            this.settingsFormBtn = new System.Windows.Forms.Button();
            this.helpFormBtn = new System.Windows.Forms.Button();
            this.historyFormBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.OrderPanel.SuspendLayout();
            this.ordersTabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getOrdersBtn
            // 
            this.getOrdersBtn.Location = new System.Drawing.Point(11, 147);
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
            this.ordersGridView.Location = new System.Drawing.Point(1908, 857);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(10, 10);
            this.ordersGridView.TabIndex = 2;
            this.ordersGridView.Visible = false;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ipLabel.Location = new System.Drawing.Point(471, 27);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(76, 16);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Machine IP:";
            // 
            // openOrdersRdBtn
            // 
            this.openOrdersRdBtn.AutoSize = true;
            this.openOrdersRdBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openOrdersRdBtn.Location = new System.Drawing.Point(17, 23);
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
            this.newOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newOrders.Location = new System.Drawing.Point(17, 75);
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
            this.allOrdersRdBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.allOrdersRdBtn.Location = new System.Drawing.Point(17, 49);
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
            this.autoPrintChBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.autoPrintChBox.Location = new System.Drawing.Point(474, 60);
            this.autoPrintChBox.Name = "autoPrintChBox";
            this.autoPrintChBox.Size = new System.Drawing.Size(152, 20);
            this.autoPrintChBox.TabIndex = 9;
            this.autoPrintChBox.Text = "Αυτοματη Εκτυπωση";
            this.autoPrintChBox.UseVisualStyleBackColor = true;
            // 
            // TablesPanel
            // 
            this.TablesPanel.AutoScroll = true;
            this.TablesPanel.BackColor = System.Drawing.Color.Transparent;
            this.TablesPanel.Location = new System.Drawing.Point(7, 166);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Size = new System.Drawing.Size(1183, 889);
            this.TablesPanel.TabIndex = 10;
            this.TablesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesPanel_Paint);
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrderPanel.Controls.Add(this.previewBtn);
            this.OrderPanel.Controls.Add(this.orderIdLabel);
            this.OrderPanel.Controls.Add(this.ordersTabsControl);
            this.OrderPanel.Controls.Add(this.printBtn);
            this.OrderPanel.Controls.Add(this.closeOrderBtn);
            this.OrderPanel.Controls.Add(this.tableLabel);
            this.OrderPanel.Location = new System.Drawing.Point(1196, 63);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(712, 739);
            this.OrderPanel.TabIndex = 16;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(197, 690);
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
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.orderIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIdLabel.Location = new System.Drawing.Point(191, 43);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(124, 32);
            this.orderIdLabel.TabIndex = 12;
            this.orderIdLabel.Text = "Order id:";
            // 
            // ordersTabsControl
            // 
            this.ordersTabsControl.Controls.Add(this.tabPage1);
            this.ordersTabsControl.Controls.Add(this.tabPage2);
            this.ordersTabsControl.Location = new System.Drawing.Point(7, 103);
            this.ordersTabsControl.Name = "ordersTabsControl";
            this.ordersTabsControl.SelectedIndex = 0;
            this.ordersTabsControl.Size = new System.Drawing.Size(715, 568);
            this.ordersTabsControl.TabIndex = 11;
            this.ordersTabsControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 539);
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
            this.tabPage2.Size = new System.Drawing.Size(707, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(7, 690);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 38);
            this.printBtn.TabIndex = 10;
            this.printBtn.Text = "Εκτυπωση παραγγελιας";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // closeOrderBtn
            // 
            this.closeOrderBtn.Location = new System.Drawing.Point(383, 690);
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
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.tableLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLabel.Location = new System.Drawing.Point(3, 43);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(101, 32);
            this.tableLabel.TabIndex = 8;
            this.tableLabel.Text = "Table: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.openOrdersRdBtn);
            this.panel1.Controls.Add(this.allOrdersRdBtn);
            this.panel1.Controls.Add(this.newOrders);
            this.panel1.Controls.Add(this.ipLabel);
            this.panel1.Controls.Add(this.getOrdersBtn);
            this.panel1.Controls.Add(this.autoPrintChBox);
            this.panel1.Location = new System.Drawing.Point(1203, 808);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 235);
            this.panel1.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Controls.Add(this.tablesFormBtn);
            this.navPanel.Controls.Add(this.productFormBtn);
            this.navPanel.Controls.Add(this.settingsFormBtn);
            this.navPanel.Controls.Add(this.helpFormBtn);
            this.navPanel.Controls.Add(this.historyFormBtn);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(705, 55);
            this.navPanel.TabIndex = 35;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tablesFormBtn
            // 
            this.tablesFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.tablesFormBtn.FlatAppearance.BorderSize = 0;
            this.tablesFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablesFormBtn.Location = new System.Drawing.Point(56, 10);
            this.tablesFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tablesFormBtn.Name = "tablesFormBtn";
            this.tablesFormBtn.Size = new System.Drawing.Size(120, 35);
            this.tablesFormBtn.TabIndex = 33;
            this.tablesFormBtn.Text = "Τραπεζια";
            this.tablesFormBtn.UseVisualStyleBackColor = false;
            // 
            // productFormBtn
            // 
            this.productFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.productFormBtn.FlatAppearance.BorderSize = 0;
            this.productFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productFormBtn.Location = new System.Drawing.Point(169, 10);
            this.productFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productFormBtn.Name = "productFormBtn";
            this.productFormBtn.Size = new System.Drawing.Size(120, 35);
            this.productFormBtn.TabIndex = 28;
            this.productFormBtn.Text = "Προιοντα";
            this.productFormBtn.UseVisualStyleBackColor = false;
            this.productFormBtn.Click += new System.EventHandler(this.productsFormBtn_Click);
            // 
            // settingsFormBtn
            // 
            this.settingsFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormBtn.FlatAppearance.BorderSize = 0;
            this.settingsFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsFormBtn.Location = new System.Drawing.Point(289, 10);
            this.settingsFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsFormBtn.Name = "settingsFormBtn";
            this.settingsFormBtn.Size = new System.Drawing.Size(120, 35);
            this.settingsFormBtn.TabIndex = 29;
            this.settingsFormBtn.Text = "Ρυθμισεις";
            this.settingsFormBtn.UseVisualStyleBackColor = false;
            this.settingsFormBtn.Click += new System.EventHandler(this.settingsFormBtn_Click);
            // 
            // helpFormBtn
            // 
            this.helpFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpFormBtn.FlatAppearance.BorderSize = 0;
            this.helpFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpFormBtn.Location = new System.Drawing.Point(529, 10);
            this.helpFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.helpFormBtn.Name = "helpFormBtn";
            this.helpFormBtn.Size = new System.Drawing.Size(120, 35);
            this.helpFormBtn.TabIndex = 31;
            this.helpFormBtn.Text = "Βοηθεια";
            this.helpFormBtn.UseVisualStyleBackColor = false;
            this.helpFormBtn.Click += new System.EventHandler(this.helpFormBtn_Click);
            // 
            // historyFormBtn
            // 
            this.historyFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.historyFormBtn.FlatAppearance.BorderSize = 0;
            this.historyFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historyFormBtn.Location = new System.Drawing.Point(409, 10);
            this.historyFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.historyFormBtn.Name = "historyFormBtn";
            this.historyFormBtn.Size = new System.Drawing.Size(120, 35);
            this.historyFormBtn.TabIndex = 30;
            this.historyFormBtn.Text = "Ιστορικο";
            this.historyFormBtn.UseVisualStyleBackColor = false;
            this.historyFormBtn.Click += new System.EventHandler(this.historyFormBtn_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.TablesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TablesForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ordersTabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tablesFormBtn;
        private System.Windows.Forms.Button productFormBtn;
        private System.Windows.Forms.Button settingsFormBtn;
        private System.Windows.Forms.Button helpFormBtn;
        private System.Windows.Forms.Button historyFormBtn;
    }
}

