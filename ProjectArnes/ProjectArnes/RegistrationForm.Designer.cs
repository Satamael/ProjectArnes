namespace ProjectArnes
{
    partial class RegistrationForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPromo = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRePassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPromo = new System.Windows.Forms.Label();
            this.buttonRegistrationEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(119, 11);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(116, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.WordWrap = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(119, 41);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(116, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Location = new System.Drawing.Point(119, 64);
            this.textBoxRePassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.Size = new System.Drawing.Size(116, 20);
            this.textBoxRePassword.TabIndex = 2;
            this.textBoxRePassword.TextChanged += new System.EventHandler(this.textBoxRePassword_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(119, 87);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(116, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPromo
            // 
            this.textBoxPromo.Location = new System.Drawing.Point(119, 120);
            this.textBoxPromo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPromo.Name = "textBoxPromo";
            this.textBoxPromo.Size = new System.Drawing.Size(116, 20);
            this.textBoxPromo.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AccessibleDescription = "";
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(9, 15);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 46);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Location = new System.Drawing.Point(9, 68);
            this.labelRePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(100, 13);
            this.labelRePassword.TabIndex = 5;
            this.labelRePassword.Text = "Повторите пароль";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 91);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.Location = new System.Drawing.Point(9, 124);
            this.labelPromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(59, 13);
            this.labelPromo.TabIndex = 5;
            this.labelPromo.Text = "Промокод";
            // 
            // buttonRegistrationEnd
            // 
            this.buttonRegistrationEnd.Location = new System.Drawing.Point(51, 160);
            this.buttonRegistrationEnd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrationEnd.Name = "buttonRegistrationEnd";
            this.buttonRegistrationEnd.Size = new System.Drawing.Size(140, 30);
            this.buttonRegistrationEnd.TabIndex = 6;
            this.buttonRegistrationEnd.Text = "Зарегистрироваться";
            this.buttonRegistrationEnd.UseVisualStyleBackColor = true;
            this.buttonRegistrationEnd.Click += new System.EventHandler(this.buttonRegistrationEnd_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 207);
            this.Controls.Add(this.buttonRegistrationEnd);
            this.Controls.Add(this.labelPromo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelRePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPromo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxRePassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPromo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRePassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPromo;
        private System.Windows.Forms.Button buttonRegistrationEnd;
    }
}