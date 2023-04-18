namespace ERRONKA7
{
    partial class langileaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(langileaLogin));
            lLangileaLogin = new Label();
            bItxiAdmin = new Button();
            bLangileaLogin = new Button();
            textLangilePasahitza = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lLangileaLogin
            // 
            lLangileaLogin.AutoEllipsis = true;
            lLangileaLogin.AutoSize = true;
            lLangileaLogin.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lLangileaLogin.Location = new Point(241, 53);
            lLangileaLogin.Name = "lLangileaLogin";
            lLangileaLogin.Size = new Size(271, 33);
            lLangileaLogin.TabIndex = 1;
            lLangileaLogin.Text = "Langilea Login";
            lLangileaLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bItxiAdmin
            // 
            bItxiAdmin.BackColor = Color.FromArgb(255, 192, 192);
            bItxiAdmin.Location = new Point(241, 351);
            bItxiAdmin.Name = "bItxiAdmin";
            bItxiAdmin.Size = new Size(107, 46);
            bItxiAdmin.TabIndex = 10;
            bItxiAdmin.Text = "Itxi";
            bItxiAdmin.UseVisualStyleBackColor = false;
            bItxiAdmin.Click += bItxiLangilea_Click;
            // 
            // bLangileaLogin
            // 
            bLangileaLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bLangileaLogin.BackColor = Color.FromArgb(192, 255, 192);
            bLangileaLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bLangileaLogin.Location = new Point(430, 305);
            bLangileaLogin.Name = "bLangileaLogin";
            bLangileaLogin.Size = new Size(144, 92);
            bLangileaLogin.TabIndex = 9;
            bLangileaLogin.Text = "LOGIN";
            bLangileaLogin.UseVisualStyleBackColor = false;
            bLangileaLogin.Click += bLangileaLogin_Click;
            // 
            // textLangilePasahitza
            // 
            textLangilePasahitza.Cursor = Cursors.IBeam;
            textLangilePasahitza.Location = new Point(347, 195);
            textLangilePasahitza.Name = "textLangilePasahitza";
            textLangilePasahitza.PasswordChar = '*';
            textLangilePasahitza.Size = new Size(227, 27);
            textLangilePasahitza.TabIndex = 8;
            textLangilePasahitza.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(241, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 7;
            label3.Text = "Pasahitza:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(241, 138);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 6;
            label2.Text = "Erabiltzailea: Langilea";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(658, 305);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // langileaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(bItxiAdmin);
            Controls.Add(bLangileaLogin);
            Controls.Add(textLangilePasahitza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lLangileaLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "langileaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Langilea Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lLangileaLogin;
        private Button bItxiAdmin;
        private Button bLangileaLogin;
        private TextBox textLangilePasahitza;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
    }
}