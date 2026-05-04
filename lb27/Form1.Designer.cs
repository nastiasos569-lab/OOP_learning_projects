namespace lb27
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
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilterDirs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFilterFiles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(12, 37);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(188, 24);
            this.comboBoxDrives.TabIndex = 0;
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrives_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cписок дисків (C:, D:\\ і т.д.)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поточный шлях";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(206, 37);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(250, 22);
            this.textBoxPath.TabIndex = 4;
            this.textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPath_KeyDown_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 114);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(188, 310);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список папок";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(206, 114);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(374, 308);
            this.listBoxFiles.TabIndex = 7;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список файлів";
            // 
            // textBoxFilterDirs
            // 
            this.textBoxFilterDirs.Location = new System.Drawing.Point(588, 142);
            this.textBoxFilterDirs.Name = "textBoxFilterDirs";
            this.textBoxFilterDirs.Size = new System.Drawing.Size(146, 22);
            this.textBoxFilterDirs.TabIndex = 10;
            this.textBoxFilterDirs.TextChanged += new System.EventHandler(this.textBoxFilterDirs_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фільтр папок";
            // 
            // textBoxFilterFiles
            // 
            this.textBoxFilterFiles.Location = new System.Drawing.Point(588, 206);
            this.textBoxFilterFiles.Name = "textBoxFilterFiles";
            this.textBoxFilterFiles.Size = new System.Drawing.Size(146, 22);
            this.textBoxFilterFiles.TabIndex = 12;
            this.textBoxFilterFiles.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фільтр файлів";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(588, 277);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(146, 145);
            this.textBoxInfo.TabIndex = 13;
            this.textBoxInfo.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Властивості:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вміст фійлів txt.";
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(756, 350);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(197, 72);
            this.richTextBoxContent.TabIndex = 15;
            this.richTextBoxContent.Text = "";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(756, 142);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(270, 177);
            this.pictureBoxPreview.TabIndex = 17;
            this.pictureBoxPreview.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(788, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Перегляд зображень:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "Вийти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Створити папку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "Видалити папку";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 44);
            this.button5.TabIndex = 22;
            this.button5.Text = "Копіювати папку";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(203, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 44);
            this.button6.TabIndex = 25;
            this.button6.Text = "Копіювати файл\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(203, 536);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 44);
            this.button7.TabIndex = 24;
            this.button7.Text = "Видалити файл\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(203, 440);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 44);
            this.button8.TabIndex = 23;
            this.button8.Text = "Створити файл\r\n\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(338, 440);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 44);
            this.button9.TabIndex = 26;
            this.button9.Text = "Перемістити файл\r\n\r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(338, 490);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 44);
            this.button10.TabIndex = 27;
            this.button10.Text = "ReadOnly";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(338, 536);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 44);
            this.button11.TabIndex = 28;
            this.button11.Text = "Зберегти .txt";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(462, 440);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 44);
            this.button12.TabIndex = 29;
            this.button12.Text = "Архівувати \r\n";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(462, 490);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(118, 44);
            this.button13.TabIndex = 30;
            this.button13.Text = "Розпакувати";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(15, 480);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(118, 44);
            this.button14.TabIndex = 31;
            this.button14.Text = "Перемістити папку";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 640);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxFilterFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFilterDirs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDrives);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterDirs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilterFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

