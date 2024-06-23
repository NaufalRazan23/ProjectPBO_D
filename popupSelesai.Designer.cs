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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popupSelesai));
            label1 = new Label();
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(255, 20);
            label1.Name = "label1";
            label1.Size = new Size(569, 54);
            label1.TabIndex = 0;
            label1.Text = "PASIEN A0000 TELAH SELESAI";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label4.Location = new Point(368, 96);
            label4.Name = "label4";
            label4.Size = new Size(362, 54);
            label4.TabIndex = 3;
            label4.Text = "NOMOR ANTRIAN";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label5.Location = new Point(309, 162);
            label5.Name = "label5";
            label5.Size = new Size(459, 54);
            label5.TabIndex = 4;
            label5.Text = "SELANJUTNYA ADALAH";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label6.Location = new Point(492, 237);
            label6.Name = "label6";
            label6.Size = new Size(110, 54);
            label6.TabIndex = 5;
            label6.Text = "A010";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label7.Location = new Point(430, 303);
            label7.Name = "label7";
            label7.Size = new Size(248, 54);
            label7.TabIndex = 6;
            label7.Text = "ATAS NAMA";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label8.Location = new Point(161, 357);
            label8.Name = "label8";
            label8.Size = new Size(777, 106);
            label8.TabIndex = 7;
            label8.Text = "nama";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.Location = new Point(372, 480);
            button1.Name = "button1";
            button1.Size = new Size(358, 95);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // popupSelesai
            // 
            AutoScaleDimensions = new SizeF(44F, 106F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1091, 587);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 40F);
            Margin = new Padding(14);
            Name = "popupSelesai";
            Text = "popupSelesai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}