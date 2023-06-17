namespace UI
{
    partial class ChargeCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your credit:";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredit.Location = new System.Drawing.Point(230, 70);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(65, 28);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "Credit";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(72, 194);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(125, 27);
            this.txtbxAmount.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Charge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(72, 160);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(237, 20);
            this.lblEmpty.TabIndex = 4;
            this.lblEmpty.Text = "Amount of credi can not be empty";
            this.lblEmpty.Visible = false;
            // 
            // ChargeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 305);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxAmount);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.label1);
            this.Name = "ChargeCredit";
            this.Text = "ChargeCredit";
            this.Load += new System.EventHandler(this.ChargeCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblCredit;
        private TextBox txtbxAmount;
        private Button button1;
        private Label lblEmpty;
    }
}