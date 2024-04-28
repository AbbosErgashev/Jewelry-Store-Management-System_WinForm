namespace JewelryStoreManagmentSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ContinueLbl = new Label();
            UsernameTbl = new TextBox();
            PasswordTbl = new TextBox();
            LoginBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 238);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 284);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // ContinueLbl
            // 
            ContinueLbl.AutoSize = true;
            ContinueLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            ContinueLbl.Location = new Point(315, 416);
            ContinueLbl.Name = "ContinueLbl";
            ContinueLbl.Size = new Size(171, 25);
            ContinueLbl.TabIndex = 6;
            ContinueLbl.Text = "Continue as Admin";
            ContinueLbl.Click += label4_Click;
            // 
            // UsernameTbl
            // 
            UsernameTbl.Location = new Point(253, 239);
            UsernameTbl.Name = "UsernameTbl";
            UsernameTbl.Size = new Size(354, 31);
            UsernameTbl.TabIndex = 7;
            // 
            // PasswordTbl
            // 
            PasswordTbl.Location = new Point(253, 284);
            PasswordTbl.Name = "PasswordTbl";
            PasswordTbl.PasswordChar = '*';
            PasswordTbl.Size = new Size(354, 31);
            PasswordTbl.TabIndex = 8;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Lime;
            LoginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = SystemColors.ControlText;
            LoginBtn.Location = new Point(340, 337);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(118, 49);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(247, 40);
            label4.Name = "label4";
            label4.Size = new Size(321, 28);
            label4.TabIndex = 10;
            label4.Text = "Jewelry Store Managment System";
            label4.Click += label4_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 457);
            Controls.Add(label4);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTbl);
            Controls.Add(UsernameTbl);
            Controls.Add(ContinueLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label ContinueLbl;
        private TextBox UsernameTbl;
        private TextBox PasswordTbl;
        private Button LoginBtn;
        private Label label4;
    }
}