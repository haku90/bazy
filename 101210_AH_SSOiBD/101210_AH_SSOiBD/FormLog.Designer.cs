namespace _101210_AH_SSOiBD
{
    partial class FormLog
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
            this.tBip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConn = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBip
            // 
            this.tBip.Location = new System.Drawing.Point(125, 59);
            this.tBip.Name = "tBip";
            this.tBip.Size = new System.Drawing.Size(100, 20);
            this.tBip.TabIndex = 0;
            this.tBip.Text = "192.168.1.13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj adres IP serwera:";
            // 
            // tBuser
            // 
            this.tBuser.Location = new System.Drawing.Point(125, 85);
            this.tBuser.Name = "tBuser";
            this.tBuser.Size = new System.Drawing.Size(100, 20);
            this.tBuser.TabIndex = 2;
            this.tBuser.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa Użytkownika:";
            // 
            // tBpass
            // 
            this.tBpass.Location = new System.Drawing.Point(125, 111);
            this.tBpass.Name = "tBpass";
            this.tBpass.PasswordChar = '*';
            this.tBpass.Size = new System.Drawing.Size(100, 20);
            this.tBpass.TabIndex = 4;
            this.tBpass.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło:";
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(83, 163);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(75, 23);
            this.btConn.TabIndex = 6;
            this.btConn.Text = "Połącz";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(164, 163);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Zamknij";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBuser;
        private System.Windows.Forms.Label label2;
        private  System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btClose;
    }
}

