namespace ProjectPBO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 74);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(947, 34);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 1;
            label4.Text = "Publik";
            label4.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1018, 34);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Admin";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 1;
            label1.Text = "HospitalQ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 233);
            label3.Name = "label3";
            label3.Size = new Size(363, 45);
            label3.TabIndex = 1;
            label3.Text = "Selamat Datang User X";
            label3.Click += label1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 293);
            label5.Name = "label5";
            label5.Size = new Size(633, 191);
            label5.TabIndex = 1;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(31, 574);
            label6.Name = "label6";
            label6.Size = new Size(142, 26);
            label6.TabIndex = 1;
            label6.Text = "Alamat Jln Jawa4 Kab Jember";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(321, 574);
            label7.Name = "label7";
            label7.Size = new Size(82, 26);
            label7.TabIndex = 1;
            label7.Text = "Company Name";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(540, 574);
            label8.Name = "label8";
            label8.Size = new Size(70, 26);
            label8.TabIndex = 1;
            label8.Text = "085714495603";
            label8.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 595);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
