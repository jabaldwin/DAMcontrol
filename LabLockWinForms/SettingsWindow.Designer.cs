namespace LabLockWinForms
{
    partial class SettingsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.startBox = new System.Windows.Forms.TextBox();
            this.stopBox = new System.Windows.Forms.TextBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unlockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Page URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stop Page URL:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(112, 26);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(282, 20);
            this.passBox.TabIndex = 3;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(112, 52);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(282, 20);
            this.startBox.TabIndex = 4;
            // 
            // stopBox
            // 
            this.stopBox.Location = new System.Drawing.Point(112, 79);
            this.stopBox.Name = "stopBox";
            this.stopBox.Size = new System.Drawing.Size(282, 20);
            this.stopBox.TabIndex = 5;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(42, 125);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(159, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(274, 125);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(96, 23);
            this.unlockButton.TabIndex = 8;
            this.unlockButton.Text = "Manual Unlock";
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 165);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.stopBox);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsWindow";
            this.Text = "Admin Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox stopBox;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button unlockButton;
    }
}