namespace ProjectArnes
{
    partial class SkillShopForm
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
            this.tableLayoutPanelSkills = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttoRefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDMG = new System.Windows.Forms.Label();
            this.labelCD = new System.Windows.Forms.Label();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEXP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSkills
            // 
            this.tableLayoutPanelSkills.ColumnCount = 4;
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanelSkills.Name = "tableLayoutPanelSkills";
            this.tableLayoutPanelSkills.RowCount = 4;
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkills.Size = new System.Drawing.Size(447, 293);
            this.tableLayoutPanelSkills.TabIndex = 0;
            this.tableLayoutPanelSkills.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelSkills_Paint);
            this.tableLayoutPanelSkills.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableElement_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(713, 415);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Изучить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttoRefresh
            // 
            this.buttoRefresh.Location = new System.Drawing.Point(632, 415);
            this.buttoRefresh.Name = "buttoRefresh";
            this.buttoRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttoRefresh.TabIndex = 2;
            this.buttoRefresh.Text = "Обновить";
            this.buttoRefresh.UseVisualStyleBackColor = true;
            this.buttoRefresh.Click += new System.EventHandler(this.buttoRefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 221);
            this.textBox1.TabIndex = 3;
            // 
            // labelDMG
            // 
            this.labelDMG.AutoSize = true;
            this.labelDMG.Location = new System.Drawing.Point(517, 246);
            this.labelDMG.Name = "labelDMG";
            this.labelDMG.Size = new System.Drawing.Size(35, 13);
            this.labelDMG.TabIndex = 4;
            this.labelDMG.Text = "label1";
            this.labelDMG.Click += new System.EventHandler(this.labelDMG_Click);
            // 
            // labelCD
            // 
            this.labelCD.AutoSize = true;
            this.labelCD.BackColor = System.Drawing.Color.Transparent;
            this.labelCD.Location = new System.Drawing.Point(517, 270);
            this.labelCD.Name = "labelCD";
            this.labelCD.Size = new System.Drawing.Size(35, 13);
            this.labelCD.TabIndex = 4;
            this.labelCD.Text = "label1";
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(517, 293);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(35, 13);
            this.labelSchool.TabIndex = 5;
            this.labelSchool.Text = "label3";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(517, 316);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 13);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Приветствую,";
            // 
            // labelEXP
            // 
            this.labelEXP.AutoSize = true;
            this.labelEXP.Location = new System.Drawing.Point(517, 340);
            this.labelEXP.Name = "labelEXP";
            this.labelEXP.Size = new System.Drawing.Size(35, 13);
            this.labelEXP.TabIndex = 5;
            this.labelEXP.Text = "label3";
            // 
            // SkillShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelEXP);
            this.Controls.Add(this.labelSchool);
            this.Controls.Add(this.labelCD);
            this.Controls.Add(this.labelDMG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttoRefresh);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.tableLayoutPanelSkills);
            this.Name = "SkillShopForm";
            this.Text = "SkillShopForm";
            this.Load += new System.EventHandler(this.SkillShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSkills;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttoRefresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDMG;
        private System.Windows.Forms.Label labelCD;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEXP;
    }
}