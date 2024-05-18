namespace WinFormsApp1
{
    partial class AnaEkran
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
            masa1 = new Button();
            masa2 = new Button();
            masa3 = new Button();
            masa6 = new Button();
            masa5 = new Button();
            masa4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // masa1
            // 
            masa1.BackColor = Color.IndianRed;
            masa1.Location = new Point(44, 136);
            masa1.Name = "masa1";
            masa1.Size = new Size(135, 56);
            masa1.TabIndex = 0;
            masa1.Text = "MASA 1";
            masa1.UseVisualStyleBackColor = false;
            masa1.Click += masa1_Click;
            // 
            // masa2
            // 
            masa2.BackColor = SystemColors.ActiveCaption;
            masa2.Location = new Point(314, 136);
            masa2.Name = "masa2";
            masa2.Size = new Size(135, 56);
            masa2.TabIndex = 1;
            masa2.Text = "MASA 2";
            masa2.UseVisualStyleBackColor = false;
            masa2.Click += masa2_Click;
            // 
            // masa3
            // 
            masa3.BackColor = SystemColors.Highlight;
            masa3.Location = new Point(584, 136);
            masa3.Name = "masa3";
            masa3.Size = new Size(135, 56);
            masa3.TabIndex = 2;
            masa3.Text = "MASA 3";
            masa3.UseVisualStyleBackColor = false;
            masa3.Click += masa3_Click;
            // 
            // masa6
            // 
            masa6.BackColor = Color.MediumOrchid;
            masa6.Location = new Point(584, 198);
            masa6.Name = "masa6";
            masa6.Size = new Size(135, 56);
            masa6.TabIndex = 5;
            masa6.Text = "MASA 6";
            masa6.UseVisualStyleBackColor = false;
            masa6.Click += masa6_Click;
            // 
            // masa5
            // 
            masa5.BackColor = Color.LightSalmon;
            masa5.Location = new Point(314, 198);
            masa5.Name = "masa5";
            masa5.Size = new Size(135, 56);
            masa5.TabIndex = 4;
            masa5.Text = "MASA 5";
            masa5.UseVisualStyleBackColor = false;
            masa5.Click += masa5_Click;
            // 
            // masa4
            // 
            masa4.BackColor = SystemColors.GrayText;
            masa4.Location = new Point(44, 198);
            masa4.Name = "masa4";
            masa4.Size = new Size(135, 56);
            masa4.TabIndex = 3;
            masa4.Text = "MASA 4";
            masa4.UseVisualStyleBackColor = false;
            masa4.Click += masa4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(192, 61);
            label1.Name = "label1";
            label1.Size = new Size(352, 30);
            label1.TabIndex = 6;
            label1.Text = "Lütfen Sipariş Verilecek Masayı Seçin";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(masa6);
            Controls.Add(masa5);
            Controls.Add(masa4);
            Controls.Add(masa3);
            Controls.Add(masa2);
            Controls.Add(masa1);
            Name = "AnaEkran";
            Text = "AnaEkran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button masa1;
        private Button masa2;
        private Button masa3;
        private Button masa6;
        private Button masa5;
        private Button masa4;
        private Label label1;
    }
}