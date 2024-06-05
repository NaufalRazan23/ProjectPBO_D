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
            label1.Location = new Point(275, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(764, 106);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE ADMIN";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 40F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(74, 256);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(518, 412);
            button1.TabIndex = 3;
            button1.Text = "ATUR ANTRIAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 40F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(748, 256);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(518, 412);
            button2.TabIndex = 4;
            button2.Text = "EDIT JADWAL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Home_Page_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 759);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4);
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