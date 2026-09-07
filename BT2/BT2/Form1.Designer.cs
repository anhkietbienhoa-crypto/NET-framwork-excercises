namespace BT2
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
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.checkStrikeout = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkUnderline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBold.Location = new System.Drawing.Point(78, 260);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(94, 36);
            this.checkBold.TabIndex = 0;
            this.checkBold.Text = "Bold";
            this.checkBold.UseVisualStyleBackColor = true;
            this.checkBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkStrikeout
            // 
            this.checkStrikeout.AutoSize = true;
            this.checkStrikeout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStrikeout.Location = new System.Drawing.Point(546, 260);
            this.checkStrikeout.Name = "checkStrikeout";
            this.checkStrikeout.Size = new System.Drawing.Size(140, 37);
            this.checkStrikeout.TabIndex = 1;
            this.checkStrikeout.Text = "Strikeout";
            this.checkStrikeout.UseVisualStyleBackColor = true;
            this.checkStrikeout.CheckedChanged += new System.EventHandler(this.checkStrikeout_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 207);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Font";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkUnderline
            // 
            this.checkUnderline.AutoSize = true;
            this.checkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnderline.Location = new System.Drawing.Point(284, 260);
            this.checkUnderline.Name = "checkUnderline";
            this.checkUnderline.Size = new System.Drawing.Size(159, 36);
            this.checkUnderline.TabIndex = 3;
            this.checkUnderline.Text = "Underline";
            this.checkUnderline.UseVisualStyleBackColor = true;
            this.checkUnderline.CheckedChanged += new System.EventHandler(this.checkUnderline_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkUnderline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkStrikeout);
            this.Controls.Add(this.checkBold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.CheckBox checkStrikeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkUnderline;
    }
}

