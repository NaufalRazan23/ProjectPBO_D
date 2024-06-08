namespace ProjectPBO
{
    partial class Home_Page_Admin
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
            button1 = new Button();
            button2 = new Button();
            label_back = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(295, 59);
            label1.Name = "label1";
            label1.Size = new Size(640, 89);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE ADMIN";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 40F);
            button1.ForeColor = Color.Ivory;
            button1.Location = new Point(135, 302);
            button1.Name = "button1";
            button1.Size = new Size(415, 329);
            button1.TabIndex = 3;
            button1.Text = "ATUR ANTRIAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 40F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(675, 302);
            button2.Name = "button2";
            button2.Size = new Size(415, 329);
            button2.TabIndex = 4;
            button2.Text = "EDIT JADWAL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label_back
            // 
            label_back.AutoSize = true;
            label_back.Font = new Font("Segoe UI", 40F);
            label_back.Location = new Point(14, 12);
            label_back.Name = "label_back";
            label_back.Size = new Size(84, 89);
            label_back.TabIndex = 5;
            label_back.Text = "<";
            label_back.Click += label2_Click;
            // 
            // Home_Page_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 793);
            Controls.Add(label_back);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Home_Page_Admin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label_back;
    }
}