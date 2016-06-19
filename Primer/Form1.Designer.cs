namespace Primer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_number = new System.Windows.Forms.Label();
            this.textBox1_number = new System.Windows.Forms.TextBox();
            this.button1_factor = new System.Windows.Forms.Button();
            this.textBox2_result = new System.Windows.Forms.TextBox();
            this.label2_result = new System.Windows.Forms.Label();
            this.label3_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_number
            // 
            this.label1_number.AutoSize = true;
            this.label1_number.Location = new System.Drawing.Point(12, 9);
            this.label1_number.Name = "label1_number";
            this.label1_number.Size = new System.Drawing.Size(47, 13);
            this.label1_number.TabIndex = 0;
            this.label1_number.Text = "Number:";
            // 
            // textBox1_number
            // 
            this.textBox1_number.Location = new System.Drawing.Point(15, 25);
            this.textBox1_number.Name = "textBox1_number";
            this.textBox1_number.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1_number.Size = new System.Drawing.Size(367, 20);
            this.textBox1_number.TabIndex = 1;
            // 
            // button1_factor
            // 
            this.button1_factor.Location = new System.Drawing.Point(15, 51);
            this.button1_factor.Name = "button1_factor";
            this.button1_factor.Size = new System.Drawing.Size(75, 23);
            this.button1_factor.TabIndex = 2;
            this.button1_factor.Text = "Factor";
            this.button1_factor.UseVisualStyleBackColor = true;
            this.button1_factor.Click += new System.EventHandler(this.button1_factor_Click);
            // 
            // textBox2_result
            // 
            this.textBox2_result.Location = new System.Drawing.Point(12, 112);
            this.textBox2_result.Name = "textBox2_result";
            this.textBox2_result.ReadOnly = true;
            this.textBox2_result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2_result.Size = new System.Drawing.Size(370, 20);
            this.textBox2_result.TabIndex = 3;
            // 
            // label2_result
            // 
            this.label2_result.AutoSize = true;
            this.label2_result.Location = new System.Drawing.Point(9, 96);
            this.label2_result.Name = "label2_result";
            this.label2_result.Size = new System.Drawing.Size(40, 13);
            this.label2_result.TabIndex = 4;
            this.label2_result.Text = "Result:";
            // 
            // label3_timer
            // 
            this.label3_timer.AutoSize = true;
            this.label3_timer.Location = new System.Drawing.Point(218, 96);
            this.label3_timer.Name = "label3_timer";
            this.label3_timer.Size = new System.Drawing.Size(164, 13);
            this.label3_timer.TabIndex = 5;
            this.label3_timer.Text = "Time Elapsed: 00:00:00.0000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 144);
            this.Controls.Add(this.label3_timer);
            this.Controls.Add(this.label2_result);
            this.Controls.Add(this.textBox2_result);
            this.Controls.Add(this.button1_factor);
            this.Controls.Add(this.textBox1_number);
            this.Controls.Add(this.label1_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Primer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_number;
        private System.Windows.Forms.TextBox textBox1_number;
        private System.Windows.Forms.Button button1_factor;
        private System.Windows.Forms.TextBox textBox2_result;
        private System.Windows.Forms.Label label2_result;
        private System.Windows.Forms.Label label3_timer;
    }
}

