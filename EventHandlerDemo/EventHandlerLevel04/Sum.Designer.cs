namespace EventHandlerLevel04
{
    partial class Sum
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.lbl_val2 = new System.Windows.Forms.Label();
            this.lbl_val1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sum";
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ans.Location = new System.Drawing.Point(221, 152);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(70, 26);
            this.lbl_Ans.TabIndex = 5;
            this.lbl_Ans.Text = "label4";
            // 
            // lbl_val2
            // 
            this.lbl_val2.AutoSize = true;
            this.lbl_val2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val2.Location = new System.Drawing.Point(221, 108);
            this.lbl_val2.Name = "lbl_val2";
            this.lbl_val2.Size = new System.Drawing.Size(70, 26);
            this.lbl_val2.TabIndex = 4;
            this.lbl_val2.Text = "label5";
            // 
            // lbl_val1
            // 
            this.lbl_val1.AutoSize = true;
            this.lbl_val1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val1.Location = new System.Drawing.Point(221, 64);
            this.lbl_val1.Name = "lbl_val1";
            this.lbl_val1.Size = new System.Drawing.Size(70, 26);
            this.lbl_val1.TabIndex = 3;
            this.lbl_val1.Text = "label6";
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 252);
            this.Controls.Add(this.lbl_Ans);
            this.Controls.Add(this.lbl_val2);
            this.Controls.Add(this.lbl_val1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.Label lbl_val2;
        private System.Windows.Forms.Label lbl_val1;
    }
}