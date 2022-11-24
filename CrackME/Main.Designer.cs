namespace CrackME
{
    partial class Main
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
            this.btn_find_password = new System.Windows.Forms.Button();
            this.btn_serial_key = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_find_password
            // 
            this.btn_find_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_password.Location = new System.Drawing.Point(18, 53);
            this.btn_find_password.Name = "btn_find_password";
            this.btn_find_password.Size = new System.Drawing.Size(246, 65);
            this.btn_find_password.TabIndex = 0;
            this.btn_find_password.Text = "Find Password";
            this.btn_find_password.UseVisualStyleBackColor = true;
            this.btn_find_password.Click += new System.EventHandler(this.btn_find_password_Click);
            // 
            // btn_serial_key
            // 
            this.btn_serial_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serial_key.Location = new System.Drawing.Point(270, 53);
            this.btn_serial_key.Name = "btn_serial_key";
            this.btn_serial_key.Size = new System.Drawing.Size(246, 65);
            this.btn_serial_key.TabIndex = 1;
            this.btn_serial_key.Text = "Serial Key";
            this.btn_serial_key.UseVisualStyleBackColor = true;
            this.btn_serial_key.Click += new System.EventHandler(this.btn_serial_key_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_serial_key);
            this.Controls.Add(this.btn_find_password);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_find_password;
        private System.Windows.Forms.Button btn_serial_key;
        private System.Windows.Forms.Label label1;
    }
}