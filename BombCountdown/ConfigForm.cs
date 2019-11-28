using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombCountdown
{
    public partial class ConfigForm : Form
    {
        #region Proprietà

        public int DurataOreCountdown1 { get; set; }
        public int DurataMinutiCountdown1 { get; set; }
        public int DurataOreCountdown2 { get; set; }
        public int DurataMinutiCountdown2 { get; set; }

        public string Password { get; set; }

        #endregion

        #region Costruttori
        public ConfigForm()
        {
            InitializeComponent();
        }

        #endregion

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
