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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            passBox.Text = RegistryManager.AdminPass;
            startBox.Text = RegistryManager.StartPage;
            stopBox.Text = RegistryManager.StopPage;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            RegistryManager.AdminPass = passBox.Text;
            RegistryManager.StartPage = startBox.Text;
            RegistryManager.StopPage = stopBox.Text;
            RegistryManager.WriteValues();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LabLockWindow.Instance.Unlock();
        }
    }
}
