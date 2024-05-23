namespace ProjectPBO.Components
{
    partial class SymptomPercentage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbSymptom = new PictureBox();
            lbPercentage = new Label();
            lbSymptom = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSymptom).BeginInit();
            SuspendLayout();
            // 
            // pbSymptom
            // 
            pbSymptom.Anchor = AnchorStyles.Left;
            pbSymptom.BackColor = SystemColors.ActiveCaptionText;
            pbSymptom.BackgroundImageLayout = ImageLayout.Stretch;
            pbSymptom.InitialImage = Properties.Resources.disease_health_internal_body_human_medical_organ_icon_133513;
            pbSymptom.Location = new Point(7, 6);
            pbSymptom.Margin = new Padding(6);
            pbSymptom.MaximumSize = new Size(100, 100);
            pbSymptom.Name = "pbSymptom";
            pbSymptom.Size = new Size(90, 90);
            pbSymptom.TabIndex = 0;
            pbSymptom.TabStop = false;
            // 
            // lbPercentage
            // 
            lbPercentage.Anchor = AnchorStyles.Right;
            lbPercentage.Font = new Font("Arial", 16F);
            lbPercentage.ForeColor = SystemColors.ControlLightLight;
            lbPercentage.Location = new Point(500, 0);
            lbPercentage.Margin = new Padding(0);
            lbPercentage.Name = "lbPercentage";
            lbPercentage.Padding = new Padding(0, 0, 5, 0);
            lbPercentage.Size = new Size(100, 100);
            lbPercentage.TabIndex = 2;
            lbPercentage.Text = "100%";
            lbPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSymptom
            // 
            lbSymptom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSymptom.Font = new Font("Arial", 14F);
            lbSymptom.ForeColor = SystemColors.ControlLightLight;
            lbSymptom.Location = new Point(106, 0);
            lbSymptom.Name = "lbSymptom";
            lbSymptom.Padding = new Padding(10, 0, 10, 0);
            lbSymptom.Size = new Size(391, 100);
            lbSymptom.TabIndex = 3;
            lbSymptom.Text = "Lorem Ipsum Dorem Idenopo ";
            lbSymptom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SymptomPercentage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(lbSymptom);
            Controls.Add(lbPercentage);
            Controls.Add(pbSymptom);
            MinimumSize = new Size(0, 100);
            Name = "SymptomPercentage";
            Size = new Size(600, 100);
            ((System.ComponentModel.ISupportInitialize)pbSymptom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSymptom;
        private Label lbPercentage;
        private Label lbSymptom;
    }
}
