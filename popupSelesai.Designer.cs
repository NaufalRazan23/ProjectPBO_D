namespace ProjectPBO
{
    partial class popupSelesai
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
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 89);
            label1.TabIndex = 0;
            label1.Text = "PASIEN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 9);
            label2.Name = "label2";
            label2.Size = new Size(243, 89);
            label2.TabIndex = 1;
            label2.Text = "A 0 0 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 9);
            label3.Name = "label3";
            label3.Size = new Size(483, 89);
            label3.TabIndex = 2;
            label3.Text = "TELAH SELESAI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(329, 98);
            label4.Name = "label4";
            label4.Size = new Size(438, 67);
            label4.TabIndex = 3;
            label4.Text = "NOMOR ANTRIAN";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.Location = new Point(266, 165);
            label5.Name = "label5";
            label5.Size = new Size(551, 67);
            label5.TabIndex = 4;
            label5.Text = "SELANJUTNYA ADALAH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 232);
            label6.Name = "label6";
            label6.Size = new Size(243, 89);
            label6.TabIndex = 5;
            label6.Text = "A 0 1 0";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 30F);
            label7.Location = new Point(395, 321);
            label7.Name = "label7";
            label7.Size = new Size(299, 67);
            label7.TabIndex = 6;
            label7.Text = "ATAS NAMA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 388);
            label8.Name = "label8";
            label8.Size = new Size(194, 89);
            label8.TabIndex = 7;
            label8.Text = "USER";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(373, 480);
            button1.Name = "button1";
            button1.Size = new Size(358, 95);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // popupSelesai
            // 
            AutoScaleDimensions = new SizeF(37F, 89F);
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
            Font = new Font("Segoe UI", 40F);
            Margin = new Padding(14, 14, 14, 14);
            Name = "popupSelesai";
            Text = "popupSelesai";
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