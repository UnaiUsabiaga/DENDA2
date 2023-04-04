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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Administraria = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Administraria
            // 
            Administraria.BackColor = SystemColors.ActiveCaption;
            Administraria.Cursor = Cursors.Hand;
            Administraria.Font = new Font("Perpetua Titling MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Administraria.Location = new Point(313, 157);
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
            button1.Location = new Point(313, 240);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(664, 322);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Administraria);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Hasiera";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Administraria;
        private Button button1;
        private EventHandler AdminLogin_Click;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}