namespace Banka_Otomasyonu
{
    partial class Musteriguncelle
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
            txtAra = new TextBox();
            label8 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            button1 = new Button();
            txtBakiye = new MaskedTextBox();
            txtTel = new MaskedTextBox();
            txtAdres = new TextBox();
            txtAdSoyad = new TextBox();
            txtTcNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            label9 = new Label();
            txtDurum = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.Location = new Point(36, 53);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(204, 28);
            txtAra.TabIndex = 22;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 56);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 37;
            label8.Click += label8_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(154, 115);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(204, 28);
            txtId.TabIndex = 35;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(36, 118);
            label7.Name = "label7";
            label7.Size = new Size(27, 21);
            label7.TabIndex = 36;
            label7.Text = "ID";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(261, 46);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 23;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtBakiye.Location = new Point(154, 360);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(204, 28);
            txtBakiye.TabIndex = 32;
            txtBakiye.ValidatingType = typeof(int);
            txtBakiye.MaskInputRejected += txtBakiye_MaskInputRejected;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTel.Location = new Point(154, 311);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 28);
            txtTel.TabIndex = 30;
            txtTel.MaskInputRejected += txtTel_MaskInputRejected;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdres.Location = new Point(154, 262);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(204, 28);
            txtAdres.TabIndex = 28;
            txtAdres.TextChanged += txtAdres_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(154, 213);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(204, 28);
            txtAdSoyad.TabIndex = 26;
            txtAdSoyad.TextChanged += txtAdSoyad_TextChanged;
            // 
            // txtTcNo
            // 
            txtTcNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTcNo.Location = new Point(154, 164);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.ReadOnly = true;
            txtTcNo.Size = new Size(204, 28);
            txtTcNo.TabIndex = 24;
            txtTcNo.TextChanged += txtTcNo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(36, 18);
            label6.Name = "label6";
            label6.Size = new Size(231, 25);
            label6.TabIndex = 34;
            label6.Text = "ID/TC NO İle Müşteri Ara";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 363);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 33;
            label5.Text = "Bakiye :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 314);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 31;
            label4.Text = "Telefon :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 265);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 29;
            label3.Text = "Adres :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 216);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 27;
            label2.Text = "Ad / Soyad : ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 167);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 25;
            label1.Text = "TC NO :";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(154, 473);
            button2.Name = "button2";
            button2.Size = new Size(204, 36);
            button2.TabIndex = 38;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(36, 412);
            label9.Name = "label9";
            label9.Size = new Size(108, 21);
            label9.TabIndex = 40;
            label9.Text = "Durum(0/1) :";
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(152, 410);
            txtDurum.Mask = "0";
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(206, 26);
            txtDurum.TabIndex = 41;
            txtDurum.ValidatingType = typeof(int);
            // 
            // Musteriguncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 521);
            Controls.Add(txtDurum);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(txtAra);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(label7);
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
            Name = "Musteriguncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Güncelleme İşlemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private Label label8;
        private TextBox txtId;
        private Label label7;
        private Button button1;
        private MaskedTextBox txtBakiye;
        private MaskedTextBox txtTel;
        private TextBox txtAdres;
        private TextBox txtAdSoyad;
        private TextBox txtTcNo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label label9;
        private MaskedTextBox txtDurum;
    }
}