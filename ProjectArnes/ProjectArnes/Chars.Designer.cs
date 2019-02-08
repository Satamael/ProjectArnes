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
            this.tableLayoutPanelBack = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxChars = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBack
            // 
            this.tableLayoutPanelBack.ColumnCount = 1;
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBack.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBack.Name = "tableLayoutPanelBack";
            this.tableLayoutPanelBack.RowCount = 4;
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanelBack.Size = new System.Drawing.Size(284, 213);
            this.tableLayoutPanelBack.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 226);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxChars
            // 
            this.comboBoxChars.FormattingEnabled = true;
            this.comboBoxChars.Location = new System.Drawing.Point(50, 228);
            this.comboBoxChars.Name = "comboBoxChars";
            this.comboBoxChars.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChars.TabIndex = 2;
            // 
            // FormChars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxChars);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tableLayoutPanelBack);
            this.Name = "FormChars";
            this.Text = "Chars";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxChars;
    }
}