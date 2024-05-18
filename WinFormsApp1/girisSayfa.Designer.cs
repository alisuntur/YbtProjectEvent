namespace WinFormsApp1
{
    partial class girisSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisSayfa));
            label1 = new Label();
            label2 = new Label();
            txtKAdi = new TextBox();
            txtPswd = new TextBox();
            btnGiris = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 79);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Parola :";
            // 
            // txtKAdi
            // 
            txtKAdi.Location = new Point(119, 37);
            txtKAdi.Name = "txtKAdi";
            txtKAdi.Size = new Size(100, 27);
            txtKAdi.TabIndex = 2;
            // 
            // txtPswd
            // 
            txtPswd.Location = new Point(119, 72);
            txtPswd.Name = "txtPswd";
            txtPswd.Size = new Size(100, 27);
            txtPswd.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.DarkSeaGreen;
            btnGiris.Location = new Point(112, 129);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(107, 33);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPswd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKAdi);
            groupBox1.Location = new Point(297, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 178);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // girisSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(3, 4, 3, 4);
            Name = "girisSayfa";
            Text = "Giris Ekran";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKAdi;
        private TextBox txtPswd;
        private Button btnGiris;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
