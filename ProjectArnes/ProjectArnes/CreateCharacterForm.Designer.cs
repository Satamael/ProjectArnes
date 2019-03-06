namespace ProjectArnes
{
    partial class CreateCharacterForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBoxPoint = new System.Windows.Forms.PictureBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelСharakter = new System.Windows.Forms.Label();
            this.labelMagic = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFamale = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFraction = new System.Windows.Forms.Label();
            this.radioButtonVesk = new System.Windows.Forms.RadioButton();
            this.radioButtonFaro = new System.Windows.Forms.RadioButton();
            this.radioButtonArnes = new System.Windows.Forms.RadioButton();
            this.pictureBoxFraction = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMagicSkills = new System.Windows.Forms.Label();
            this.pictureBoxClassChar = new System.Windows.Forms.PictureBox();
            this.checkedListBoxCharClass = new System.Windows.Forms.CheckedListBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.panelChoose = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoint)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFraction)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassChar)).BeginInit();
            this.panelChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(269, 543);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBoxPoint
            // 
            this.pictureBoxPoint.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoint.BackgroundImage = global::ProjectArnes.Properties.Resources.Choose;
            this.pictureBoxPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPoint.Location = new System.Drawing.Point(75, 81);
            this.pictureBoxPoint.Name = "pictureBoxPoint";
            this.pictureBoxPoint.Size = new System.Drawing.Size(19, 20);
            this.pictureBoxPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPoint.TabIndex = 6;
            this.pictureBoxPoint.TabStop = false;
            this.pictureBoxPoint.Click += new System.EventHandler(this.pictureBoxPoint_Click);
            this.pictureBoxPoint.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxPoint_DragDrop);
            this.pictureBoxPoint.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxPoint_DragEnter);
            this.pictureBoxPoint.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBoxPoint_DragEnter);
            this.pictureBoxPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPoint_MouseMove);
            this.pictureBoxPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPoint_MouseUp);
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(214, 319);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(32, 13);
            this.labelHP.TabIndex = 7;
            this.labelHP.Text = "Сила";
            // 
            // labelСharakter
            // 
            this.labelСharakter.AutoSize = true;
            this.labelСharakter.Location = new System.Drawing.Point(214, 406);
            this.labelСharakter.Name = "labelСharakter";
            this.labelСharakter.Size = new System.Drawing.Size(52, 13);
            this.labelСharakter.TabIndex = 7;
            this.labelСharakter.Text = "Харизма";
            // 
            // labelMagic
            // 
            this.labelMagic.AutoSize = true;
            this.labelMagic.Location = new System.Drawing.Point(214, 345);
            this.labelMagic.Name = "labelMagic";
            this.labelMagic.Size = new System.Drawing.Size(39, 13);
            this.labelMagic.TabIndex = 7;
            this.labelMagic.Text = "Магия";
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Location = new System.Drawing.Point(214, 375);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(56, 13);
            this.labelDex.TabIndex = 7;
            this.labelDex.Text = "Ловкость";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(33, 50);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMale.TabIndex = 11;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFamale
            // 
            this.radioButtonFamale.AutoSize = true;
            this.radioButtonFamale.Location = new System.Drawing.Point(117, 50);
            this.radioButtonFamale.Name = "radioButtonFamale";
            this.radioButtonFamale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFamale.TabIndex = 11;
            this.radioButtonFamale.TabStop = true;
            this.radioButtonFamale.Text = "Женский";
            this.radioButtonFamale.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.radioButtonFamale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Controls.Add(this.buttonAva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 88);
            this.panel1.TabIndex = 13;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(2, 22);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 13;
            this.LabelName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пол";
            // 
            // buttonAva
            // 
            this.buttonAva.Location = new System.Drawing.Point(256, 22);
            this.buttonAva.Name = "buttonAva";
            this.buttonAva.Size = new System.Drawing.Size(85, 50);
            this.buttonAva.TabIndex = 7;
            this.buttonAva.Text = "Загрузить свою аватарку";
            this.buttonAva.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFraction);
            this.panel2.Controls.Add(this.radioButtonVesk);
            this.panel2.Controls.Add(this.radioButtonFaro);
            this.panel2.Controls.Add(this.radioButtonArnes);
            this.panel2.Controls.Add(this.pictureBoxFraction);
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 100);
            this.panel2.TabIndex = 14;
            // 
            // labelFraction
            // 
            this.labelFraction.AutoSize = true;
            this.labelFraction.Location = new System.Drawing.Point(2, 20);
            this.labelFraction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFraction.Name = "labelFraction";
            this.labelFraction.Size = new System.Drawing.Size(44, 13);
            this.labelFraction.TabIndex = 11;
            this.labelFraction.Text = "Родина";
            // 
            // radioButtonVesk
            // 
            this.radioButtonVesk.AutoSize = true;
            this.radioButtonVesk.Location = new System.Drawing.Point(155, 65);
            this.radioButtonVesk.Name = "radioButtonVesk";
            this.radioButtonVesk.Size = new System.Drawing.Size(50, 17);
            this.radioButtonVesk.TabIndex = 10;
            this.radioButtonVesk.TabStop = true;
            this.radioButtonVesk.Text = "Веск";
            this.radioButtonVesk.UseVisualStyleBackColor = true;
            // 
            // radioButtonFaro
            // 
            this.radioButtonFaro.AutoSize = true;
            this.radioButtonFaro.Location = new System.Drawing.Point(155, 42);
            this.radioButtonFaro.Name = "radioButtonFaro";
            this.radioButtonFaro.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFaro.TabIndex = 9;
            this.radioButtonFaro.TabStop = true;
            this.radioButtonFaro.Text = "Фаро";
            this.radioButtonFaro.UseVisualStyleBackColor = true;
            // 
            // radioButtonArnes
            // 
            this.radioButtonArnes.AutoSize = true;
            this.radioButtonArnes.Location = new System.Drawing.Point(155, 18);
            this.radioButtonArnes.Name = "radioButtonArnes";
            this.radioButtonArnes.Size = new System.Drawing.Size(56, 17);
            this.radioButtonArnes.TabIndex = 8;
            this.radioButtonArnes.TabStop = true;
            this.radioButtonArnes.Text = "Арнес";
            this.radioButtonArnes.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFraction
            // 
            this.pictureBoxFraction.Location = new System.Drawing.Point(62, 5);
            this.pictureBoxFraction.Name = "pictureBoxFraction";
            this.pictureBoxFraction.Size = new System.Drawing.Size(84, 89);
            this.pictureBoxFraction.TabIndex = 6;
            this.pictureBoxFraction.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelMagicSkills);
            this.panel3.Controls.Add(this.pictureBoxClassChar);
            this.panel3.Controls.Add(this.checkedListBoxCharClass);
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 123);
            this.panel3.TabIndex = 15;
            // 
            // labelMagicSkills
            // 
            this.labelMagicSkills.AutoSize = true;
            this.labelMagicSkills.Location = new System.Drawing.Point(2, 6);
            this.labelMagicSkills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMagicSkills.Name = "labelMagicSkills";
            this.labelMagicSkills.Size = new System.Drawing.Size(51, 13);
            this.labelMagicSkills.TabIndex = 6;
            this.labelMagicSkills.Text = "Таланты";
            // 
            // pictureBoxClassChar
            // 
            this.pictureBoxClassChar.Location = new System.Drawing.Point(62, 6);
            this.pictureBoxClassChar.Name = "pictureBoxClassChar";
            this.pictureBoxClassChar.Size = new System.Drawing.Size(84, 95);
            this.pictureBoxClassChar.TabIndex = 5;
            this.pictureBoxClassChar.TabStop = false;
            // 
            // checkedListBoxCharClass
            // 
            this.checkedListBoxCharClass.FormattingEnabled = true;
            this.checkedListBoxCharClass.Items.AddRange(new object[] {
            "Огонь",
            "Вода",
            "Земля",
            "Воздух",
            "Металл",
            "Антари"});
            this.checkedListBoxCharClass.Location = new System.Drawing.Point(155, 3);
            this.checkedListBoxCharClass.Name = "checkedListBoxCharClass";
            this.checkedListBoxCharClass.Size = new System.Drawing.Size(196, 79);
            this.checkedListBoxCharClass.TabIndex = 4;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(2, 319);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(54, 13);
            this.labelPoints.TabIndex = 16;
            this.labelPoints.Text = "Качества";
            // 
            // panelChoose
            // 
            this.panelChoose.BackColor = System.Drawing.Color.Transparent;
            this.panelChoose.BackgroundImage = global::ProjectArnes.Properties.Resources.Choosing;
            this.panelChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChoose.Controls.Add(this.pictureBoxPoint);
            this.panelChoose.Location = new System.Drawing.Point(9, 336);
            this.panelChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(188, 203);
            this.panelChoose.TabIndex = 17;
            // 
            // CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 568);
            this.Controls.Add(this.panelChoose);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelСharakter);
            this.Controls.Add(this.labelDex);
            this.Controls.Add(this.labelMagic);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.buttonCreate);
            this.Name = "CreateCharacterForm";
            this.Text = "Создание персонажа";
            this.Load += new System.EventHandler(this.CreateCharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFraction)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassChar)).EndInit();
            this.panelChoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxPoint;
        private System.Windows.Forms.Label labelСharakter;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelMagic;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonFamale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxClassChar;
        private System.Windows.Forms.CheckedListBox checkedListBoxCharClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonVesk;
        private System.Windows.Forms.RadioButton radioButtonFaro;
        private System.Windows.Forms.RadioButton radioButtonArnes;
        private System.Windows.Forms.PictureBox pictureBoxFraction;
        private System.Windows.Forms.Button buttonAva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelMagicSkills;
        private System.Windows.Forms.Label labelFraction;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panelChoose;
    }
}