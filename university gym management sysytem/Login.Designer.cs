namespace university_gym_management_sysytem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxUserName);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(227, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(93, 213);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(324, 31);
            this.txtBoxPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(74, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(386, 56);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gym Login";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxUserName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUserName.Location = new System.Drawing.Point(93, 132);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(324, 31);
            this.txtBoxUserName.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.panel1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxUserName;
        private TextBox txtBoxPassword;
    }
}