namespace Shop_project
{
    partial class FormProviderAdd
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelProviderNumber = new System.Windows.Forms.Label();
            this.tbProviderNumber = new System.Windows.Forms.TextBox();
            this.labelProviderAdress = new System.Windows.Forms.Label();
            this.tbProviderAdress = new System.Windows.Forms.TextBox();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.tbProviderName = new System.Windows.Forms.TextBox();
            this.dgvProviderAdd = new System.Windows.Forms.DataGridView();
            this.labelProviderPaymentDetails = new System.Windows.Forms.Label();
            this.tbProviderPaymentDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(563, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelProviderNumber
            // 
            this.labelProviderNumber.AutoSize = true;
            this.labelProviderNumber.Location = new System.Drawing.Point(604, 155);
            this.labelProviderNumber.Name = "labelProviderNumber";
            this.labelProviderNumber.Size = new System.Drawing.Size(119, 16);
            this.labelProviderNumber.TabIndex = 15;
            this.labelProviderNumber.Text = "Номер телефона";
            // 
            // tbProviderNumber
            // 
            this.tbProviderNumber.Location = new System.Drawing.Point(544, 183);
            this.tbProviderNumber.Name = "tbProviderNumber";
            this.tbProviderNumber.Size = new System.Drawing.Size(243, 22);
            this.tbProviderNumber.TabIndex = 14;
            // 
            // labelProviderAdress
            // 
            this.labelProviderAdress.AutoSize = true;
            this.labelProviderAdress.Location = new System.Drawing.Point(636, 92);
            this.labelProviderAdress.Name = "labelProviderAdress";
            this.labelProviderAdress.Size = new System.Drawing.Size(47, 16);
            this.labelProviderAdress.TabIndex = 13;
            this.labelProviderAdress.Text = "Адрес";
            // 
            // tbProviderAdress
            // 
            this.tbProviderAdress.Location = new System.Drawing.Point(544, 118);
            this.tbProviderAdress.Name = "tbProviderAdress";
            this.tbProviderAdress.Size = new System.Drawing.Size(243, 22);
            this.tbProviderAdress.TabIndex = 12;
            // 
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Location = new System.Drawing.Point(591, 23);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(154, 16);
            this.labelProviderName.TabIndex = 11;
            this.labelProviderName.Text = "Название поставщика";
            // 
            // tbProviderName
            // 
            this.tbProviderName.Location = new System.Drawing.Point(544, 56);
            this.tbProviderName.Name = "tbProviderName";
            this.tbProviderName.Size = new System.Drawing.Size(243, 22);
            this.tbProviderName.TabIndex = 10;
            // 
            // dgvProviderAdd
            // 
            this.dgvProviderAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderAdd.Location = new System.Drawing.Point(13, 8);
            this.dgvProviderAdd.Name = "dgvProviderAdd";
            this.dgvProviderAdd.RowHeadersWidth = 51;
            this.dgvProviderAdd.RowTemplate.Height = 24;
            this.dgvProviderAdd.Size = new System.Drawing.Size(525, 434);
            this.dgvProviderAdd.TabIndex = 9;
            // 
            // labelProviderPaymentDetails
            // 
            this.labelProviderPaymentDetails.AutoSize = true;
            this.labelProviderPaymentDetails.Location = new System.Drawing.Point(621, 224);
            this.labelProviderPaymentDetails.Name = "labelProviderPaymentDetails";
            this.labelProviderPaymentDetails.Size = new System.Drawing.Size(79, 16);
            this.labelProviderPaymentDetails.TabIndex = 19;
            this.labelProviderPaymentDetails.Text = "Реквизиты";
            // 
            // tbProviderPaymentDetails
            // 
            this.tbProviderPaymentDetails.Location = new System.Drawing.Point(544, 252);
            this.tbProviderPaymentDetails.Name = "tbProviderPaymentDetails";
            this.tbProviderPaymentDetails.Size = new System.Drawing.Size(243, 22);
            this.tbProviderPaymentDetails.TabIndex = 18;
            // 
            // FormProviderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProviderPaymentDetails);
            this.Controls.Add(this.tbProviderPaymentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelProviderNumber);
            this.Controls.Add(this.tbProviderNumber);
            this.Controls.Add(this.labelProviderAdress);
            this.Controls.Add(this.tbProviderAdress);
            this.Controls.Add(this.labelProviderName);
            this.Controls.Add(this.tbProviderName);
            this.Controls.Add(this.dgvProviderAdd);
            this.Name = "FormProviderAdd";
            this.Text = "FormProviderAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelProviderNumber;
        private System.Windows.Forms.TextBox tbProviderNumber;
        private System.Windows.Forms.Label labelProviderAdress;
        private System.Windows.Forms.TextBox tbProviderAdress;
        private System.Windows.Forms.Label labelProviderName;
        private System.Windows.Forms.TextBox tbProviderName;
        private System.Windows.Forms.DataGridView dgvProviderAdd;
        private System.Windows.Forms.Label labelProviderPaymentDetails;
        private System.Windows.Forms.TextBox tbProviderPaymentDetails;
    }
}