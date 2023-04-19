namespace ERRONKA7
{
    partial class adminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMenu));
            adminMenua = new Label();
            BTdatuakBistaratu = new Button();
            BTdatuakEguneratu = new Button();
            btIrten = new Button();
            SuspendLayout();
            // 
            // adminMenua
            // 
            adminMenua.AutoSize = true;
            adminMenua.Font = new Font("Rockwell Nova", 18F, FontStyle.Regular, GraphicsUnit.Point);
            adminMenua.Location = new Point(229, 35);
            adminMenua.Name = "adminMenua";
            adminMenua.Size = new Size(336, 41);
            adminMenua.TabIndex = 0;
            adminMenua.Text = "Administrazio Menua";
            // 
            // BTdatuakBistaratu
            // 
            BTdatuakBistaratu.BackColor = Color.FromArgb(255, 255, 192);
            BTdatuakBistaratu.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BTdatuakBistaratu.ForeColor = Color.Black;
            BTdatuakBistaratu.Location = new Point(250, 117);
            BTdatuakBistaratu.MaximumSize = new Size(294, 72);
            BTdatuakBistaratu.MinimumSize = new Size(294, 72);
            BTdatuakBistaratu.Name = "BTdatuakBistaratu";
            BTdatuakBistaratu.Size = new Size(294, 72);
            BTdatuakBistaratu.TabIndex = 1;
            BTdatuakBistaratu.Text = "Datuak Bistaratu";
            BTdatuakBistaratu.UseVisualStyleBackColor = false;
            BTdatuakBistaratu.Click += BTdatuakBistaratu_Click;
            // 
            // BTdatuakEguneratu
            // 
            BTdatuakEguneratu.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BTdatuakEguneratu.ForeColor = Color.FromArgb(64, 64, 64);
            BTdatuakEguneratu.Location = new Point(250, 219);
            BTdatuakEguneratu.MaximumSize = new Size(294, 72);
            BTdatuakEguneratu.MinimumSize = new Size(294, 72);
            BTdatuakEguneratu.Name = "BTdatuakEguneratu";
            BTdatuakEguneratu.Size = new Size(294, 72);
            BTdatuakEguneratu.TabIndex = 2;
            BTdatuakEguneratu.Text = "Datuak Eguneratu";
            BTdatuakEguneratu.UseVisualStyleBackColor = true;
            BTdatuakEguneratu.Click += BTdatuakEguneratu_Click;
            // 
            // btIrten
            // 
            btIrten.BackColor = Color.FromArgb(255, 128, 128);
            btIrten.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btIrten.Location = new Point(329, 362);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(119, 61);
            btIrten.TabIndex = 3;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = false;
            btIrten.Click += btIrten_Click;
            // 
            // adminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btIrten);
            Controls.Add(BTdatuakEguneratu);
            Controls.Add(BTdatuakBistaratu);
            Controls.Add(adminMenua);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "adminMenu";
            Text = "Administrari Menua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMenua;
        private Button BTdatuakBistaratu;
        private Button BTdatuakEguneratu;
        private Button btIrten;
    }
}