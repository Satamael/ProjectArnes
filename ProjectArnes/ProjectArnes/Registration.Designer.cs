namespace ProjectArnes
{
    partial class Registration
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
            this.textBoxLogin.Location = new System.Drawing.Point(159, 13);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 22);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.WordWrap = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(159, 51);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Location = new System.Drawing.Point(159, 79);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.Size = new System.Drawing.Size(154, 22);
            this.textBoxRePassword.TabIndex = 2;
            this.textBoxRePassword.TextChanged += new System.EventHandler(this.textBoxRePassword_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(159, 107);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(154, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPromo
            // 
            this.textBoxPromo.Location = new System.Drawing.Point(159, 148);
            this.textBoxPromo.Name = "textBoxPromo";
            this.textBoxPromo.Size = new System.Drawing.Size(154, 22);
            this.textBoxPromo.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AccessibleDescription = "";
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 18);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 56);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Location = new System.Drawing.Point(12, 84);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(130, 17);
            this.labelRePassword.TabIndex = 5;
            this.labelRePassword.Text = "Повторите пароль";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 112);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.Location = new System.Drawing.Point(12, 153);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(74, 17);
            this.labelPromo.TabIndex = 5;
            this.labelPromo.Text = "Промокод";
            // 
            // buttonRegistrationEnd
            // 
            this.buttonRegistrationEnd.Location = new System.Drawing.Point(68, 197);
            this.buttonRegistrationEnd.Name = "buttonRegistrationEnd";
            this.buttonRegistrationEnd.Size = new System.Drawing.Size(187, 37);
            this.buttonRegistrationEnd.TabIndex = 6;
            this.buttonRegistrationEnd.Text = "Зарегистрироваться";
            this.buttonRegistrationEnd.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
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
            this.Name = "Registration";
            this.Text = "Registration";
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