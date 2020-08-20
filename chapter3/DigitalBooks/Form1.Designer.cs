namespace DigitalBooks
{
    partial class MainForm
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
            this.DigitalPicBox = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.btnEBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblThankYou = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DigitalPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DigitalPicBox
            // 
            this.DigitalPicBox.Location = new System.Drawing.Point(353, 164);
            this.DigitalPicBox.Name = "DigitalPicBox";
            this.DigitalPicBox.Size = new System.Drawing.Size(454, 482);
            this.DigitalPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DigitalPicBox.TabIndex = 0;
            this.DigitalPicBox.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(491, 734);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(178, 85);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.Color.Black;
            this.btnAudio.Location = new System.Drawing.Point(207, 734);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(178, 85);
            this.btnAudio.TabIndex = 2;
            this.btnAudio.Text = "Audio";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // btnEBook
            // 
            this.btnEBook.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBook.ForeColor = System.Drawing.Color.Black;
            this.btnEBook.Location = new System.Drawing.Point(775, 734);
            this.btnEBook.Name = "btnEBook";
            this.btnEBook.Size = new System.Drawing.Size(178, 85);
            this.btnEBook.TabIndex = 3;
            this.btnEBook.Text = "eBook";
            this.btnEBook.UseVisualStyleBackColor = true;
            this.btnEBook.Click += new System.EventHandler(this.btnEBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(491, 909);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 85);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(411, 28);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 75);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Digital Books";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(362, 664);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(436, 41);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Please select a Digital Book";
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(362, 840);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(453, 41);
            this.lblThankYou.TabIndex = 7;
            this.lblThankYou.Text = "Thank you for your selection";
            this.lblThankYou.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1160, 1147);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEBook);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.DigitalPicBox);
            this.Name = "MainForm";
            this.Text = "Digital Books";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DigitalPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DigitalPicBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnEBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblThankYou;
    }
}

