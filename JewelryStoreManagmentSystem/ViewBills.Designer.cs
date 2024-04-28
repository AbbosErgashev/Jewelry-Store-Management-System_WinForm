namespace JewelryStoreManagmentSystem
{
    partial class ViewBills
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
            pictureBox1 = new PictureBox();
            BackBtn = new Button();
            SellsViewDGV = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellsViewDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_out;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Lime;
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackBtn.ForeColor = SystemColors.ControlText;
            BackBtn.Location = new Point(407, 540);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(147, 43);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // SellsViewDGV
            // 
            SellsViewDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SellsViewDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SellsViewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellsViewDGV.Location = new Point(12, 65);
            SellsViewDGV.Name = "SellsViewDGV";
            SellsViewDGV.RowHeadersWidth = 51;
            SellsViewDGV.Size = new Size(937, 454);
            SellsViewDGV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(427, 19);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Sells List";
            label1.Click += label1_Click;
            // 
            // ViewBills
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 614);
            Controls.Add(SellsViewDGV);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ViewBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBills";
            Load += ViewBills_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellsViewDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BackBtn;
        private DataGridView SellsViewDGV;
        private PictureBox pictureBox1;
    }
}