namespace UI
{
    partial class InsertNewBook
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
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWriter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTranslator = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pbBookCover = new System.Windows.Forms.PictureBox();
            this.btnRegistor = new System.Windows.Forms.Button();
            this.btnInserCover = new System.Windows.Forms.Button();
            this.lblBookCover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(119, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(249, 20);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "character must be between 6 and 20";
            this.lblName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Book name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 27);
            this.txtName.TabIndex = 20;
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.ForeColor = System.Drawing.Color.Red;
            this.lblWriter.Location = new System.Drawing.Point(119, 142);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(249, 20);
            this.lblWriter.TabIndex = 25;
            this.lblWriter.Text = "character must be between 6 and 20";
            this.lblWriter.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Writer";
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(119, 112);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(205, 27);
            this.txtWriter.TabIndex = 23;
            // 
            // lblTranslator
            // 
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.ForeColor = System.Drawing.Color.Red;
            this.lblTranslator.Location = new System.Drawing.Point(119, 213);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(249, 20);
            this.lblTranslator.TabIndex = 28;
            this.lblTranslator.Text = "character must be between 6 and 20";
            this.lblTranslator.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Translator";
            // 
            // txtTranslator
            // 
            this.txtTranslator.Location = new System.Drawing.Point(119, 183);
            this.txtTranslator.Name = "txtTranslator";
            this.txtTranslator.Size = new System.Drawing.Size(205, 27);
            this.txtTranslator.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 256);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(82, 27);
            this.txtPrice.TabIndex = 29;
            // 
            // pbBookCover
            // 
            this.pbBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBookCover.Location = new System.Drawing.Point(511, 40);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.Size = new System.Drawing.Size(220, 280);
            this.pbBookCover.TabIndex = 31;
            this.pbBookCover.TabStop = false;
            // 
            // btnRegistor
            // 
            this.btnRegistor.Location = new System.Drawing.Point(168, 327);
            this.btnRegistor.Name = "btnRegistor";
            this.btnRegistor.Size = new System.Drawing.Size(94, 29);
            this.btnRegistor.TabIndex = 33;
            this.btnRegistor.Text = "Registor";
            this.btnRegistor.UseVisualStyleBackColor = true;
            this.btnRegistor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserCover
            // 
            this.btnInserCover.Location = new System.Drawing.Point(580, 327);
            this.btnInserCover.Name = "btnInserCover";
            this.btnInserCover.Size = new System.Drawing.Size(94, 29);
            this.btnInserCover.TabIndex = 34;
            this.btnInserCover.Text = "Book cover";
            this.btnInserCover.UseVisualStyleBackColor = true;
            this.btnInserCover.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBookCover
            // 
            this.lblBookCover.AutoSize = true;
            this.lblBookCover.ForeColor = System.Drawing.Color.Red;
            this.lblBookCover.Location = new System.Drawing.Point(522, 359);
            this.lblBookCover.Name = "lblBookCover";
            this.lblBookCover.Size = new System.Drawing.Size(203, 20);
            this.lblBookCover.TabIndex = 35;
            this.lblBookCover.Text = "Book cover can not be empty";
            this.lblBookCover.Visible = false;
            // 
            // InsertNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBookCover);
            this.Controls.Add(this.btnInserCover);
            this.Controls.Add(this.btnRegistor);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblTranslator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTranslator);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Name = "InsertNewBook";
            this.Text = "InsertNewBook";
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label label7;
        private TextBox txtName;
        private Label lblWriter;
        private Label label9;
        private TextBox txtWriter;
        private Label lblTranslator;
        private Label label11;
        private TextBox txtTranslator;
        private Label label13;
        private TextBox txtPrice;
        private PictureBox pbBookCover;
        private Button btnRegistor;
        private Button btnInserCover;
        private Label lblBookCover;
    }
}