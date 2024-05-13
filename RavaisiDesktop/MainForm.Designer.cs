namespace RavaisiDesktop
{
    partial class MainForm
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
            this.tablesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablesBtn
            // 
            this.tablesBtn.Location = new System.Drawing.Point(318, 165);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(147, 77);
            this.tablesBtn.TabIndex = 0;
            this.tablesBtn.Text = "Tables";
            this.tablesBtn.UseVisualStyleBackColor = true;
            this.tablesBtn.Click += new System.EventHandler(this.tablesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesBtn);
            this.Name = "MainForm";
            this.Text = "Ravaisi PDA";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tablesBtn;
    }
}