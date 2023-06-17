namespace UI
{
    partial class SignUpPage
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
            this.txtbx_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_Lastname = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_Name
            // 
            this.txtbx_Name.Location = new System.Drawing.Point(123, 64);
            this.txtbx_Name.Name = "txtbx_Name";
            this.txtbx_Name.Size = new System.Drawing.Size(205, 27);
            this.txtbx_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.ForeColor = System.Drawing.Color.Red;
            this.namelbl.Location = new System.Drawing.Point(123, 94);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(249, 20);
            this.namelbl.TabIndex = 10;
            this.namelbl.Text = "character must be between 3 and 10";
            this.namelbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Location = new System.Drawing.Point(123, 276);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(205, 27);
            this.txtbx_Password.TabIndex = 17;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.ForeColor = System.Drawing.Color.Red;
            this.usernamelbl.Location = new System.Drawing.Point(123, 240);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(214, 20);
            this.usernamelbl.TabIndex = 22;
            this.usernamelbl.Text = "this username has already used";
            this.usernamelbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Username";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Location = new System.Drawing.Point(123, 210);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(205, 27);
            this.txtbx_Username.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lastname";
            // 
            // txtbx_Lastname
            // 
            this.txtbx_Lastname.Location = new System.Drawing.Point(123, 139);
            this.txtbx_Lastname.Name = "txtbx_Lastname";
            this.txtbx_Lastname.Size = new System.Drawing.Size(205, 27);
            this.txtbx_Lastname.TabIndex = 23;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.ForeColor = System.Drawing.Color.Red;
            this.passwordlbl.Location = new System.Drawing.Point(123, 306);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(249, 20);
            this.passwordlbl.TabIndex = 25;
            this.passwordlbl.Text = "character must be between 3 and 10";
            this.passwordlbl.Visible = false;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.ForeColor = System.Drawing.Color.Red;
            this.lastnamelbl.Location = new System.Drawing.Point(123, 169);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(249, 20);
            this.lastnamelbl.TabIndex = 26;
            this.lastnamelbl.Text = "character must be between 3 and 10";
            this.lastnamelbl.Visible = false;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbx_Lastname);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_Name);
            this.Name = "SignUpPage";
            this.Text = "SignUpPage";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbx_Name;
        private Label label1;
        private Button button1;
        private Label namelbl;
        private Label label7;
        private TextBox txtbx_Password;
        private Label usernamelbl;
        private Label label10;
        private TextBox txtbx_Username;
        private Label label12;
        private TextBox txtbx_Lastname;
        private Label passwordlbl;
        private Label lastnamelbl;
    }
}