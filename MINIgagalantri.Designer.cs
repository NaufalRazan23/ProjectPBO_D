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
            label4.Location = new Point(173, 223);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(485, 96);
            label4.TabIndex = 51;
            label4.Text = "ANTRIAN ANDA GAGAL DI BUAT, TIDAK ADA\r\nDOKTER YANG SEDANG BEKERJA, MOHON\r\nPERIKSA BAGIAN JADWAL\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(351, 408);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 50;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MINIgagalantri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 623);
            Controls.Add(label4);
            Controls.Add(button2);
            Margin = new Padding(4, 5, 4, 5);
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