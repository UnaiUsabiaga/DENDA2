namespace ERRONKA7
{
    partial class login
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
            Administraria = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Administraria
            // 
            Administraria.BackColor = SystemColors.ActiveCaption;
            Administraria.Cursor = Cursors.Hand;
            Administraria.Font = new Font("Perpetua Titling MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Administraria.Location = new Point(313, 103);
            Administraria.Name = "Administraria";
            Administraria.Size = new Size(181, 60);
            Administraria.TabIndex = 0;
            Administraria.Text = "Administraria";
            Administraria.UseVisualStyleBackColor = false;
            Administraria.Click += bAdmin_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(313, 192);
            button1.Name = "button1";
            button1.Size = new Size(181, 47);
            button1.TabIndex = 1;
            button1.Text = "Langilea";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(313, 373);
            button2.Name = "button2";
            button2.Size = new Size(181, 38);
            button2.TabIndex = 2;
            button2.Text = "Irten";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Administraria);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Hasiera";
            Load += login_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Administraria;
        private Button button1;
        private EventHandler AdminLogin_Click;
        private Button button2;
    }
}