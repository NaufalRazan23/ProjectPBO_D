namespace ProjectPBO
{
    partial class Home_Page_User
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
            btnBuatAntrian = new Guna.UI2.WinForms.Guna2Button();
            labelHomePage = new Label();
            Btn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnBuatAntrian
            // 
            btnBuatAntrian.BackColor = SystemColors.Control;
            btnBuatAntrian.CustomizableEdges = customizableEdges1;
            btnBuatAntrian.DisabledState.BorderColor = Color.DarkGray;
            btnBuatAntrian.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuatAntrian.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuatAntrian.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuatAntrian.FillColor = Color.Black;
            btnBuatAntrian.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnBuatAntrian.ForeColor = Color.White;
            btnBuatAntrian.Location = new Point(111, 337);
            btnBuatAntrian.Margin = new Padding(2, 3, 2, 3);
            btnBuatAntrian.Name = "btnBuatAntrian";
            btnBuatAntrian.RightToLeft = RightToLeft.Yes;
            btnBuatAntrian.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBuatAntrian.Size = new Size(377, 241);
            btnBuatAntrian.TabIndex = 3;
            btnBuatAntrian.Text = "BUAT ANTRIAN";
            btnBuatAntrian.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            btnBuatAntrian.UseWaitCursor = true;
            btnBuatAntrian.Click += guna2Button1_Click;
            // 
            // labelHomePage
            // 
            labelHomePage.AllowDrop = true;
            labelHomePage.Anchor = AnchorStyles.Top;
            labelHomePage.AutoSize = true;
            labelHomePage.Font = new Font("Microsoft YaHei", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomePage.Location = new Point(411, 47);
            labelHomePage.Name = "labelHomePage";
            labelHomePage.Size = new Size(454, 100);
            labelHomePage.TabIndex = 0;
            labelHomePage.Text = "HOME PAGE";
            labelHomePage.TextAlign = ContentAlignment.TopCenter;
            labelHomePage.UseCompatibleTextRendering = true;
            labelHomePage.UseWaitCursor = true;
            labelHomePage.Click += label1_Click;
            // 
            // Btn
            // 
            Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn.CustomizableEdges = customizableEdges3;
            Btn.DisabledState.BorderColor = Color.DarkGray;
            Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn.FillColor = Color.Black;
            Btn.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn.ForeColor = Color.White;
            Btn.Location = new Point(735, 337);
            Btn.Margin = new Padding(2, 3, 2, 3);
            Btn.Name = "Btn";
            Btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Btn.Size = new Size(379, 241);
            Btn.TabIndex = 4;
            Btn.Text = "KONSULTASI KESEHATAN";
            Btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            Btn.UseWaitCursor = true;
            Btn.Click += guna2Button1_Click_1;
            // 
            // Home_Page_User
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1249, 793);
            Controls.Add(Btn);
            Controls.Add(btnBuatAntrian);
            Controls.Add(labelHomePage);
            Name = "Home_Page_User";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HomepageAntrianUser'";
            TopMost = true;
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            Load += Home_Page_User_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomePage;
        private Guna.UI2.WinForms.Guna2Button Btn;
        private Guna.UI2.WinForms.Guna2Button btnBuatAntrian;
    }
}