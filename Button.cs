using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoystickButtonTest
{
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }

        private int buttonId;
        public int ButtonId
        {
            get { return buttonId; }
            set
            {
                buttonId = value;
                btnStatus.Text = value.ToString();
            }
        }

        private bool buttonStatus;
        public bool ButtonStatus
        {
            get { return buttonStatus; }
            set
            {
                buttonStatus = value;
                if (buttonStatus == true)
                {
                    this.btnStatus.ImageIndex = 1;
                }
                else
                {
                    this.btnStatus.ImageIndex = 0;
                }
            }
        }
    }
}
