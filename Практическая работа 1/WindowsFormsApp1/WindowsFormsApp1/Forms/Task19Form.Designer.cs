namespace WindowsFormsApp1
{
    partial class Task19Form
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
            this.dLabel = new System.Windows.Forms.Label();
            this.aInput = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.TextBox();
            this.cInput = new System.Windows.Forms.TextBox();
            this.dInput = new System.Windows.Forms.TextBox();
            this.fitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(13, 13);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(16, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(13, 46);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(16, 13);
            this.bLabel.TabIndex = 1;
            this.bLabel.Text = "b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(13, 80);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(16, 13);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "c:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(13, 117);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(16, 13);
            this.dLabel.TabIndex = 3;
            this.dLabel.Text = "d:";
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(45, 6);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(100, 20);
            this.aInput.TabIndex = 4;
            this.aInput.TextChanged += new System.EventHandler(this.aInput_TextChanged);
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(45, 39);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 20);
            this.bInput.TabIndex = 5;
            this.bInput.TextChanged += new System.EventHandler(this.bInput_TextChanged);
            // 
            // cInput
            // 
            this.cInput.Location = new System.Drawing.Point(45, 73);
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(100, 20);
            this.cInput.TabIndex = 6;
            this.cInput.TextChanged += new System.EventHandler(this.cInput_TextChanged);
            // 
            // dInput
            // 
            this.dInput.Location = new System.Drawing.Point(45, 110);
            this.dInput.Name = "dInput";
            this.dInput.Size = new System.Drawing.Size(100, 20);
            this.dInput.TabIndex = 7;
            this.dInput.TextChanged += new System.EventHandler(this.dInput_TextChanged);
            // 
            // fitButton
            // 
            this.fitButton.Location = new System.Drawing.Point(202, 73);
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(75, 23);
            this.fitButton.TabIndex = 8;
            this.fitButton.Text = "Fit?";
            this.fitButton.UseVisualStyleBackColor = true;
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(321, 76);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "...";
            // 
            // Task19Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.fitButton);
            this.Controls.Add(this.dInput);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Name = "Task19Form";
            this.Text = "Task19Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TextBox aInput;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.TextBox dInput;
        private System.Windows.Forms.Button fitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}