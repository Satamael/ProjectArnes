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
            this.checkedListBoxFraction = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxFraction = new System.Windows.Forms.PictureBox();
            this.pictureBoxClassChar = new System.Windows.Forms.PictureBox();
            this.checkedListBoxCharClass = new System.Windows.Forms.CheckedListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonAva = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxFraction
            // 
            this.checkedListBoxFraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFraction.FormattingEnabled = true;
            this.checkedListBoxFraction.Items.AddRange(new object[] {
            "Арнес",
            "Веск",
            "Фаро"});
            this.checkedListBoxFraction.Location = new System.Drawing.Point(102, 32);
            this.checkedListBoxFraction.Name = "checkedListBoxFraction";
            this.checkedListBoxFraction.Size = new System.Drawing.Size(93, 49);
            this.checkedListBoxFraction.TabIndex = 0;
            // 
            // pictureBoxFraction
            // 
            this.pictureBoxFraction.Location = new System.Drawing.Point(12, 32);
            this.pictureBoxFraction.Name = "pictureBoxFraction";
            this.pictureBoxFraction.Size = new System.Drawing.Size(84, 50);
            this.pictureBoxFraction.TabIndex = 1;
            this.pictureBoxFraction.TabStop = false;
            // 
            // pictureBoxClassChar
            // 
            this.pictureBoxClassChar.Location = new System.Drawing.Point(12, 110);
            this.pictureBoxClassChar.Name = "pictureBoxClassChar";
            this.pictureBoxClassChar.Size = new System.Drawing.Size(84, 79);
            this.pictureBoxClassChar.TabIndex = 3;
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
            this.checkedListBoxCharClass.Location = new System.Drawing.Point(102, 110);
            this.checkedListBoxCharClass.Name = "checkedListBoxCharClass";
            this.checkedListBoxCharClass.Size = new System.Drawing.Size(239, 94);
            this.checkedListBoxCharClass.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(266, 314);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonAva
            // 
            this.buttonAva.Location = new System.Drawing.Point(201, 31);
            this.buttonAva.Name = "buttonAva";
            this.buttonAva.Size = new System.Drawing.Size(85, 50);
            this.buttonAva.TabIndex = 4;
            this.buttonAva.Text = "Загрузить свою аватарку";
            this.buttonAva.UseVisualStyleBackColor = true;
            this.buttonAva.Click += new System.EventHandler(this.buttonAva_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(56, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 339);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAva);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxClassChar);
            this.Controls.Add(this.checkedListBoxCharClass);
            this.Controls.Add(this.pictureBoxFraction);
            this.Controls.Add(this.checkedListBoxFraction);
            this.Name = "CreateCharacter";
            this.Text = "Создание персонажа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFraction;
        private System.Windows.Forms.PictureBox pictureBoxFraction;
        private System.Windows.Forms.PictureBox pictureBoxClassChar;
        private System.Windows.Forms.CheckedListBox checkedListBoxCharClass;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonAva;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}