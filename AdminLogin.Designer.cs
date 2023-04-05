namespace ERRONKA7
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPasahitza = new TextBox();
            bAdminLogin = new Button();
            bItxiAdmin = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 56);
            label1.Name = "label1";
            label1.Size = new Size(369, 33);
            label1.TabIndex = 0;
            label1.Text = "Administraria Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 156);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 1;
            label2.Text = "Erabiltzailea: Administraria";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 203);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "Pasahitza:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPasahitza
            // 
            textPasahitza.Cursor = Cursors.IBeam;
            textPasahitza.Location = new Point(371, 203);
            textPasahitza.Name = "textPasahitza";
            textPasahitza.PasswordChar = '*';
            textPasahitza.Size = new Size(229, 27);
            textPasahitza.TabIndex = 3;
            textPasahitza.UseSystemPasswordChar = true;
            // 
            // bAdminLogin
            // 
            bAdminLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bAdminLogin.BackColor = Color.FromArgb(192, 255, 192);
            bAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bAdminLogin.Location = new Point(456, 318);
            bAdminLogin.Name = "bAdminLogin";
            bAdminLogin.Size = new Size(144, 92);
            bAdminLogin.TabIndex = 4;
            bAdminLogin.Text = "LOGIN";
            bAdminLogin.UseVisualStyleBackColor = false;
            bAdminLogin.Click += bAdminLogin_Click;
            // 
            // bItxiAdmin
            // 
            bItxiAdmin.BackColor = Color.FromArgb(255, 192, 192);
            bItxiAdmin.Location = new Point(265, 364);
            bItxiAdmin.Name = "bItxiAdmin";
            bItxiAdmin.Size = new Size(107, 46);
            bItxiAdmin.TabIndex = 5;
            bItxiAdmin.Text = "Itxi";
            bItxiAdmin.UseVisualStyleBackColor = false;
            bItxiAdmin.Click += bItxiAdmin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(662, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(bItxiAdmin);
            Controls.Add(bAdminLogin);
            Controls.Add(textPasahitza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administraria Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textPasahitza;
        private Button bAdminLogin;
        private Button bItxiAdmin;
        private PictureBox pictureBox2;
    }
}