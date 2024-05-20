namespace RavaisiDesktop
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.navPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablesFormBtnP = new System.Windows.Forms.Button();
            this.productsFormBtn = new System.Windows.Forms.Button();
            this.settingsFormBtn = new System.Windows.Forms.Button();
            this.helpFormBtn = new System.Windows.Forms.Button();
            this.historyFormBtn = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.navPanel.TabIndex = 36;
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
            this.tablesFormBtnP.Click += new System.EventHandler(this.tablesFormBtnP_Click);
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
            this.productsFormBtn.Click += new System.EventHandler(this.productsFormBtn_Click);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RavaisiDesktop.Properties.Resources.flat_lay_frame_with_seafood_copy_space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 781);
            this.ControlBox = false;
            this.Controls.Add(this.navPanel);
            this.Name = "SettingsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tablesFormBtnP;
        private System.Windows.Forms.Button productsFormBtn;
        private System.Windows.Forms.Button settingsFormBtn;
        private System.Windows.Forms.Button helpFormBtn;
        private System.Windows.Forms.Button historyFormBtn;
    }
}