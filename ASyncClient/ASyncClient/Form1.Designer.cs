namespace ASyncClient
{
    partial class Form
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 30);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 22);
            this.label.TabIndex = 5;
            this.label.Text = "Number:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(131, 27);
            this.textBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(221, 30);
            this.textBox.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(184, 87);
            this.button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(104, 52);
            this.button.TabIndex = 3;
            this.button.Text = "Convert to Words";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 170);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
    }
}

