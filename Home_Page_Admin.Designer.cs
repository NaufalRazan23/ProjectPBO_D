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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(220, 59);
            label1.Name = "label1";
            label1.Size = new Size(640, 89);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE ADMIN";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 40F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(59, 205);
            button1.Name = "button1";
            button1.Size = new Size(414, 330);
            button1.TabIndex = 3;
            button1.Text = "ATUR ANTRIAN";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 40F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(598, 205);
            button2.Name = "button2";
            button2.Size = new Size(414, 330);
            button2.TabIndex = 4;
            button2.Text = "EDIT JADWAL";
            button2.UseVisualStyleBackColor = false;
            // 
            // Home_Page_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 607);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Home_Page_Admin";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}