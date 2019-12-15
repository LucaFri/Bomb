namespace BombCountdown
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOreC1 = new System.Windows.Forms.Label();
            this.lblMinutiC1 = new System.Windows.Forms.Label();
            this.lblMinutiC2 = new System.Windows.Forms.Label();
            this.lblOreC2 = new System.Windows.Forms.Label();
            this.nudOreC1 = new System.Windows.Forms.NumericUpDown();
            this.nudMinutiC1 = new System.Windows.Forms.NumericUpDown();
            this.nudMinutiC2 = new System.Windows.Forms.NumericUpDown();
            this.nudOreC2 = new System.Windows.Forms.NumericUpDown();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudOreC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutiC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutiC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOreC2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOreC1
            // 
            this.lblOreC1.AutoSize = true;
            this.lblOreC1.Location = new System.Drawing.Point(5, 17);
            this.lblOreC1.Name = "lblOreC1";
            this.lblOreC1.Size = new System.Drawing.Size(147, 13);
            this.lblOreC1.TabIndex = 0;
            this.lblOreC1.Text = "Durata ore primo countdown: ";
            // 
            // lblMinutiC1
            // 
            this.lblMinutiC1.AutoSize = true;
            this.lblMinutiC1.Location = new System.Drawing.Point(268, 17);
            this.lblMinutiC1.Name = "lblMinutiC1";
            this.lblMinutiC1.Size = new System.Drawing.Size(159, 13);
            this.lblMinutiC1.TabIndex = 1;
            this.lblMinutiC1.Text = "Durata minuti primo countdown: ";
            // 
            // lblMinutiC2
            // 
            this.lblMinutiC2.AutoSize = true;
            this.lblMinutiC2.Location = new System.Drawing.Point(268, 41);
            this.lblMinutiC2.Name = "lblMinutiC2";
            this.lblMinutiC2.Size = new System.Drawing.Size(175, 13);
            this.lblMinutiC2.TabIndex = 3;
            this.lblMinutiC2.Text = "Durata minuti secondo countdown: ";
            // 
            // lblOreC2
            // 
            this.lblOreC2.AutoSize = true;
            this.lblOreC2.Location = new System.Drawing.Point(5, 41);
            this.lblOreC2.Name = "lblOreC2";
            this.lblOreC2.Size = new System.Drawing.Size(163, 13);
            this.lblOreC2.TabIndex = 2;
            this.lblOreC2.Text = "Durata ore secondo countdown: ";
            // 
            // nudOreC1
            // 
            this.nudOreC1.Location = new System.Drawing.Point(187, 15);
            this.nudOreC1.Name = "nudOreC1";
            this.nudOreC1.Size = new System.Drawing.Size(62, 20);
            this.nudOreC1.TabIndex = 4;
            // 
            // nudMinutiC1
            // 
            this.nudMinutiC1.Location = new System.Drawing.Point(450, 15);
            this.nudMinutiC1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutiC1.Name = "nudMinutiC1";
            this.nudMinutiC1.Size = new System.Drawing.Size(62, 20);
            this.nudMinutiC1.TabIndex = 5;
            // 
            // nudMinutiC2
            // 
            this.nudMinutiC2.Location = new System.Drawing.Point(450, 39);
            this.nudMinutiC2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutiC2.Name = "nudMinutiC2";
            this.nudMinutiC2.Size = new System.Drawing.Size(62, 20);
            this.nudMinutiC2.TabIndex = 7;
            // 
            // nudOreC2
            // 
            this.nudOreC2.Location = new System.Drawing.Point(187, 39);
            this.nudOreC2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudOreC2.Name = "nudOreC2";
            this.nudOreC2.Size = new System.Drawing.Size(62, 20);
            this.nudOreC2.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password da indovinare:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 65);
            this.txtPassword.MaxLength = 90;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(393, 85);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(119, 23);
            this.btnAvvia.TabIndex = 10;
            this.btnAvvia.Text = "Avvia countdown";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(23, 94);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 11;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 120);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.nudMinutiC2);
            this.Controls.Add(this.nudOreC2);
            this.Controls.Add(this.nudMinutiC1);
            this.Controls.Add(this.nudOreC1);
            this.Controls.Add(this.lblMinutiC2);
            this.Controls.Add(this.lblOreC2);
            this.Controls.Add(this.lblMinutiC1);
            this.Controls.Add(this.lblOreC1);
            this.Name = "ConfigForm";
            this.Text = "Configura countdown";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudOreC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutiC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutiC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOreC2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOreC1;
        private System.Windows.Forms.Label lblMinutiC1;
        private System.Windows.Forms.Label lblMinutiC2;
        private System.Windows.Forms.Label lblOreC2;
        private System.Windows.Forms.NumericUpDown nudOreC1;
        private System.Windows.Forms.NumericUpDown nudMinutiC1;
        private System.Windows.Forms.NumericUpDown nudMinutiC2;
        private System.Windows.Forms.NumericUpDown nudOreC2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Label lblError;
    }
}