namespace WindowsFormsApp111
{
    partial class CheckIO_Form
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
            this.butCheckin = new System.Windows.Forms.Button();
            this.butCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCheckin
            // 
            this.butCheckin.Location = new System.Drawing.Point(498, 23);
            this.butCheckin.Name = "butCheckin";
            this.butCheckin.Size = new System.Drawing.Size(115, 39);
            this.butCheckin.TabIndex = 0;
            this.butCheckin.Text = "Checkin";
            this.butCheckin.UseVisualStyleBackColor = true;
            // 
            // butCheckout
            // 
            this.butCheckout.Location = new System.Drawing.Point(633, 23);
            this.butCheckout.Name = "butCheckout";
            this.butCheckout.Size = new System.Drawing.Size(115, 39);
            this.butCheckout.TabIndex = 1;
            this.butCheckout.Text = "Checkout";
            this.butCheckout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bắt đầu ca làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết thúc ca làm việc:";
            // 
            // CheckIO_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCheckout);
            this.Controls.Add(this.butCheckin);
            this.Name = "CheckIO_Form";
            this.Text = "CheckIO_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheckin;
        private System.Windows.Forms.Button butCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}