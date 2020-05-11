namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmRadyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadyo));
            this.lnkLabelKanal1 = new System.Windows.Forms.LinkLabel();
            this.lnkLblKanal2 = new System.Windows.Forms.LinkLabel();
            this.lnkLblKanal3 = new System.Windows.Forms.LinkLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLabelKanal1
            // 
            this.lnkLabelKanal1.AutoSize = true;
            this.lnkLabelKanal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnkLabelKanal1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLabelKanal1.ForeColor = System.Drawing.Color.Yellow;
            this.lnkLabelKanal1.Location = new System.Drawing.Point(12, 421);
            this.lnkLabelKanal1.Name = "lnkLabelKanal1";
            this.lnkLabelKanal1.Size = new System.Drawing.Size(107, 28);
            this.lnkLabelKanal1.TabIndex = 0;
            this.lnkLabelKanal1.TabStop = true;
            this.lnkLabelKanal1.Text = "PowerTurk";
            this.lnkLabelKanal1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelKanal1_LinkClicked);
            // 
            // lnkLblKanal2
            // 
            this.lnkLblKanal2.AutoSize = true;
            this.lnkLblKanal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnkLblKanal2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblKanal2.ForeColor = System.Drawing.Color.Yellow;
            this.lnkLblKanal2.Location = new System.Drawing.Point(197, 421);
            this.lnkLblKanal2.Name = "lnkLblKanal2";
            this.lnkLblKanal2.Size = new System.Drawing.Size(56, 28);
            this.lnkLblKanal2.TabIndex = 1;
            this.lnkLblKanal2.TabStop = true;
            this.lnkLblKanal2.Text = "90lar";
            this.lnkLblKanal2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblKanal2_LinkClicked);
            // 
            // lnkLblKanal3
            // 
            this.lnkLblKanal3.AutoSize = true;
            this.lnkLblKanal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnkLblKanal3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblKanal3.ForeColor = System.Drawing.Color.Yellow;
            this.lnkLblKanal3.Location = new System.Drawing.Point(347, 421);
            this.lnkLblKanal3.Name = "lnkLblKanal3";
            this.lnkLblKanal3.Size = new System.Drawing.Size(91, 28);
            this.lnkLblKanal3.TabIndex = 2;
            this.lnkLblKanal3.TabStop = true;
            this.lnkLblKanal3.Text = "Sivas FM";
            this.lnkLblKanal3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblKanal3_LinkClicked);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(665, 328);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // FrmRadyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lnkLblKanal3);
            this.Controls.Add(this.lnkLblKanal2);
            this.Controls.Add(this.lnkLabelKanal1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRadyo";
            this.Text = "Radyo Dinle";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLabelKanal1;
        private System.Windows.Forms.LinkLabel lnkLblKanal2;
        private System.Windows.Forms.LinkLabel lnkLblKanal3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}