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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_find_password = new System.Windows.Forms.Button();
            this.btn_serial_key = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_db = new System.Windows.Forms.Button();
            this.btn_http_requests = new System.Windows.Forms.Button();
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
            // btn_login_db
            // 
            this.btn_login_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_db.Location = new System.Drawing.Point(18, 124);
            this.btn_login_db.Name = "btn_login_db";
            this.btn_login_db.Size = new System.Drawing.Size(246, 65);
            this.btn_login_db.TabIndex = 3;
            this.btn_login_db.Text = "Database";
            this.btn_login_db.UseVisualStyleBackColor = true;
            this.btn_login_db.Click += new System.EventHandler(this.btn_login_db_Click);
            // 
            // btn_http_requests
            // 
            this.btn_http_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_http_requests.Location = new System.Drawing.Point(270, 124);
            this.btn_http_requests.Name = "btn_http_requests";
            this.btn_http_requests.Size = new System.Drawing.Size(246, 65);
            this.btn_http_requests.TabIndex = 4;
            this.btn_http_requests.Text = "Http Request";
            this.btn_http_requests.UseVisualStyleBackColor = true;
            this.btn_http_requests.Click += new System.EventHandler(this.btn_http_requests_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 203);
            this.Controls.Add(this.btn_http_requests);
            this.Controls.Add(this.btn_login_db);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_serial_key);
            this.Controls.Add(this.btn_find_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_find_password;
        private System.Windows.Forms.Button btn_serial_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_db;
        private System.Windows.Forms.Button btn_http_requests;
    }
}