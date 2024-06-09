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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(berhasilDibuat));
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
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 30.75F, FontStyle.Bold);
            label1.Location = new Point(329, 7);
            label1.Name = "label1";
            label1.Size = new Size(551, 55);
            label1.TabIndex = 0;
            label1.Text = "ANTRIAN BERHASIL DIBUAT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label2.Location = new Point(267, 201);
            label2.Name = "label2";
            label2.Size = new Size(656, 54);
            label2.TabIndex = 1;
            label2.Text = "NOMOR ANTRIAN ANDA ADALAH";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label3.Location = new Point(526, 255);
            label3.Name = "label3";
            label3.Size = new Size(140, 54);
            label3.TabIndex = 2;
            label3.Text = "B 0 1 0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label4.Location = new Point(478, 318);
            label4.Name = "label4";
            label4.Size = new Size(248, 54);
            label4.TabIndex = 3;
            label4.Text = "ATAS NAMA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label5.Location = new Point(547, 368);
            label5.Name = "label5";
            label5.Size = new Size(119, 54);
            label5.TabIndex = 4;
            label5.Text = "USER";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label6.Location = new Point(452, 417);
            label6.Name = "label6";
            label6.Size = new Size(309, 28);
            label6.TabIndex = 5;
            label6.Text = "SILAHKAN MENUNGGU NOMOR";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label7.Location = new Point(465, 445);
            label7.Name = "label7";
            label7.Size = new Size(271, 28);
            label7.TabIndex = 6;
            label7.Text = "ANTRIAN DAN NAMA ANDA";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label8.Location = new Point(547, 471);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 7;
            label8.Text = "DIPANGGIL";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            button1.Location = new Point(492, 646);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(224, 64);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // berhasilDibuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1254, 729);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "berhasilDibuat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "berhasilDibuat";
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