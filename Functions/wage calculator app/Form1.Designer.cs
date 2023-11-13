namespace wage_calculator_app
{
    partial class WageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WageCalculator));
            calculateButton = new Button();
            hoursLabel = new Label();
            HourlyRatelabel = new Label();
            Exitbutton = new Button();
            hourstextbox = new TextBox();
            hourlyRatetextBox = new TextBox();
            Taxlabel = new Label();
            taxRatetextbox = new TextBox();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(30, 213);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(106, 48);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate Net Pay";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(30, 48);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(83, 15);
            hoursLabel.TabIndex = 1;
            hoursLabel.Text = "Hours Worked";
            // 
            // HourlyRatelabel
            // 
            HourlyRatelabel.AutoSize = true;
            HourlyRatelabel.Location = new Point(30, 84);
            HourlyRatelabel.Name = "HourlyRatelabel";
            HourlyRatelabel.Size = new Size(69, 15);
            HourlyRatelabel.TabIndex = 2;
            HourlyRatelabel.Text = "Hourly Rate";
            // 
            // Exitbutton
            // 
            Exitbutton.Location = new Point(222, 213);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(92, 48);
            Exitbutton.TabIndex = 3;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = true;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // hourstextbox
            // 
            hourstextbox.Location = new Point(153, 48);
            hourstextbox.Name = "hourstextbox";
            hourstextbox.Size = new Size(161, 23);
            hourstextbox.TabIndex = 4;
            // 
            // hourlyRatetextBox
            // 
            hourlyRatetextBox.Location = new Point(153, 91);
            hourlyRatetextBox.Name = "hourlyRatetextBox";
            hourlyRatetextBox.Size = new Size(161, 23);
            hourlyRatetextBox.TabIndex = 5;
            // 
            // Taxlabel
            // 
            Taxlabel.AutoSize = true;
            Taxlabel.Location = new Point(40, 122);
            Taxlabel.Name = "Taxlabel";
            Taxlabel.Size = new Size(50, 15);
            Taxlabel.TabIndex = 6;
            Taxlabel.Text = "Tax Rate";
            // 
            // taxRatetextbox
            // 
            taxRatetextbox.Location = new Point(153, 134);
            taxRatetextbox.Name = "taxRatetextbox";
            taxRatetextbox.Size = new Size(161, 23);
            taxRatetextbox.TabIndex = 7;
            // 
            // WageCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 306);
            Controls.Add(taxRatetextbox);
            Controls.Add(Taxlabel);
            Controls.Add(hourlyRatetextBox);
            Controls.Add(hourstextbox);
            Controls.Add(Exitbutton);
            Controls.Add(HourlyRatelabel);
            Controls.Add(hoursLabel);
            Controls.Add(calculateButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WageCalculator";
            Text = "Wage Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label hoursLabel;
        private Label HourlyRatelabel;
        private Button Exitbutton;
        private TextBox hourstextbox;
        private TextBox hourlyRatetextBox;
        private Label Taxlabel;
        private TextBox taxRatetextbox;
    }
}