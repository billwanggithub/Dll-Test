
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_sum = new System.Windows.Forms.Label();
            this.label_sub = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUB";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(101, 37);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(11, 12);
            this.label_sum.TabIndex = 0;
            this.label_sum.Text = "0";
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.Location = new System.Drawing.Point(101, 75);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(11, 12);
            this.label_sub.TabIndex = 0;
            this.label_sub.Text = "0";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(51, 107);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 1;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 165);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sub);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Button button_calculate;
    }
}

