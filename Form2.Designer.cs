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
            datuakBistaratu = new Button();
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
            // datuakBistaratu
            // 
            datuakBistaratu.Location = new Point(256, 128);
            datuakBistaratu.MaximumSize = new Size(294, 72);
            datuakBistaratu.MinimumSize = new Size(294, 72);
            datuakBistaratu.Name = "datuakBistaratu";
            datuakBistaratu.Size = new Size(294, 72);
            datuakBistaratu.TabIndex = 1;
            datuakBistaratu.Text = "Datuak Bistaratu";
            datuakBistaratu.UseVisualStyleBackColor = true;
            // 
            // adminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(datuakBistaratu);
            Controls.Add(adminMenua);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "adminMenu";
            Text = "Administrari Menua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMenua;
        private Button datuakBistaratu;
    }
}