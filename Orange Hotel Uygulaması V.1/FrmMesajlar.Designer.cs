namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmMesajlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesajAdsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewMesaj = new System.Windows.Forms.ListView();
            this.mesajId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdıSoyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtMesajAdsoyad
            // 
            this.txtMesajAdsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMesajAdsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesajAdsoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMesajAdsoyad.Location = new System.Drawing.Point(167, 38);
            this.txtMesajAdsoyad.Name = "txtMesajAdsoyad";
            this.txtMesajAdsoyad.Size = new System.Drawing.Size(282, 30);
            this.txtMesajAdsoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(91, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesaj:";
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMesaj.Location = new System.Drawing.Point(167, 84);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(677, 274);
            this.txtMesaj.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(167, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewMesaj
            // 
            this.listViewMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listViewMesaj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mesajId,
            this.AdıSoyadı,
            this.Mesaj});
            this.listViewMesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listViewMesaj.Location = new System.Drawing.Point(167, 437);
            this.listViewMesaj.Name = "listViewMesaj";
            this.listViewMesaj.Size = new System.Drawing.Size(677, 217);
            this.listViewMesaj.TabIndex = 5;
            this.listViewMesaj.UseCompatibleStateImageBehavior = false;
            this.listViewMesaj.View = System.Windows.Forms.View.Details;
            this.listViewMesaj.DoubleClick += new System.EventHandler(this.listViewMesajDoubleClick);
            // 
            // mesajId
            // 
            this.mesajId.Text = "mesajId";
            this.mesajId.Width = 92;
            // 
            // AdıSoyadı
            // 
            this.AdıSoyadı.Text = "AdıSoyadı";
            this.AdıSoyadı.Width = 191;
            // 
            // Mesaj
            // 
            this.Mesaj.Text = "Mesaj";
            this.Mesaj.Width = 320;
            // 
            // FrmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(851, 611);
            this.Controls.Add(this.listViewMesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMesajAdsoyad);
            this.Controls.Add(this.label1);
            this.Name = "FrmMesajlar";
            this.Text = "FrmMesajlar";
            this.Load += new System.EventHandler(this.FrmMesajlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesajAdsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewMesaj;
        private System.Windows.Forms.ColumnHeader mesajId;
        private System.Windows.Forms.ColumnHeader AdıSoyadı;
        private System.Windows.Forms.ColumnHeader Mesaj;
    }
}