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
    public partial class BombForm : Form
    {

        #region Costruttori
        public BombForm()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            Point startLocationCentralControl = GetCentralPoint(sevenSegmentArrayCountdown);
            sevenSegmentArrayCountdown.Location = startLocationCentralControl;
        } 
        #endregion

        #region Metodi privati
        private Point GetCentralPoint(UserControl userControl)
        {
            return new Point((this.Width / 2) - userControl.Width / 2,
                (this.Height / 2) - userControl.Height / 2);
        } 
        #endregion

        #region Eventi
        private void BombForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.LWin)
                e.Handled = true;
        }

        private void BombForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void BombForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void BombForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        } 
        #endregion
    }
}
