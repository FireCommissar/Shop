namespace Shop_project
{
    partial class FormSupplyChange
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
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.labelSupplyDate = new System.Windows.Forms.Label();
            this.labelSupplyProduct = new System.Windows.Forms.Label();
            this.labelSupplyProvider = new System.Windows.Forms.Label();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.labelSupplyPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelSupplyQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dgvSupplyChange = new System.Windows.Forms.DataGridView();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyChange)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.Location = new System.Drawing.Point(573, 316);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSupplyDate.TabIndex = 36;
            // 
            // labelSupplyDate
            // 
            this.labelSupplyDate.AutoSize = true;
            this.labelSupplyDate.Location = new System.Drawing.Point(620, 288);
            this.labelSupplyDate.Name = "labelSupplyDate";
            this.labelSupplyDate.Size = new System.Drawing.Size(103, 16);
            this.labelSupplyDate.TabIndex = 35;
            this.labelSupplyDate.Text = "Дата поставки";
            // 
            // labelSupplyProduct
            // 
            this.labelSupplyProduct.AutoSize = true;
            this.labelSupplyProduct.Location = new System.Drawing.Point(638, 15);
            this.labelSupplyProduct.Name = "labelSupplyProduct";
            this.labelSupplyProduct.Size = new System.Drawing.Size(48, 16);
            this.labelSupplyProduct.TabIndex = 34;
            this.labelSupplyProduct.Text = "Товар";
            // 
            // labelSupplyProvider
            // 
            this.labelSupplyProvider.AutoSize = true;
            this.labelSupplyProvider.Location = new System.Drawing.Point(620, 81);
            this.labelSupplyProvider.Name = "labelSupplyProvider";
            this.labelSupplyProvider.Size = new System.Drawing.Size(79, 16);
            this.labelSupplyProvider.TabIndex = 33;
            this.labelSupplyProvider.Text = "Поставщик";
            // 
            // cbProvider
            // 
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(546, 111);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(243, 24);
            this.cbProvider.TabIndex = 32;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(546, 44);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(243, 24);
            this.cbProduct.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(562, 400);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(97, 23);
            this.btnChange.TabIndex = 29;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelSupplyPrice
            // 
            this.labelSupplyPrice.AutoSize = true;
            this.labelSupplyPrice.Location = new System.Drawing.Point(638, 220);
            this.labelSupplyPrice.Name = "labelSupplyPrice";
            this.labelSupplyPrice.Size = new System.Drawing.Size(40, 16);
            this.labelSupplyPrice.TabIndex = 28;
            this.labelSupplyPrice.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(546, 246);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(243, 22);
            this.tbPrice.TabIndex = 27;
            // 
            // labelSupplyQuantity
            // 
            this.labelSupplyQuantity.AutoSize = true;
            this.labelSupplyQuantity.Location = new System.Drawing.Point(620, 156);
            this.labelSupplyQuantity.Name = "labelSupplyQuantity";
            this.labelSupplyQuantity.Size = new System.Drawing.Size(85, 16);
            this.labelSupplyQuantity.TabIndex = 26;
            this.labelSupplyQuantity.Text = "Количество";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(546, 184);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(243, 22);
            this.tbQuantity.TabIndex = 25;
            // 
            // dgvSupplyChange
            // 
            this.dgvSupplyChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplyChange.Location = new System.Drawing.Point(11, 8);
            this.dgvSupplyChange.Name = "dgvSupplyChange";
            this.dgvSupplyChange.RowHeadersWidth = 51;
            this.dgvSupplyChange.RowTemplate.Height = 24;
            this.dgvSupplyChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplyChange.Size = new System.Drawing.Size(525, 434);
            this.dgvSupplyChange.TabIndex = 24;
            this.dgvSupplyChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplyChange_CellClick);
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(623, 355);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(87, 20);
            this.cbPaid.TabIndex = 37;
            this.cbPaid.Text = "Оплачен";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // FormSupplyChange
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
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelSupplyPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelSupplyQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.dgvSupplyChange);
            this.Name = "FormSupplyChange";
            this.Text = "FormSupplyChange";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.Label labelSupplyDate;
        private System.Windows.Forms.Label labelSupplyProduct;
        private System.Windows.Forms.Label labelSupplyProvider;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label labelSupplyPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labelSupplyQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DataGridView dgvSupplyChange;
        private System.Windows.Forms.CheckBox cbPaid;
    }
}