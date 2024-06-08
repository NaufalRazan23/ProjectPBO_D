namespace ProjectPBO
{
    partial class Jadwal_dokter_spesialis
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            CHari = new DataGridViewTextBoxColumn();
            CMulai = new DataGridViewTextBoxColumn();
            CSelesai = new DataGridViewTextBoxColumn();
            CDokter = new DataGridViewTextBoxColumn();
            CJenis = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(676, 106);
            label1.TabIndex = 8;
            label1.Text = "JADWAL DOKTER";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "IniDataKanan";
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CHari, CMulai, CSelesai, CDokter, CJenis });
            dataGridView1.Location = new Point(286, 227);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1014, 655);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Empty;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.backbutton;
            btnBack.Location = new Point(17, 47);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(69, 52);
            btnBack.TabIndex = 11;
            btnBack.Click += btnBack_Click;
            // 
            // CHari
            // 
            CHari.HeaderText = "Hari";
            CHari.MinimumWidth = 8;
            CHari.Name = "CHari";
            CHari.Width = 150;
            // 
            // CMulai
            // 
            CMulai.HeaderText = "Mulai";
            CMulai.MinimumWidth = 8;
            CMulai.Name = "CMulai";
            CMulai.Width = 150;
            // 
            // CSelesai
            // 
            CSelesai.HeaderText = "Selesai";
            CSelesai.MinimumWidth = 8;
            CSelesai.Name = "CSelesai";
            CSelesai.Width = 150;
            // 
            // CDokter
            // 
            CDokter.HeaderText = "Dokter";
            CDokter.MinimumWidth = 8;
            CDokter.Name = "CDokter";
            CDokter.Width = 200;
            // 
            // CJenis
            // 
            CJenis.HeaderText = "Jenis";
            CJenis.MinimumWidth = 8;
            CJenis.Name = "CJenis";
            CJenis.Width = 300;
            // 
            // Jadwal_dokter_spesialis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 927);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Jadwal_dokter_spesialis";
            Text = "Jadwal_dokter_spesialis";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private DataGridViewTextBoxColumn CHari;
        private DataGridViewTextBoxColumn CMulai;
        private DataGridViewTextBoxColumn CSelesai;
        private DataGridViewTextBoxColumn CDokter;
        private DataGridViewTextBoxColumn CJenis;
    }
}