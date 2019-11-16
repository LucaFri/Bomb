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
            this.sevenSegmentArrayCountdown = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.SuspendLayout();
            // 
            // sevenSegmentArrayCountdown
            // 
            this.sevenSegmentArrayCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentArrayCountdown.ArrayCount = 6;
            this.sevenSegmentArrayCountdown.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArrayCountdown.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentArrayCountdown.ColorLight = System.Drawing.Color.Green;
            this.sevenSegmentArrayCountdown.DecimalShow = true;
            this.sevenSegmentArrayCountdown.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArrayCountdown.ElementWidth = 10;
            this.sevenSegmentArrayCountdown.ItalicFactor = 0F;
            this.sevenSegmentArrayCountdown.Location = new System.Drawing.Point(0, 0);
            this.sevenSegmentArrayCountdown.Name = "sevenSegmentArrayCountdown";
            this.sevenSegmentArrayCountdown.Size = new System.Drawing.Size(900, 200);
            this.sevenSegmentArrayCountdown.TabIndex = 0;
            this.sevenSegmentArrayCountdown.TabStop = false;
            this.sevenSegmentArrayCountdown.Value = null;
            // 
            // BombForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1022);
            this.ControlBox = false;
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

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArrayCountdown;
    }
}

