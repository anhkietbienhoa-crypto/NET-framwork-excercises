namespace WindowsForms1
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
            this.KeyPressLabel = new System.Windows.Forms.Label();
            this.KeyPressLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyPressLabel
            // 
            this.KeyPressLabel.AutoSize = true;
            this.KeyPressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPressLabel.Location = new System.Drawing.Point(530, 212);
            this.KeyPressLabel.Name = "KeyPressLabel";
            this.KeyPressLabel.Size = new System.Drawing.Size(92, 32);
            this.KeyPressLabel.TabIndex = 0;
            this.KeyPressLabel.Text = "label1";
            // 
            // KeyPressLabel1
            // 
            this.KeyPressLabel1.AutoSize = true;
            this.KeyPressLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPressLabel1.Location = new System.Drawing.Point(530, 275);
            this.KeyPressLabel1.Name = "KeyPressLabel1";
            this.KeyPressLabel1.Size = new System.Drawing.Size(92, 32);
            this.KeyPressLabel1.TabIndex = 1;
            this.KeyPressLabel1.Text = "label2";
            this.KeyPressLabel1.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KeyPressLabel1);
            this.Controls.Add(this.KeyPressLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyPressLabel;
        private System.Windows.Forms.Label KeyPressLabel1;
        private System.Windows.Forms.Button button1;
    }
}

