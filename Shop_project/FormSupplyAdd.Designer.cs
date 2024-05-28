namespace Shop_project
{
    partial class FormSupplyAdd
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
            this.labelSupplyPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelSupplyQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dgvSupplyAdd = new System.Windows.Forms.DataGridView();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.labelSupplyProvider = new System.Windows.Forms.Label();
            this.labelSupplyProduct = new System.Windows.Forms.Label();
            this.labelSupplyDate = new System.Windows.Forms.Label();
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyAdd)).BeginInit();
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
            // labelSupplyPrice
            // 
            this.labelSupplyPrice.AutoSize = true;
            this.labelSupplyPrice.Location = new System.Drawing.Point(639, 224);
            this.labelSupplyPrice.Name = "labelSupplyPrice";
            this.labelSupplyPrice.Size = new System.Drawing.Size(40, 16);
            this.labelSupplyPrice.TabIndex = 13;
            this.labelSupplyPrice.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(547, 250);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(243, 22);
            this.tbPrice.TabIndex = 12;
            // 
            // labelSupplyQuantity
            // 
            this.labelSupplyQuantity.AutoSize = true;
            this.labelSupplyQuantity.Location = new System.Drawing.Point(621, 160);
            this.labelSupplyQuantity.Name = "labelSupplyQuantity";
            this.labelSupplyQuantity.Size = new System.Drawing.Size(85, 16);
            this.labelSupplyQuantity.TabIndex = 11;
            this.labelSupplyQuantity.Text = "Количество";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(547, 188);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(243, 22);
            this.tbQuantity.TabIndex = 10;
            // 
            // dgvSupplyAdd
            // 
            this.dgvSupplyAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplyAdd.Location = new System.Drawing.Point(12, 12);
            this.dgvSupplyAdd.Name = "dgvSupplyAdd";
            this.dgvSupplyAdd.RowHeadersWidth = 51;
            this.dgvSupplyAdd.RowTemplate.Height = 24;
            this.dgvSupplyAdd.Size = new System.Drawing.Size(525, 434);
            this.dgvSupplyAdd.TabIndex = 9;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(547, 48);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(243, 24);
            this.cbProduct.TabIndex = 18;
            // 
            // cbProvider
            // 
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(547, 115);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(243, 24);
            this.cbProvider.TabIndex = 19;
            // 
            // labelSupplyProvider
            // 
            this.labelSupplyProvider.AutoSize = true;
            this.labelSupplyProvider.Location = new System.Drawing.Point(621, 85);
            this.labelSupplyProvider.Name = "labelSupplyProvider";
            this.labelSupplyProvider.Size = new System.Drawing.Size(79, 16);
            this.labelSupplyProvider.TabIndex = 20;
            this.labelSupplyProvider.Text = "Поставщик";
            // 
            // labelSupplyProduct
            // 
            this.labelSupplyProduct.AutoSize = true;
            this.labelSupplyProduct.Location = new System.Drawing.Point(639, 19);
            this.labelSupplyProduct.Name = "labelSupplyProduct";
            this.labelSupplyProduct.Size = new System.Drawing.Size(48, 16);
            this.labelSupplyProduct.TabIndex = 21;
            this.labelSupplyProduct.Text = "Товар";
            // 
            // labelSupplyDate
            // 
            this.labelSupplyDate.AutoSize = true;
            this.labelSupplyDate.Location = new System.Drawing.Point(621, 292);
            this.labelSupplyDate.Name = "labelSupplyDate";
            this.labelSupplyDate.Size = new System.Drawing.Size(103, 16);
            this.labelSupplyDate.TabIndex = 22;
            this.labelSupplyDate.Text = "Дата поставки";
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.Location = new System.Drawing.Point(563, 320);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSupplyDate.TabIndex = 23;
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(624, 360);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(87, 20);
            this.cbPaid.TabIndex = 24;
            this.cbPaid.Text = "Оплачен";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // FormSupplyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.dtpSupplyDate);
            this.Controls.Add(this.labelSupplyDate);
            this.Controls.Add(this.labelSupplyProduct);
            this.Controls.Add(this.labelSupplyProvider);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelSupplyPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelSupplyQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.dgvSupplyAdd);
            this.Name = "FormSupplyAdd";
            this.Text = "FormSupplyAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelSupplyPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labelSupplyQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DataGridView dgvSupplyAdd;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label labelSupplyProvider;
        private System.Windows.Forms.Label labelSupplyProduct;
        private System.Windows.Forms.Label labelSupplyDate;
        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.CheckBox cbPaid;
    }
}