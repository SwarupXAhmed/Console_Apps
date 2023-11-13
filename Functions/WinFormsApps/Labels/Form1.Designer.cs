namespace Labels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topLeftLabel = new Label();
            TopCemterLabel = new Label();
            topRightLabel = new Label();
            middleLeftLabel = new Label();
            middleCenterlabel = new Label();
            rightMiddleLabel = new Label();
            bottomLeftLabel = new Label();
            bottomCenterLabel = new Label();
            bottomRightLAbel = new Label();
            button1 = new Button();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // topLeftLabel
            // 
            topLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            topLeftLabel.Location = new Point(41, 51);
            topLeftLabel.Name = "topLeftLabel";
            topLeftLabel.Size = new Size(139, 45);
            topLeftLabel.TabIndex = 0;
            topLeftLabel.Click += topLeftLabel_Click;
            // 
            // TopCemterLabel
            // 
            TopCemterLabel.BorderStyle = BorderStyle.FixedSingle;
            TopCemterLabel.Location = new Point(203, 51);
            TopCemterLabel.Name = "TopCemterLabel";
            TopCemterLabel.Size = new Size(132, 45);
            TopCemterLabel.TabIndex = 1;
            TopCemterLabel.TextAlign = ContentAlignment.TopCenter;
            TopCemterLabel.Click += TopCemterLabel_Click;
            // 
            // topRightLabel
            // 
            topRightLabel.BorderStyle = BorderStyle.FixedSingle;
            topRightLabel.Location = new Point(364, 51);
            topRightLabel.Name = "topRightLabel";
            topRightLabel.Size = new Size(129, 45);
            topRightLabel.TabIndex = 2;
            topRightLabel.TextAlign = ContentAlignment.TopRight;
            topRightLabel.Click += topRightLabel_Click;
            // 
            // middleLeftLabel
            // 
            middleLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            middleLeftLabel.Location = new Point(41, 100);
            middleLeftLabel.Name = "middleLeftLabel";
            middleLeftLabel.Size = new Size(139, 45);
            middleLeftLabel.TabIndex = 3;
            middleLeftLabel.TextAlign = ContentAlignment.MiddleLeft;
            middleLeftLabel.Click += middleLeftLabel_Click;
            // 
            // middleCenterlabel
            // 
            middleCenterlabel.BorderStyle = BorderStyle.FixedSingle;
            middleCenterlabel.Location = new Point(203, 100);
            middleCenterlabel.Name = "middleCenterlabel";
            middleCenterlabel.Size = new Size(132, 45);
            middleCenterlabel.TabIndex = 4;
            middleCenterlabel.TextAlign = ContentAlignment.MiddleCenter;
            middleCenterlabel.Click += middleCenterlabel_Click;
            // 
            // rightMiddleLabel
            // 
            rightMiddleLabel.BorderStyle = BorderStyle.FixedSingle;
            rightMiddleLabel.Location = new Point(364, 100);
            rightMiddleLabel.Name = "rightMiddleLabel";
            rightMiddleLabel.Size = new Size(129, 45);
            rightMiddleLabel.TabIndex = 5;
            rightMiddleLabel.TextAlign = ContentAlignment.MiddleRight;
            rightMiddleLabel.Click += rightMiddleLabel_Click;
            // 
            // bottomLeftLabel
            // 
            bottomLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomLeftLabel.Location = new Point(41, 157);
            bottomLeftLabel.Name = "bottomLeftLabel";
            bottomLeftLabel.Size = new Size(139, 45);
            bottomLeftLabel.TabIndex = 6;
            bottomLeftLabel.TextAlign = ContentAlignment.BottomLeft;
            bottomLeftLabel.Click += bottomLeftLabel_Click;
            // 
            // bottomCenterLabel
            // 
            bottomCenterLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomCenterLabel.Location = new Point(203, 157);
            bottomCenterLabel.Name = "bottomCenterLabel";
            bottomCenterLabel.Size = new Size(132, 45);
            bottomCenterLabel.TabIndex = 7;
            bottomCenterLabel.TextAlign = ContentAlignment.BottomCenter;
            bottomCenterLabel.Click += bottomCenterLabel_Click;
            // 
            // bottomRightLAbel
            // 
            bottomRightLAbel.BorderStyle = BorderStyle.FixedSingle;
            bottomRightLAbel.Location = new Point(364, 157);
            bottomRightLAbel.Name = "bottomRightLAbel";
            bottomRightLAbel.Size = new Size(129, 45);
            bottomRightLAbel.TabIndex = 8;
            bottomRightLAbel.TextAlign = ContentAlignment.BottomRight;
            bottomRightLAbel.Click += bottomRightLAbel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(407, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(218, 298);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 476);
            Controls.Add(materialButton1);
            Controls.Add(button1);
            Controls.Add(bottomRightLAbel);
            Controls.Add(bottomCenterLabel);
            Controls.Add(bottomLeftLabel);
            Controls.Add(rightMiddleLabel);
            Controls.Add(middleCenterlabel);
            Controls.Add(middleLeftLabel);
            Controls.Add(topRightLabel);
            Controls.Add(TopCemterLabel);
            Controls.Add(topLeftLabel);
            Name = "Form1";
            Text = "Label Alignment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topLeftLabel;
        private Label TopCemterLabel;
        private Label topRightLabel;
        private Label middleLeftLabel;
        private Label middleCenterlabel;
        private Label rightMiddleLabel;
        private Label bottomLeftLabel;
        private Label bottomCenterLabel;
        private Label bottomRightLAbel;
        private Button button1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}