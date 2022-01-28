namespace EventHandlerLevel05
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
            this.dgv_Show = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Dateis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Show
            // 
            this.dgv_Show.AllowUserToAddRows = false;
            this.dgv_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_Active,
            this.dgv_Dateis,
            this.dgv_name,
            this.dgv_Marks});
            this.dgv_Show.Location = new System.Drawing.Point(3, 3);
            this.dgv_Show.Name = "dgv_Show";
            this.dgv_Show.Size = new System.Drawing.Size(795, 402);
            this.dgv_Show.TabIndex = 0;
            // 
            // dgv_id
            // 
            this.dgv_id.DataPropertyName = "Id";
            this.dgv_id.HeaderText = "Id";
            this.dgv_id.Name = "dgv_id";
            this.dgv_id.ReadOnly = true;
            // 
            // dgv_Active
            // 
            this.dgv_Active.DataPropertyName = "IsActive";
            this.dgv_Active.HeaderText = "Active";
            this.dgv_Active.Name = "dgv_Active";
            this.dgv_Active.ReadOnly = true;
            // 
            // dgv_Dateis
            // 
            this.dgv_Dateis.DataPropertyName = "DateIs";
            this.dgv_Dateis.HeaderText = "Date";
            this.dgv_Dateis.Name = "dgv_Dateis";
            this.dgv_Dateis.ReadOnly = true;
            // 
            // dgv_name
            // 
            this.dgv_name.DataPropertyName = "Name";
            this.dgv_name.HeaderText = "Name";
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            // 
            // dgv_Marks
            // 
            this.dgv_Marks.DataPropertyName = "Marks";
            this.dgv_Marks.HeaderText = "Marks";
            this.dgv_Marks.Name = "dgv_Marks";
            this.dgv_Marks.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(696, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(611, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgv_Show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Show;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Dateis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Marks;
    }
}

