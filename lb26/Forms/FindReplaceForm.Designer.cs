namespace lb26.Forms
{
    partial class FindReplaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbDocuments = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Знайти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Замінити на:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(204, 194);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(297, 22);
            this.txtFind.TabIndex = 2;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(204, 236);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(297, 22);
            this.txtReplace.TabIndex = 3;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(204, 297);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(142, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Замінити";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbDocuments
            // 
            this.cmbDocuments.FormattingEnabled = true;
            this.cmbDocuments.Location = new System.Drawing.Point(204, 79);
            this.cmbDocuments.Name = "cmbDocuments";
            this.cmbDocuments.Size = new System.Drawing.Size(142, 24);
            this.cmbDocuments.TabIndex = 6;
            this.cmbDocuments.SelectedIndexChanged += new System.EventHandler(this.cmbDocuments_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оберіть файл, в якому треба провести заміну\r\n(серед активних, тобто тих, що ви що" +
    "йно створили)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Або оберіть існуючий файл для заміни з вашого комп\'ютера\r\n\r\n";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(204, 152);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(142, 23);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Обрати";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDocuments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindReplaceForm";
            this.Text = "FindReplaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbDocuments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenFile;
    }
}