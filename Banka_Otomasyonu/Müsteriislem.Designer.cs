namespace Banka_Otomasyonu
{
    partial class Müsteriislem
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
            groupBox1 = new GroupBox();
            btnHesapH = new Button();
            btnCikis = new Button();
            btnSifre = new Button();
            btnHavale = new Button();
            btnBakiyeGör = new Button();
            btnParaYatir = new Button();
            btnParaCek = new Button();
            label2 = new Label();
            label1 = new Label();
            lblADSoyad = new Label();
            lblHesapNo = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapH);
            groupBox1.Controls.Add(btnCikis);
            groupBox1.Controls.Add(btnSifre);
            groupBox1.Controls.Add(btnHavale);
            groupBox1.Controls.Add(btnBakiyeGör);
            groupBox1.Controls.Add(btnParaYatir);
            groupBox1.Controls.Add(btnParaCek);
            groupBox1.Location = new Point(42, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 461);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnHesapH
            // 
            btnHesapH.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapH.Location = new Point(49, 334);
            btnHesapH.Name = "btnHesapH";
            btnHesapH.Size = new Size(242, 39);
            btnHesapH.TabIndex = 6;
            btnHesapH.Text = "Hesap Hareketleri";
            btnHesapH.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Crimson;
            btnCikis.Location = new Point(49, 393);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(242, 39);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnSifre
            // 
            btnSifre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifre.Location = new Point(49, 275);
            btnSifre.Name = "btnSifre";
            btnSifre.Size = new Size(242, 39);
            btnSifre.TabIndex = 4;
            btnSifre.Text = "Şifre Değiştir";
            btnSifre.UseVisualStyleBackColor = true;
            // 
            // btnHavale
            // 
            btnHavale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHavale.Location = new Point(49, 216);
            btnHavale.Name = "btnHavale";
            btnHavale.Size = new Size(242, 39);
            btnHavale.TabIndex = 3;
            btnHavale.Text = "Havale/EFT";
            btnHavale.UseVisualStyleBackColor = true;
            // 
            // btnBakiyeGör
            // 
            btnBakiyeGör.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBakiyeGör.Location = new Point(49, 157);
            btnBakiyeGör.Name = "btnBakiyeGör";
            btnBakiyeGör.Size = new Size(242, 39);
            btnBakiyeGör.TabIndex = 2;
            btnBakiyeGör.Text = "Bakiye Görüntüle";
            btnBakiyeGör.UseVisualStyleBackColor = true;
            // 
            // btnParaYatir
            // 
            btnParaYatir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnParaYatir.Location = new Point(49, 98);
            btnParaYatir.Name = "btnParaYatir";
            btnParaYatir.Size = new Size(242, 39);
            btnParaYatir.TabIndex = 1;
            btnParaYatir.Text = "Para Yatır";
            btnParaYatir.UseVisualStyleBackColor = true;
            // 
            // btnParaCek
            // 
            btnParaCek.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnParaCek.Location = new Point(49, 39);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(242, 39);
            btnParaCek.TabIndex = 0;
            btnParaCek.Text = "Para Çek";
            btnParaCek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, -18);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 3;
            label1.Text = "Ad Soyad:";
            // 
            // lblADSoyad
            // 
            lblADSoyad.AutoSize = true;
            lblADSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblADSoyad.ForeColor = Color.Crimson;
            lblADSoyad.Location = new Point(150, 9);
            lblADSoyad.Name = "lblADSoyad";
            lblADSoyad.Size = new Size(17, 25);
            lblADSoyad.TabIndex = 6;
            lblADSoyad.Text = ".";
            lblADSoyad.Click += label3_Click;
            // 
            // lblHesapNo
            // 
            lblHesapNo.AutoSize = true;
            lblHesapNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHesapNo.ForeColor = Color.Crimson;
            lblHesapNo.Location = new Point(150, 54);
            lblHesapNo.Name = "lblHesapNo";
            lblHesapNo.Size = new Size(17, 25);
            lblHesapNo.TabIndex = 7;
            lblHesapNo.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(42, 54);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 8;
            label5.Text = "Hesap No:";
            // 
            // Müsteriislem
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 577);
            Controls.Add(label5);
            Controls.Add(lblHesapNo);
            Controls.Add(lblADSoyad);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Müsteriislem";
            Text = "Müşteri İşlemleri";
            Load += Müsteriislem_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCikis;
        private Button btnSifre;
        private Button btnHavale;
        private Button btnBakiyeGör;
        private Button btnParaYatir;
        private Button btnParaCek;
        private Label label2;
        private Label label1;
        private Label lblADSoyad;
        private Label lblHesapNo;
        private Label label5;
        private Button btnHesapH;
    }
}