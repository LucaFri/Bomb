namespace BombCountdown
{
    partial class BombForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BombForm));
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.sevenSegmentArrayCountdown = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.timerImageBackGround = new System.Windows.Forms.Timer(this.components);
            this.sevenSegmentPassword = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.SuspendLayout();
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // sevenSegmentArrayCountdown
            // 
            this.sevenSegmentArrayCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentArrayCountdown.ArrayCount = 8;
            this.sevenSegmentArrayCountdown.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArrayCountdown.ColorDark = System.Drawing.Color.Empty;
            this.sevenSegmentArrayCountdown.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArrayCountdown.DecimalShow = true;
            this.sevenSegmentArrayCountdown.ElementPadding = new System.Windows.Forms.Padding(8, 5, 19, 5);
            this.sevenSegmentArrayCountdown.ElementWidth = 11;
            this.sevenSegmentArrayCountdown.ItalicFactor = 0.01F;
            this.sevenSegmentArrayCountdown.Location = new System.Drawing.Point(669, 282);
            this.sevenSegmentArrayCountdown.Name = "sevenSegmentArrayCountdown";
            this.sevenSegmentArrayCountdown.Size = new System.Drawing.Size(559, 137);
            this.sevenSegmentArrayCountdown.TabIndex = 0;
            this.sevenSegmentArrayCountdown.TabStop = false;
            this.sevenSegmentArrayCountdown.Value = null;
            // 
            // timerImageBackGround
            // 
            this.timerImageBackGround.Interval = 1000;
            this.timerImageBackGround.Tick += new System.EventHandler(this.timerImageBackGround_Tick);
            // 
            // sevenSegmentPassword
            // 
            this.sevenSegmentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentPassword.ArrayCount = 9;
            this.sevenSegmentPassword.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentPassword.ColorDark = System.Drawing.Color.Empty;
            this.sevenSegmentPassword.ColorLight = System.Drawing.Color.Green;
            this.sevenSegmentPassword.DecimalShow = true;
            this.sevenSegmentPassword.ElementPadding = new System.Windows.Forms.Padding(8, 5, 19, 5);
            this.sevenSegmentPassword.ElementWidth = 11;
            this.sevenSegmentPassword.ItalicFactor = 0.01F;
            this.sevenSegmentPassword.Location = new System.Drawing.Point(669, 581);
            this.sevenSegmentPassword.Name = "sevenSegmentPassword";
            this.sevenSegmentPassword.Size = new System.Drawing.Size(559, 117);
            this.sevenSegmentPassword.TabIndex = 2;
            this.sevenSegmentPassword.TabStop = false;
            this.sevenSegmentPassword.Value = null;
            // 
            // BombForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 1022);
            this.ControlBox = false;
            this.Controls.Add(this.sevenSegmentPassword);
            this.Controls.Add(this.sevenSegmentArrayCountdown);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "BombForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BombForm_FormClosing);
            this.Load += new System.EventHandler(this.BombForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BombForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BombForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BombForm_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArrayCountdown;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Timer timerImageBackGround;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentPassword;
    }
}

