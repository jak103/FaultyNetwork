namespace FaultyNetwork
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.corruptionRateBox = new System.Windows.Forms.NumericUpDown();
            this.dropRateBox = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.corruptionRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropRateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 12);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(776, 342);
            this.outputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corruption Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drop Rate:";
            // 
            // corruptionRateBox
            // 
            this.corruptionRateBox.Location = new System.Drawing.Point(140, 402);
            this.corruptionRateBox.Name = "corruptionRateBox";
            this.corruptionRateBox.Size = new System.Drawing.Size(82, 26);
            this.corruptionRateBox.TabIndex = 2;
            this.corruptionRateBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dropRateBox
            // 
            this.dropRateBox.Location = new System.Drawing.Point(336, 402);
            this.dropRateBox.Name = "dropRateBox";
            this.dropRateBox.Size = new System.Drawing.Size(82, 26);
            this.dropRateBox.TabIndex = 2;
            this.dropRateBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 361);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Print Output";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dropRateBox);
            this.Controls.Add(this.corruptionRateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Faulty Network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.corruptionRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropRateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown corruptionRateBox;
        private System.Windows.Forms.NumericUpDown dropRateBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

