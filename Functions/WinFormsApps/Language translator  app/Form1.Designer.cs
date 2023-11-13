namespace Language_translator__app
{
    partial class LanguageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageForm));
            HeadLinelabel = new Label();
            arabiclanguageButton = new MaterialSkin.Controls.MaterialButton();
            spanishLanguageButton1 = new MaterialSkin.Controls.MaterialButton();
            GermenlanguageButton = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // HeadLinelabel
            // 
            HeadLinelabel.AutoSize = true;
            HeadLinelabel.Location = new Point(92, 62);
            HeadLinelabel.Name = "HeadLinelabel";
            HeadLinelabel.Size = new Size(253, 15);
            HeadLinelabel.TabIndex = 0;
            HeadLinelabel.Text = "Select a Language and I will say Good Morning";
            HeadLinelabel.Click += HeadLinelabel_Click;
            // 
            // arabiclanguageButton
            // 
            arabiclanguageButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            arabiclanguageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            arabiclanguageButton.Depth = 0;
            arabiclanguageButton.HighEmphasis = true;
            arabiclanguageButton.Icon = null;
            arabiclanguageButton.Location = new Point(60, 198);
            arabiclanguageButton.Margin = new Padding(4, 6, 4, 6);
            arabiclanguageButton.MouseState = MaterialSkin.MouseState.HOVER;
            arabiclanguageButton.Name = "arabiclanguageButton";
            arabiclanguageButton.NoAccentTextColor = Color.Empty;
            arabiclanguageButton.Size = new Size(73, 36);
            arabiclanguageButton.TabIndex = 2;
            arabiclanguageButton.Text = "Arabic";
            arabiclanguageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            arabiclanguageButton.UseAccentColor = false;
            arabiclanguageButton.UseVisualStyleBackColor = true;
            arabiclanguageButton.Click += arabiclanguageButton_Click;
            // 
            // spanishLanguageButton1
            // 
            spanishLanguageButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            spanishLanguageButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            spanishLanguageButton1.Depth = 0;
            spanishLanguageButton1.HighEmphasis = true;
            spanishLanguageButton1.Icon = null;
            spanishLanguageButton1.Location = new Point(173, 198);
            spanishLanguageButton1.Margin = new Padding(4, 6, 4, 6);
            spanishLanguageButton1.MouseState = MaterialSkin.MouseState.HOVER;
            spanishLanguageButton1.Name = "spanishLanguageButton1";
            spanishLanguageButton1.NoAccentTextColor = Color.Empty;
            spanishLanguageButton1.Size = new Size(83, 36);
            spanishLanguageButton1.TabIndex = 3;
            spanishLanguageButton1.Text = "Spanish";
            spanishLanguageButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            spanishLanguageButton1.UseAccentColor = false;
            spanishLanguageButton1.UseVisualStyleBackColor = true;
            spanishLanguageButton1.Click += spanishLanguageButton1_Click;
            // 
            // GermenlanguageButton
            // 
            GermenlanguageButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GermenlanguageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GermenlanguageButton.Depth = 0;
            GermenlanguageButton.HighEmphasis = true;
            GermenlanguageButton.Icon = null;
            GermenlanguageButton.Location = new Point(306, 198);
            GermenlanguageButton.Margin = new Padding(4, 6, 4, 6);
            GermenlanguageButton.MouseState = MaterialSkin.MouseState.HOVER;
            GermenlanguageButton.Name = "GermenlanguageButton";
            GermenlanguageButton.NoAccentTextColor = Color.Empty;
            GermenlanguageButton.Size = new Size(82, 36);
            GermenlanguageButton.TabIndex = 4;
            GermenlanguageButton.Text = "German";
            GermenlanguageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GermenlanguageButton.UseAccentColor = false;
            GermenlanguageButton.UseVisualStyleBackColor = true;
            GermenlanguageButton.Click += GermenlanguageButton_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(92, 100);
            label1.Name = "label1";
            label1.Size = new Size(272, 61);
            label1.TabIndex = 5;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // LanguageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 310);
            Controls.Add(label1);
            Controls.Add(GermenlanguageButton);
            Controls.Add(spanishLanguageButton1);
            Controls.Add(arabiclanguageButton);
            Controls.Add(HeadLinelabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LanguageForm";
            Text = "Language Translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadLinelabel;
        private MaterialSkin.Controls.MaterialButton arabiclanguageButton;
        private MaterialSkin.Controls.MaterialButton spanishLanguageButton1;
        private MaterialSkin.Controls.MaterialButton GermenlanguageButton;
        private Label label1;
    }
}