namespace ProjectArnes
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBacked = new System.Windows.Forms.Panel();
            this.menuStripVirtical = new System.Windows.Forms.MenuStrip();
            this.saddaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saddsadssdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHorisontal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBacked.SuspendLayout();
            this.menuStripVirtical.SuspendLayout();
            this.menuStripHorisontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBacked
            // 
            this.panelBacked.Controls.Add(this.menuStripVirtical);
            this.panelBacked.Controls.Add(this.menuStripHorisontal);
            this.panelBacked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBacked.Location = new System.Drawing.Point(0, 0);
            this.panelBacked.Name = "panelBacked";
            this.panelBacked.Size = new System.Drawing.Size(654, 544);
            this.panelBacked.TabIndex = 0;
            // 
            // menuStripVirtical
            // 
            this.menuStripVirtical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripVirtical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saddaaToolStripMenuItem,
            this.saddsadssdToolStripMenuItem});
            this.menuStripVirtical.Location = new System.Drawing.Point(0, 24);
            this.menuStripVirtical.Name = "menuStripVirtical";
            this.menuStripVirtical.Size = new System.Drawing.Size(85, 520);
            this.menuStripVirtical.TabIndex = 1;
            this.menuStripVirtical.Text = "menuStrip2";
            // 
            // saddaaToolStripMenuItem
            // 
            this.saddaaToolStripMenuItem.Name = "saddaaToolStripMenuItem";
            this.saddaaToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.saddaaToolStripMenuItem.Text = "saddaa";
            // 
            // saddsadssdToolStripMenuItem
            // 
            this.saddsadssdToolStripMenuItem.Name = "saddsadssdToolStripMenuItem";
            this.saddsadssdToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.saddsadssdToolStripMenuItem.Text = "saddsadssd";
            // 
            // menuStripHorisontal
            // 
            this.menuStripHorisontal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStripHorisontal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripHorisontal.Location = new System.Drawing.Point(0, 0);
            this.menuStripHorisontal.Name = "menuStripHorisontal";
            this.menuStripHorisontal.Size = new System.Drawing.Size(654, 24);
            this.menuStripHorisontal.TabIndex = 0;
            this.menuStripHorisontal.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem1.Text = "122121321";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem2.Text = "214422412442";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 544);
            this.Controls.Add(this.panelBacked);
            this.MainMenuStrip = this.menuStripHorisontal;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBacked.ResumeLayout(false);
            this.panelBacked.PerformLayout();
            this.menuStripVirtical.ResumeLayout(false);
            this.menuStripVirtical.PerformLayout();
            this.menuStripHorisontal.ResumeLayout(false);
            this.menuStripHorisontal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBacked;
        private System.Windows.Forms.MenuStrip menuStripHorisontal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStripVirtical;
        private System.Windows.Forms.ToolStripMenuItem saddaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saddsadssdToolStripMenuItem;
    }
}

