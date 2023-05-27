namespace Banka_Otomasyonu
{
    partial class SifreDegistirme
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
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtEski = new TextBox();
            txtYeni = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 18;
            label3.Text = "Yeni Şifre:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(163, 195);
            button1.Name = "button1";
            button1.Size = new Size(198, 42);
            button1.TabIndex = 17;
            button1.Text = "Şifre Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 15;
            label2.Text = "Eski Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(9, 40);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 14;
            label1.Text = "Şifre Değiştirme İşlemi";
            // 
            // txtEski
            // 
            txtEski.Location = new Point(163, 96);
            txtEski.Name = "txtEski";
            txtEski.Size = new Size(198, 26);
            txtEski.TabIndex = 19;
            // 
            // txtYeni
            // 
            txtYeni.Location = new Point(161, 144);
            txtYeni.Name = "txtYeni";
            txtYeni.Size = new Size(198, 26);
            txtYeni.TabIndex = 20;
            // 
            // SifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 316);
            Controls.Add(txtYeni);
            Controls.Add(txtEski);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SifreDegistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreDegistirme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtEski;
        private TextBox txtYeni;
    }
}