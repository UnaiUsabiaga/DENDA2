﻿namespace ERRONKA7
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
            lLangileaLogin = new Label();
            bItxiAdmin = new Button();
            bAdminLogin = new Button();
            textPasahitza = new TextBox();
            label3 = new Label();
            label2 = new Label();
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
            bItxiAdmin.Click += bItxiAdmin_Click;
            // 
            // bAdminLogin
            // 
            bAdminLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bAdminLogin.BackColor = Color.FromArgb(192, 255, 192);
            bAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bAdminLogin.Location = new Point(430, 305);
            bAdminLogin.Name = "bAdminLogin";
            bAdminLogin.Size = new Size(144, 92);
            bAdminLogin.TabIndex = 9;
            bAdminLogin.Text = "LOGIN";
            bAdminLogin.UseVisualStyleBackColor = false;
            // 
            // textPasahitza
            // 
            textPasahitza.Cursor = Cursors.IBeam;
            textPasahitza.Location = new Point(347, 195);
            textPasahitza.Name = "textPasahitza";
            textPasahitza.PasswordChar = '*';
            textPasahitza.Size = new Size(227, 27);
            textPasahitza.TabIndex = 8;
            textPasahitza.UseSystemPasswordChar = true;
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
            // langileaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bItxiAdmin);
            Controls.Add(bAdminLogin);
            Controls.Add(textPasahitza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lLangileaLogin);
            Name = "langileaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Langilea Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lLangileaLogin;
        private Button bItxiAdmin;
        private Button bAdminLogin;
        private TextBox textPasahitza;
        private Label label3;
        private Label label2;
    }
}