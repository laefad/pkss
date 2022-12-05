namespace WindowsFormsApp1.Forms
{
    partial class Task10Form
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
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.aInput = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.TextBox();
            this.cInput = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(13, 24);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(19, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "a: ";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(13, 52);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(16, 13);
            this.bLabel.TabIndex = 1;
            this.bLabel.Text = "b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(12, 79);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(16, 13);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "c:";
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(39, 24);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(100, 20);
            this.aInput.TabIndex = 3;
            this.aInput.TextChanged += new System.EventHandler(this.aInput_TextChanged);
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(36, 52);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 20);
            this.bInput.TabIndex = 4;
            this.bInput.TextChanged += new System.EventHandler(this.bInput_TextChanged);
            // 
            // cInput
            // 
            this.cInput.Location = new System.Drawing.Point(35, 79);
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(100, 20);
            this.cInput.TabIndex = 5;
            this.cInput.TextChanged += new System.EventHandler(this.cInput_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(157, 52);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Task10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Name = "Task10Form";
            this.Text = "Task10Form";
            this.Load += new System.EventHandler(this.Task10Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox aInput;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.Button sortButton;
    }
}