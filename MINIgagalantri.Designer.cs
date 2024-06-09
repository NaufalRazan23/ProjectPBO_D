namespace ProjectPBO
{
    partial class MINIgagalantri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MINIgagalantri));
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 134);
            label4.Name = "label4";
            label4.Size = new Size(321, 63);
            label4.TabIndex = 51;
            label4.Text = "ANTRIAN ANDA GAGAL DI BUAT, TIDAK ADA\r\nDOKTER YANG SEDANG BEKERJA, MOHON\r\nPERIKSA BAGIAN JADWAL\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(246, 245);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 50;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // MINIgagalantri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(558, 374);
            Controls.Add(label4);
            Controls.Add(button2);
            Name = "MINIgagalantri";
            Text = "gagalantri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button2;
    }
}