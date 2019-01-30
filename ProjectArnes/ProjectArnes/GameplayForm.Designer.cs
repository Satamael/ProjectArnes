namespace ProjectArnes
{
    partial class GameplayForm
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
            this.PanelBackgraund = new System.Windows.Forms.Panel();
            this.progressBarEmemyHP = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCharName = new System.Windows.Forms.Label();
            this.progressBarMP = new System.Windows.Forms.ProgressBar();
            this.pictureBoxCharPic = new System.Windows.Forms.PictureBox();
            this.progressBarHP = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanelSkills = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelBackgraund.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharPic)).BeginInit();
            this.tabControlOutput.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBackgraund
            // 
            this.PanelBackgraund.Controls.Add(this.progressBarEmemyHP);
            this.PanelBackgraund.Controls.Add(this.panel1);
            this.PanelBackgraund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackgraund.Location = new System.Drawing.Point(0, 0);
            this.PanelBackgraund.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelBackgraund.Name = "PanelBackgraund";
            this.PanelBackgraund.Size = new System.Drawing.Size(1055, 548);
            this.PanelBackgraund.TabIndex = 0;
            // 
            // progressBarEmemyHP
            // 
            this.progressBarEmemyHP.BackColor = System.Drawing.Color.DarkRed;
            this.progressBarEmemyHP.Location = new System.Drawing.Point(675, 15);
            this.progressBarEmemyHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarEmemyHP.Name = "progressBarEmemyHP";
            this.progressBarEmemyHP.Size = new System.Drawing.Size(375, 30);
            this.progressBarEmemyHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEmemyHP.TabIndex = 3;
            this.progressBarEmemyHP.Value = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanelSkills);
            this.panel1.Controls.Add(this.tabControlOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 169);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCharName);
            this.panel2.Controls.Add(this.progressBarMP);
            this.panel2.Controls.Add(this.pictureBoxCharPic);
            this.panel2.Controls.Add(this.progressBarHP);
            this.panel2.Location = new System.Drawing.Point(440, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 138);
            this.panel2.TabIndex = 4;
            // 
            // labelCharName
            // 
            this.labelCharName.AutoSize = true;
            this.labelCharName.Location = new System.Drawing.Point(147, 15);
            this.labelCharName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(46, 17);
            this.labelCharName.TabIndex = 1;
            this.labelCharName.Text = "label1";
            // 
            // progressBarMP
            // 
            this.progressBarMP.Location = new System.Drawing.Point(145, 82);
            this.progressBarMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarMP.Name = "progressBarMP";
            this.progressBarMP.Size = new System.Drawing.Size(151, 28);
            this.progressBarMP.TabIndex = 3;
            this.progressBarMP.Value = 100;
            // 
            // pictureBoxCharPic
            // 
            this.pictureBoxCharPic.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxCharPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCharPic.Name = "pictureBoxCharPic";
            this.pictureBoxCharPic.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxCharPic.TabIndex = 0;
            this.pictureBoxCharPic.TabStop = false;
            // 
            // progressBarHP
            // 
            this.progressBarHP.Location = new System.Drawing.Point(145, 47);
            this.progressBarHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Size = new System.Drawing.Size(151, 28);
            this.progressBarHP.TabIndex = 3;
            this.progressBarHP.Value = 100;
            // 
            // tableLayoutPanelSkills
            // 
            this.tableLayoutPanelSkills.ColumnCount = 10;
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSkills.Location = new System.Drawing.Point(16, 124);
            this.tableLayoutPanelSkills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelSkills.Name = "tableLayoutPanelSkills";
            this.tableLayoutPanelSkills.RowCount = 1;
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelSkills.Size = new System.Drawing.Size(400, 37);
            this.tableLayoutPanelSkills.TabIndex = 2;
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Controls.Add(this.tabPage1);
            this.tabControlOutput.Controls.Add(this.tabPage2);
            this.tabControlOutput.Controls.Add(this.tabPage3);
            this.tabControlOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlOutput.Location = new System.Drawing.Point(779, 0);
            this.tabControlOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(276, 169);
            this.tabControlOutput.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(268, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подсказки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(4, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 132);
            this.textBox3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(268, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнал боя";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(4, 4);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 132);
            this.textBox4.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonEnter);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(268, 140);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Чат";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(224, 97);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(37, 39);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = ">>";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 97);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 35);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 85);
            this.textBox1.TabIndex = 0;
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 548);
            this.Controls.Add(this.PanelBackgraund);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameplayForm";
            this.Text = "GameplayForm";
            this.PanelBackgraund.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharPic)).EndInit();
            this.tabControlOutput.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackgraund;
        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBarEmemyHP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.ProgressBar progressBarMP;
        private System.Windows.Forms.PictureBox pictureBoxCharPic;
        private System.Windows.Forms.ProgressBar progressBarHP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSkills;
    }
}