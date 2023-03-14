namespace QuadraticEquation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputBox = new GroupBox();
            cTextBox = new TextBox();
            bTextBox = new TextBox();
            aTextBox = new TextBox();
            cLabel = new Label();
            bLabel = new Label();
            aLabel = new Label();
            resultBox = new GroupBox();
            dTextBox = new TextBox();
            dLabel = new Label();
            xSecondTextBox = new TextBox();
            xFirstTextBox = new TextBox();
            xSecondLable = new Label();
            xFirstLable = new Label();
            controlBox = new GroupBox();
            thirdMethodRadioButton = new RadioButton();
            secondMethodRadioButton = new RadioButton();
            firstMethodRadioButton = new RadioButton();
            clearButton = new Button();
            calculateButton = new Button();
            inputBox.SuspendLayout();
            resultBox.SuspendLayout();
            controlBox.SuspendLayout();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Controls.Add(cTextBox);
            inputBox.Controls.Add(bTextBox);
            inputBox.Controls.Add(aTextBox);
            inputBox.Controls.Add(cLabel);
            inputBox.Controls.Add(bLabel);
            inputBox.Controls.Add(aLabel);
            inputBox.ForeColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(inputBox, "inputBox");
            inputBox.Name = "inputBox";
            inputBox.TabStop = false;
            // 
            // cTextBox
            // 
            cTextBox.BackColor = Color.FromArgb(64, 64, 64);
            cTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(cTextBox, "cTextBox");
            cTextBox.Name = "cTextBox";
            cTextBox.KeyPress += TextBox_KeyPress;
            // 
            // bTextBox
            // 
            bTextBox.BackColor = Color.FromArgb(64, 64, 64);
            bTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(bTextBox, "bTextBox");
            bTextBox.Name = "bTextBox";
            bTextBox.KeyPress += TextBox_KeyPress;
            // 
            // aTextBox
            // 
            aTextBox.BackColor = Color.FromArgb(64, 64, 64);
            aTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(aTextBox, "aTextBox");
            aTextBox.Name = "aTextBox";
            aTextBox.KeyPress += TextBox_KeyPress;
            // 
            // cLabel
            // 
            resources.ApplyResources(cLabel, "cLabel");
            cLabel.ForeColor = Color.FromArgb(0, 192, 192);
            cLabel.Name = "cLabel";
            // 
            // bLabel
            // 
            resources.ApplyResources(bLabel, "bLabel");
            bLabel.ForeColor = Color.FromArgb(0, 192, 192);
            bLabel.Name = "bLabel";
            // 
            // aLabel
            // 
            resources.ApplyResources(aLabel, "aLabel");
            aLabel.ForeColor = Color.FromArgb(0, 192, 192);
            aLabel.Name = "aLabel";
            // 
            // resultBox
            // 
            resultBox.Controls.Add(dTextBox);
            resultBox.Controls.Add(dLabel);
            resultBox.Controls.Add(xSecondTextBox);
            resultBox.Controls.Add(xFirstTextBox);
            resultBox.Controls.Add(xSecondLable);
            resultBox.Controls.Add(xFirstLable);
            resultBox.ForeColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(resultBox, "resultBox");
            resultBox.Name = "resultBox";
            resultBox.TabStop = false;
            // 
            // dTextBox
            // 
            dTextBox.BackColor = Color.FromArgb(64, 64, 64);
            dTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(dTextBox, "dTextBox");
            dTextBox.Name = "dTextBox";
            dTextBox.ReadOnly = true;
            // 
            // dLabel
            // 
            resources.ApplyResources(dLabel, "dLabel");
            dLabel.ForeColor = Color.FromArgb(0, 192, 192);
            dLabel.Name = "dLabel";
            // 
            // xSecondTextBox
            // 
            xSecondTextBox.BackColor = Color.FromArgb(64, 64, 64);
            xSecondTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(xSecondTextBox, "xSecondTextBox");
            xSecondTextBox.Name = "xSecondTextBox";
            xSecondTextBox.ReadOnly = true;
            // 
            // xFirstTextBox
            // 
            xFirstTextBox.BackColor = Color.FromArgb(64, 64, 64);
            xFirstTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(xFirstTextBox, "xFirstTextBox");
            xFirstTextBox.Name = "xFirstTextBox";
            xFirstTextBox.ReadOnly = true;
            // 
            // xSecondLable
            // 
            resources.ApplyResources(xSecondLable, "xSecondLable");
            xSecondLable.ForeColor = Color.FromArgb(0, 192, 192);
            xSecondLable.Name = "xSecondLable";
            // 
            // xFirstLable
            // 
            resources.ApplyResources(xFirstLable, "xFirstLable");
            xFirstLable.ForeColor = Color.FromArgb(0, 192, 192);
            xFirstLable.Name = "xFirstLable";
            // 
            // controlBox
            // 
            controlBox.Controls.Add(thirdMethodRadioButton);
            controlBox.Controls.Add(secondMethodRadioButton);
            controlBox.Controls.Add(firstMethodRadioButton);
            controlBox.Controls.Add(clearButton);
            controlBox.Controls.Add(calculateButton);
            controlBox.ForeColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(controlBox, "controlBox");
            controlBox.Name = "controlBox";
            controlBox.TabStop = false;
            // 
            // thirdMethodRadioButton
            // 
            resources.ApplyResources(thirdMethodRadioButton, "thirdMethodRadioButton");
            thirdMethodRadioButton.ForeColor = Color.FromArgb(0, 192, 192);
            thirdMethodRadioButton.Name = "thirdMethodRadioButton";
            thirdMethodRadioButton.TabStop = true;
            thirdMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondMethodRadioButton
            // 
            resources.ApplyResources(secondMethodRadioButton, "secondMethodRadioButton");
            secondMethodRadioButton.ForeColor = Color.FromArgb(0, 192, 192);
            secondMethodRadioButton.Name = "secondMethodRadioButton";
            secondMethodRadioButton.TabStop = true;
            secondMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstMethodRadioButton
            // 
            resources.ApplyResources(firstMethodRadioButton, "firstMethodRadioButton");
            firstMethodRadioButton.Checked = true;
            firstMethodRadioButton.ForeColor = Color.FromArgb(0, 192, 192);
            firstMethodRadioButton.Name = "firstMethodRadioButton";
            firstMethodRadioButton.TabStop = true;
            firstMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.ForeColor = Color.FromArgb(0, 192, 192);
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(calculateButton, "calculateButton");
            calculateButton.ForeColor = Color.FromArgb(0, 192, 192);
            calculateButton.Name = "calculateButton";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(controlBox);
            Controls.Add(resultBox);
            Controls.Add(inputBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            KeyPress += TextBox_KeyPress;
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            controlBox.ResumeLayout(false);
            controlBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox inputBox;
        private GroupBox resultBox;
        private GroupBox controlBox;
        private TextBox cTextBox;
        private TextBox bTextBox;
        private TextBox aTextBox;
        private Label cLabel;
        private Label bLabel;
        private Label aLabel;
        private RadioButton thirdMethodRadioButton;
        private RadioButton secondMethodRadioButton;
        private RadioButton firstMethodRadioButton;
        private Button clearButton;
        private Button calculateButton;
        private TextBox xSecondTextBox;
        private TextBox xFirstTextBox;
        private Label xSecondLable;
        private Label xFirstLable;
        private TextBox dTextBox;
        private Label dLabel;
    }
}