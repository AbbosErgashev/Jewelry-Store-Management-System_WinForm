namespace JewelryStoreManagmentSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label4 = new Label();
            LoginBtn = new Button();
            PasswordTbl = new TextBox();
            CancelLbl = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(266, 25);
            label4.Name = "label4";
            label4.Size = new Size(321, 28);
            label4.TabIndex = 18;
            label4.Text = "Jewelry Store Managment System";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Lime;
            LoginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = SystemColors.ControlText;
            LoginBtn.Location = new Point(359, 316);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(118, 49);
            LoginBtn.TabIndex = 17;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTbl
            // 
            PasswordTbl.Location = new Point(266, 246);
            PasswordTbl.Name = "PasswordTbl";
            PasswordTbl.PasswordChar = '*';
            PasswordTbl.Size = new Size(354, 31);
            PasswordTbl.TabIndex = 16;
            // 
            // CancelLbl
            // 
            CancelLbl.AutoSize = true;
            CancelLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            CancelLbl.Location = new Point(384, 401);
            CancelLbl.Name = "CancelLbl";
            CancelLbl.Size = new Size(66, 25);
            CancelLbl.TabIndex = 14;
            CancelLbl.Text = "Cancel";
            CancelLbl.Click += CancelLbl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 246);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(367, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTbl);
            Controls.Add(CancelLbl);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button LoginBtn;
        private TextBox PasswordTbl;
        private Label CancelLbl;
        private Label label3;
        private PictureBox pictureBox1;
    }
}