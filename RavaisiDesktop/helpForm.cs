using RavaisiDesktop.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RavaisiDesktop
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void productsFormBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
            this.Close();
        }
        
        private void settingsFormBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Close();
        }

        private void historyFormBtn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablesFormBtnHp_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            tablesForm.Show();
            this.Close();
        }
        
        private void loadBackroundImage()
        {
            this.BackgroundImage = Resources.flat_lay_frame_with_seafood_copy_space;
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => loadBackroundImage());
        }
    }
}