namespace RavaisiDesktop
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addProductPriceTxBox = new System.Windows.Forms.TextBox();
            this.addProductNameTxBox = new System.Windows.Forms.TextBox();
            this.historyFormBtn = new System.Windows.Forms.Button();
            this.helpFormBtn = new System.Windows.Forms.Button();
            this.settingsFormBtn = new System.Windows.Forms.Button();
            this.productsFormBtn = new System.Windows.Forms.Button();
            this.tablesFormBtnP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navPanel = new System.Windows.Forms.Panel();
            this.searchBarPanel = new System.Windows.Forms.Panel();
            this.categoriesRdBtn = new System.Windows.Forms.RadioButton();
            this.productsRdBtn = new System.Windows.Forms.RadioButton();
            this.toppingsRdBtn = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(56, 234);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(953, 529);
            this.productsDataGridView.TabIndex = 0;
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.listView1);
            this.productsPanel.Controls.Add(this.checkedListBox1);
            this.productsPanel.Controls.Add(this.toppingsRdBtn);
            this.productsPanel.Controls.Add(this.productsRdBtn);
            this.productsPanel.Controls.Add(this.categoriesRdBtn);
            this.productsPanel.Controls.Add(this.button1);
            this.productsPanel.Controls.Add(this.addProductPriceTxBox);
            this.productsPanel.Controls.Add(this.addProductNameTxBox);
            this.productsPanel.Location = new System.Drawing.Point(1075, 92);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(422, 672);
            this.productsPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addProductPriceTxBox
            // 
            this.addProductPriceTxBox.Location = new System.Drawing.Point(31, 247);
            this.addProductPriceTxBox.Name = "addProductPriceTxBox";
            this.addProductPriceTxBox.Size = new System.Drawing.Size(199, 22);
            this.addProductPriceTxBox.TabIndex = 1;
            // 
            // addProductNameTxBox
            // 
            this.addProductNameTxBox.Location = new System.Drawing.Point(31, 196);
            this.addProductNameTxBox.Name = "addProductNameTxBox";
            this.addProductNameTxBox.Size = new System.Drawing.Size(199, 22);
            this.addProductNameTxBox.TabIndex = 0;
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
            // productsFormBtn
            // 
            this.productsFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsFormBtn.FlatAppearance.BorderSize = 0;
            this.productsFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsFormBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsFormBtn.Location = new System.Drawing.Point(169, 10);
            this.productsFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productsFormBtn.Name = "productsFormBtn";
            this.productsFormBtn.Size = new System.Drawing.Size(120, 35);
            this.productsFormBtn.TabIndex = 28;
            this.productsFormBtn.Text = "Προιοντα";
            this.productsFormBtn.UseVisualStyleBackColor = false;
            this.productsFormBtn.Click += new System.EventHandler(this.productFormBtn_Click);
            // 
            // tablesFormBtnP
            // 
            this.tablesFormBtnP.BackColor = System.Drawing.Color.Transparent;
            this.tablesFormBtnP.FlatAppearance.BorderSize = 0;
            this.tablesFormBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesFormBtnP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablesFormBtnP.Location = new System.Drawing.Point(56, 10);
            this.tablesFormBtnP.Margin = new System.Windows.Forms.Padding(0);
            this.tablesFormBtnP.Name = "tablesFormBtnP";
            this.tablesFormBtnP.Size = new System.Drawing.Size(120, 35);
            this.tablesFormBtnP.TabIndex = 33;
            this.tablesFormBtnP.Text = "Τραπεζια";
            this.tablesFormBtnP.UseVisualStyleBackColor = false;
            this.tablesFormBtnP.Click += new System.EventHandler(this.button2_Click);
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
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Controls.Add(this.tablesFormBtnP);
            this.navPanel.Controls.Add(this.productsFormBtn);
            this.navPanel.Controls.Add(this.settingsFormBtn);
            this.navPanel.Controls.Add(this.helpFormBtn);
            this.navPanel.Controls.Add(this.historyFormBtn);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(705, 55);
            this.navPanel.TabIndex = 35;
            // 
            // searchBarPanel
            // 
            this.searchBarPanel.Location = new System.Drawing.Point(56, 91);
            this.searchBarPanel.Name = "searchBarPanel";
            this.searchBarPanel.Size = new System.Drawing.Size(953, 100);
            this.searchBarPanel.TabIndex = 36;
            // 
            // categoriesRdBtn
            // 
            this.categoriesRdBtn.AutoSize = true;
            this.categoriesRdBtn.Location = new System.Drawing.Point(34, 54);
            this.categoriesRdBtn.Name = "categoriesRdBtn";
            this.categoriesRdBtn.Size = new System.Drawing.Size(97, 20);
            this.categoriesRdBtn.TabIndex = 4;
            this.categoriesRdBtn.TabStop = true;
            this.categoriesRdBtn.Text = "Κατηγοριες";
            this.categoriesRdBtn.UseVisualStyleBackColor = true;
            // 
            // productsRdBtn
            // 
            this.productsRdBtn.AutoSize = true;
            this.productsRdBtn.Location = new System.Drawing.Point(34, 80);
            this.productsRdBtn.Name = "productsRdBtn";
            this.productsRdBtn.Size = new System.Drawing.Size(86, 20);
            this.productsRdBtn.TabIndex = 5;
            this.productsRdBtn.TabStop = true;
            this.productsRdBtn.Text = "Προιοντα";
            this.productsRdBtn.UseVisualStyleBackColor = true;
            // 
            // toppingsRdBtn
            // 
            this.toppingsRdBtn.AutoSize = true;
            this.toppingsRdBtn.Location = new System.Drawing.Point(34, 106);
            this.toppingsRdBtn.Name = "toppingsRdBtn";
            this.toppingsRdBtn.Size = new System.Drawing.Size(62, 20);
            this.toppingsRdBtn.TabIndex = 6;
            this.toppingsRdBtn.TabStop = true;
            this.toppingsRdBtn.Text = "Υλικα";
            this.toppingsRdBtn.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(34, 328);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 208);
            this.checkedListBox1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(258, 385);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RavaisiDesktop.Properties.Resources.flat_lay_frame_with_seafood_copy_space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1509, 874);
            this.ControlBox = false;
            this.Controls.Add(this.searchBarPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.productsDataGridView);
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addProductPriceTxBox;
        private System.Windows.Forms.TextBox addProductNameTxBox;
        private System.Windows.Forms.Button historyFormBtn;
        private System.Windows.Forms.Button helpFormBtn;
        private System.Windows.Forms.Button settingsFormBtn;
        private System.Windows.Forms.Button productsFormBtn;
        private System.Windows.Forms.Button tablesFormBtnP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel searchBarPanel;
        private System.Windows.Forms.RadioButton toppingsRdBtn;
        private System.Windows.Forms.RadioButton productsRdBtn;
        private System.Windows.Forms.RadioButton categoriesRdBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView listView1;
    }
}