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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 44);
            label1.Name = "label1";
            label1.Size = new Size(594, 40);
            label1.TabIndex = 2;
            label1.Text = "REKOMENDASI OBAT YANG DIPERLUKAN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 669);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 125);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 55);
            label2.Name = "label2";
            label2.Size = new Size(789, 21);
            label2.TabIndex = 0;
            label2.Text = "UNTUK KONSULTASI LEBIH LANJUT SILAHKAN MENGAMBIL ANTRIAN MENUJU DOKTER";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(379, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 217);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(199, 68);
            label8.Name = "label8";
            label8.Size = new Size(119, 27);
            label8.TabIndex = 4;
            label8.Text = "DEGIROL";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(165, 169);
            label5.Name = "label5";
            label5.Size = new Size(167, 27);
            label5.TabIndex = 2;
            label5.Text = "SP TORCHES";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(199, 123);
            label4.Name = "label4";
            label4.Size = new Size(101, 35);
            label4.TabIndex = 1;
            label4.Text = "ANAK";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(186, 21);
            label3.Name = "label3";
            label3.Size = new Size(146, 35);
            label3.TabIndex = 0;
            label3.Text = "DEWASA";
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges9;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Empty;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.backbutton;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBack.Size = new Size(54, 41);
            btnBack.TabIndex = 5;
            btnBack.Click += btnBack_Click;
            // 
            // lbSymptom
            // 
            lbSymptom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSymptom.BackColor = Color.Black;
            lbSymptom.Font = new Font("Arial", 14F);
            lbSymptom.ForeColor = SystemColors.ControlLightLight;
            lbSymptom.Location = new Point(169, 176);
            lbSymptom.Name = "lbSymptom";
            lbSymptom.Padding = new Padding(10, 0, 10, 0);
            lbSymptom.Size = new Size(325, 100);
            lbSymptom.TabIndex = 7;
            lbSymptom.Text = "Lorem Ipsum Dorem Idenopo ";
            lbSymptom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPercentage
            // 
            lbPercentage.Anchor = AnchorStyles.Right;
            lbPercentage.BackColor = Color.Black;
            lbPercentage.Font = new Font("Arial", 16F);
            lbPercentage.ForeColor = SystemColors.ControlLightLight;
            lbPercentage.Location = new Point(69, 176);
            lbPercentage.Margin = new Padding(0);
            lbPercentage.Name = "lbPercentage";
            lbPercentage.Padding = new Padding(0, 0, 5, 0);
            lbPercentage.Size = new Size(100, 100);
            lbPercentage.TabIndex = 6;
            lbPercentage.Text = "100%";
            lbPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Arial", 14F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(753, 174);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 10, 0);
            label6.Size = new Size(325, 100);
            label6.TabIndex = 9;
            label6.Text = "Lorem Ipsum Dorem Idenopo ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Arial", 16F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(1077, 174);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 5, 0);
            label7.Size = new Size(100, 100);
            label7.TabIndex = 8;
            label7.Text = "100%";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RekomendasiObatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 793);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lbSymptom);
            Controls.Add(lbPercentage);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "RekomendasiObatForm";
            Text = "RekomendasiObatForm";
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