namespace ProjectPBO
{
    partial class RekomendasiObatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekomendasiObatForm));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lbSymptom = new Label();
            lbPercentage = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 33);
            label1.Name = "label1";
            label1.Size = new Size(471, 31);
            label1.TabIndex = 2;
            label1.Text = "REKOMENDASI OBAT YANG DIPERLUKAN";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 535);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 61);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 20);
            label2.Name = "label2";
            label2.Size = new Size(651, 18);
            label2.TabIndex = 0;
            label2.Text = "UNTUK KONSULTASI LEBIH LANJUT SILAHKAN MENGAMBIL ANTRIAN MENUJU DOKTER";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(304, 281);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 163);
            panel2.TabIndex = 4;
            panel2.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(174, 51);
            label8.Name = "label8";
            label8.Size = new Size(98, 22);
            label8.TabIndex = 4;
            label8.Text = "DEGIROL";
            label8.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(144, 127);
            label5.Name = "label5";
            label5.Size = new Size(135, 22);
            label5.TabIndex = 2;
            label5.Text = "SP TORCHES";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(174, 92);
            label4.Name = "label4";
            label4.Size = new Size(81, 29);
            label4.TabIndex = 1;
            label4.Text = "ANAK";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(163, 16);
            label3.Name = "label3";
            label3.Size = new Size(118, 29);
            label3.TabIndex = 0;
            label3.Text = "DEWASA";
            label3.UseWaitCursor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Empty;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.backbutton;
            btnBack.Location = new Point(10, 9);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(47, 31);
            btnBack.TabIndex = 5;
            btnBack.UseWaitCursor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbSymptom
            // 
            lbSymptom.Anchor = AnchorStyles.None;
            lbSymptom.BackColor = Color.Black;
            lbSymptom.Font = new Font("Arial", 14F);
            lbSymptom.ForeColor = SystemColors.ControlLightLight;
            lbSymptom.Location = new Point(148, 132);
            lbSymptom.Name = "lbSymptom";
            lbSymptom.Padding = new Padding(9, 0, 9, 0);
            lbSymptom.Size = new Size(284, 75);
            lbSymptom.TabIndex = 7;
            lbSymptom.Text = "Lorem Ipsum Dorem Idenopo ";
            lbSymptom.TextAlign = ContentAlignment.MiddleCenter;
            lbSymptom.UseWaitCursor = true;
            // 
            // lbPercentage
            // 
            lbPercentage.Anchor = AnchorStyles.None;
            lbPercentage.BackColor = Color.Black;
            lbPercentage.Font = new Font("Arial", 16F);
            lbPercentage.ForeColor = SystemColors.ControlLightLight;
            lbPercentage.Location = new Point(58, 132);
            lbPercentage.Margin = new Padding(0);
            lbPercentage.Name = "lbPercentage";
            lbPercentage.Padding = new Padding(0, 0, 4, 0);
            lbPercentage.Size = new Size(88, 75);
            lbPercentage.TabIndex = 6;
            lbPercentage.Text = "100%";
            lbPercentage.TextAlign = ContentAlignment.MiddleCenter;
            lbPercentage.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Arial", 14F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(655, 132);
            label6.Name = "label6";
            label6.Padding = new Padding(9, 0, 9, 0);
            label6.Size = new Size(284, 75);
            label6.TabIndex = 9;
            label6.Text = "Lorem Ipsum Dorem Idenopo ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Arial", 16F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(942, 132);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 4, 0);
            label7.Size = new Size(88, 75);
            label7.TabIndex = 8;
            label7.Text = "100%";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.UseWaitCursor = true;
            // 
            // RekomendasiObatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1093, 595);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lbSymptom);
            Controls.Add(lbPercentage);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RekomendasiObatForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RekomendasiObatForm";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lbSymptom;
        private Label lbPercentage;
        private Label label6;
        private Label label7;
    }
}