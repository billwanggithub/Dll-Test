
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUB";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(64, 20);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(11, 12);
            this.label_sum.TabIndex = 0;
            this.label_sum.Text = "0";
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.Location = new System.Drawing.Point(64, 58);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(11, 12);
            this.label_sub.TabIndex = 0;
            this.label_sub.Text = "0";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(12, 90);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 1;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(179, 20);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "xxxx";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(179, 58);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(11, 12);
            this.label_age.TabIndex = 0;
            this.label_age.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 165);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
    }
}

