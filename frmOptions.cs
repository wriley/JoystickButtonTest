using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoystickButtonTest
{
    public partial class frmOptions : Form
    {
        frmMain parentForm;

        public frmOptions(frmMain frm)
        {
            InitializeComponent();
            parentForm = new frmMain();
            parentForm = frm;
        }


        private void frmOptions_Load(object sender, EventArgs e)
        {
            cbRefreshes.SelectedIndex = cbRefreshes.FindString(parentForm.getRefreshInterval().ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            parentForm.setRefreshInterval(Convert.ToInt32(cbRefreshes.SelectedItem.ToString()));
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
