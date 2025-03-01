namespace HastaneProje
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(189, 239);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(184, 31);
            this.TxtSifre.TabIndex = 46;
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(189, 305);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(184, 43);
            this.BtnBilgiGuncelle.TabIndex = 45;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(189, 44);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(184, 31);
            this.TxtAd.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Doktor Ad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(189, 86);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(184, 31);
            this.TxtSoyad.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Doktor Soyad:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(189, 131);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(184, 31);
            this.MskTC.TabIndex = 36;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Doktor Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Doktor TC Kimlik No:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(189, 189);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(186, 31);
            this.CmbBrans.TabIndex = 47;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Doktor  Branş:";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(469, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label4;
    }
}