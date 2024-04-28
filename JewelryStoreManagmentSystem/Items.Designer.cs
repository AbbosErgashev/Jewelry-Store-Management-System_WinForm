namespace JewelryStoreManagmentSystem
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            ProductsLbl = new Label();
            CustomersLbl = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ItemNameTbl = new TextBox();
            QuantityTbl = new TextBox();
            txt = new Label();
            PriceTbl = new TextBox();
            label5 = new Label();
            CategoriesCb = new ComboBox();
            TypesCb = new ComboBox();
            SaveBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ResetBtn = new Button();
            label6 = new Label();
            ProductListDGV = new DataGridView();
            FilterTy = new ComboBox();
            FilterCat = new ComboBox();
            ResetFilter = new Button();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // ProductsLbl
            // 
            ProductsLbl.AutoSize = true;
            ProductsLbl.Location = new Point(480, 36);
            ProductsLbl.Name = "ProductsLbl";
            ProductsLbl.Size = new Size(82, 25);
            ProductsLbl.TabIndex = 0;
            ProductsLbl.Text = "Products";
            // 
            // CustomersLbl
            // 
            CustomersLbl.AutoSize = true;
            CustomersLbl.Location = new Point(695, 40);
            CustomersLbl.Name = "CustomersLbl";
            CustomersLbl.Size = new Size(97, 25);
            CustomersLbl.TabIndex = 2;
            CustomersLbl.Text = "Customers";
            CustomersLbl.Click += CustomersLbl_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ring1;
            pictureBox3.Location = new Point(536, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 229);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 5;
            label3.Text = "Item";
            // 
            // ItemNameTbl
            // 
            ItemNameTbl.Location = new Point(74, 257);
            ItemNameTbl.Name = "ItemNameTbl";
            ItemNameTbl.Size = new Size(201, 31);
            ItemNameTbl.TabIndex = 6;
            // 
            // QuantityTbl
            // 
            QuantityTbl.Location = new Point(884, 257);
            QuantityTbl.Name = "QuantityTbl";
            QuantityTbl.Size = new Size(125, 31);
            QuantityTbl.TabIndex = 8;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(884, 229);
            txt.Name = "txt";
            txt.Size = new Size(80, 25);
            txt.TabIndex = 7;
            txt.Text = "Quantity";
            // 
            // PriceTbl
            // 
            PriceTbl.Location = new Point(711, 259);
            PriceTbl.Name = "PriceTbl";
            PriceTbl.Size = new Size(125, 31);
            PriceTbl.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(711, 231);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // CategoriesCb
            // 
            CategoriesCb.FormattingEnabled = true;
            CategoriesCb.Items.AddRange(new object[] { "Earing", "Necklace", "Ring" });
            CategoriesCb.Location = new Point(302, 257);
            CategoriesCb.Name = "CategoriesCb";
            CategoriesCb.Size = new Size(172, 33);
            CategoriesCb.TabIndex = 11;
            CategoriesCb.Text = "Categories";
            // 
            // TypesCb
            // 
            TypesCb.FormattingEnabled = true;
            TypesCb.Items.AddRange(new object[] { "Gold", "Silver", "Diamond" });
            TypesCb.Location = new Point(498, 257);
            TypesCb.Name = "TypesCb";
            TypesCb.Size = new Size(172, 33);
            TypesCb.TabIndex = 12;
            TypesCb.Text = "Types";
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Lime;
            SaveBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            SaveBtn.Location = new Point(257, 319);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(127, 45);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DeleteBtn.Location = new Point(550, 319);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(127, 45);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            UpdateBtn.Location = new Point(409, 319);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(127, 45);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Cyan;
            ResetBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ResetBtn.Location = new Point(702, 319);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(127, 45);
            ResetBtn.TabIndex = 16;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 430);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 17;
            label6.Text = "Products List";
            // 
            // ProductListDGV
            // 
            ProductListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductListDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListDGV.Location = new Point(12, 461);
            ProductListDGV.Name = "ProductListDGV";
            ProductListDGV.RowHeadersWidth = 51;
            ProductListDGV.Size = new Size(1113, 260);
            ProductListDGV.TabIndex = 18;
            ProductListDGV.CellContentClick += ProductListDGV_CellContentClick;
            // 
            // FilterTy
            // 
            FilterTy.FormattingEnabled = true;
            FilterTy.Items.AddRange(new object[] { "Gold", "Silver", "Diamond" });
            FilterTy.Location = new Point(803, 422);
            FilterTy.Name = "FilterTy";
            FilterTy.Size = new Size(176, 33);
            FilterTy.TabIndex = 20;
            FilterTy.Text = "Types";
            FilterTy.SelectionChangeCommitted += FilterTypes_SelectionChangeCommitted;
            // 
            // FilterCat
            // 
            FilterCat.FormattingEnabled = true;
            FilterCat.Items.AddRange(new object[] { "Earing", "Necklace", "Ring" });
            FilterCat.Location = new Point(609, 422);
            FilterCat.Name = "FilterCat";
            FilterCat.Size = new Size(169, 33);
            FilterCat.TabIndex = 19;
            FilterCat.Text = "Categories";
            FilterCat.SelectionChangeCommitted += FilterCategory_SelectionChangeCommitted;
            // 
            // ResetFilter
            // 
            ResetFilter.BackColor = Color.Cyan;
            ResetFilter.Location = new Point(985, 422);
            ResetFilter.Name = "ResetFilter";
            ResetFilter.Size = new Size(139, 33);
            ResetFilter.TabIndex = 21;
            ResetFilter.Text = "Reset Filter";
            ResetFilter.UseVisualStyleBackColor = false;
            ResetFilter.Click += ResetFilter_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(480, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 10);
            panel1.TabIndex = 42;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(625, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(405, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 733);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(ResetFilter);
            Controls.Add(FilterTy);
            Controls.Add(FilterCat);
            Controls.Add(ProductListDGV);
            Controls.Add(label6);
            Controls.Add(ResetBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(TypesCb);
            Controls.Add(CategoriesCb);
            Controls.Add(PriceTbl);
            Controls.Add(label5);
            Controls.Add(QuantityTbl);
            Controls.Add(txt);
            Controls.Add(ItemNameTbl);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(CustomersLbl);
            Controls.Add(ProductsLbl);
            MaximizeBox = false;
            Name = "Items";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductsLbl;
        private Label CustomersLbl;
        private PictureBox pictureBox3;
        private Label label3;
        private TextBox ItemNameTbl;
        private TextBox QuantityTbl;
        private Label txt;
        private TextBox PriceTbl;
        private Label label5;
        private ComboBox CategoriesCb;
        private ComboBox TypesCb;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ResetBtn;
        private Label label6;
        private DataGridView ProductListDGV;
        private ComboBox FilterTy;
        private ComboBox FilterCat;
        private Button ResetFilter;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}