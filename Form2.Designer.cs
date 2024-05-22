namespace ProjectPBO
{
    partial class Form2
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
            panel1 = new Panel();
            KELUHAN_3 = new ListBox();
            KELUHAN_2 = new ListBox();
            KELUHAN_1 = new ListBox();
            button1 = new Button();
            KONSULTASI = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 74);
            panel1.TabIndex = 1;
            // 
            // KELUHAN_3
            // 
            KELUHAN_3.FormattingEnabled = true;
            KELUHAN_3.ItemHeight = 15;
            KELUHAN_3.Location = new Point(313, 360);
            KELUHAN_3.Name = "KELUHAN_3";
            KELUHAN_3.Size = new Size(457, 49);
            KELUHAN_3.TabIndex = 2;
            // 
            // KELUHAN_2
            // 
            KELUHAN_2.FormattingEnabled = true;
            KELUHAN_2.ItemHeight = 15;
            KELUHAN_2.Location = new Point(313, 305);
            KELUHAN_2.Name = "KELUHAN_2";
            KELUHAN_2.Size = new Size(457, 49);
            KELUHAN_2.TabIndex = 2;
            // 
            // KELUHAN_1
            // 
            KELUHAN_1.Anchor = AnchorStyles.Right;
            KELUHAN_1.FormattingEnabled = true;
            KELUHAN_1.ItemHeight = 15;
            KELUHAN_1.Location = new Point(313, 250);
            KELUHAN_1.Name = "KELUHAN_1";
            KELUHAN_1.Size = new Size(457, 49);
            KELUHAN_1.TabIndex = 2;
            KELUHAN_1.SelectedIndexChanged += KELUHAN_1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(468, 427);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 3;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // KONSULTASI
            // 
            KONSULTASI.AutoSize = true;
            KONSULTASI.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            KONSULTASI.Location = new Point(468, 103);
            KONSULTASI.Name = "KONSULTASI";
            KONSULTASI.Size = new Size(110, 23);
            KONSULTASI.TabIndex = 4;
            KONSULTASI.Text = "KONSULTASI";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 157);
            label1.Name = "label1";
            label1.Size = new Size(505, 76);
            label1.TabIndex = 4;
            label1.Text = "silahkan masukkan keluhan yang anda alami, kami akan mendiagnosa penyakit dan obat yang bisa membantu mengurangi gejala tersebut";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 595);
            Controls.Add(label1);
            Controls.Add(KONSULTASI);
            Controls.Add(button1);
            Controls.Add(KELUHAN_1);
            Controls.Add(KELUHAN_2);
            Controls.Add(KELUHAN_3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox KELUHAN_3;
        private ListBox KELUHAN_2;
        private ListBox KELUHAN_1;
        private Button button1;
        private Label KONSULTASI;
        private Label label1;
    }
}