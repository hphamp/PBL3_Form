namespace WindowsFormsApp111
{
    partial class ServicePay_Form
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
            this.butPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butPayment
            // 
            this.butPayment.Location = new System.Drawing.Point(561, 394);
            this.butPayment.Name = "butPayment";
            this.butPayment.Size = new System.Drawing.Size(195, 33);
            this.butPayment.TabIndex = 0;
            this.butPayment.Text = "Payment";
            this.butPayment.UseVisualStyleBackColor = true;
            // 
            // ServicePay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPayment);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ServicePay_Form";
            this.Text = "ServicePay_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPayment;
    }
}