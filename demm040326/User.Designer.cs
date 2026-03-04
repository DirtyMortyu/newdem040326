namespace demm040326
{
    partial class User
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeorderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewComboBoxColumn();
            bindingSource_manuf = new BindingSource(components);
            supplierIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            bindingSource_sup = new BindingSource(components);
            categoryIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            bindingSource_categor = new BindingSource(components);
            salepercentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            bindingSource_tovar = new BindingSource(components);
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manuf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_sup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_categor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tovar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { articleDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, sizeorderDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, supplierIdDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, salepercentDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, discriptionDataGridViewTextBoxColumn, imageDataGridViewImageColumn });
            dataGridView1.DataSource = bindingSource_tovar;
            dataGridView1.Location = new Point(40, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(601, 212);
            dataGridView1.TabIndex = 0;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            articleDataGridViewTextBoxColumn.HeaderText = "Article";
            articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeorderDataGridViewTextBoxColumn
            // 
            sizeorderDataGridViewTextBoxColumn.DataPropertyName = "Sizeorder";
            sizeorderDataGridViewTextBoxColumn.HeaderText = "Sizeorder";
            sizeorderDataGridViewTextBoxColumn.Name = "sizeorderDataGridViewTextBoxColumn";
            sizeorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ManufId";
            dataGridViewTextBoxColumn1.DataSource = bindingSource_manuf;
            dataGridViewTextBoxColumn1.DisplayMember = "Name";
            dataGridViewTextBoxColumn1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridViewTextBoxColumn1.HeaderText = "ManufId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn1.ValueMember = "Idmanufacturer";
            // 
            // bindingSource_manuf
            // 
            bindingSource_manuf.DataSource = typeof(Models.Manufacturer);
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.DataSource = bindingSource_sup;
            supplierIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            supplierIdDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            supplierIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            supplierIdDataGridViewTextBoxColumn.ValueMember = "Idsupplier";
            // 
            // bindingSource_sup
            // 
            bindingSource_sup.DataSource = typeof(Models.Supplier);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.DataSource = bindingSource_categor;
            categoryIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            categoryIdDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            categoryIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            categoryIdDataGridViewTextBoxColumn.ValueMember = "Idcategory";
            // 
            // bindingSource_categor
            // 
            bindingSource_categor.DataSource = typeof(Models.Category);
            // 
            // salepercentDataGridViewTextBoxColumn
            // 
            salepercentDataGridViewTextBoxColumn.DataPropertyName = "Salepercent";
            salepercentDataGridViewTextBoxColumn.HeaderText = "Salepercent";
            salepercentDataGridViewTextBoxColumn.Name = "salepercentDataGridViewTextBoxColumn";
            salepercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            discriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.DataPropertyName = "Image";
            imageDataGridViewImageColumn.HeaderText = "Image";
            imageDataGridViewImageColumn.Image = Properties.Resources.picture;
            imageDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // bindingSource_tovar
            // 
            bindingSource_tovar.DataSource = typeof(Models.Tovar);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(713, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 424);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manuf).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_sup).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_categor).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tovar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        public BindingSource bindingSource_manuf;
        public BindingSource bindingSource_sup;
        public BindingSource bindingSource_categor;
        public BindingSource bindingSource_tovar;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeorderDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salepercentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
    }
}