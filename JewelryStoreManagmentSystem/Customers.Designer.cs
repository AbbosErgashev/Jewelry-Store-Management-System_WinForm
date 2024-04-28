namespace JewelryStoreManagmentSystem
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            CustomersListDGV = new DataGridView();
            label6 = new Label();
            ResetBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            CNameTbl = new TextBox();
            label5 = new Label();
            CPhoneTbl = new TextBox();
            QuantityTbl = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            CustomersLbl = new Label();
            pictureBox1 = new PictureBox();
            ProductsLbl = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CustomersListDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // CustomersListDGV
            // 
            CustomersListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersListDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersListDGV.Location = new Point(12, 395);
            CustomersListDGV.Name = "CustomersListDGV";
            CustomersListDGV.RowHeadersWidth = 51;
            CustomersListDGV.Size = new Size(1117, 311);
            CustomersListDGV.TabIndex = 37;
            CustomersListDGV.CellContentClick += CustomersListDGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(528, 358);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 36;
            label6.Text = "Customers List";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Cyan;
            ResetBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ResetBtn.Location = new Point(770, 310);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(121, 49);
            ResetBtn.TabIndex = 35;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            UpdateBtn.Location = new Point(421, 310);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(121, 49);
            UpdateBtn.TabIndex = 34;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DeleteBtn.Location = new Point(602, 310);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(121, 49);
            DeleteBtn.TabIndex = 33;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Lime;
            SaveBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            SaveBtn.Location = new Point(244, 310);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 49);
            SaveBtn.TabIndex = 32;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CNameTbl
            // 
            CNameTbl.Location = new Point(224, 249);
            CNameTbl.Name = "CNameTbl";
            CNameTbl.Size = new Size(299, 31);
            CNameTbl.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 221);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 28;
            label5.Text = "Customer Name";
            // 
            // CPhoneTbl
            // 
            CPhoneTbl.Location = new Point(623, 249);
            CPhoneTbl.Name = "CPhoneTbl";
            CPhoneTbl.Size = new Size(292, 31);
            CPhoneTbl.TabIndex = 27;
            // 
            // QuantityTbl
            // 
            QuantityTbl.AutoSize = true;
            QuantityTbl.Location = new Point(623, 221);
            QuantityTbl.Name = "QuantityTbl";
            QuantityTbl.Size = new Size(144, 25);
            QuantityTbl.TabIndex = 26;
            QuantityTbl.Text = "Customer Phone";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ring1;
            pictureBox3.Location = new Point(528, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(608, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // CustomersLbl
            // 
            CustomersLbl.AutoSize = true;
            CustomersLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CustomersLbl.Location = new Point(678, 37);
            CustomersLbl.Name = "CustomersLbl";
            CustomersLbl.Size = new Size(109, 28);
            CustomersLbl.TabIndex = 21;
            CustomersLbl.Text = "Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // ProductsLbl
            // 
            ProductsLbl.AutoSize = true;
            ProductsLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ProductsLbl.Location = new Point(467, 37);
            ProductsLbl.Name = "ProductsLbl";
            ProductsLbl.Size = new Size(92, 28);
            ProductsLbl.TabIndex = 19;
            ProductsLbl.Text = "Products";
            ProductsLbl.Click += ProductsLbl_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(684, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 10);
            panel1.TabIndex = 39;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 722);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(CustomersListDGV);
            Controls.Add(label6);
            Controls.Add(ResetBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CNameTbl);
            Controls.Add(label5);
            Controls.Add(CPhoneTbl);
            Controls.Add(QuantityTbl);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(CustomersLbl);
            Controls.Add(pictureBox1);
            Controls.Add(ProductsLbl);
            MaximizeBox = false;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)CustomersListDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustomersListDGV;
        private Label label6;
        private Button ResetBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private TextBox CNameTbl;
        private Label label5;
        private TextBox CPhoneTbl;
        private Label QuantityTbl;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label CustomersLbl;
        private PictureBox pictureBox1;
        private Label ProductsLbl;
        private PictureBox pictureBox4;
        private Panel panel1;
    }
}