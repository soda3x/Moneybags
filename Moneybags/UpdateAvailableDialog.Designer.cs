
namespace Moneybags
{
    partial class UpdateAvailableDialog
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
            this.newVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.currentVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.ignoreBtn = new MetroFramework.Controls.MetroButton();
            this.goToUpdateBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // newVersionLabel
            // 
            this.newVersionLabel.AutoSize = true;
            this.newVersionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.newVersionLabel.Location = new System.Drawing.Point(23, 97);
            this.newVersionLabel.Name = "newVersionLabel";
            this.newVersionLabel.Size = new System.Drawing.Size(110, 25);
            this.newVersionLabel.TabIndex = 1;
            this.newVersionLabel.Text = "New Version:";
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.currentVersionLabel.Location = new System.Drawing.Point(23, 134);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(133, 25);
            this.currentVersionLabel.TabIndex = 2;
            this.currentVersionLabel.Text = "Current Version:";
            // 
            // ignoreBtn
            // 
            this.ignoreBtn.Location = new System.Drawing.Point(191, 206);
            this.ignoreBtn.Name = "ignoreBtn";
            this.ignoreBtn.Size = new System.Drawing.Size(144, 23);
            this.ignoreBtn.TabIndex = 3;
            this.ignoreBtn.Text = "Not Now";
            this.ignoreBtn.Click += new System.EventHandler(this.ignoreBtn_Click);
            // 
            // goToUpdateBtn
            // 
            this.goToUpdateBtn.Location = new System.Drawing.Point(341, 206);
            this.goToUpdateBtn.Name = "goToUpdateBtn";
            this.goToUpdateBtn.Size = new System.Drawing.Size(144, 23);
            this.goToUpdateBtn.TabIndex = 4;
            this.goToUpdateBtn.Text = "Download Update";
            this.goToUpdateBtn.Click += new System.EventHandler(this.goToUpdateBtn_Click);
            // 
            // UpdateAvailableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(497, 243);
            this.Controls.Add(this.goToUpdateBtn);
            this.Controls.Add(this.ignoreBtn);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.newVersionLabel);
            this.Name = "UpdateAvailableDialog";
            this.Resizable = false;
            this.Text = "New version of Moneybags available!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel newVersionLabel;
        private MetroFramework.Controls.MetroLabel currentVersionLabel;
        private MetroFramework.Controls.MetroButton ignoreBtn;
        private MetroFramework.Controls.MetroButton goToUpdateBtn;
    }
}