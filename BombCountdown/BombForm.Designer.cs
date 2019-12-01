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
            this.sevenSegmentArrayCountdown = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.password = new System.Windows.Forms.TextBox();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.sevenSegmentArrayCountdown.Location = new System.Drawing.Point(0, 0);
            this.sevenSegmentArrayCountdown.Name = "sevenSegmentArrayCountdown";
            this.sevenSegmentArrayCountdown.Size = new System.Drawing.Size(900, 200);
            this.sevenSegmentArrayCountdown.TabIndex = 0;
            this.sevenSegmentArrayCountdown.TabStop = false;
            this.sevenSegmentArrayCountdown.Value = null;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.DimGray;
            this.password.Font = new System.Drawing.Font("Verdana Pro Cond", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(45, 230);
            this.password.MaxLength = 4;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(281, 124);
            this.password.TabIndex = 1;
            this.password.TabStop = false;
            this.password.Text = "0000";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // BombForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1902, 1022);
            this.ControlBox = false;
            this.Controls.Add(this.password);
            this.Controls.Add(this.sevenSegmentArrayCountdown);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "BombForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BombForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BombForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BombForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BombForm_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArrayCountdown;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

