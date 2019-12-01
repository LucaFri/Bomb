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

        int _durataOreCountdown1;
        int _durataMinutiCountdown1;
        int _durataOreCountdown2;
        int _durataMinutiCountdown2;
        string _password;
        private bool _isFinished = false;

        #endregion

        #region Costruttori
        public BombForm()
        {
            InitializeComponent();
            ConfigForm configForm = new ConfigForm();
            configForm.FormClosed += ConfigForm_FormClosed;
            SetStartLocationControl();
            this.Visible = false;
            sevenSegmentArrayCountdown.ColorDark = Color.FromArgb(20, 20, 20);
            configForm.Show();
        }

        #endregion

        #region Metodi privati        

        private void GetParametersFromConfigForm(ConfigForm config)
        {
            _password = config.Password;
            _durataOreCountdown1 = config.DurataOreCountdown1;
            _durataMinutiCountdown1 = config.DurataMinutiCountdown1;
            _durataOreCountdown2 = config.DurataOreCountdown2;
            _durataMinutiCountdown2 = config.DurataMinutiCountdown2;
        }
        private void SetStartLocationControl()
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            Point startLocationCentralSevenSegment = GetCentralPoint(sevenSegmentArrayCountdown);
            sevenSegmentArrayCountdown.Location = startLocationCentralSevenSegment;
            //sevenSegmentArrayCountdown.Value = "35.568";
            Point startLocationCentralTextBox = GetCentralPoint(password);
            password.Location = new Point(startLocationCentralTextBox.X, startLocationCentralTextBox.Y
                + sevenSegmentArrayCountdown.Height + 30);
        }      
        private Point GetCentralPoint(Control control)
        {
            return new Point((this.Width / 2) - control.Width / 2,
                (this.Height / 2) - control.Height / 2);
        }
        private void AvviaCountdown(int min = 0, int ore = 0)
        {
            //if (min + ore == 0) throw new Exception("Countdown non impostato");
            _start = DateTime.Now;
            _end = _start.AddMinutes(min).AddHours(ore);
            timerCountDown.Start();
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
            if(!_isFinished) e.Cancel = true;
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
            if (password.Text == _password)
            {
                timerCountDown.Stop();
                MessageBox.Show("Bravo hai trovato la password!!!");
                _isFinished = true;
                this.Close();
            }
        }


        #endregion

        #region Eventi Timer

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
                    AvviaCountdown(_durataMinutiCountdown2, _durataOreCountdown2);
                }
                else
                {
                    MessageBox.Show("Boooooooom");
                    _isFinished = true;
                    this.Close();
                }
            }
        }

        #endregion

        #region Eventi ConfigForm

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ConfigForm config = sender as ConfigForm;
                if(!config.IsValid)
                {
                    _isFinished = true;
                    this.Close();
                }
                else
                {
                    GetParametersFromConfigForm(config);
                    this.Visible = true;
                    AvviaCountdown(_durataMinutiCountdown1, _durataOreCountdown1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}
