using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLockWinForms
{
    public partial class AdminPassWindow : Form
    {

        public AdminPassWindow()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if (passBox.Text == RegistryManager.AdminPass)
            {
                new SettingsWindow().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
