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
        #region Campi privati

        bool _firstTime = true;
        TimeSpan _ts;
        DateTime _start;
        DateTime _end;

        #endregion        

        #region Costruttori
        public BombForm()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            Point startLocationCentralSevenSegment = GetCentralPoint(sevenSegmentArrayCountdown);
            sevenSegmentArrayCountdown.Location = startLocationCentralSevenSegment;
            //sevenSegmentArrayCountdown.Value = "35.568";
            Point startLocationCentralTextBox = GetCentralPoint(password);
            password.Location = new Point(startLocationCentralTextBox.X, startLocationCentralTextBox.Y
                + sevenSegmentArrayCountdown.Height + 30);
            AvviaCountdown(1);
        }

        #endregion

        #region Metodi privati
        private Point GetCentralPoint(Control control)
        {
            return new Point((this.Width / 2) - control.Width / 2,
                (this.Height / 2) - control.Height / 2);
        }
        private void AvviaCountdown(int min = 0, int ore = 0)
        {
            if (min + ore == 0) throw new Exception("Countdown non impostato");
            _start = DateTime.Now;
            _end = _start.AddSeconds(15);
            _end = _start.AddMinutes(min).AddHours(ore);
            timerCountDown.Start();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Eventi

        #region Eventi Form
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

        #region Eventi TextBox password
        private void password_KeyPress(object sender, KeyPressEventArgs e)
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

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "1234")
            {
                timerCountDown.Stop();
                MessageBox.Show("Bravo hai trovato la password!!!");
            }
        }


        #endregion

        #endregion

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (_end > DateTime.Now)
            {
                _ts = _end - DateTime.Now;
                sevenSegmentArrayCountdown.Value = _ts.ToString(@"hh\.mm\.ss\.ff");
            }
            else
            {
                sevenSegmentArrayCountdown.Value = "00.00.00.00";
                timerCountDown.Stop();
                if (_firstTime)
                {
                    _firstTime = false;
                    AvviaCountdown(4,1);
                }
                else
                {
                    MessageBox.Show("Boooooooom");
                }
            }
        }
    }
}
