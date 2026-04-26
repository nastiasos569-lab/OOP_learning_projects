namespace lb26.Forms
{
    partial class MainForm
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
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtTariff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(147, 94);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(141, 24);
            this.cmbTemplates.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(147, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(141, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(147, 227);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(141, 22);
            this.txtAccount.TabIndex = 3;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(147, 270);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(141, 22);
            this.txtVolume.TabIndex = 4;
            // 
            // txtTariff
            // 
            this.txtTariff.Location = new System.Drawing.Point(147, 308);
            this.txtTariff.Name = "txtTariff";
            this.txtTariff.Size = new System.Drawing.Size(141, 22);
            this.txtTariff.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер шаблону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адреса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рахунок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Обсяг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Тариф";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "ПІБ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Створити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 69);
            this.button2.TabIndex = 14;
            this.button2.Text = "Переглянути варіанти шаблонів Word\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(326, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "Пошук/Заміна";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(326, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 38);
            this.button5.TabIndex = 17;
            this.button5.Text = "Вихід";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 447);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTariff);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbTemplates);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtTariff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}