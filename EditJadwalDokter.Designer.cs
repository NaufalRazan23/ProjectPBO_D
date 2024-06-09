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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJadwalDokter));
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
            guna2HtmlLabel1.Anchor = AnchorStyles.Top;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 24F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(317, 7);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(363, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "EDIT JADWAL DOKTER";
            guna2HtmlLabel1.UseWaitCursor = true;
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
            btnBack.Location = new Point(10, 9);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(48, 31);
            btnBack.TabIndex = 7;
            btnBack.UseWaitCursor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(853, 19);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 32);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "🖉";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHapus.Font = new Font("Segoe UI", 12F);
            btnHapus.Location = new Point(813, 19);
            btnHapus.Margin = new Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(36, 32);
            btnHapus.TabIndex = 22;
            btnHapus.Text = "🗑";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambah.Font = new Font("Segoe UI", 12F);
            btnTambah.Location = new Point(893, 19);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(36, 32);
            btnTambah.TabIndex = 23;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "IniDataKanan";
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CHari, CMulai, CSelesai, CDokter, CJenis });
            dataGridView1.Location = new Point(108, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(710, 393);
            dataGridView1.TabIndex = 24;
            dataGridView1.UseWaitCursor = true;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(937, 473);
            Controls.Add(dataGridView1);
            Controls.Add(btnTambah);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(guna2HtmlLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditJadwalDokter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "`";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
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