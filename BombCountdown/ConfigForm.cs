using System;
using System.Windows.Forms;

namespace BombCountdown
{
    public partial class ConfigForm : Form
    {
        #region Campi privati

        public bool IsValid { get; set; } = false;

        #endregion

        #region Proprietà pubbliche

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

        #region Eventi form
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPassword.Text.Length > 8)
                {
                    e.Handled = true;
                }
                lblError.Text = string.Empty;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            try
            {
                DurataOreCountdown1 = (int)nudOreC1.Value;
                DurataMinutiCountdown1 = (int)nudMinutiC1.Value;
                DurataOreCountdown2 = (int)nudOreC2.Value;
                DurataMinutiCountdown2 = (int)nudMinutiC2.Value;
                Password = txtPassword.Text;
                IsValid = ConfigIsValid();
                if (IsValid)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Metodi privati
        private bool ConfigIsValid()
        {
            bool ret = false;
            if (DurataMinutiCountdown1 + DurataOreCountdown1 == 0)
            {
                lblError.Text = "Devi inserire un tempo minimo per il primo countdown";
                return ret;
            }
            if (DurataMinutiCountdown2 + DurataOreCountdown2 == 0)
            {
                lblError.Text = "Devi inserire un tempo minimo per il secondo countdown";
                return ret;
            }
            if (Password == string.Empty)
            {
                lblError.Text = "Devi inserire una password da indovinare";
                return ret;
            }
            return true;
        } 
        #endregion
    }
}
