namespace Banka_Otomasyonu
{
    partial class MusteriAra
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
            txtId = new TextBox();
            label7 = new Label();
            txtAra = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(289, 58);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 1;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtBakiye.Location = new Point(182, 385);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(204, 28);
            txtBakiye.TabIndex = 14;
            txtBakiye.ValidatingType = typeof(int);
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTel.Location = new Point(182, 334);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(204, 28);
            txtTel.TabIndex = 12;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdres.Location = new Point(182, 283);
            txtAdres.Name = "txtAdres";
            txtAdres.ReadOnly = true;
            txtAdres.Size = new Size(204, 28);
            txtAdres.TabIndex = 10;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(182, 232);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(204, 28);
            txtAdSoyad.TabIndex = 8;
            // 
            // txtTcNo
            // 
            txtTcNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTcNo.Location = new Point(182, 181);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.ReadOnly = true;
            txtTcNo.Size = new Size(204, 28);
            txtTcNo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(64, 30);
            label6.Name = "label6";
            label6.Size = new Size(231, 25);
            label6.TabIndex = 17;
            label6.Text = "ID/TC NO İle Müşteri Ara";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 385);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 15;
            label5.Text = "Bakiye :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 334);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 13;
            label4.Text = "Telefon :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 283);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 11;
            label3.Text = "Adres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 232);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 9;
            label2.Text = "Ad / Soyad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 181);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 7;
            label1.Text = "TC NO :";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(182, 130);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(204, 28);
            txtId.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(64, 130);
            label7.Name = "label7";
            label7.Size = new Size(27, 21);
            label7.TabIndex = 19;
            label7.Text = "ID";
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.Location = new Point(64, 65);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(204, 28);
            txtAra.TabIndex = 0;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(64, 68);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 21;
            label8.Click += label8_Click;
            // 
            // MusteriAra
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 496);
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
            Name = "MusteriAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musteri Arama İşlemi";
            Load += MusteriAra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtId;
        private Label label7;
        private TextBox txtAra;
        private Label label8;
    }
}