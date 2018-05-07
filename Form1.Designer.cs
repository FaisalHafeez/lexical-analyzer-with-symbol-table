namespace lab13
{
    partial class Form1
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
            this.Tokenize = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ST = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Tokenize
            // 
            this.Tokenize.Location = new System.Drawing.Point(374, 455);
            this.Tokenize.Name = "Tokenize";
            this.Tokenize.Size = new System.Drawing.Size(109, 44);
            this.Tokenize.TabIndex = 0;
            this.Tokenize.Text = "Tokenize";
            this.Tokenize.UseVisualStyleBackColor = true;
            this.Tokenize.Click += new System.EventHandler(this.Tokenize_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(77, 65);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(291, 144);
            this.Input.TabIndex = 1;
            this.Input.Text = "";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(77, 262);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(291, 144);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Symbol Table";
            // 
            // ST
            // 
            this.ST.Location = new System.Drawing.Point(441, 81);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(360, 334);
            this.ST.TabIndex = 8;
            this.ST.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 555);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Tokenize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tokenize;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ST;
    }
}

