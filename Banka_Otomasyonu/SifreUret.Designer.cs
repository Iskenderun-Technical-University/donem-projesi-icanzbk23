namespace Banka_Otomasyonu
{
    partial class SifreUret
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
            txtSifre = new TextBox();
            txtTc = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtTelefon = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(122, 150);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(242, 26);
            txtSifre.TabIndex = 3;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(122, 63);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(244, 26);
            txtTc.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 24;
            label3.Text = "Yeni Şifre:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(166, 206);
            button1.Name = "button1";
            button1.Size = new Size(198, 42);
            button1.TabIndex = 4;
            button1.Text = "Şifre Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(17, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 22;
            label2.Text = "TC No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(201, 24);
            label1.TabIndex = 21;
            label1.Text = "Yeni Şifre Oluşturma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(17, 102);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 27;
            label4.Text = "Telefon No:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(122, 102);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(244, 26);
            txtTelefon.TabIndex = 1;
            // 
            // SifreUret
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 289);
            Controls.Add(txtTelefon);
            Controls.Add(label4);
            Controls.Add(txtSifre);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SifreUret";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreUret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private TextBox txtTc;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label4;
        private MaskedTextBox txtTelefon;
    }
}