using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace JoystickButtonTest
{
    public partial class frmMain : Form
    {
        private JoystickInterface.Joystick jst;
        private string currentJoystick = null;
        private int refreshInterval = 100;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            jst = new JoystickInterface.Joystick(this.Handle);
            updateDeviceList();
            updateInterval(refreshInterval);
            tmrButtonStatus.Enabled = true;
        }

        private void updateDeviceList()
        {
            string[] discoveredJoysticks = jst.FindJoysticks();

            if (discoveredJoysticks != null)
            {
                cbActiveDevice.Items.Clear();
                cbActiveDevice.Items.AddRange(discoveredJoysticks);
            }
        }

        private void cbActiveDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentJoystick = cbActiveDevice.Items[cbActiveDevice.SelectedIndex].ToString();

            if (jst.AcquireJoystick(currentJoystick))
            {
                populateButtons();
            }
            else
            {
            }
        }

        private void sortButtons()
        {
            SortedList<int, Control> sl = new SortedList<int, Control>();

            foreach (Control btn in flpButtons.Controls)
            {
                sl.Add(((JoystickButtonTest.Button)btn).ButtonId, btn);
            }

            foreach (Control btn in sl.Values)
            {
                btn.SendToBack();
            }
        }

        private void populateButtons()
        {
            flpButtons.Controls.Clear();
            jst.UpdateStatus();

            for (int i = 0; i < jst.Buttons.Length; i++)
            {
                Button btn = new Button();
                ((JoystickButtonTest.Button)btn).ButtonId = i + 1;
                flpButtons.Controls.Add(btn);
            }
        }

        private void tmrButtonStatus_Tick(object sender, EventArgs e)
        {
            if (currentJoystick != null)
            {
                jst.UpdateStatus();

                if (jst.Buttons != null)
                {
                    foreach (Control btn in flpButtons.Controls)
                    {
                        if (btn is JoystickButtonTest.Button)
                        {
                            ((JoystickButtonTest.Button)btn).ButtonStatus =
                                jst.Buttons[((JoystickButtonTest.Button)btn).ButtonId - 1];
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog(this);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions frm = new frmOptions(this);
            frm.ShowDialog(this);
        }

        private void showNotYetImplemented()
        {
            MessageBox.Show("This function is not yet implemented");
        }

        public int getRefreshInterval()
        {
            return refreshInterval;
        }

        public void setRefreshInterval(int r)
        {
            updateInterval(r);
        }

        public void updateInterval(int r)
        {
            refreshInterval = r;
            tmrButtonStatus.Interval = 1000 / refreshInterval;
            lblRefreshDisplay.Text = String.Format("Refreshing every {0} ms", refreshInterval);
        }
    }
}
