namespace ProjectPBO
{
    partial class KonsultasiForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonsultasiForm));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbKeluhan1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            cbKeluhan2 = new Guna.UI2.WinForms.Guna2ComboBox();
            cbKeluhan3 = new Guna.UI2.WinForms.Guna2ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.Top;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(424, 74);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(200, 47);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "KONSULTASI";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(344, 125);
            guna2HtmlLabel2.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(382, 138);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "SILAHKAN MASUKKAN KELUHAN YANG ANDA ALAMI, \r\nKAMI AKAN MENDIAGNOSA PENYAKIT DAN OBAT YANG BISA MEMBANTU MENGURANGI GEJALA TERSEBUT";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // cbKeluhan1
            // 
            cbKeluhan1.AllowDrop = true;
            cbKeluhan1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbKeluhan1.BackColor = Color.Transparent;
            cbKeluhan1.CustomizableEdges = customizableEdges1;
            cbKeluhan1.DisplayMember = "KELUHAN 1";
            cbKeluhan1.DrawMode = DrawMode.OwnerDrawFixed;
            cbKeluhan1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKeluhan1.FocusedColor = Color.FromArgb(94, 148, 255);
            cbKeluhan1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbKeluhan1.Font = new Font("Segoe UI", 10F);
            cbKeluhan1.ForeColor = Color.FromArgb(68, 88, 112);
            cbKeluhan1.ItemHeight = 30;
            cbKeluhan1.Items.AddRange(new object[] { "KELUHAN 1", "PUSING", "MERIANG", "PANAS", "BIBIR PECAH PECAH", "TENGOROKAN SAKIT" });
            cbKeluhan1.Location = new Point(332, 267);
            cbKeluhan1.Margin = new Padding(3, 2, 3, 2);
            cbKeluhan1.Name = "cbKeluhan1";
            cbKeluhan1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbKeluhan1.Size = new Size(383, 36);
            cbKeluhan1.StartIndex = 0;
            cbKeluhan1.TabIndex = 2;
            cbKeluhan1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Bottom;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(455, 418);
            guna2Button1.Margin = new Padding(3, 2, 3, 2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(141, 42);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "SUBMIT";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges5;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Empty;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.backbutton;
            btnBack.Location = new Point(8, 7);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBack.Size = new Size(47, 31);
            btnBack.TabIndex = 6;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 41);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // cbKeluhan2
            // 
            cbKeluhan2.AllowDrop = true;
            cbKeluhan2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbKeluhan2.BackColor = Color.Transparent;
            cbKeluhan2.CustomizableEdges = customizableEdges7;
            cbKeluhan2.DisplayMember = "KELUHAN 2";
            cbKeluhan2.DrawMode = DrawMode.OwnerDrawFixed;
            cbKeluhan2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKeluhan2.FocusedColor = Color.FromArgb(94, 148, 255);
            cbKeluhan2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbKeluhan2.Font = new Font("Segoe UI", 10F);
            cbKeluhan2.ForeColor = Color.FromArgb(68, 88, 112);
            cbKeluhan2.ItemHeight = 30;
            cbKeluhan2.Items.AddRange(new object[] { "KELUHAN 2", "PUSING", "MERIANG", "PANAS", "BIBIR PECAH PECAH", "TENGOROKAN SAKIT" });
            cbKeluhan2.Location = new Point(332, 308);
            cbKeluhan2.Margin = new Padding(3, 2, 3, 2);
            cbKeluhan2.Name = "cbKeluhan2";
            cbKeluhan2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbKeluhan2.Size = new Size(383, 36);
            cbKeluhan2.StartIndex = 0;
            cbKeluhan2.TabIndex = 8;
            cbKeluhan2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // cbKeluhan3
            // 
            cbKeluhan3.AllowDrop = true;
            cbKeluhan3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbKeluhan3.BackColor = Color.Transparent;
            cbKeluhan3.CustomizableEdges = customizableEdges9;
            cbKeluhan3.DisplayMember = "KELUHAN 1";
            cbKeluhan3.DrawMode = DrawMode.OwnerDrawFixed;
            cbKeluhan3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKeluhan3.FocusedColor = Color.FromArgb(94, 148, 255);
            cbKeluhan3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbKeluhan3.Font = new Font("Segoe UI", 10F);
            cbKeluhan3.ForeColor = Color.FromArgb(68, 88, 112);
            cbKeluhan3.ItemHeight = 30;
            cbKeluhan3.Items.AddRange(new object[] { "KELUHAN 3", "PUSING", "MERIANG", "PANAS", "BIBIR PECAH PECAH", "TENGOROKAN SAKIT" });
            cbKeluhan3.Location = new Point(332, 348);
            cbKeluhan3.Margin = new Padding(3, 2, 3, 2);
            cbKeluhan3.Name = "cbKeluhan3";
            cbKeluhan3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbKeluhan3.Size = new Size(383, 36);
            cbKeluhan3.StartIndex = 0;
            cbKeluhan3.TabIndex = 9;
            cbKeluhan3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // KonsultasiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1093, 595);
            Controls.Add(cbKeluhan3);
            Controls.Add(cbKeluhan2);
            Controls.Add(guna2Button1);
            Controls.Add(cbKeluhan1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KonsultasiForm";
            Text = "KonsultasiForm";
            WindowState = FormWindowState.Maximized;
            Load += KonsultasiForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbKeluhan1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbKeluhan2;
        private Guna.UI2.WinForms.Guna2ComboBox cbKeluhan3;
    }
}