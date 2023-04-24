namespace ERRONKA7
{
    partial class datuakBistaratu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datuakBistaratu));
            produktuMota = new Label();
            mintegia = new Label();
            dataGridBistaratu = new DataGridView();
            bajaEmandaErakutsi = new CheckBox();
            btBistaratu = new Button();
            btReset = new Button();
            btIrten = new Button();
            comboBoxGailuMota = new ComboBox();
            comboBoxMintegia = new ComboBox();
            comboBoxEzaugarria = new ComboBox();
            comboBoxEzaugarriPosibleak = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridBistaratu).BeginInit();
            SuspendLayout();
            // 
            // produktuMota
            // 
            produktuMota.AutoSize = true;
            produktuMota.Location = new Point(23, 24);
            produktuMota.Name = "produktuMota";
            produktuMota.Size = new Size(85, 20);
            produktuMota.TabIndex = 3;
            produktuMota.Text = "Gailu Mota:";
            // 
            // mintegia
            // 
            mintegia.AutoSize = true;
            mintegia.Location = new Point(23, 105);
            mintegia.Name = "mintegia";
            mintegia.Size = new Size(71, 20);
            mintegia.TabIndex = 5;
            mintegia.Text = "Mintegia:";
            // 
            // dataGridBistaratu
            // 
            dataGridBistaratu.AllowUserToAddRows = false;
            dataGridBistaratu.AllowUserToDeleteRows = false;
            dataGridBistaratu.AllowUserToResizeColumns = false;
            dataGridBistaratu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridBistaratu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridBistaratu.BackgroundColor = SystemColors.Control;
            dataGridBistaratu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridBistaratu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBistaratu.GridColor = SystemColors.Control;
            dataGridBistaratu.Location = new Point(13, 197);
            dataGridBistaratu.Name = "dataGridBistaratu";
            dataGridBistaratu.ReadOnly = true;
            dataGridBistaratu.RowHeadersWidth = 51;
            dataGridBistaratu.RowTemplate.Height = 29;
            dataGridBistaratu.Size = new Size(775, 241);
            dataGridBistaratu.TabIndex = 20;
            // 
            // bajaEmandaErakutsi
            // 
            bajaEmandaErakutsi.AutoSize = true;
            bajaEmandaErakutsi.Location = new Point(23, 167);
            bajaEmandaErakutsi.Name = "bajaEmandaErakutsi";
            bajaEmandaErakutsi.Size = new Size(271, 24);
            bajaEmandaErakutsi.TabIndex = 21;
            bajaEmandaErakutsi.Text = "Bajan emanda daudenak EZ erakutsi";
            bajaEmandaErakutsi.UseVisualStyleBackColor = true;
            bajaEmandaErakutsi.CheckedChanged += bajaEmandaErakutsi_CheckedChanged;
            // 
            // btBistaratu
            // 
            btBistaratu.BackColor = Color.FromArgb(192, 255, 192);
            btBistaratu.Cursor = Cursors.Hand;
            btBistaratu.Location = new Point(342, 140);
            btBistaratu.Name = "btBistaratu";
            btBistaratu.Size = new Size(135, 51);
            btBistaratu.TabIndex = 24;
            btBistaratu.Text = "Bistaratu";
            btBistaratu.UseVisualStyleBackColor = false;
            btBistaratu.Click += btBistaratu_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(493, 140);
            btReset.Name = "btReset";
            btReset.Size = new Size(128, 51);
            btReset.TabIndex = 25;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btIrten
            // 
            btIrten.BackColor = Color.LightCoral;
            btIrten.Location = new Point(679, 151);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(79, 40);
            btIrten.TabIndex = 26;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = false;
            btIrten.Click += btIrten_Click;
            // 
            // comboBoxGailuMota
            // 
            comboBoxGailuMota.AccessibleRole = AccessibleRole.ScrollBar;
            comboBoxGailuMota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGailuMota.Location = new Point(114, 21);
            comboBoxGailuMota.Name = "comboBoxGailuMota";
            comboBoxGailuMota.Size = new Size(172, 28);
            comboBoxGailuMota.TabIndex = 27;
            comboBoxGailuMota.SelectedIndexChanged += comboBoxGailuMota_SelectedIndexChanged;
            // 
            // comboBoxMintegia
            // 
            comboBoxMintegia.Cursor = Cursors.Hand;
            comboBoxMintegia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMintegia.FormattingEnabled = true;
            comboBoxMintegia.Location = new Point(114, 97);
            comboBoxMintegia.Name = "comboBoxMintegia";
            comboBoxMintegia.Size = new Size(172, 28);
            comboBoxMintegia.TabIndex = 28;
            // 
            // comboBoxEzaugarria
            // 
            comboBoxEzaugarria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEzaugarria.FormattingEnabled = true;
            comboBoxEzaugarria.Location = new Point(114, 59);
            comboBoxEzaugarria.Name = "comboBoxEzaugarria";
            comboBoxEzaugarria.Size = new Size(172, 28);
            comboBoxEzaugarria.TabIndex = 29;
            comboBoxEzaugarria.SelectedIndexChanged += comboBoxEzaugarria_SelectedIndexChanged;
            // 
            // comboBoxEzaugarriPosibleak
            // 
            comboBoxEzaugarriPosibleak.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEzaugarriPosibleak.FormattingEnabled = true;
            comboBoxEzaugarriPosibleak.Location = new Point(342, 64);
            comboBoxEzaugarriPosibleak.Name = "comboBoxEzaugarriPosibleak";
            comboBoxEzaugarriPosibleak.Size = new Size(175, 28);
            comboBoxEzaugarriPosibleak.TabIndex = 30;
            comboBoxEzaugarriPosibleak.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 31;
            label1.Text = "Ezaugarria:";
            // 
            // datuakBistaratu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 448);
            Controls.Add(label1);
            Controls.Add(comboBoxEzaugarriPosibleak);
            Controls.Add(comboBoxEzaugarria);
            Controls.Add(comboBoxMintegia);
            Controls.Add(comboBoxGailuMota);
            Controls.Add(btIrten);
            Controls.Add(btReset);
            Controls.Add(btBistaratu);
            Controls.Add(bajaEmandaErakutsi);
            Controls.Add(dataGridBistaratu);
            Controls.Add(mintegia);
            Controls.Add(produktuMota);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(818, 495);
            MinimizeBox = false;
            MinimumSize = new Size(818, 495);
            Name = "datuakBistaratu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datuak Bistaratu";
            Load += datuakBistaratu_Load;
            KeyPress += datuakBistaratu_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dataGridBistaratu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label produktuMota;
        private Label mintegia;
        private DataGridView dataGridBistaratu;
        private CheckBox bajaEmandaErakutsi;
        private Button btBistaratu;
        private Button btReset;
        private Button btIrten;
        private ComboBox comboBoxGailuMota;
        private ComboBox comboBoxMintegia;
        private ComboBox comboBoxEzaugarria;
        private ComboBox comboBoxEzaugarriPosibleak;
        private Label label1;
    }
}