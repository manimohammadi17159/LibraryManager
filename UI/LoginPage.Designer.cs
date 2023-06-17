namespace UI
{
    partial class LoginPage
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
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.llblSignup = new System.Windows.Forms.LinkLabel();
            this.lblnotfound = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(163, 145);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(254, 27);
            this.txtbx_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(163, 208);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(254, 27);
            this.txtbx_password.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // llblSignup
            // 
            this.llblSignup.AutoSize = true;
            this.llblSignup.Location = new System.Drawing.Point(248, 321);
            this.llblSignup.Name = "llblSignup";
            this.llblSignup.Size = new System.Drawing.Size(61, 20);
            this.llblSignup.TabIndex = 5;
            this.llblSignup.TabStop = true;
            this.llblSignup.Text = "Sign Up";
            this.llblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblnotfound
            // 
            this.lblnotfound.AutoSize = true;
            this.lblnotfound.ForeColor = System.Drawing.Color.Red;
            this.lblnotfound.Location = new System.Drawing.Point(172, 241);
            this.lblnotfound.Name = "lblnotfound";
            this.lblnotfound.Size = new System.Drawing.Size(234, 20);
            this.lblnotfound.TabIndex = 6;
            this.lblnotfound.Text = "username or password is incorrect";
            this.lblnotfound.Visible = false;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(85, -4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(94, 29);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(0, -4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(216, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login as:";
            // 
            // lblUserModel
            // 
            this.lblUserModel.AutoSize = true;
            this.lblUserModel.ForeColor = System.Drawing.Color.Blue;
            this.lblUserModel.Location = new System.Drawing.Point(286, 109);
            this.lblUserModel.Name = "lblUserModel";
            this.lblUserModel.Size = new System.Drawing.Size(36, 20);
            this.lblUserModel.TabIndex = 10;
            this.lblUserModel.Text = "user";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 435);
            this.Controls.Add(this.lblUserModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblnotfound);
            this.Controls.Add(this.llblSignup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_username);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbx_username;
        private Label label1;
        private Label label2;
        private TextBox txtbx_password;
        private Button button1;
        private LinkLabel llblSignup;
        private Label lblnotfound;
        private Button btnUser;
        private Button btnAdmin;
        private Label label3;
        private Label lblUserModel;
    }
}