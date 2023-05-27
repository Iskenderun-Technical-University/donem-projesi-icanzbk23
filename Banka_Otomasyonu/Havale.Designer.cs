namespace Banka_Otomasyonu
{
    partial class Havale
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
            txtNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txtMiktar = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(115, 220);
            button1.Name = "button1";
            button1.Size = new Size(198, 42);
            button1.TabIndex = 11;
            button1.Text = "Havale/EFT Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(165, 105);
            txtNo.Mask = "000000000000";
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(198, 30);
            txtNo.TabIndex = 10;
            txtNo.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(33, 115);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 9;
            label2.Text = "Alıcı Hesap No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(30, 59);
            label1.Name = "label1";
            label1.Size = new Size(180, 24);
            label1.TabIndex = 8;
            label1.Text = "Havale/EFT İşlemi";
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiktar.Location = new Point(165, 160);
            txtMiktar.Mask = "000000000000";
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(198, 30);
            txtMiktar.TabIndex = 13;
            txtMiktar.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(33, 165);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 12;
            label3.Text = "Miktar(₺)";
            // 
            // Havale
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 312);
            Controls.Add(txtMiktar);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Havale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Havale/EFT";
            Load += Havale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtNo;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtMiktar;
        private Label label3;
    }
}