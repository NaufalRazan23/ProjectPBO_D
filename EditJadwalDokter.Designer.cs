namespace ProjectPBO
{
    partial class EditJadwalDokter
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnTambah = new Button();
            dataGridView1 = new DataGridView();
            CHari = new DataGridViewTextBoxColumn();
            CMulai = new DataGridViewTextBoxColumn();
            CSelesai = new DataGridViewTextBoxColumn();
            CDokter = new DataGridViewTextBoxColumn();
            CJenis = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 24F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(453, 12);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(545, 58);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "EDIT JADWAL DOKTER";
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
            btnBack.Location = new Point(14, 15);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(69, 52);
            btnBack.TabIndex = 7;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(1219, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(51, 53);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "🖉";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Segoe UI", 12F);
            btnHapus.Location = new Point(1162, 31);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(51, 53);
            btnHapus.TabIndex = 22;
            btnHapus.Text = "🗑";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTambah
            // 
            btnTambah.Font = new Font("Segoe UI", 12F);
            btnTambah.Location = new Point(1276, 31);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(51, 53);
            btnTambah.TabIndex = 23;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "IniDataKanan";
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CHari, CMulai, CSelesai, CDokter, CJenis });
            dataGridView1.Location = new Point(155, 107);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1014, 655);
            dataGridView1.TabIndex = 24;
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
            // EditJadwalDokter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 788);
            Controls.Add(dataGridView1);
            Controls.Add(btnTambah);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(guna2HtmlLabel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditJadwalDokter";
            Text = "EditJadwalDoktor";
            Load += EditJadwalDokter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnTambah;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CHari;
        private DataGridViewTextBoxColumn CMulai;
        private DataGridViewTextBoxColumn CSelesai;
        private DataGridViewTextBoxColumn CDokter;
        private DataGridViewTextBoxColumn CJenis;
    }
}