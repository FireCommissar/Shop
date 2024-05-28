namespace Shop_project
{
    partial class FormProductChange
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
            this.btnChange = new System.Windows.Forms.Button();
            this.labelProductUnitType = new System.Windows.Forms.Label();
            this.tbProductUnitType = new System.Windows.Forms.TextBox();
            this.labelProductVendorCode = new System.Windows.Forms.Label();
            this.tbProductVendorCode = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.dgvProductChange = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChange)).BeginInit();
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
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(563, 404);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(97, 23);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelProductUnitType
            // 
            this.labelProductUnitType.AutoSize = true;
            this.labelProductUnitType.Location = new System.Drawing.Point(604, 155);
            this.labelProductUnitType.Name = "labelProductUnitType";
            this.labelProductUnitType.Size = new System.Drawing.Size(141, 16);
            this.labelProductUnitType.TabIndex = 15;
            this.labelProductUnitType.Text = "Единица измерения";
            // 
            // tbProductUnitType
            // 
            this.tbProductUnitType.Location = new System.Drawing.Point(544, 183);
            this.tbProductUnitType.Name = "tbProductUnitType";
            this.tbProductUnitType.Size = new System.Drawing.Size(243, 22);
            this.tbProductUnitType.TabIndex = 14;
            // 
            // labelProductVendorCode
            // 
            this.labelProductVendorCode.AutoSize = true;
            this.labelProductVendorCode.Location = new System.Drawing.Point(636, 92);
            this.labelProductVendorCode.Name = "labelProductVendorCode";
            this.labelProductVendorCode.Size = new System.Drawing.Size(62, 16);
            this.labelProductVendorCode.TabIndex = 13;
            this.labelProductVendorCode.Text = "Артикул";
            // 
            // tbProductVendorCode
            // 
            this.tbProductVendorCode.Location = new System.Drawing.Point(544, 118);
            this.tbProductVendorCode.Name = "tbProductVendorCode";
            this.tbProductVendorCode.Size = new System.Drawing.Size(243, 22);
            this.tbProductVendorCode.TabIndex = 12;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(604, 26);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(123, 16);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "Название товара";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(544, 56);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(243, 22);
            this.tbProductName.TabIndex = 10;
            // 
            // dgvProductChange
            // 
            this.dgvProductChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductChange.Location = new System.Drawing.Point(13, 8);
            this.dgvProductChange.Name = "dgvProductChange";
            this.dgvProductChange.RowHeadersWidth = 51;
            this.dgvProductChange.RowTemplate.Height = 24;
            this.dgvProductChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductChange.Size = new System.Drawing.Size(525, 434);
            this.dgvProductChange.TabIndex = 9;
            this.dgvProductChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductChange_CellClick);
            // 
            // FormProductChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelProductUnitType);
            this.Controls.Add(this.tbProductUnitType);
            this.Controls.Add(this.labelProductVendorCode);
            this.Controls.Add(this.tbProductVendorCode);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.dgvProductChange);
            this.Name = "FormProductChange";
            this.Text = "FormProductChange";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label labelProductUnitType;
        private System.Windows.Forms.TextBox tbProductUnitType;
        private System.Windows.Forms.Label labelProductVendorCode;
        private System.Windows.Forms.TextBox tbProductVendorCode;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DataGridView dgvProductChange;
    }
}