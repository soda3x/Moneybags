using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneybags
{
    public partial class UpdateAvailableDialog : MetroFramework.Forms.MetroForm
    {
        private readonly Label updateStatusLabel;

        public UpdateAvailableDialog(string currentVersion, string newVersion, Label updateStatusLabel)
        {
            InitializeComponent();
            newVersionLabel.Text = "New Version: " + newVersion;
            currentVersionLabel.Text = "Current Version: " + currentVersion;
            this.updateStatusLabel = updateStatusLabel;
        }

        private void IgnoreBtn_Click(object sender, EventArgs e)
        {
            this.updateStatusLabel.Text = "You are using an outdated version of Moneybags. Update Moneybags for the best experience.";
            this.Dispose();
        }

        private void GoToUpdateBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soda3x/Moneybags/releases");
        }
    }
}
