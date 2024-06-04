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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            labelHomePage = new Label();
            btnBuatAntrian = new Guna.UI2.WinForms.Guna2Button();
            Btn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // labelHomePage
            // 
            labelHomePage.AutoSize = true;
            labelHomePage.Font = new Font("Microsoft YaHei", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomePage.Location = new Point(421, 41);
            labelHomePage.Margin = new Padding(4, 0, 4, 0);
            labelHomePage.Name = "labelHomePage";
            labelHomePage.Size = new Size(548, 106);
            labelHomePage.TabIndex = 0;
            labelHomePage.Text = "HOME PAGE";
            labelHomePage.Click += label1_Click;
            // 
            // btnBuatAntrian
            // 
            btnBuatAntrian.CustomizableEdges = customizableEdges5;
            btnBuatAntrian.DisabledState.BorderColor = Color.DarkGray;
            btnBuatAntrian.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuatAntrian.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuatAntrian.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuatAntrian.FillColor = Color.Black;
            btnBuatAntrian.Font = new Font("Segoe UI", 45F);
            btnBuatAntrian.ForeColor = Color.White;
            btnBuatAntrian.Location = new Point(92, 239);
            btnBuatAntrian.Name = "btnBuatAntrian";
            btnBuatAntrian.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBuatAntrian.Size = new Size(474, 302);
            btnBuatAntrian.TabIndex = 3;
            btnBuatAntrian.Text = "BUAT ANTRIAN";
            btnBuatAntrian.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            btnBuatAntrian.Click += guna2Button1_Click;
            // 
            // Btn
            // 
            Btn.CustomizableEdges = customizableEdges7;
            Btn.DisabledState.BorderColor = Color.DarkGray;
            Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn.FillColor = Color.Black;
            Btn.Font = new Font("Segoe UI", 35F);
            Btn.ForeColor = Color.White;
            Btn.Location = new Point(787, 239);
            Btn.Name = "Btn";
            Btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Btn.Size = new Size(474, 302);
            Btn.TabIndex = 4;
            Btn.Text = "KONSULTASI KESEHATAN";
            Btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            Btn.Click += guna2Button1_Click_1;
            // 
            // Home_Page_User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 759);
            Controls.Add(Btn);
            Controls.Add(btnBuatAntrian);
            Controls.Add(labelHomePage);
            Margin = new Padding(4);
            Name = "Home_Page_User";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomePage;
        private Guna.UI2.WinForms.Guna2Button btnBuatAntrian;
        private Guna.UI2.WinForms.Guna2Button Btn;
    }
}