namespace ProjectArnes
{
    partial class UserControlCharacter
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSTR = new System.Windows.Forms.Label();
            this.labelMG = new System.Windows.Forms.Label();
            this.labelCR = new System.Windows.Forms.Label();
            this.labelDEX = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGender = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeland = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelTalants = new System.Windows.Forms.TableLayoutPanel();
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeland)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(110, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(104, 27);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(51, 13);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Таланты";
            // 
            // labelSTR
            // 
            this.labelSTR.AutoSize = true;
            this.labelSTR.Location = new System.Drawing.Point(261, 27);
            this.labelSTR.Name = "labelSTR";
            this.labelSTR.Size = new System.Drawing.Size(32, 13);
            this.labelSTR.TabIndex = 2;
            this.labelSTR.Text = "Сила";
            // 
            // labelMG
            // 
            this.labelMG.AutoSize = true;
            this.labelMG.Location = new System.Drawing.Point(261, 53);
            this.labelMG.Name = "labelMG";
            this.labelMG.Size = new System.Drawing.Size(39, 13);
            this.labelMG.TabIndex = 2;
            this.labelMG.Text = "Магия";
            // 
            // labelCR
            // 
            this.labelCR.AutoSize = true;
            this.labelCR.Location = new System.Drawing.Point(344, 53);
            this.labelCR.Name = "labelCR";
            this.labelCR.Size = new System.Drawing.Size(52, 13);
            this.labelCR.TabIndex = 2;
            this.labelCR.Text = "Харизма";
            // 
            // labelDEX
            // 
            this.labelDEX.AutoSize = true;
            this.labelDEX.Location = new System.Drawing.Point(344, 27);
            this.labelDEX.Name = "labelDEX";
            this.labelDEX.Size = new System.Drawing.Size(56, 13);
            this.labelDEX.TabIndex = 2;
            this.labelDEX.Text = "Ловкость";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(113, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxGender
            // 
            this.pictureBoxGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGender.Location = new System.Drawing.Point(159, 43);
            this.pictureBoxGender.Name = "pictureBoxGender";
            this.pictureBoxGender.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGender.TabIndex = 3;
            this.pictureBoxGender.TabStop = false;
            // 
            // pictureBoxHomeland
            // 
            this.pictureBoxHomeland.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHomeland.Location = new System.Drawing.Point(209, 43);
            this.pictureBoxHomeland.Name = "pictureBoxHomeland";
            this.pictureBoxHomeland.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxHomeland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHomeland.TabIndex = 3;
            this.pictureBoxHomeland.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фракция";
            // 
            // tableLayoutPanelTalants
            // 
            this.tableLayoutPanelTalants.ColumnCount = 2;
            this.tableLayoutPanelTalants.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTalants.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTalants.Location = new System.Drawing.Point(103, 43);
            this.tableLayoutPanelTalants.Name = "tableLayoutPanelTalants";
            this.tableLayoutPanelTalants.RowCount = 2;
            this.tableLayoutPanelTalants.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTalants.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTalants.Size = new System.Drawing.Size(50, 50);
            this.tableLayoutPanelTalants.TabIndex = 4;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(206, 86);
            this.labelHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(35, 13);
            this.labelHome.TabIndex = 6;
            this.labelHome.Text = "label4";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(347, 75);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 7;
            this.buttonChoose.Text = "Выбрать";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // UserControlCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.tableLayoutPanelTalants);
            this.Controls.Add(this.pictureBoxHomeland);
            this.Controls.Add(this.pictureBoxGender);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelDEX);
            this.Controls.Add(this.labelCR);
            this.Controls.Add(this.labelMG);
            this.Controls.Add(this.labelSTR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "UserControlCharacter";
            this.Size = new System.Drawing.Size(429, 103);
            this.Load += new System.EventHandler(this.UserControlCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelSTR;
        private System.Windows.Forms.Label labelMG;
        private System.Windows.Forms.Label labelCR;
        private System.Windows.Forms.Label labelDEX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxGender;
        private System.Windows.Forms.PictureBox pictureBoxHomeland;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTalants;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button buttonChoose;
    }
}
