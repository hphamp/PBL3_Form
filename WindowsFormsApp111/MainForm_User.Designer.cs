namespace WindowsFormsApp111
{
    partial class MainForm_User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonalInfor = new System.Windows.Forms.Button();
            this.btnLoutout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnChat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPersonalInfor);
            this.panel1.Controls.Add(this.btnLoutout);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(949, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 615);
            this.panel1.TabIndex = 0;
            // 
            // btnPersonalInfor
            // 
            this.btnPersonalInfor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPersonalInfor.Location = new System.Drawing.Point(13, 238);
            this.btnPersonalInfor.Name = "btnPersonalInfor";
            this.btnPersonalInfor.Size = new System.Drawing.Size(307, 29);
            this.btnPersonalInfor.TabIndex = 9;
            this.btnPersonalInfor.Text = "Personal information";
            this.btnPersonalInfor.UseVisualStyleBackColor = false;
            this.btnPersonalInfor.Click += new System.EventHandler(this.btnPersonalInfor_Click);
            // 
            // btnLoutout
            // 
            this.btnLoutout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoutout.Location = new System.Drawing.Point(96, 273);
            this.btnLoutout.Name = "btnLoutout";
            this.btnLoutout.Size = new System.Drawing.Size(150, 29);
            this.btnLoutout.TabIndex = 8;
            this.btnLoutout.Text = "Log out";
            this.btnLoutout.UseVisualStyleBackColor = false;
            this.btnLoutout.Click += new System.EventHandler(this.btnLoutout_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(172, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Service";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOptions.Location = new System.Drawing.Point(13, 203);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(150, 29);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service prices (VNĐ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time remaining:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time used:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total time:";
            // 
            // panel_body
            // 
            this.panel_body.Location = new System.Drawing.Point(12, 16);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(918, 611);
            this.panel_body.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp111.Properties.Resources.backgroud;
            this.pictureBox1.Location = new System.Drawing.Point(2, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(19, 577);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(292, 23);
            this.btnChat.TabIndex = 12;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // MainForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1298, 639);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm_User";
            this.Text = "MainForm_User";
            this.Load += new System.EventHandler(this.MainForm_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPersonalInfor;
        private System.Windows.Forms.Button btnLoutout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnChat;
    }
}