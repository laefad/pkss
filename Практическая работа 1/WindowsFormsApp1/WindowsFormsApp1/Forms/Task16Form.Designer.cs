namespace WindowsFormsApp1.Forms
{
    partial class Task16Form
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
            this.circleLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.circleInput = new System.Windows.Forms.TextBox();
            this.squareInput = new System.Windows.Forms.TextBox();
            this.fitButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Location = new System.Drawing.Point(22, 27);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(39, 13);
            this.circleLabel.TabIndex = 0;
            this.circleLabel.Text = "Circle: ";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Location = new System.Drawing.Point(17, 60);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(44, 13);
            this.squareLabel.TabIndex = 1;
            this.squareLabel.Text = "Square:";
            // 
            // circleInput
            // 
            this.circleInput.Location = new System.Drawing.Point(67, 20);
            this.circleInput.Name = "circleInput";
            this.circleInput.Size = new System.Drawing.Size(100, 20);
            this.circleInput.TabIndex = 2;
            this.circleInput.TextChanged += new System.EventHandler(this.circleInput_TextChanged);
            // 
            // squareInput
            // 
            this.squareInput.Location = new System.Drawing.Point(67, 57);
            this.squareInput.Name = "squareInput";
            this.squareInput.Size = new System.Drawing.Size(100, 20);
            this.squareInput.TabIndex = 3;
            this.squareInput.TextChanged += new System.EventHandler(this.squareInput_TextChanged);
            // 
            // fitButton
            // 
            this.fitButton.Location = new System.Drawing.Point(189, 40);
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(75, 23);
            this.fitButton.TabIndex = 4;
            this.fitButton.Text = "Fit?";
            this.fitButton.UseVisualStyleBackColor = true;
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(304, 49);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(16, 13);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "...";
            // 
            // Task16Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.fitButton);
            this.Controls.Add(this.squareInput);
            this.Controls.Add(this.circleInput);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.circleLabel);
            this.Name = "Task16Form";
            this.Text = "Task16Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.TextBox circleInput;
        private System.Windows.Forms.TextBox squareInput;
        private System.Windows.Forms.Button fitButton;
        private System.Windows.Forms.Label answerLabel;
    }
}