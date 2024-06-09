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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page_Admin));
            label1 = new Label();
            label_back = new Label();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(637, 44);
            label1.Name = "label1";
            label1.Size = new Size(538, 71);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE ADMIN";
            // 
            // label_back
            // 
            label_back.AutoSize = true;
            label_back.BackColor = Color.Transparent;
            label_back.Font = new Font("Segoe UI", 40F);
            label_back.Location = new Point(12, 9);
            label_back.Name = "label_back";
            label_back.Size = new Size(67, 72);
            label_back.TabIndex = 5;
            label_back.Text = "<";
            label_back.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.CustomizableEdges = customizableEdges1;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.Black;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(450, 375);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button1.Size = new Size(330, 181);
            button1.TabIndex = 6;
            button1.Text = "LIHAT ANTRIAN";
            button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.CustomizableEdges = customizableEdges3;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.FillColor = Color.Black;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1003, 375);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button2.Size = new Size(332, 181);
            button2.TabIndex = 7;
            button2.Text = "EDIT JADWAL DOKTER";
            button2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            button2.Click += button2_Click;
            // 
            // Home_Page_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1850, 935);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_back);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label_back;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
    }
}