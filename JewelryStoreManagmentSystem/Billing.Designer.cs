namespace JewelryStoreManagmentSystem
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            ViewBtn = new Button();
            pictureBox1 = new PictureBox();
            TotalLbl = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            ProductsDGV = new DataGridView();
            CustomersDGV = new DataGridView();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            CustomersLbl = new Label();
            panel2 = new Panel();
            AddToBillBtn = new Button();
            QtyTbl = new TextBox();
            label6 = new Label();
            CNameTbl = new TextBox();
            label4 = new Label();
            PriceTbl = new TextBox();
            label3 = new Label();
            PNameTbl = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ViewBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TotalLbl);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(BillDGV);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(CustomersLbl);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 712);
            panel1.TabIndex = 0;
            // 
            // ViewBtn
            // 
            ViewBtn.BackColor = Color.Lime;
            ViewBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ViewBtn.Location = new Point(156, 347);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(144, 44);
            ViewBtn.TabIndex = 30;
            ViewBtn.Text = "View Sells";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLbl.Location = new Point(997, 363);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(67, 31);
            TotalLbl.TabIndex = 28;
            TotalLbl.Text = "Total";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(ProductsDGV);
            panel3.Controls.Add(CustomersDGV);
            panel3.Location = new Point(15, 407);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 302);
            panel3.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(773, 15);
            label8.Name = "label8";
            label8.Size = new Size(129, 28);
            label8.TabIndex = 39;
            label8.Text = "Products List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(198, 15);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 38;
            label7.Text = "Customers List";
            // 
            // ProductsDGV
            // 
            ProductsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(-15, 52);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.Size = new Size(545, 225);
            ProductsDGV.TabIndex = 31;
            ProductsDGV.CellContentClick += ProductsDGV_CellContentClick;
            // 
            // CustomersDGV
            // 
            CustomersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersDGV.Location = new Point(562, 52);
            CustomersDGV.Name = "CustomersDGV";
            CustomersDGV.RowHeadersWidth = 51;
            CustomersDGV.Size = new Size(545, 225);
            CustomersDGV.TabIndex = 30;
            CustomersDGV.CellContentClick += CustomersDGV_CellContentClick;
            // 
            // BillDGV
            // 
            BillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Location = new Point(577, 120);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.Size = new Size(545, 225);
            BillDGV.TabIndex = 26;
            BillDGV.CellContentClick += BillDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Product";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(825, 120);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 25;
            label1.Text = "Bill";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // CustomersLbl
            // 
            CustomersLbl.AutoSize = true;
            CustomersLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLbl.Location = new Point(527, 32);
            CustomersLbl.Name = "CustomersLbl";
            CustomersLbl.Size = new Size(109, 28);
            CustomersLbl.TabIndex = 23;
            CustomersLbl.Text = "Customers";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddToBillBtn);
            panel2.Controls.Add(QtyTbl);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(CNameTbl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(PriceTbl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PNameTbl);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 225);
            panel2.TabIndex = 0;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.Lime;
            AddToBillBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            AddToBillBtn.Location = new Point(148, 169);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(159, 44);
            AddToBillBtn.TabIndex = 31;
            AddToBillBtn.Text = "Add To Bill";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // QtyTbl
            // 
            QtyTbl.Location = new Point(258, 38);
            QtyTbl.Name = "QtyTbl";
            QtyTbl.Size = new Size(202, 31);
            QtyTbl.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 10);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 36;
            label6.Text = "Quantity";
            // 
            // CNameTbl
            // 
            CNameTbl.Enabled = false;
            CNameTbl.Location = new Point(3, 111);
            CNameTbl.Name = "CNameTbl";
            CNameTbl.Size = new Size(205, 31);
            CNameTbl.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 83);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 34;
            label4.Text = "Customer Name";
            // 
            // PriceTbl
            // 
            PriceTbl.Enabled = false;
            PriceTbl.Location = new Point(258, 111);
            PriceTbl.Name = "PriceTbl";
            PriceTbl.Size = new Size(202, 31);
            PriceTbl.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 32;
            label3.Text = "Price";
            // 
            // PNameTbl
            // 
            PNameTbl.Enabled = false;
            PNameTbl.Location = new Point(3, 38);
            PNameTbl.Name = "PNameTbl";
            PNameTbl.Size = new Size(205, 31);
            PNameTbl.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 30;
            label5.Text = "Product Name";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 736);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView BillDGV;
        private Label label1;
        private PictureBox pictureBox2;
        private Label CustomersLbl;
        private Label TotalLbl;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private DataGridView ProductsDGV;
        private DataGridView CustomersDGV;
        private Button ViewBtn;
        private Button AddToBillBtn;
        private TextBox QtyTbl;
        private Label label6;
        private TextBox CNameTbl;
        private Label label4;
        private TextBox PriceTbl;
        private Label label3;
        private TextBox PNameTbl;
        private Label label5;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}