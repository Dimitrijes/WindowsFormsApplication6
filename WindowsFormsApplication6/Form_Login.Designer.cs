namespace WindowsFormsApplication6
{
    partial class Form_Login
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_korisnicko_ime = new System.Windows.Forms.Label();
            this.bt_enter = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Controls.Add(this.Label_korisnicko_ime);
            this.gb_login.Controls.Add(this.bt_enter);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Location = new System.Drawing.Point(12, 12);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(260, 237);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // Label_korisnicko_ime
            // 
            this.Label_korisnicko_ime.AutoSize = true;
            this.Label_korisnicko_ime.Location = new System.Drawing.Point(6, 40);
            this.Label_korisnicko_ime.Name = "Label_korisnicko_ime";
            this.Label_korisnicko_ime.Size = new System.Drawing.Size(75, 13);
            this.Label_korisnicko_ime.TabIndex = 3;
            this.Label_korisnicko_ime.Text = "Korisnicko ime";
            // 
            // bt_enter
            // 
            this.bt_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_enter.Location = new System.Drawing.Point(9, 142);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(245, 46);
            this.bt_enter.TabIndex = 2;
            this.bt_enter.Text = "&Enter";
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(116, 107);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(138, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_username
            // 
            this.tb_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tb_username.Location = new System.Drawing.Point(116, 37);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(138, 20);
            this.tb_username.TabIndex = 0;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gb_login);
            this.Name = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_korisnicko_ime;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
    }
}

