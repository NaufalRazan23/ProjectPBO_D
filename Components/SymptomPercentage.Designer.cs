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
            lbPercentage = new Label();
            lbSymptom = new Label();
            SuspendLayout();
            // 
            // lbPercentage
            // 
            lbPercentage.Anchor = AnchorStyles.Right;
            lbPercentage.Font = new Font("Arial", 16F);
            lbPercentage.ForeColor = SystemColors.ControlLightLight;
            lbPercentage.Location = new Point(625, 0);
            lbPercentage.Margin = new Padding(0);
            lbPercentage.Name = "lbPercentage";
            lbPercentage.Padding = new Padding(0, 0, 6, 0);
            lbPercentage.Size = new Size(125, 125);
            lbPercentage.TabIndex = 2;
            lbPercentage.Text = "100%";
            lbPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSymptom
            // 
            lbSymptom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSymptom.Font = new Font("Arial", 14F);
            lbSymptom.ForeColor = SystemColors.ControlLightLight;
            lbSymptom.Location = new Point(4, 0);
            lbSymptom.Margin = new Padding(4, 0, 4, 0);
            lbSymptom.Name = "lbSymptom";
            lbSymptom.Padding = new Padding(12, 0, 12, 0);
            lbSymptom.Size = new Size(617, 125);
            lbSymptom.TabIndex = 3;
            lbSymptom.Text = "Lorem Ipsum Dorem Idenopo ";
            lbSymptom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SymptomPercentage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(lbSymptom);
            Controls.Add(lbPercentage);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(0, 125);
            Name = "SymptomPercentage";
            Size = new Size(750, 125);
            ResumeLayout(false);
        }

        #endregion
        private Label lbPercentage;
        private Label lbSymptom;
    }
}
