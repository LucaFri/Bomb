using BombCountdown.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombCountdown
{
    public partial class BombForm : Form
    {

        #region Campi privati

        string passwordSegment = string.Empty;
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tictac-of-a-wall-clock.wav");
        TimeSpan second20 = new TimeSpan(0, 0, 22);
        TimeSpan second1 = new TimeSpan(0, 0, 1);
        bool _firstTime = true;
        bool startTicTac = true;

        bool fase1a = true;
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
            sevenSegmentPassword.ColorDark = Color.FromArgb(20, 20, 20);
            sevenSegmentArrayCountdown.ColorBackground = Color.FromArgb(4, 11, 30);
            sevenSegmentPassword.ColorBackground = Color.FromArgb(4, 11, 30);
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
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            Point startLocationCentralSevenSegment = GetCentralPoint(sevenSegmentArrayCountdown);
            //sevenSegmentArrayCountdown.Location = startLocationCentralSevenSegment;
            //sevenSegmentArrayCountdown.Value = "35.568";
            //Point startLocationCentralTextBox = GetCentralPoint(password);
            //password.Location = new Point(startLocationCentralTextBox.X, startLocationCentralTextBox.Y
            // + sevenSegmentArrayCountdown.Height + 30);
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
            this.Focus();
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
            if (!_isFinished) e.Cancel = true;
        }

        private void BombForm_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (sevenSegmentPassword?.Value?.Length > 8)
                {
                    if (e.KeyValue == 8 || e.KeyValue == 46)
                    {
                        sevenSegmentPassword.Value = sevenSegmentPassword.Value.Substring(0, sevenSegmentPassword.Value.Length - 1);
                        return;
                    }
                    return;
                }
                switch (e.KeyValue)
                {
                    //case '0':
                    case 48:
                    case 96:
                        sevenSegmentPassword.Value += "0";
                        break;
                    //case '1':
                    case 49:
                    case 97:
                        sevenSegmentPassword.Value += "1";
                        break;
                    //case '2':
                    case 50:
                    case 98:
                        sevenSegmentPassword.Value += "2";
                        break;
                    //case '3':
                    case 51:
                    case 99:
                        sevenSegmentPassword.Value += "3";
                        break;
                    //case '4':
                    case 52:
                    case 100:
                        sevenSegmentPassword.Value += "4";
                        break;
                    //case '5':
                    case 53:
                    case 101:
                        sevenSegmentPassword.Value += "5";
                        break;
                    //case '6':
                    case 54:
                    case 102:
                        sevenSegmentPassword.Value += "6";
                        break;
                    //case '7':
                    case 55:
                    case 103:
                        sevenSegmentPassword.Value += "7";
                        break;
                    //case '8':
                    case 56:
                    case 104:
                        sevenSegmentPassword.Value += "8";
                        break;
                    //case '9':
                    case 57:
                    case 105:
                        sevenSegmentPassword.Value += "9";
                        break;
                    //case '\b':
                    case 8:
                    case 46:
                        if (sevenSegmentPassword.Value.Length > 0)
                        {
                            sevenSegmentPassword.Value = sevenSegmentPassword.Value.Substring(0, sevenSegmentPassword.Value.Length - 1);
                        }
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
                if(sevenSegmentPassword.Value == _password)
                {
                    timerCountDown.Stop();
                    MessageBox.Show("Bravo hai trovato la password!!!");
                    _isFinished = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void BombForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        #endregion

        #region Eventi TextBox password
        //private void password_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    switch (e.KeyChar)
        //    {
        //        case '0':
        //        case '1':
        //        case '2':
        //        case '3':
        //        case '4':
        //        case '5':
        //        case '6':
        //        case '7':
        //        case '8':
        //        case '9':
        //        case '\b':
        //            break;
        //        default:
        //            e.Handled = true;
        //            break;
        //    }
        //}

        //private void password_TextChanged(object sender, EventArgs e)
        //{
        //    if (password.Text == _password)
        //    {
        //        timerCountDown.Stop();
        //        MessageBox.Show("Bravo hai trovato la password!!!");
        //        _isFinished = true;
        //        this.Close();
        //    }
        //}


        #endregion

        #region Eventi Timer

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (_end > DateTime.Now)
            {
                _ts = _end - DateTime.Now;
                sevenSegmentArrayCountdown.Value = _ts.ToString(@"hh\.mm\.ss\.ff");
                TimeSpan now = _end - DateTime.Now;
                if (now < second20 && startTicTac)
                {
                    simpleSound.SoundLocation = @"c:\Windows\Media\tictac-of-a-wall-clock.wav";
                    simpleSound.Play();
                    startTicTac = false;
                }
            }
            else
            {
                sevenSegmentArrayCountdown.Value = "00.00.00.00";
                timerCountDown.Stop();
                if (_firstTime)
                {
                    simpleSound.Stop();
                    simpleSound.SoundLocation = @"c:\Windows\Media\alarm-003.wav";
                    simpleSound.Play();
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
                if (!config.IsValid)
                {
                    _isFinished = true;
                    this.Close();
                }
                else
                {
                    GetParametersFromConfigForm(config);
                    this.Visible = true;
                    this.Focus();
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

        private void BombForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            var pathApp = AppDomain.CurrentDomain.BaseDirectory;
            var pathApp2 = Path.Combine(pathApp, "img", "fase1A.jpg");
            this.BackgroundImage = Resources.fase1B;
            timerImageBackGround.Start();
        }

        private void timerImageBackGround_Tick(object sender, EventArgs e)
        {
            if (fase1a)
            {
                this.BackgroundImage = Resources.fase1A;
                fase1a = false;
            }
            else
            {
                this.BackgroundImage = Resources.fase1B;
                fase1a = true;
            }
        }

        private void sevenSegmentPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
