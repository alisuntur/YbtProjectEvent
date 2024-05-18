namespace WinFormsApp1
{
    partial class Fatura
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
            lstFatura = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstFatura
            // 
            lstFatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstFatura.FormattingEnabled = true;
            lstFatura.ItemHeight = 25;
            lstFatura.Location = new Point(80, 43);
            lstFatura.Name = "lstFatura";
            lstFatura.Size = new Size(607, 329);
            lstFatura.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(685, 385);
            button1.Name = "button1";
            button1.Size = new Size(103, 53);
            button1.TabIndex = 10;
            button1.Text = "Masa Seç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Fatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lstFatura);
            Name = "Fatura";
            Text = "Fatura";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFatura;
        private Button button1;
    }
}