namespace WinFormsApp1
{
    partial class SiparisSayfasi
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
            lblMasa = new Label();
            lstUrunler = new ListBox();
            btnEkle = new Button();
            btnCıkar = new Button();
            lstSiparisler = new ListBox();
            btn_faturaKes = new Button();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(290, 29);
            label1.Name = "label1";
            label1.Size = new Size(421, 37);
            label1.TabIndex = 0;
            label1.Text = "Numaralı Masa Siparişi Alınıyor";
            // 
            // lblMasa
            // 
            lblMasa.AutoSize = true;
            lblMasa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblMasa.Location = new Point(188, 29);
            lblMasa.Name = "lblMasa";
            lblMasa.Size = new Size(96, 37);
            lblMasa.TabIndex = 1;
            lblMasa.Text = "label2";
            // 
            // lstUrunler
            // 
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 15;
            lstUrunler.Location = new Point(48, 129);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(236, 364);
            lstUrunler.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.YellowGreen;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(381, 194);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(103, 53);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.BackColor = Color.Brown;
            btnCıkar.FlatStyle = FlatStyle.Flat;
            btnCıkar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCıkar.ForeColor = SystemColors.ButtonHighlight;
            btnCıkar.Location = new Point(381, 281);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(103, 53);
            btnCıkar.TabIndex = 4;
            btnCıkar.Text = "Çıkar";
            btnCıkar.UseVisualStyleBackColor = false;
            btnCıkar.Click += btnCıkar_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(565, 128);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(236, 364);
            lstSiparisler.TabIndex = 5;
            // 
            // btn_faturaKes
            // 
            btn_faturaKes.BackColor = SystemColors.Highlight;
            btn_faturaKes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_faturaKes.ForeColor = SystemColors.ButtonHighlight;
            btn_faturaKes.Location = new Point(822, 29);
            btn_faturaKes.Name = "btn_faturaKes";
            btn_faturaKes.Size = new Size(103, 53);
            btn_faturaKes.TabIndex = 6;
            btn_faturaKes.Text = "Fatura Kes";
            btn_faturaKes.UseVisualStyleBackColor = false;
            btn_faturaKes.Click += btn_faturaKes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.Location = new Point(69, 91);
            label2.Name = "label2";
            label2.Size = new Size(167, 37);
            label2.TabIndex = 7;
            label2.Text = "Urun Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.Location = new Point(565, 90);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 8;
            label3.Text = "Sipariş Listesi";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 26);
            button1.Name = "button1";
            button1.Size = new Size(103, 53);
            button1.TabIndex = 9;
            button1.Text = "Masa Seç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SiparisSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(952, 563);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_faturaKes);
            Controls.Add(lstSiparisler);
            Controls.Add(btnCıkar);
            Controls.Add(btnEkle);
            Controls.Add(lstUrunler);
            Controls.Add(lblMasa);
            Controls.Add(label1);
            Name = "SiparisSayfasi";
            Text = "SiparisSayfasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMasa;
        private ListBox lstUrunler;
        private Button btnEkle;
        private Button btnCıkar;
        private ListBox lstSiparisler;
        private Button btn_faturaKes;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}