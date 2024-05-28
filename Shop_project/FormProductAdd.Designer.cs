namespace Shop_project
{
    partial class FormProductAdd
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
            this.dgvProductAdd = new System.Windows.Forms.DataGridView();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductVendorCode = new System.Windows.Forms.Label();
            this.tbProductVendorCode = new System.Windows.Forms.TextBox();
            this.labelProductUnitType = new System.Windows.Forms.Label();
            this.tbProductUnitType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductAdd
            // 
            this.dgvProductAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductAdd.Location = new System.Drawing.Point(1, 4);
            this.dgvProductAdd.Name = "dgvProductAdd";
            this.dgvProductAdd.RowHeadersWidth = 51;
            this.dgvProductAdd.RowTemplate.Height = 24;
            this.dgvProductAdd.Size = new System.Drawing.Size(525, 434);
            this.dgvProductAdd.TabIndex = 0;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(532, 52);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(243, 22);
            this.tbProductName.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(592, 22);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(123, 16);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Название товара";
            // 
            // labelProductVendorCode
            // 
            this.labelProductVendorCode.AutoSize = true;
            this.labelProductVendorCode.Location = new System.Drawing.Point(624, 88);
            this.labelProductVendorCode.Name = "labelProductVendorCode";
            this.labelProductVendorCode.Size = new System.Drawing.Size(62, 16);
            this.labelProductVendorCode.TabIndex = 4;
            this.labelProductVendorCode.Text = "Артикул";
            // 
            // tbProductVendorCode
            // 
            this.tbProductVendorCode.Location = new System.Drawing.Point(532, 114);
            this.tbProductVendorCode.Name = "tbProductVendorCode";
            this.tbProductVendorCode.Size = new System.Drawing.Size(243, 22);
            this.tbProductVendorCode.TabIndex = 3;
            // 
            // labelProductUnitType
            // 
            this.labelProductUnitType.AutoSize = true;
            this.labelProductUnitType.Location = new System.Drawing.Point(592, 151);
            this.labelProductUnitType.Name = "labelProductUnitType";
            this.labelProductUnitType.Size = new System.Drawing.Size(141, 16);
            this.labelProductUnitType.TabIndex = 6;
            this.labelProductUnitType.Text = "Единица измерения";
            // 
            // tbProductUnitType
            // 
            this.tbProductUnitType.Location = new System.Drawing.Point(532, 179);
            this.tbProductUnitType.Name = "tbProductUnitType";
            this.tbProductUnitType.Size = new System.Drawing.Size(243, 22);
            this.tbProductUnitType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(551, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelProductUnitType);
            this.Controls.Add(this.tbProductUnitType);
            this.Controls.Add(this.labelProductVendorCode);
            this.Controls.Add(this.tbProductVendorCode);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.dgvProductAdd);
            this.Name = "FormProductAdd";
            this.Text = "FormProductAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductAdd;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductVendorCode;
        private System.Windows.Forms.TextBox tbProductVendorCode;
        private System.Windows.Forms.Label labelProductUnitType;
        private System.Windows.Forms.TextBox tbProductUnitType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}