namespace ProjectArnes
{
    partial class FormChars
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxChars = new System.Windows.Forms.ComboBox();
            this.CreateNewCharacterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelBack = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 316);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxChars
            // 
            this.comboBoxChars.FormattingEnabled = true;
            this.comboBoxChars.Location = new System.Drawing.Point(12, 318);
            this.comboBoxChars.Name = "comboBoxChars";
            this.comboBoxChars.Size = new System.Drawing.Size(159, 21);
            this.comboBoxChars.TabIndex = 2;
            this.comboBoxChars.Text = "Удалить персонажа номер...";
            this.comboBoxChars.SelectedIndexChanged += new System.EventHandler(this.comboBoxChars_SelectedIndexChanged);
            // 
            // CreateNewCharacterButton
            // 
            this.CreateNewCharacterButton.Location = new System.Drawing.Point(258, 316);
            this.CreateNewCharacterButton.Name = "CreateNewCharacterButton";
            this.CreateNewCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewCharacterButton.TabIndex = 1;
            this.CreateNewCharacterButton.Text = "создать";
            this.CreateNewCharacterButton.UseVisualStyleBackColor = true;
            this.CreateNewCharacterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanelBack
            // 
            this.tableLayoutPanelBack.ColumnCount = 1;
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBack.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBack.Name = "tableLayoutPanelBack";
            this.tableLayoutPanelBack.RowCount = 3;
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.Size = new System.Drawing.Size(429, 310);
            this.tableLayoutPanelBack.TabIndex = 0;
            this.tableLayoutPanelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelBack_Paint);
            // 
            // FormChars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 353);
            this.Controls.Add(this.comboBoxChars);
            this.Controls.Add(this.CreateNewCharacterButton);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tableLayoutPanelBack);
            this.Name = "FormChars";
            this.Text = "Chars";
            this.Load += new System.EventHandler(this.FormChars_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxChars;
        private System.Windows.Forms.Button CreateNewCharacterButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBack;
    }
}