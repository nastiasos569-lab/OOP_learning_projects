namespace lb26.Forms
{
    partial class TemplatePreviewForm
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
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTemplates
            // 
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.ItemHeight = 16;
            this.lstTemplates.Location = new System.Drawing.Point(62, 88);
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.Size = new System.Drawing.Size(194, 228);
            this.lstTemplates.TabIndex = 0;
            this.lstTemplates.SelectedIndexChanged += new System.EventHandler(this.lstTemplates_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Переглянути";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TemplatePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstTemplates);
            this.Name = "TemplatePreviewForm";
            this.Text = "  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}