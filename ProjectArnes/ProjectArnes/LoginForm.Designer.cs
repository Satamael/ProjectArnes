namespace ProjectArnes
{
    partial class LoginForm
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
            this.textBoxLoginInput = new System.Windows.Forms.TextBox();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLoginInput
            // 
            this.textBoxLoginInput.Location = new System.Drawing.Point(47, 56);
            this.textBoxLoginInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLoginInput.Name = "textBoxLoginInput";
            this.textBoxLoginInput.Size = new System.Drawing.Size(146, 20);
            this.textBoxLoginInput.TabIndex = 0;
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Location = new System.Drawing.Point(47, 89);
            this.textBoxPasswordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(146, 20);
            this.textBoxPasswordInput.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(136, 112);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(56, 24);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(47, 112);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(82, 24);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 207);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.textBoxLoginInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginInput;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReg;
    }
}