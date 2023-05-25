namespace Banka_Otomasyonu
{
    partial class Yetkili_işlem
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
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCikis = new Button();
            btnListele = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnAra = new Button();
            btnEkle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldiniz Sayın Admin";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCikis);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Location = new Point(47, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "yetkili işlemleri";
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Crimson;
            btnCikis.Location = new Point(49, 359);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(242, 39);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.Location = new Point(49, 295);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(242, 39);
            btnListele.TabIndex = 4;
            btnListele.Text = "Müşterileri Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(49, 231);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(242, 39);
            btnSil.TabIndex = 3;
            btnSil.Text = "Müşteri Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(49, 167);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(242, 39);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Müşteri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAra.Location = new Point(49, 103);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(242, 39);
            btnAra.TabIndex = 1;
            btnAra.Text = "Müşteri Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(49, 39);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(242, 39);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Müşteri Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Yetkili_işlem
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 540);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Yetkili_işlem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili işlemleri";
            Load += Yetkili_işlem_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnCikis;
        private Button btnListele;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnAra;
        private Button btnEkle;
    }
}