namespace WindowsFormsApp111
{
    partial class AccManagement_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 0;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(366, 13);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 334);
            this.dataGridView1.TabIndex = 2;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(29, 401);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(130, 401);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 4;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(230, 401);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 5;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // AccManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "AccManagement";
            this.Text = "AccManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
    }
}