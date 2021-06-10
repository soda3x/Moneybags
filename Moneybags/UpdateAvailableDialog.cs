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
        public UpdateAvailableDialog(string currentVersion, string newVersion)
        {
            InitializeComponent();
            newVersionLabel.Text = "New Version: " + newVersion;
            currentVersionLabel.Text = "Current Version: " + currentVersion;
        }

        private void ignoreBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void goToUpdateBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soda3x/Moneybags/releases");
        }
    }
}
