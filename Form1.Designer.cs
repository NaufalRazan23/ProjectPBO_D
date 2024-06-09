namespace ojectPBO
{
    public class Home_Page_User
    {
        public void SomeMethod()
        {
            // Implementasi metode
        }
    }

    public class Home_Page_Admin
    {
        public void SomeMethod()
        {
            // Implementasi metode
        }
    }
}

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
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1824, 75);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(1567, 24);
            label4.Name = "label4";
            label4.Size = new Size(98, 37);
            label4.TabIndex = 1;
            label4.Text = "Publik";
            label4.TextAlign = ContentAlignment.TopRight;
            label4.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(1708, 24);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 1;
            label2.Text = "Admin";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 1;
            label1.Text = "HospitalQ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 233);
            label3.Name = "label3";
            label3.Size = new Size(458, 45);
            label3.TabIndex = 1;
            label3.Text = "Selamat Datang Di HospitalQ";
            label3.Click += label1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
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
            label6.BackColor = SystemColors.Control;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(0, 870);
            label6.Name = "label6";
            label6.Size = new Size(1824, 26);
            label6.TabIndex = 1;
            label6.Text = "Alamat Jln Jawa4 Kab Jember";
            label6.TextAlign = ContentAlignment.BottomLeft;
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(873, 880);
            label7.Name = "label7";
            label7.Size = new Size(85, 16);
            label7.TabIndex = 1;
            label7.Text = "Company Name";
            label7.TextAlign = ContentAlignment.BottomCenter;
            label7.UseWaitCursor = true;
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(1659, 869);
            label8.Name = "label8";
            label8.Size = new Size(164, 26);
            label8.TabIndex = 1;
            label8.Text = "085714495603";
            label8.TextAlign = ContentAlignment.BottomRight;
            label8.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1824, 896);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        protected internal Label label4;
    }
}