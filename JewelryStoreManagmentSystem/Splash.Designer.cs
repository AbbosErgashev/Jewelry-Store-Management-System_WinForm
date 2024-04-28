namespace JewelryStoreManagmentSystem
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            PercentageLbl = new Label();
            ProgressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(233, 41);
            label1.Name = "label1";
            label1.Size = new Size(321, 28);
            label1.TabIndex = 0;
            label1.Text = "Jewelry Store Managment System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ring;
            pictureBox1.Location = new Point(320, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(12, 338);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 2;
            label2.Text = "Loading Modules... ";
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            PercentageLbl.Location = new Point(185, 338);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(27, 25);
            PercentageLbl.TabIndex = 3;
            PercentageLbl.Text = "%";
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = Color.White;
            ProgressBar.Location = new Point(12, 376);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(698, 18);
            ProgressBar.TabIndex = 4;
            ProgressBar.Click += ProgressBar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 336);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 5;
            label3.Text = "Dildora Qurbonova";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(722, 418);
            Controls.Add(label3);
            Controls.Add(ProgressBar);
            Controls.Add(PercentageLbl);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label PercentageLbl;
        private ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}
