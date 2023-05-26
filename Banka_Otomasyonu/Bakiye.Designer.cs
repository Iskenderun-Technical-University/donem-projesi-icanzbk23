namespace Banka_Otomasyonu
{
    partial class Bakiye
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
            lblBakiye = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(30, 102);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Bakiyeniz(₺) : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(198, 24);
            label1.TabIndex = 8;
            label1.Text = "Bakiye Görüntüleme";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBakiye.ForeColor = Color.CornflowerBlue;
            lblBakiye.Location = new Point(157, 102);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(13, 20);
            lblBakiye.TabIndex = 10;
            lblBakiye.Text = ".";
            // 
            // Bakiye
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 177);
            Controls.Add(lblBakiye);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bakiye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bakiye";
            Load += Bakiye_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label lblBakiye;
    }
}