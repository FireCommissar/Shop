namespace Shop_project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSupply = new System.Windows.Forms.TabPage();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnDeleteSupply = new System.Windows.Forms.Button();
            this.btnChangeSupply = new System.Windows.Forms.Button();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tabPageProvider = new System.Windows.Forms.TabPage();
            this.btnDeleteProvider = new System.Windows.Forms.Button();
            this.btnChangeProvider = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.tabPageProvidersReport = new System.Windows.Forms.TabPage();
            this.providerChartSecondDate = new System.Windows.Forms.DateTimePicker();
            this.providerChartFirstDate = new System.Windows.Forms.DateTimePicker();
            this.tbProviderPick = new System.Windows.Forms.TextBox();
            this.btnProviderForm = new System.Windows.Forms.Button();
            this.cbProviderPick = new System.Windows.Forms.ComboBox();
            this.providerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageProductReport = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControlMain.SuspendLayout();
            this.tabPageSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPageProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.tabPageProvidersReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerChart)).BeginInit();
            this.tabPageProductReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.tabPageSupply);
            this.TabControlMain.Controls.Add(this.tabPageProduct);
            this.TabControlMain.Controls.Add(this.tabPageProvider);
            this.TabControlMain.Controls.Add(this.tabPageProvidersReport);
            this.TabControlMain.Controls.Add(this.tabPageProductReport);
            this.TabControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControlMain.Location = new System.Drawing.Point(-1, -1);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(802, 454);
            this.TabControlMain.TabIndex = 0;
            // 
            // tabPageSupply
            // 
            this.tabPageSupply.Controls.Add(this.btnExportExcel);
            this.tabPageSupply.Controls.Add(this.btnDeleteSupply);
            this.tabPageSupply.Controls.Add(this.btnChangeSupply);
            this.tabPageSupply.Controls.Add(this.btnAddSupply);
            this.tabPageSupply.Controls.Add(this.dgvSupply);
            this.tabPageSupply.Location = new System.Drawing.Point(4, 25);
            this.tabPageSupply.Name = "tabPageSupply";
            this.tabPageSupply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupply.Size = new System.Drawing.Size(794, 425);
            this.tabPageSupply.TabIndex = 0;
            this.tabPageSupply.Text = "Поставки";
            this.tabPageSupply.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(557, 380);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(139, 45);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Экспорт в Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnDeleteSupply
            // 
            this.btnDeleteSupply.Location = new System.Drawing.Point(228, 391);
            this.btnDeleteSupply.Name = "btnDeleteSupply";
            this.btnDeleteSupply.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteSupply.TabIndex = 9;
            this.btnDeleteSupply.Text = "Удалить";
            this.btnDeleteSupply.UseVisualStyleBackColor = true;
            this.btnDeleteSupply.Click += new System.EventHandler(this.btnDeleteSupply_Click);
            // 
            // btnChangeSupply
            // 
            this.btnChangeSupply.Location = new System.Drawing.Point(117, 391);
            this.btnChangeSupply.Name = "btnChangeSupply";
            this.btnChangeSupply.Size = new System.Drawing.Size(105, 23);
            this.btnChangeSupply.TabIndex = 8;
            this.btnChangeSupply.Text = "Изменить";
            this.btnChangeSupply.UseVisualStyleBackColor = true;
            this.btnChangeSupply.Click += new System.EventHandler(this.btnChangeSupply_Click);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(6, 391);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(105, 23);
            this.btnAddSupply.TabIndex = 7;
            this.btnAddSupply.Text = "Добавить";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // dgvSupply
            // 
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Location = new System.Drawing.Point(-4, 0);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.RowHeadersWidth = 51;
            this.dgvSupply.RowTemplate.Height = 24;
            this.dgvSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupply.Size = new System.Drawing.Size(795, 378);
            this.dgvSupply.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.btnDeleteProduct);
            this.tabPageProduct.Controls.Add(this.btnChangeProduct);
            this.tabPageProduct.Controls.Add(this.btnAddProduct);
            this.tabPageProduct.Controls.Add(this.dgvProducts);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(794, 425);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Товары";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(222, 391);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(111, 391);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(105, 23);
            this.btnChangeProduct.TabIndex = 2;
            this.btnChangeProduct.Text = "Изменить";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(0, 391);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(-4, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(798, 381);
            this.dgvProducts.TabIndex = 0;
            // 
            // tabPageProvider
            // 
            this.tabPageProvider.Controls.Add(this.btnDeleteProvider);
            this.tabPageProvider.Controls.Add(this.btnChangeProvider);
            this.tabPageProvider.Controls.Add(this.btnAddProvider);
            this.tabPageProvider.Controls.Add(this.dgvProviders);
            this.tabPageProvider.Location = new System.Drawing.Point(4, 25);
            this.tabPageProvider.Name = "tabPageProvider";
            this.tabPageProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvider.Size = new System.Drawing.Size(794, 425);
            this.tabPageProvider.TabIndex = 2;
            this.tabPageProvider.Text = "Поставщики";
            this.tabPageProvider.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProvider
            // 
            this.btnDeleteProvider.Location = new System.Drawing.Point(231, 391);
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteProvider.TabIndex = 6;
            this.btnDeleteProvider.Text = "Удалить";
            this.btnDeleteProvider.UseVisualStyleBackColor = true;
            this.btnDeleteProvider.Click += new System.EventHandler(this.btnDeleteProvider_Click);
            // 
            // btnChangeProvider
            // 
            this.btnChangeProvider.Location = new System.Drawing.Point(120, 391);
            this.btnChangeProvider.Name = "btnChangeProvider";
            this.btnChangeProvider.Size = new System.Drawing.Size(105, 23);
            this.btnChangeProvider.TabIndex = 5;
            this.btnChangeProvider.Text = "Изменить";
            this.btnChangeProvider.UseVisualStyleBackColor = true;
            this.btnChangeProvider.Click += new System.EventHandler(this.btnChangeProvider_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Location = new System.Drawing.Point(9, 391);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(105, 23);
            this.btnAddProvider.TabIndex = 4;
            this.btnAddProvider.Text = "Добавить";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // dgvProviders
            // 
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Location = new System.Drawing.Point(0, 3);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.RowHeadersWidth = 51;
            this.dgvProviders.RowTemplate.Height = 24;
            this.dgvProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProviders.Size = new System.Drawing.Size(791, 375);
            this.dgvProviders.TabIndex = 0;
            // 
            // tabPageProvidersReport
            // 
            this.tabPageProvidersReport.Controls.Add(this.providerChartSecondDate);
            this.tabPageProvidersReport.Controls.Add(this.providerChartFirstDate);
            this.tabPageProvidersReport.Controls.Add(this.tbProviderPick);
            this.tabPageProvidersReport.Controls.Add(this.btnProviderForm);
            this.tabPageProvidersReport.Controls.Add(this.cbProviderPick);
            this.tabPageProvidersReport.Controls.Add(this.providerChart);
            this.tabPageProvidersReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageProvidersReport.Name = "tabPageProvidersReport";
            this.tabPageProvidersReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvidersReport.Size = new System.Drawing.Size(794, 425);
            this.tabPageProvidersReport.TabIndex = 3;
            this.tabPageProvidersReport.Text = "Отчёт по поставщикам";
            this.tabPageProvidersReport.UseVisualStyleBackColor = true;
            // 
            // providerChartSecondDate
            // 
            this.providerChartSecondDate.Location = new System.Drawing.Point(568, 213);
            this.providerChartSecondDate.Name = "providerChartSecondDate";
            this.providerChartSecondDate.Size = new System.Drawing.Size(200, 22);
            this.providerChartSecondDate.TabIndex = 25;
            // 
            // providerChartFirstDate
            // 
            this.providerChartFirstDate.Location = new System.Drawing.Point(568, 166);
            this.providerChartFirstDate.Name = "providerChartFirstDate";
            this.providerChartFirstDate.Size = new System.Drawing.Size(200, 22);
            this.providerChartFirstDate.TabIndex = 24;
            // 
            // tbProviderPick
            // 
            this.tbProviderPick.Location = new System.Drawing.Point(568, 72);
            this.tbProviderPick.Name = "tbProviderPick";
            this.tbProviderPick.Size = new System.Drawing.Size(200, 22);
            this.tbProviderPick.TabIndex = 3;
            this.tbProviderPick.Text = "Выберите поставщика";
            // 
            // btnProviderForm
            // 
            this.btnProviderForm.Location = new System.Drawing.Point(606, 281);
            this.btnProviderForm.Name = "btnProviderForm";
            this.btnProviderForm.Size = new System.Drawing.Size(121, 39);
            this.btnProviderForm.TabIndex = 2;
            this.btnProviderForm.Text = "Сформировать";
            this.btnProviderForm.UseVisualStyleBackColor = true;
            this.btnProviderForm.Click += new System.EventHandler(this.btnProviderForm_Click);
            // 
            // cbProviderPick
            // 
            this.cbProviderPick.FormattingEnabled = true;
            this.cbProviderPick.Location = new System.Drawing.Point(568, 114);
            this.cbProviderPick.Name = "cbProviderPick";
            this.cbProviderPick.Size = new System.Drawing.Size(200, 24);
            this.cbProviderPick.TabIndex = 1;
            // 
            // providerChart
            // 
            chartArea3.Name = "ChartArea1";
            this.providerChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.providerChart.Legends.Add(legend3);
            this.providerChart.Location = new System.Drawing.Point(0, 0);
            this.providerChart.Name = "providerChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Оборот всего";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Оплачено";
            this.providerChart.Series.Add(series4);
            this.providerChart.Series.Add(series5);
            this.providerChart.Size = new System.Drawing.Size(524, 425);
            this.providerChart.TabIndex = 0;
            this.providerChart.Text = "chart1";
            // 
            // tabPageProductReport
            // 
            this.tabPageProductReport.Controls.Add(this.checkedListBox1);
            this.tabPageProductReport.Controls.Add(this.textBox1);
            this.tabPageProductReport.Controls.Add(this.btnProductForm);
            this.tabPageProductReport.Controls.Add(this.productChart);
            this.tabPageProductReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageProductReport.Name = "tabPageProductReport";
            this.tabPageProductReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductReport.Size = new System.Drawing.Size(794, 425);
            this.tabPageProductReport.TabIndex = 4;
            this.tabPageProductReport.Text = "Отчёт по товарам";
            this.tabPageProductReport.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(553, 114);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 106);
            this.checkedListBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Выберите товары";
            // 
            // btnProductForm
            // 
            this.btnProductForm.Location = new System.Drawing.Point(621, 312);
            this.btnProductForm.Name = "btnProductForm";
            this.btnProductForm.Size = new System.Drawing.Size(121, 39);
            this.btnProductForm.TabIndex = 28;
            this.btnProductForm.Text = "Сформировать";
            this.btnProductForm.UseVisualStyleBackColor = true;
            this.btnProductForm.Click += new System.EventHandler(this.btnProductForm_Click);
            // 
            // productChart
            // 
            chartArea4.Name = "ChartArea1";
            this.productChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.productChart.Legends.Add(legend4);
            this.productChart.Location = new System.Drawing.Point(13, 0);
            this.productChart.Name = "productChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Подлежит оплате";
            this.productChart.Series.Add(series6);
            this.productChart.Size = new System.Drawing.Size(524, 425);
            this.productChart.TabIndex = 26;
            this.productChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlMain);
            this.Name = "MainForm";
            this.Text = "Магазин (вариант 7)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabControlMain.ResumeLayout(false);
            this.tabPageSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPageProvider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.tabPageProvidersReport.ResumeLayout(false);
            this.tabPageProvidersReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerChart)).EndInit();
            this.tabPageProductReport.ResumeLayout(false);
            this.tabPageProductReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage tabPageSupply;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TabPage tabPageProvider;
        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.TabPage tabPageProvidersReport;
        private System.Windows.Forms.TabPage tabPageProductReport;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteSupply;
        private System.Windows.Forms.Button btnChangeSupply;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.Button btnDeleteProvider;
        private System.Windows.Forms.Button btnChangeProvider;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.TextBox tbProviderPick;
        private System.Windows.Forms.Button btnProviderForm;
        private System.Windows.Forms.ComboBox cbProviderPick;
        private System.Windows.Forms.DataVisualization.Charting.Chart providerChart;
        private System.Windows.Forms.DateTimePicker providerChartSecondDate;
        private System.Windows.Forms.DateTimePicker providerChartFirstDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnProductForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

