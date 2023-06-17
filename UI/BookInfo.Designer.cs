namespace UI
{
    partial class BookInfo
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
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.Writer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblNotEnough = new System.Windows.Forms.Label();
            this.lblAlreadyBuy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(325, 81);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(220, 280);
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(399, 37);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(80, 20);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Bookname";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(325, 374);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(220, 49);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Writer
            // 
            this.Writer.AutoSize = true;
            this.Writer.Location = new System.Drawing.Point(44, 81);
            this.Writer.Name = "Writer";
            this.Writer.Size = new System.Drawing.Size(57, 20);
            this.Writer.TabIndex = 3;
            this.Writer.Text = "Writer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Translator: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(98, 219);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Translator: ";
            // 
            // lblTranslator
            // 
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.Location = new System.Drawing.Point(122, 146);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(81, 20);
            this.lblTranslator.TabIndex = 8;
            this.lblTranslator.Text = "Translator: ";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(98, 81);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(81, 20);
            this.lblWriter.TabIndex = 9;
            this.lblWriter.Text = "Translator: ";
            // 
            // lblNotEnough
            // 
            this.lblNotEnough.AutoSize = true;
            this.lblNotEnough.ForeColor = System.Drawing.Color.Red;
            this.lblNotEnough.Location = new System.Drawing.Point(373, 426);
            this.lblNotEnough.Name = "lblNotEnough";
            this.lblNotEnough.Size = new System.Drawing.Size(130, 20);
            this.lblNotEnough.TabIndex = 10;
            this.lblNotEnough.Text = "Not enough credit";
            this.lblNotEnough.Visible = false;
            // 
            // lblAlreadyBuy
            // 
            this.lblAlreadyBuy.AutoSize = true;
            this.lblAlreadyBuy.ForeColor = System.Drawing.Color.Blue;
            this.lblAlreadyBuy.Location = new System.Drawing.Point(306, 375);
            this.lblAlreadyBuy.Name = "lblAlreadyBuy";
            this.lblAlreadyBuy.Size = new System.Drawing.Size(261, 20);
            this.lblAlreadyBuy.TabIndex = 11;
            this.lblAlreadyBuy.Text = "This book has already been purchased";
            this.lblAlreadyBuy.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "🔙";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlreadyBuy);
            this.Controls.Add(this.lblNotEnough);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.lblTranslator);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Writer);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pbCover);
            this.Name = "BookInfo";
            this.Text = "BookInfo";
            this.Load += new System.EventHandler(this.BookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbCover = new();
        private Label lblBookName = new();
        private Button btnBuy;
        private Label Writer = new();
        private Label label3;
        private Label label5;
        private Label lblPrice = new();
        private Label lblTranslator = new();
        private Label lblWriter = new();
        private Label lblNotEnough;
        private Label lblAlreadyBuy;
        private Button button1;
    }
}