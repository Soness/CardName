namespace WindowsFormsApp6
{
    partial class Form1
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
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.templateImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.PictureBox();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImage
            // 
            this.sourceImage.Location = new System.Drawing.Point(12, 12);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(990, 617);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceImage.TabIndex = 0;
            this.sourceImage.TabStop = false;
            // 
            // templateImage
            // 
            this.templateImage.Location = new System.Drawing.Point(1037, 12);
            this.templateImage.Name = "templateImage";
            this.templateImage.Size = new System.Drawing.Size(179, 124);
            this.templateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.templateImage.TabIndex = 1;
            this.templateImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1037, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(1037, 161);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(179, 50);
            this.textImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textImage.TabIndex = 4;
            this.textImage.TabStop = false;
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameLabel.Location = new System.Drawing.Point(1053, 214);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(0, 19);
            this.CardNameLabel.TabIndex = 5;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionLabel.Location = new System.Drawing.Point(1032, 357);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(0, 25);
            this.positionLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 753);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.textImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.templateImage);
            this.Controls.Add(this.sourceImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.PictureBox templateImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox textImage;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.Label positionLabel;
    }
}

