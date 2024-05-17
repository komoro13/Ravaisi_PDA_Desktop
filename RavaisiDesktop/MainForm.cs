using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RavaisiDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        String XAMPPPath = "";
        private void mainForm_Load(object sender, EventArgs e)
        {
            readXAMPPPath();
            System.Diagnostics.Process XAMPP = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = XAMPPPath;
            XAMPP.StartInfo = startInfo;
            XAMPP.Start();

        }
        private void readXAMPPPath()
        {
            string path = "./filenames.txt";
            string[] lines = File.ReadAllLines(path);
            XAMPPPath = lines[0].Split('#')[0].Trim();
        }

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            tablesForm.WindowState = FormWindowState.Maximized;
            tablesForm.Show();
        }
    }
}
