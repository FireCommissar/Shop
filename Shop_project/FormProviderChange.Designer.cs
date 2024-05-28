namespace Shop_project
{
    partial class FormProviderChange
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
            this.labelProviderPaymentDetails = new System.Windows.Forms.Label();
            this.tbProviderPaymentDetails = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.labelProviderNumber = new System.Windows.Forms.Label();
            this.tbProviderNumber = new System.Windows.Forms.TextBox();
            this.labelProviderAdress = new System.Windows.Forms.Label();
            this.tbProviderAdress = new System.Windows.Forms.TextBox();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.tbProviderName = new System.Windows.Forms.TextBox();
            this.dgvProviderChange = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderChange)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProviderPaymentDetails
            // 
            this.labelProviderPaymentDetails.AutoSize = true;
            this.labelProviderPaymentDetails.Location = new System.Drawing.Point(621, 224);
            this.labelProviderPaymentDetails.Name = "labelProviderPaymentDetails";
            this.labelProviderPaymentDetails.Size = new System.Drawing.Size(79, 16);
            this.labelProviderPaymentDetails.TabIndex = 30;
            this.labelProviderPaymentDetails.Text = "Реквизиты";
            // 
            // tbProviderPaymentDetails
            // 
            this.tbProviderPaymentDetails.Location = new System.Drawing.Point(544, 252);
            this.tbProviderPaymentDetails.Name = "tbProviderPaymentDetails";
            this.tbProviderPaymentDetails.Size = new System.Drawing.Size(243, 22);
            this.tbProviderPaymentDetails.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(563, 404);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(97, 23);
            this.btnChange.TabIndex = 27;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelProviderNumber
            // 
            this.labelProviderNumber.AutoSize = true;
            this.labelProviderNumber.Location = new System.Drawing.Point(604, 155);
            this.labelProviderNumber.Name = "labelProviderNumber";
            this.labelProviderNumber.Size = new System.Drawing.Size(119, 16);
            this.labelProviderNumber.TabIndex = 26;
            this.labelProviderNumber.Text = "Номер телефона";
            // 
            // tbProviderNumber
            // 
            this.tbProviderNumber.Location = new System.Drawing.Point(544, 183);
            this.tbProviderNumber.Name = "tbProviderNumber";
            this.tbProviderNumber.Size = new System.Drawing.Size(243, 22);
            this.tbProviderNumber.TabIndex = 25;
            // 
            // labelProviderAdress
            // 
            this.labelProviderAdress.AutoSize = true;
            this.labelProviderAdress.Location = new System.Drawing.Point(636, 92);
            this.labelProviderAdress.Name = "labelProviderAdress";
            this.labelProviderAdress.Size = new System.Drawing.Size(47, 16);
            this.labelProviderAdress.TabIndex = 24;
            this.labelProviderAdress.Text = "Адрес";
            // 
            // tbProviderAdress
            // 
            this.tbProviderAdress.Location = new System.Drawing.Point(544, 118);
            this.tbProviderAdress.Name = "tbProviderAdress";
            this.tbProviderAdress.Size = new System.Drawing.Size(243, 22);
            this.tbProviderAdress.TabIndex = 23;
            // 
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Location = new System.Drawing.Point(591, 23);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(154, 16);
            this.labelProviderName.TabIndex = 22;
            this.labelProviderName.Text = "Название поставщика";
            // 
            // tbProviderName
            // 
            this.tbProviderName.Location = new System.Drawing.Point(544, 56);
            this.tbProviderName.Name = "tbProviderName";
            this.tbProviderName.Size = new System.Drawing.Size(243, 22);
            this.tbProviderName.TabIndex = 21;
            // 
            // dgvProviderChange
            // 
            this.dgvProviderChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderChange.Location = new System.Drawing.Point(13, 8);
            this.dgvProviderChange.Name = "dgvProviderChange";
            this.dgvProviderChange.RowHeadersWidth = 51;
            this.dgvProviderChange.RowTemplate.Height = 24;
            this.dgvProviderChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProviderChange.Size = new System.Drawing.Size(525, 434);
            this.dgvProviderChange.TabIndex = 20;
            this.dgvProviderChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProviderChange_CellClick);
            // 
            // FormProviderChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProviderPaymentDetails);
            this.Controls.Add(this.tbProviderPaymentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelProviderNumber);
            this.Controls.Add(this.tbProviderNumber);
            this.Controls.Add(this.labelProviderAdress);
            this.Controls.Add(this.tbProviderAdress);
            this.Controls.Add(this.labelProviderName);
            this.Controls.Add(this.tbProviderName);
            this.Controls.Add(this.dgvProviderChange);
            this.Name = "FormProviderChange";
            this.Text = "FormProviderChange";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProviderPaymentDetails;
        private System.Windows.Forms.TextBox tbProviderPaymentDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label labelProviderNumber;
        private System.Windows.Forms.TextBox tbProviderNumber;
        private System.Windows.Forms.Label labelProviderAdress;
        private System.Windows.Forms.TextBox tbProviderAdress;
        private System.Windows.Forms.Label labelProviderName;
        private System.Windows.Forms.TextBox tbProviderName;
        private System.Windows.Forms.DataGridView dgvProviderChange;
    }
}