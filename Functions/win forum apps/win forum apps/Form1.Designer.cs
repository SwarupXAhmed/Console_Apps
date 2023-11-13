namespace win_forum_apps
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.HotTrack;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Location = new Point(641, 36);
            btn1.Name = "btn1";
            btn1.Size = new Size(147, 46);
            btn1.TabIndex = 0;
            btn1.Text = "Click me";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 193);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Main form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox textBox1;
    }
}