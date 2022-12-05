namespace WindowsFormsApp1.Forms
{
    partial class Task13Form
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
            this.x1Label = new System.Windows.Forms.Label();
            this.x1Input = new System.Windows.Forms.TextBox();
            this.x2Label = new System.Windows.Forms.Label();
            this.x2Input = new System.Windows.Forms.TextBox();
            this.x3Label = new System.Windows.Forms.Label();
            this.x3Input = new System.Windows.Forms.TextBox();
            this.y3Input = new System.Windows.Forms.TextBox();
            this.y3Label = new System.Windows.Forms.Label();
            this.y2Input = new System.Windows.Forms.TextBox();
            this.y2Label = new System.Windows.Forms.Label();
            this.y1Input = new System.Windows.Forms.TextBox();
            this.y1Label = new System.Windows.Forms.Label();
            this.existsButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(12, 29);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(21, 13);
            this.x1Label.TabIndex = 0;
            this.x1Label.Text = "x1:";
            // 
            // x1Input
            // 
            this.x1Input.Location = new System.Drawing.Point(39, 22);
            this.x1Input.Name = "x1Input";
            this.x1Input.Size = new System.Drawing.Size(100, 20);
            this.x1Input.TabIndex = 1;
            this.x1Input.TextChanged += new System.EventHandler(this.x1Input_TextChanged);
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Location = new System.Drawing.Point(12, 65);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(21, 13);
            this.x2Label.TabIndex = 2;
            this.x2Label.Text = "x2:";
            // 
            // x2Input
            // 
            this.x2Input.Location = new System.Drawing.Point(39, 58);
            this.x2Input.Name = "x2Input";
            this.x2Input.Size = new System.Drawing.Size(100, 20);
            this.x2Input.TabIndex = 3;
            this.x2Input.TextChanged += new System.EventHandler(this.x2Input_TextChanged);
            // 
            // x3Label
            // 
            this.x3Label.AutoSize = true;
            this.x3Label.Location = new System.Drawing.Point(12, 105);
            this.x3Label.Name = "x3Label";
            this.x3Label.Size = new System.Drawing.Size(21, 13);
            this.x3Label.TabIndex = 4;
            this.x3Label.Text = "x3:";
            // 
            // x3Input
            // 
            this.x3Input.Location = new System.Drawing.Point(39, 98);
            this.x3Input.Name = "x3Input";
            this.x3Input.Size = new System.Drawing.Size(100, 20);
            this.x3Input.TabIndex = 5;
            this.x3Input.TextChanged += new System.EventHandler(this.x3Input_TextChanged);
            // 
            // y3Input
            // 
            this.y3Input.Location = new System.Drawing.Point(187, 98);
            this.y3Input.Name = "y3Input";
            this.y3Input.Size = new System.Drawing.Size(100, 20);
            this.y3Input.TabIndex = 11;
            this.y3Input.TextChanged += new System.EventHandler(this.y3Input_TextChanged);
            // 
            // y3Label
            // 
            this.y3Label.AutoSize = true;
            this.y3Label.Location = new System.Drawing.Point(160, 105);
            this.y3Label.Name = "y3Label";
            this.y3Label.Size = new System.Drawing.Size(21, 13);
            this.y3Label.TabIndex = 10;
            this.y3Label.Text = "y3:";
            // 
            // y2Input
            // 
            this.y2Input.Location = new System.Drawing.Point(187, 58);
            this.y2Input.Name = "y2Input";
            this.y2Input.Size = new System.Drawing.Size(100, 20);
            this.y2Input.TabIndex = 9;
            this.y2Input.TextChanged += new System.EventHandler(this.y2Input_TextChanged);
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(160, 65);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(21, 13);
            this.y2Label.TabIndex = 8;
            this.y2Label.Text = "y2:";
            // 
            // y1Input
            // 
            this.y1Input.Location = new System.Drawing.Point(187, 22);
            this.y1Input.Name = "y1Input";
            this.y1Input.Size = new System.Drawing.Size(100, 20);
            this.y1Input.TabIndex = 7;
            this.y1Input.TextChanged += new System.EventHandler(this.y1Input_TextChanged);
            // 
            // y1Label
            // 
            this.y1Label.AutoSize = true;
            this.y1Label.Location = new System.Drawing.Point(160, 29);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(21, 13);
            this.y1Label.TabIndex = 6;
            this.y1Label.Text = "y1:";
            // 
            // existsButton
            // 
            this.existsButton.Location = new System.Drawing.Point(338, 65);
            this.existsButton.Name = "existsButton";
            this.existsButton.Size = new System.Drawing.Size(75, 23);
            this.existsButton.TabIndex = 12;
            this.existsButton.Text = "Exists?";
            this.existsButton.UseVisualStyleBackColor = true;
            this.existsButton.Click += new System.EventHandler(this.existsButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(462, 70);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "...";
            // 
            // Task13Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.existsButton);
            this.Controls.Add(this.y3Input);
            this.Controls.Add(this.y3Label);
            this.Controls.Add(this.y2Input);
            this.Controls.Add(this.y2Label);
            this.Controls.Add(this.y1Input);
            this.Controls.Add(this.y1Label);
            this.Controls.Add(this.x3Input);
            this.Controls.Add(this.x3Label);
            this.Controls.Add(this.x2Input);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.x1Input);
            this.Controls.Add(this.x1Label);
            this.Name = "Task13Form";
            this.Text = "Task13Form";
            this.Load += new System.EventHandler(this.Task13Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.TextBox x1Input;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.TextBox x2Input;
        private System.Windows.Forms.Label x3Label;
        private System.Windows.Forms.TextBox x3Input;
        private System.Windows.Forms.TextBox y3Input;
        private System.Windows.Forms.Label y3Label;
        private System.Windows.Forms.TextBox y2Input;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.TextBox y1Input;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.Button existsButton;
        private System.Windows.Forms.Label resultLabel;
    }
}