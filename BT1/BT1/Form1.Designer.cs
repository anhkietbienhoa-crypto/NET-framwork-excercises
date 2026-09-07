namespace BT1
{
    partial class mainform
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
            this.InPutPass = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Showme = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InPutPass
            // 
            this.InPutPass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InPutPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InPutPass.Location = new System.Drawing.Point(211, 140);
            this.InPutPass.Name = "InPutPass";
            this.InPutPass.Size = new System.Drawing.Size(373, 30);
            this.InPutPass.TabIndex = 0;
            this.InPutPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(211, 87);
            this.Input.Name = "Input";
            this.Input.PasswordChar = '#';
            this.Input.Size = new System.Drawing.Size(373, 30);
            this.Input.TabIndex = 1;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.UseSystemPasswordChar = true;
            // 
            // Showme
            // 
            this.Showme.Dock = System.Windows.Forms.DockStyle.Left;
            this.Showme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showme.Location = new System.Drawing.Point(0, 0);
            this.Showme.Name = "Showme";
            this.Showme.Size = new System.Drawing.Size(202, 450);
            this.Showme.TabIndex = 2;
            this.Showme.Text = " Show me ";
            this.Showme.UseVisualStyleBackColor = true;
            this.Showme.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(598, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(202, 450);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainform
            // 
            this.AcceptButton = this.Showme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Showme);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.InPutPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.Text = "Label TextBox Button";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InPutPass;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Showme;
        private System.Windows.Forms.Button Exit;
    }
}

