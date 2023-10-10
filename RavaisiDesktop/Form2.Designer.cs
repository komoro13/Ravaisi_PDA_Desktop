namespace RavaisiDesktop
{
    partial class orderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.tableLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.ordersTabsControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.closeOrderBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.thermalPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.thermalPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.ordersTabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(12, 39);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(49, 16);
            this.tableLabel.TabIndex = 0;
            this.tableLabel.Text = "Table: ";
            this.tableLabel.Click += new System.EventHandler(this.tableLabel_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(6, 29);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(60, 16);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "Products";
            this.orderLabel.Click += new System.EventHandler(this.orderLabel_Click);
            // 
            // ordersTabsControl
            // 
            this.ordersTabsControl.Controls.Add(this.tabPage1);
            this.ordersTabsControl.Controls.Add(this.tabPage2);
            this.ordersTabsControl.Location = new System.Drawing.Point(38, 99);
            this.ordersTabsControl.Name = "ordersTabsControl";
            this.ordersTabsControl.SelectedIndex = 0;
            this.ordersTabsControl.Size = new System.Drawing.Size(491, 495);
            this.ordersTabsControl.TabIndex = 4;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(121, 38);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(58, 16);
            this.orderIdLabel.TabIndex = 5;
            this.orderIdLabel.Text = "Order id:";
            // 
            // closeOrderBtn
            // 
            this.closeOrderBtn.Location = new System.Drawing.Point(580, 301);
            this.closeOrderBtn.Name = "closeOrderBtn";
            this.closeOrderBtn.Size = new System.Drawing.Size(180, 38);
            this.closeOrderBtn.TabIndex = 2;
            this.closeOrderBtn.Text = "Κλεισιμο παραγγελιας";
            this.closeOrderBtn.UseVisualStyleBackColor = true;
            this.closeOrderBtn.Click += new System.EventHandler(this.closeOrderBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(580, 131);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 38);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Εκτυπωση παραγγελιας";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // thermalPrintPreviewDialog
            // 
            this.thermalPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.thermalPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.thermalPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.thermalPrintPreviewDialog.Enabled = true;
            this.thermalPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("thermalPrintPreviewDialog.Icon")));
            this.thermalPrintPreviewDialog.Name = "thermalPrintPreviewDialog";
            this.thermalPrintPreviewDialog.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Προεπισκοπηση";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thermalPrintDocument
            // 
            this.thermalPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.thermalPrintDocument_PrintPage);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 785);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.ordersTabsControl);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.closeOrderBtn);
            this.Controls.Add(this.tableLabel);
            this.Name = "orderForm";
            this.Text = "Order form";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.ordersTabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.TabControl ordersTabsControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Button closeOrderBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintPreviewDialog thermalPrintPreviewDialog;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument thermalPrintDocument;
    }
}