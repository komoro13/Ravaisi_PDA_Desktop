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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // getOrdersBtn
            // 
            this.getOrdersBtn.Location = new System.Drawing.Point(692, 931);
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
            this.ordersGridView.Location = new System.Drawing.Point(64, 83);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(870, 374);
            this.ordersGridView.TabIndex = 2;
            this.ordersGridView.Visible = false;
            this.ordersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellContentClick);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(1280, 866);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(76, 16);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Machine IP:";
            // 
            // openOrdersRdBtn
            // 
            this.openOrdersRdBtn.AutoSize = true;
            this.openOrdersRdBtn.Location = new System.Drawing.Point(55, 862);
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
            this.newOrders.Location = new System.Drawing.Point(55, 956);
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
            this.allOrdersRdBtn.Location = new System.Drawing.Point(55, 909);
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
            this.autoPrintChBox.Location = new System.Drawing.Point(334, 909);
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
            this.TablesPanel.Location = new System.Drawing.Point(27, 25);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Size = new System.Drawing.Size(1825, 819);
            this.TablesPanel.TabIndex = 10;
            this.TablesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesPanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1826, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1826, 1025);
            this.Controls.Add(this.TablesPanel);
            this.Controls.Add(this.autoPrintChBox);
            this.Controls.Add(this.allOrdersRdBtn);
            this.Controls.Add(this.newOrders);
            this.Controls.Add(this.openOrdersRdBtn);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.getOrdersBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TablesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ραβαΐσι PDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

