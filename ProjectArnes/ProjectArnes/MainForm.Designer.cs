﻿namespace ProjectArnes
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
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персонажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкаНаBetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поддердатьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.событияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.достиженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тавернаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дворецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цистернаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жилищеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.saddsadssdToolStripMenuItem,
            this.картаToolStripMenuItem,
            this.событияToolStripMenuItem,
            this.заданияToolStripMenuItem,
            this.достиженияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStripVirtical.Location = new System.Drawing.Point(0, 24);
            this.menuStripVirtical.Name = "menuStripVirtical";
            this.menuStripVirtical.Size = new System.Drawing.Size(93, 520);
            this.menuStripVirtical.TabIndex = 1;
            this.menuStripVirtical.Text = "menuStrip2";
            // 
            // saddaaToolStripMenuItem
            // 
            this.saddaaToolStripMenuItem.Name = "saddaaToolStripMenuItem";
            this.saddaaToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.saddaaToolStripMenuItem.Text = "Персонаж";
            // 
            // saddsadssdToolStripMenuItem
            // 
            this.saddsadssdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.улицыToolStripMenuItem,
            this.тавернаToolStripMenuItem,
            this.дворецToolStripMenuItem,
            this.цистернаToolStripMenuItem,
            this.жилищеToolStripMenuItem});
            this.saddsadssdToolStripMenuItem.Name = "saddsadssdToolStripMenuItem";
            this.saddsadssdToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.saddsadssdToolStripMenuItem.Text = "Город";
            // 
            // menuStripHorisontal
            // 
            this.menuStripHorisontal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.входToolStripMenuItem,
            this.персонажToolStripMenuItem,
            this.заявкаНаBetaToolStripMenuItem,
            this.поддердатьПроектToolStripMenuItem,
            this.разработчикToolStripMenuItem});
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Главная";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem2.Text = "Регистрация";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.входToolStripMenuItem.Text = "Вход";
            // 
            // персонажToolStripMenuItem
            // 
            this.персонажToolStripMenuItem.Name = "персонажToolStripMenuItem";
            this.персонажToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.персонажToolStripMenuItem.Text = "Тех. Поддержка";
            this.персонажToolStripMenuItem.Click += new System.EventHandler(this.персонажToolStripMenuItem_Click);
            // 
            // заявкаНаBetaToolStripMenuItem
            // 
            this.заявкаНаBetaToolStripMenuItem.Name = "заявкаНаBetaToolStripMenuItem";
            this.заявкаНаBetaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.заявкаНаBetaToolStripMenuItem.Text = "Заявка на BetaTest";
            // 
            // поддердатьПроектToolStripMenuItem
            // 
            this.поддердатьПроектToolStripMenuItem.Name = "поддердатьПроектToolStripMenuItem";
            this.поддердатьПроектToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.поддердатьПроектToolStripMenuItem.Text = "Поддердать проект";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.разработчикToolStripMenuItem.Text = "Разработчики";
            // 
            // событияToolStripMenuItem
            // 
            this.событияToolStripMenuItem.Name = "событияToolStripMenuItem";
            this.событияToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.событияToolStripMenuItem.Text = "События";
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // достиженияToolStripMenuItem
            // 
            this.достиженияToolStripMenuItem.Name = "достиженияToolStripMenuItem";
            this.достиженияToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.достиженияToolStripMenuItem.Text = "Достижения";
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.картаToolStripMenuItem.Text = "Карта";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // улицыToolStripMenuItem
            // 
            this.улицыToolStripMenuItem.Name = "улицыToolStripMenuItem";
            this.улицыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.улицыToolStripMenuItem.Text = "Улицы";
            // 
            // тавернаToolStripMenuItem
            // 
            this.тавернаToolStripMenuItem.Name = "тавернаToolStripMenuItem";
            this.тавернаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.тавернаToolStripMenuItem.Text = "Таверна";
            // 
            // дворецToolStripMenuItem
            // 
            this.дворецToolStripMenuItem.Name = "дворецToolStripMenuItem";
            this.дворецToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дворецToolStripMenuItem.Text = "Дворец";
            // 
            // цистернаToolStripMenuItem
            // 
            this.цистернаToolStripMenuItem.Name = "цистернаToolStripMenuItem";
            this.цистернаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.цистернаToolStripMenuItem.Text = "Цистерна";
            // 
            // жилищеToolStripMenuItem
            // 
            this.жилищеToolStripMenuItem.Name = "жилищеToolStripMenuItem";
            this.жилищеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.жилищеToolStripMenuItem.Text = "Жилище";
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
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персонажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тавернаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дворецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цистернаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жилищеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem событияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem достиженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкаНаBetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поддердатьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
    }
}
