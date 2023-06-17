namespace UI
{
    partial class AdminPanel
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
            this.lvUsers = new System.Windows.Forms.ListView();
            this.clmUsername = new System.Windows.Forms.ColumnHeader();
            this.clmName = new System.Windows.Forms.ColumnHeader();
            this.clmLastname = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLatsname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblTotalBookSold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbUserInfo.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.BackColor = System.Drawing.Color.White;
            this.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUsername,
            this.clmName,
            this.clmLastname});
            this.lvUsers.Location = new System.Drawing.Point(12, 161);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(300, 281);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 100;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 100;
            // 
            // clmLastname
            // 
            this.clmLastname.Text = "Lastname";
            this.clmLastname.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(17, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lastname:";
            // 
            // lblLatsname
            // 
            this.lblLatsname.AutoSize = true;
            this.lblLatsname.ForeColor = System.Drawing.Color.Black;
            this.lblLatsname.Location = new System.Drawing.Point(102, 76);
            this.lblLatsname.Name = "lblLatsname";
            this.lblLatsname.Size = new System.Drawing.Size(50, 20);
            this.lblLatsname.TabIndex = 11;
            this.lblLatsname.Text = "label2";
            this.lblLatsname.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(102, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(50, 20);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "label7";
            this.lblUsername.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(102, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "label8";
            this.lblPassword.Visible = false;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.ForeColor = System.Drawing.Color.Black;
            this.lblCredit.Location = new System.Drawing.Point(102, 209);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(50, 20);
            this.lblCredit.TabIndex = 8;
            this.lblCredit.Text = "label9";
            this.lblCredit.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(102, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label10";
            this.lblName.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(19, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(97, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.btnDelete);
            this.gbUserInfo.Controls.Add(this.label3);
            this.gbUserInfo.Controls.Add(this.btnEdit);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.lblLatsname);
            this.gbUserInfo.Controls.Add(this.label5);
            this.gbUserInfo.Controls.Add(this.lblUsername);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Controls.Add(this.lblPassword);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Controls.Add(this.lblCredit);
            this.gbUserInfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbUserInfo.Location = new System.Drawing.Point(327, 157);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(228, 281);
            this.gbUserInfo.TabIndex = 14;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User info";
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookCount.Location = new System.Drawing.Point(105, 56);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(52, 49);
            this.lblBookCount.TabIndex = 30;
            this.lblBookCount.Text = "..";
            // 
            // lblTotalBookSold
            // 
            this.lblTotalBookSold.AutoSize = true;
            this.lblTotalBookSold.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBookSold.Location = new System.Drawing.Point(143, 46);
            this.lblTotalBookSold.Name = "lblTotalBookSold";
            this.lblTotalBookSold.Size = new System.Drawing.Size(76, 59);
            this.lblTotalBookSold.TabIndex = 30;
            this.lblTotalBookSold.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "new Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "new Credit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "new Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "new Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "new Lastname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 22;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(181, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 27);
            this.txtUsername.TabIndex = 23;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(181, 73);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(125, 27);
            this.txtLastname.TabIndex = 24;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(181, 206);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(125, 27);
            this.txtCredit.TabIndex = 25;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(106, 246);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(94, 29);
            this.btnDone.TabIndex = 26;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.label2);
            this.gbEdit.Controls.Add(this.btnDone);
            this.gbEdit.Controls.Add(this.label10);
            this.gbEdit.Controls.Add(this.txtCredit);
            this.gbEdit.Controls.Add(this.label9);
            this.gbEdit.Controls.Add(this.txtLastname);
            this.gbEdit.Controls.Add(this.label8);
            this.gbEdit.Controls.Add(this.txtUsername);
            this.gbEdit.Controls.Add(this.label7);
            this.gbEdit.Controls.Add(this.txtPassword);
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Location = new System.Drawing.Point(561, 157);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(312, 281);
            this.gbEdit.TabIndex = 27;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit info";
            this.gbEdit.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(97, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 46);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = ".........";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsers);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsers.Location = new System.Drawing.Point(96, 43);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(76, 59);
            this.lblUsers.TabIndex = 29;
            this.lblUsers.Text = "...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.computer_icons_person_user_download_alumni_2d156fd3327b5e5ef2340ce4c6214549__1_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 93);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 125);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total sales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.kisspng_dollar_sign_united_states_dollar_computer_icons_dollar_signs_5b477c76c36395_5218027515314115748003__2_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalBookSold);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(207, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 125);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total book sold";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.clipart2163491__1_;
            this.pictureBox3.Location = new System.Drawing.Point(6, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 94);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBookCount);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Location = new System.Drawing.Point(690, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 125);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book count";
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::UI.Properties.Resources.pngwing_com__1_;
            this.pictureBox4.Image = global::UI.Properties.Resources.pngwing1;
            this.pictureBox4.Location = new System.Drawing.Point(10, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 94);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.lvUsers);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvUsers;
        private ColumnHeader clmUsername;
        private ColumnHeader clmName;
        private ColumnHeader clmLastname;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblLatsname;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblCredit;
        private Label lblName;
        private Button btnEdit;
        private Button btnDelete;
        private GroupBox gbUserInfo;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtLastname;
        private TextBox txtCredit;
        private Button btnDone;
        private GroupBox gbEdit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblTotal;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Label lblUsers;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblTotalBookSold;
        private GroupBox groupBox4;
        private Label lblBookCount;
        private PictureBox pictureBox4;
    }
}