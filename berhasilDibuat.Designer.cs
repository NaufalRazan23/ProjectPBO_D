namespace ProjectPBO
{
    partial class berhasilDibuat
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(644, 67);
            label1.TabIndex = 0;
            label1.Text = "ANTRIAN BERHASIL DIBUAT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(134, 76);
            label2.Name = "label2";
            label2.Size = new Size(792, 67);
            label2.TabIndex = 1;
            label2.Text = "NOMOR ANTRIAN ANDA ADALAH";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 40F);
            label3.Location = new Point(407, 143);
            label3.Name = "label3";
            label3.Size = new Size(238, 89);
            label3.TabIndex = 2;
            label3.Text = "B 0 1 0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(375, 232);
            label4.Name = "label4";
            label4.Size = new Size(299, 67);
            label4.TabIndex = 3;
            label4.Text = "ATAS NAMA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.Location = new Point(454, 299);
            label5.Name = "label5";
            label5.Size = new Size(145, 67);
            label5.TabIndex = 4;
            label5.Text = "USER";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(340, 366);
            label6.Name = "label6";
            label6.Size = new Size(381, 35);
            label6.TabIndex = 5;
            label6.Text = "SILAHKAN MENUNGGU NOMOR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(360, 401);
            label7.Name = "label7";
            label7.Size = new Size(334, 35);
            label7.TabIndex = 6;
            label7.Text = "ANTRIAN DAN NAMA ANDA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(454, 436);
            label8.Name = "label8";
            label8.Size = new Size(140, 35);
            label8.TabIndex = 7;
            label8.Text = "DIPANGGIL";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(407, 474);
            button1.Name = "button1";
            button1.Size = new Size(256, 86);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // berhasilDibuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 587);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "berhasilDibuat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "berhasilDibuat";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}