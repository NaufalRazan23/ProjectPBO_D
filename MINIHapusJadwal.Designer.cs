namespace ProjectPBO
{
    partial class MINIHapusJadwal
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
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(126, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(604, 32);
            label4.TabIndex = 48;
            label4.Text = "APAKAH ANDA YAKIN INGIN MENGHAPUS JADWAL INI?";
            // 
            // button2
            // 
            button2.Location = new Point(409, 412);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 47;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(280, 412);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 46;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MINIHapusJadwal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 623);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MINIHapusJadwal";
            Text = "HapusJadwal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button2;
        private Button button1;
    }
}