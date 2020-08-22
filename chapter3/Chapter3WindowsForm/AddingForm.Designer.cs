namespace WindowsFormsApp1
{
    partial class AdditionForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddend1 = new System.Windows.Forms.Label();
            this.lblAddend2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(97, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Click to Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddend1
            // 
            this.lblAddend1.AutoSize = true;
            this.lblAddend1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddend1.Location = new System.Drawing.Point(93, 73);
            this.lblAddend1.Name = "lblAddend1";
            this.lblAddend1.Size = new System.Drawing.Size(102, 20);
            this.lblAddend1.TabIndex = 1;
            this.lblAddend1.Text = "Enter a Number";
            // 
            // lblAddend2
            // 
            this.lblAddend2.AutoSize = true;
            this.lblAddend2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddend2.Location = new System.Drawing.Point(93, 129);
            this.lblAddend2.Name = "lblAddend2";
            this.lblAddend2.Size = new System.Drawing.Size(141, 20);
            this.lblAddend2.TabIndex = 2;
            this.lblAddend2.Text = "Enter Another Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(254, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(254, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(273, 200);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(81, 20);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "XXXXXXXXX";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSum.Visible = false;
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 518);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAddend2);
            this.Controls.Add(this.lblAddend1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdditionForm";
            this.Text = "Addition Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddend1;
        private System.Windows.Forms.Label lblAddend2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSum;
    }
}

