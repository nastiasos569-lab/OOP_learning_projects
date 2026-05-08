namespace lb31
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортУTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитиПроцесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модуліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 422);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оновитиToolStripMenuItem,
            this.експортУTXTToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
            // 
            // експортУTXTToolStripMenuItem
            // 
            this.експортУTXTToolStripMenuItem.Name = "експортУTXTToolStripMenuItem";
            this.експортУTXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.експортУTXTToolStripMenuItem.Text = "Експорт у TXT";
            this.експортУTXTToolStripMenuItem.Click += new System.EventHandler(this.експортУTXTToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інформаціяToolStripMenuItem,
            this.завершитиПроцесToolStripMenuItem,
            this.потокиToolStripMenuItem,
            this.модуліToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 100);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            this.інформаціяToolStripMenuItem.Click += new System.EventHandler(this.інформаціяToolStripMenuItem_Click);
            // 
            // завершитиПроцесToolStripMenuItem
            // 
            this.завершитиПроцесToolStripMenuItem.Name = "завершитиПроцесToolStripMenuItem";
            this.завершитиПроцесToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.завершитиПроцесToolStripMenuItem.Text = "Завершити процес";
            this.завершитиПроцесToolStripMenuItem.Click += new System.EventHandler(this.завершитиПроцесToolStripMenuItem_Click);
            // 
            // потокиToolStripMenuItem
            // 
            this.потокиToolStripMenuItem.Name = "потокиToolStripMenuItem";
            this.потокиToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.потокиToolStripMenuItem.Text = "Потоки";
            this.потокиToolStripMenuItem.Click += new System.EventHandler(this.потокиToolStripMenuItem_Click);
            // 
            // модуліToolStripMenuItem
            // 
            this.модуліToolStripMenuItem.Name = "модуліToolStripMenuItem";
            this.модуліToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.модуліToolStripMenuItem.Text = "Модулі";
            this.модуліToolStripMenuItem.Click += new System.EventHandler(this.модуліToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експортУTXTToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитиПроцесToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem потокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модуліToolStripMenuItem;
    }
}

