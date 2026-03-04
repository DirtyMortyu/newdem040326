namespace demm040326
{
    partial class changes
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
            txtArticle = new TextBox();
            bindingSource_tovar = new BindingSource(components);
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtUnit = new TextBox();
            txtPercent = new TextBox();
            txtMax = new TextBox();
            txtDescription = new TextBox();
            txtEntity = new TextBox();
            cmbManufacturer = new ComboBox();
            bindingSource_manuf = new BindingSource(components);
            cmmSuplier = new ComboBox();
            cmbCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button_save = new Button();
            button2 = new Button();
            bindingSource_sup = new BindingSource(components);
            bindingSource_categor = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource_tovar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manuf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_sup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_categor).BeginInit();
            SuspendLayout();
            // 
            // txtArticle
            // 
            txtArticle.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Article", true));
            txtArticle.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Article", true));
            txtArticle.Location = new Point(26, 41);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(177, 23);
            txtArticle.TabIndex = 0;
            // 
            // bindingSource_tovar
            // 
            bindingSource_tovar.DataSource = typeof(Models.Tovar);
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Name", true));
            txtName.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Name", true));
            txtName.Location = new Point(28, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Price", true));
            txtPrice.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Price", true));
            txtPrice.Location = new Point(28, 198);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Unit", true));
            txtUnit.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Unit", true));
            txtUnit.Location = new Point(26, 144);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(177, 23);
            txtUnit.TabIndex = 2;
            // 
            // txtPercent
            // 
            txtPercent.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Salepercent", true));
            txtPercent.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Salepercent", true));
            txtPercent.Location = new Point(30, 301);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(177, 23);
            txtPercent.TabIndex = 5;
            // 
            // txtMax
            // 
            txtMax.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Sizeorder", true));
            txtMax.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Sizeorder", true));
            txtMax.Location = new Point(28, 247);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(177, 23);
            txtMax.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Discription", true));
            txtDescription.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Discription", true));
            txtDescription.Location = new Point(28, 408);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(177, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtEntity
            // 
            txtEntity.DataBindings.Add(new Binding("DataContext", bindingSource_tovar, "Quantity", true));
            txtEntity.DataBindings.Add(new Binding("Text", bindingSource_tovar, "Quantity", true));
            txtEntity.Location = new Point(26, 354);
            txtEntity.Name = "txtEntity";
            txtEntity.Size = new Size(177, 23);
            txtEntity.TabIndex = 6;
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.DataBindings.Add(new Binding("SelectedValue", bindingSource_manuf, "Idmanufacturer", true));
            cmbManufacturer.DataSource = bindingSource_manuf;
            cmbManufacturer.DisplayMember = "Name";
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(242, 41);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(121, 23);
            cmbManufacturer.TabIndex = 8;
            cmbManufacturer.ValueMember = "Idmanufacturer";
            // 
            // bindingSource_manuf
            // 
            bindingSource_manuf.DataSource = typeof(Models.Manufacturer);
            // 
            // cmmSuplier
            // 
            cmmSuplier.DataBindings.Add(new Binding("SelectedValue", bindingSource_sup, "Idsupplier", true));
            cmmSuplier.DataSource = bindingSource_sup;
            cmmSuplier.DisplayMember = "Name";
            cmmSuplier.FormattingEnabled = true;
            cmmSuplier.Location = new Point(242, 95);
            cmmSuplier.Name = "cmmSuplier";
            cmmSuplier.Size = new Size(121, 23);
            cmmSuplier.TabIndex = 9;
            cmmSuplier.ValueMember = "Idsupplier";
            // 
            // cmbCategory
            // 
            cmbCategory.DataBindings.Add(new Binding("SelectedValue", bindingSource_categor, "Idcategory", true));
            cmbCategory.DataSource = bindingSource_categor;
            cmbCategory.DisplayMember = "Idcategory";
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(241, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 10;
            cmbCategory.ValueMember = "Idcategory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 14);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 11;
            label1.Text = "Артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 12;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 336);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Количество";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 14;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 228);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 15;
            label5.Text = "Максимум заказа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 23);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 16;
            label6.Text = "Производство";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 77);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 17;
            label7.Text = "Производитель";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 132);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 18;
            label8.Text = "Категория";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 283);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 19;
            label9.Text = "Скидка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 390);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 20;
            label10.Text = "Описание";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 126);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 21;
            label11.Text = "Единица измерения";
            // 
            // button_save
            // 
            button_save.Location = new Point(261, 286);
            button_save.Name = "button_save";
            button_save.Size = new Size(101, 47);
            button_save.TabIndex = 22;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(261, 353);
            button2.Name = "button2";
            button2.Size = new Size(101, 52);
            button2.TabIndex = 23;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bindingSource_sup
            // 
            bindingSource_sup.DataSource = typeof(Models.Supplier);
            // 
            // bindingSource_categor
            // 
            bindingSource_categor.DataSource = typeof(Models.Category);
            // 
            // changes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 475);
            Controls.Add(button2);
            Controls.Add(button_save);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategory);
            Controls.Add(cmmSuplier);
            Controls.Add(cmbManufacturer);
            Controls.Add(txtDescription);
            Controls.Add(txtEntity);
            Controls.Add(txtPercent);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Controls.Add(txtArticle);
            Name = "changes";
            Text = "changes";
            Load += changes_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource_tovar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manuf).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_sup).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_categor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArticle;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtUnit;
        private TextBox txtPercent;
        private TextBox txtMax;
        private TextBox txtDescription;
        private TextBox txtEntity;
        private ComboBox cmbManufacturer;
        private ComboBox cmmSuplier;
        private ComboBox cmbCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
        public Button button_save;
        public BindingSource bindingSource_tovar;
        public BindingSource bindingSource_manuf;
        public BindingSource bindingSource_sup;
        public BindingSource bindingSource_categor;
    }
}