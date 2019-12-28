namespace NachoDTOMaker
{
    partial class LoginFRM
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
            this.ServerTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectBT = new System.Windows.Forms.Button();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.RememberCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ServerTB
            // 
            this.ServerTB.Location = new System.Drawing.Point(12, 36);
            this.ServerTB.Name = "ServerTB";
            this.ServerTB.Size = new System.Drawing.Size(518, 26);
            this.ServerTB.TabIndex = 0;
            // 
            // UserTB
            // 
            this.UserTB.Location = new System.Drawing.Point(12, 92);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(518, 26);
            this.UserTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(12, 148);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(518, 26);
            this.PasswordTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // ConnectBT
            // 
            this.ConnectBT.Location = new System.Drawing.Point(12, 211);
            this.ConnectBT.Name = "ConnectBT";
            this.ConnectBT.Size = new System.Drawing.Size(518, 32);
            this.ConnectBT.TabIndex = 6;
            this.ConnectBT.Text = "Connect";
            this.ConnectBT.UseVisualStyleBackColor = true;
            this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.ForeColor = System.Drawing.Color.Coral;
            this.ErrorLB.Location = new System.Drawing.Point(12, 181);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(0, 20);
            this.ErrorLB.TabIndex = 7;
            // 
            // RememberCB
            // 
            this.RememberCB.AutoSize = true;
            this.RememberCB.Location = new System.Drawing.Point(335, 180);
            this.RememberCB.Name = "RememberCB";
            this.RememberCB.Size = new System.Drawing.Size(195, 24);
            this.RememberCB.TabIndex = 8;
            this.RememberCB.Text = "Remember credentials";
            this.RememberCB.UseVisualStyleBackColor = true;
            // 
            // LoginFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 260);
            this.Controls.Add(this.RememberCB);
            this.Controls.Add(this.ErrorLB);
            this.Controls.Add(this.ConnectBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserTB);
            this.Controls.Add(this.ServerTB);
            this.Name = "LoginFRM";
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFRM_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerTB;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectBT;
        private System.Windows.Forms.Label ErrorLB;
        private System.Windows.Forms.CheckBox RememberCB;
    }
}

