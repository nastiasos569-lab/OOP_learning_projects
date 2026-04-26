namespace lb25
{
    partial class ServiceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.buttonReport1 = new System.Windows.Forms.Button();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.textBoxSearchService = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Назва";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(621, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 37);
            this.button4.TabIndex = 19;
            this.button4.Text = "Вийти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(141, 241);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(111, 37);
            this.buttonReport2.TabIndex = 18;
            this.buttonReport2.Text = "Видалити";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // buttonReport1
            // 
            this.buttonReport1.Location = new System.Drawing.Point(141, 183);
            this.buttonReport1.Name = "buttonReport1";
            this.buttonReport1.Size = new System.Drawing.Size(111, 37);
            this.buttonReport1.TabIndex = 17;
            this.buttonReport1.Text = "Оновити";
            this.buttonReport1.UseVisualStyleBackColor = true;
            this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(141, 350);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(111, 37);
            this.buttonSearchClient.TabIndex = 16;
            this.buttonSearchClient.Text = "Пошук";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(141, 123);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(111, 37);
            this.buttonAddClient.TabIndex = 15;
            this.buttonAddClient.Text = "Додати";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(346, 44);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(573, 291);
            this.dataGridViewServices.TabIndex = 14;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellContentClick);
            // 
            // textBoxSearchService
            // 
            this.textBoxSearchService.Location = new System.Drawing.Point(141, 313);
            this.textBoxSearchService.Name = "textBoxSearchService";
            this.textBoxSearchService.Size = new System.Drawing.Size(175, 22);
            this.textBoxSearchService.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(141, 85);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(175, 22);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(141, 44);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(175, 22);
            this.textBoxServiceName.TabIndex = 11;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonReport2);
            this.Controls.Add(this.buttonReport1);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.textBoxSearchService);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Name = "ServiceForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.Button buttonReport1;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.TextBox textBoxSearchService;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxServiceName;
    }
}