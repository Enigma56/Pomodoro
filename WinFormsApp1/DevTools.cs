using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public bool EnabledButtons { get; set; }
        public void SetVisibility()
        {
            if (EnabledButtons is false)
            {
                oneMinuteIncrease.Enabled = false;
                oneMinuteIncrease.Visible = false;
            }
        }
    }
}
