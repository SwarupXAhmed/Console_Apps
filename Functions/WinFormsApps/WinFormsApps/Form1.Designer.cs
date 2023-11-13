namespace WinFormsApps
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
            btn1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnUpper = new Button();
            btnLower = new Button();
            label2 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Location = new Point(347, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 37);
            btn1.TabIndex = 0;
            btn1.Text = "Click me";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(301, 173);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 2;
            // 
            // btnUpper
            // 
            btnUpper.BackColor = SystemColors.ActiveCaption;
            btnUpper.Location = new Point(347, 285);
            btnUpper.Name = "btnUpper";
            btnUpper.Size = new Size(85, 37);
            btnUpper.TabIndex = 3;
            btnUpper.Text = "Upper";
            btnUpper.UseVisualStyleBackColor = false;
            btnUpper.Click += btnUpper_Click;
            // 
            // btnLower
            // 
            btnLower.BackColor = SystemColors.ActiveCaption;
            btnLower.Location = new Point(347, 337);
            btnLower.Name = "btnLower";
            btnLower.Size = new Size(85, 37);
            btnLower.TabIndex = 4;
            btnLower.Text = "Lower";
            btnLower.UseVisualStyleBackColor = false;
            btnLower.Click += btnLower_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(516, 138);
            label2.Name = "label2";
            label2.Size = new Size(191, 50);
            label2.TabIndex = 5;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1062, 384);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1202, 450);
            Controls.Add(exitButton);
            Controls.Add(label2);
            Controls.Add(btnLower);
            Controls.Add(btnUpper);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button btn1;
        private Button btnUpper;
        private Button btnLower;
        private Label label2;
        private Button exitButton;
    }
}