namespace AirLineApp
{
    partial class CancelWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelWindow));
            this.cancelGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.noButton = new System.Windows.Forms.Button();
            this.cancelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelGroupBox
            // 
            this.cancelGroupBox.BackColor = System.Drawing.Color.Black;
            this.cancelGroupBox.Controls.Add(this.pictureBox1);
            this.cancelGroupBox.Controls.Add(this.noButton);
            this.cancelGroupBox.Controls.Add(this.cancelTextBox);
            this.cancelGroupBox.Controls.Add(this.label1);
            this.cancelGroupBox.Controls.Add(this.yesButton);
            this.cancelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelGroupBox.ForeColor = System.Drawing.Color.White;
            this.cancelGroupBox.Location = new System.Drawing.Point(47, 64);
            this.cancelGroupBox.Name = "cancelGroupBox";
            this.cancelGroupBox.Size = new System.Drawing.Size(364, 421);
            this.cancelGroupBox.TabIndex = 7;
            this.cancelGroupBox.TabStop = false;
            this.cancelGroupBox.Text = "Are You Sure to Cancel Flight?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 230);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Black;
            this.noButton.Image = ((System.Drawing.Image)(resources.GetObject("noButton.Image")));
            this.noButton.Location = new System.Drawing.Point(194, 352);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(89, 40);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "NO";
            this.noButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // cancelTextBox
            // 
            this.cancelTextBox.BackColor = System.Drawing.Color.White;
            this.cancelTextBox.ForeColor = System.Drawing.Color.Black;
            this.cancelTextBox.Location = new System.Drawing.Point(196, 50);
            this.cancelTextBox.Multiline = true;
            this.cancelTextBox.Name = "cancelTextBox";
            this.cancelTextBox.Size = new System.Drawing.Size(100, 32);
            this.cancelTextBox.TabIndex = 5;
            this.cancelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Seat No :";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Black;
            this.yesButton.Image = ((System.Drawing.Image)(resources.GetObject("yesButton.Image")));
            this.yesButton.Location = new System.Drawing.Point(51, 352);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(92, 40);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "YES";
            this.yesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "BANGLADESH INTERNATIONAL AIRLINES";
            // 
            // CancelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(458, 497);
            this.Controls.Add(this.cancelGroupBox);
            this.Controls.Add(this.label2);
            this.Name = "CancelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANCEL FLIGHT";
            this.cancelGroupBox.ResumeLayout(false);
            this.cancelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cancelGroupBox;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.TextBox cancelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}