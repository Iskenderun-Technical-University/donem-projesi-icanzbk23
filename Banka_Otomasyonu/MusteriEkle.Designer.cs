namespace Banka_Otomasyonu
{
    partial class MusteriEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTcNo = new TextBox();
            txtAdSoyad = new TextBox();
            txtAdres = new TextBox();
            txtTel = new MaskedTextBox();
            txtBakiye = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 107);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "TC NO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 163);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad / Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 219);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Adres :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 275);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 331);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 4;
            label5.Text = "Bakiye :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(161, 41);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 5;
            label6.Text = "Müşteri Ekleme";
            // 
            // txtTcNo
            // 
            txtTcNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTcNo.Location = new Point(187, 107);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(204, 28);
            txtTcNo.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(187, 163);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(204, 28);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdres.Location = new Point(187, 222);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(204, 28);
            txtAdres.TabIndex = 2;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTel.Location = new Point(187, 278);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 28);
            txtTel.TabIndex = 3;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtBakiye.Location = new Point(187, 331);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(204, 28);
            txtBakiye.TabIndex = 4;
            txtBakiye.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(187, 424);
            button1.Name = "button1";
            button1.Size = new Size(178, 52);
            button1.TabIndex = 5;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 544);
            Controls.Add(button1);
            Controls.Add(txtBakiye);
            Controls.Add(txtTel);
            Controls.Add(txtAdres);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTcNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Müşteri Ekleme";
            Load += MusteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTcNo;
        private TextBox txtAdSoyad;
        private TextBox txtAdres;
        private MaskedTextBox txtTel;
        private MaskedTextBox txtBakiye;
        private Button button1;
    }
}