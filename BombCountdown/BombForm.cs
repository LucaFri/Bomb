using BombCountdown.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BombCountdown
{
    public partial class BombForm : Form
    {

        #region Campi privati

        bool _firstTime = true;
        bool _startTicTac = true;
        bool _isFinished = false;
        bool _fase2 = false;
        bool _fase1a = true;
        int _durataOreCountdown1;
        int _durataMinutiCountdown1;
        int _durataOreCountdown2;
        int _durataMinutiCountdown2;
        string _password;
        TimeSpan _second20 = new TimeSpan(0, 0, 22);
        TimeSpan _second30 = new TimeSpan(0, 0, 30);
        TimeSpan _second1 = new TimeSpan(0, 0, 1);
        TimeSpan _ts;
        DateTime _start;
        DateTime _end;
        DateTime? _startAlarm;
        SoundPlayer _simpleSound = new SoundPlayer(@"c:\Windows\Media\tictac-of-a-wall-clock.wav");

        #endregion

        #region Costruttori
        public BombForm()
        {
            InitializeComponent();
            ConfigForm configForm = new ConfigForm();
            configForm.FormClosed += ConfigForm_FormClosed;
            this.Visible = false;
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
            Point startLocationCentralSevenSegment = GetCentralPoint(sevenSegmentArrayCountdown);
        }
        private Point GetCentralPoint(Control control)
        {
            return new Point((this.Width / 2) - control.Width / 2,
                (this.Height / 2) - control.Height / 2);
        }
        private void AvviaCountdown(int min = 0, int ore = 0)
        {
            _start = DateTime.Now;
            _end = _start.AddMinutes(min).AddHours(ore);
            timerCountDown.Start();
            this.Focus();
        }

        #endregion

        #region Eventi

        #region Eventi Form
        private void BombForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            int indexLastScreen = Screen.AllScreens.Length - 1;
            this.Location = Screen.AllScreens[indexLastScreen].WorkingArea.Location;
            sevenSegmentArrayCountdown.ColorDark = Color.FromArgb(20, 20, 20);
            sevenSegmentPassword.ColorDark = Color.FromArgb(20, 20, 20);
            sevenSegmentArrayCountdown.ColorBackground = Color.FromArgb(4, 11, 30);
            sevenSegmentPassword.ColorBackground = Color.FromArgb(4, 11, 30);
            this.BackgroundImage = Resources.fase1B;
            timerImageBackGround.Start();
        }
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
                if (sevenSegmentPassword.Value == _password)
                {
                    timerCountDown.Stop();
                    this.BackgroundImage = Resources.winner;
                    this.sevenSegmentArrayCountdown.Visible = false;
                    this.sevenSegmentPassword.Visible = false;
                    //MessageBox.Show("Bravo hai trovato la password!!!");
                    _isFinished = true;
                }
                if (_fase2)
                {
                    this.BackgroundImage = Resources.pairs;
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
            if (_startAlarm.HasValue && (DateTime.Now - _startAlarm) > _second30)
            {
                _simpleSound.Stop();
                AvviaCountdown(_durataMinutiCountdown2, _durataOreCountdown2);
            }
            if (_end > DateTime.Now)
            {
                _ts = _end - DateTime.Now;
                sevenSegmentArrayCountdown.Value = _ts.ToString(@"hh\.mm\.ss\.ff");
                TimeSpan now = _end - DateTime.Now;
                if (now < _second20 && _startTicTac)
                {
                    _simpleSound.SoundLocation = @"c:\Windows\Media\tictac-of-a-wall-clock.wav";
                    _simpleSound.Play();
                    _startTicTac = false;
                }
            }
            else
            {
                sevenSegmentArrayCountdown.Value = "00.00.00.00";
                timerCountDown.Stop();
                if (_firstTime)
                {
                    _simpleSound.Stop();
                    timerImageBackGround.Stop();
                    _simpleSound.SoundLocation = @"c:\Windows\Media\alarm-003.wav";
                    _simpleSound.Play();
                    _fase2 = true;
                    _firstTime = false;
                    _startAlarm = DateTime.Now;
                    this.BackgroundImage = Resources.faseC;
                }
                else
                {
                    _isFinished = true;
                    this.BackgroundImage = Resources.death;
                    this.sevenSegmentArrayCountdown.Visible = false;
                    this.sevenSegmentPassword.Visible = false;
                    this.Close();
                }
            }
        }
        private void timerImageBackGround_Tick(object sender, EventArgs e)
        {
            if (_fase1a)
            {
                this.BackgroundImage = Resources.fase1A;
                _fase1a = false;
            }
            else
            {
                this.BackgroundImage = Resources.fase1B;
                _fase1a = true;
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

    }
}
