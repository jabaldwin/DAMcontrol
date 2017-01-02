using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using System.Diagnostics;

namespace LabLockWinForms
{
    public partial class LabLockWindow : Form
    {
        public static LabLockWindow Instance;

        private GeckoWebBrowser browser;

        public LabLockWindow()
        {
            InitializeComponent();
            Instance = this;
            RegistryManager.ReadValues();

            browser = new GeckoWebBrowser();
            browser.Navigate(RegistryManager.StartPage);
            browser.Navigated += Browser_Navigated;

            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);

            Panel toolbar = new Panel();
            toolbar.BackColor = Color.FromArgb(165, 69, 0);
            toolbar.Height = 50;
            toolbar.Dock = DockStyle.Bottom;
            this.Controls.Add(toolbar);

            Button resetButton = BuildButton("Reset Page");
            toolbar.Padding = new Padding((toolbar.Height - resetButton.Height) / 2);
            resetButton.Dock = DockStyle.Left;
            toolbar.Controls.Add(resetButton);
            resetButton.Click += ResetButton_Click;
            
            Button adminButton = BuildButton("Admin Panel");
            adminButton.Dock = DockStyle.Right;
            toolbar.Controls.Add(adminButton);
            adminButton.Click += AdminButton_Click;

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            this.Height = 600;
            this.Width = 800;

            browser.Width = this.Width;
            toolbar.Width = this.Width;
        }

        public void Unlock()
        {
            //// Prepare the process to run
            //ProcessStartInfo start = new ProcessStartInfo();
            //// Enter the executable to run, including the complete path
            //start.FileName = "C:\\DamControl\\MatterControl.exe";
            //// Do you want to show a console window?
            //start.CreateNoWindow = false;
            ////start.WindowStyle = ProcessWindowStyle.Maximized;
            //start.UseShellExecute = false;
            //start.RedirectStandardError = true;
            //start.RedirectStandardOutput = true;
            //start.LoadUserProfile = true;

            //this.Hide();

            //// Run the external process & wait for it to finish
            //using (Process proc = Process.Start(start))
            //{
            //    proc.WaitForExit();
            //}
            Program.successfulLogin = true;

            this.Close();
        }


        private Button BuildButton(string label)
        {
            Button b = new Button();
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = Color.FromArgb(165, 69, 0);
            b.ForeColor = Color.Black;
            b.FlatAppearance.BorderColor = Color.Black;
            b.FlatAppearance.BorderSize = 3;
            b.TabStop = false;
            b.Font = new Font("Arial", 12, FontStyle.Bold);
            b.Text = label;
            b.Width = 150;
            b.Height = 35;
            return b;
        }

        private void Browser_Navigated(object sender, GeckoNavigatedEventArgs e)
        {
            if (e.Uri == new Uri(RegistryManager.StopPage))
            {
                Unlock();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            browser.Navigate(RegistryManager.StartPage);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            new AdminPassWindow().ShowDialog();
        }
    }
}
