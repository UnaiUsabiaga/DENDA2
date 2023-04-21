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
            orderBy = new Label();
            produktuMota = new Label();
            mintegia = new Label();
            dataGridBistaratu = new DataGridView();
            bajaEmandaErakutsi = new CheckBox();
            txtOrderBy = new TextBox();
            btBistaratu = new Button();
            btReset = new Button();
            btIrten = new Button();
            comboBoxGailuMota = new ComboBox();
            comboBoxMintegia = new ComboBox();
            comboBoxEzaugarria = new ComboBox();
            comboBoxEzaugarriPosibleak = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridBistaratu).BeginInit();
            SuspendLayout();
            // 
            // orderBy
            // 
            orderBy.AutoSize = true;
            orderBy.Location = new Point(445, 62);
            orderBy.Name = "orderBy";
            orderBy.Size = new Size(56, 15);
            orderBy.TabIndex = 0;
            orderBy.Text = "Order by:";
            // 
            // produktuMota
            // 
            produktuMota.AutoSize = true;
            produktuMota.Location = new Point(20, 18);
            produktuMota.Name = "produktuMota";
            produktuMota.Size = new Size(68, 15);
            produktuMota.TabIndex = 3;
            produktuMota.Text = "Gailu Mota:";
            // 
            // mintegia
            // 
            mintegia.AutoSize = true;
            mintegia.Location = new Point(445, 22);
            mintegia.Name = "mintegia";
            mintegia.Size = new Size(57, 15);
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
            dataGridBistaratu.Location = new Point(11, 148);
            dataGridBistaratu.Margin = new Padding(3, 2, 3, 2);
            dataGridBistaratu.Name = "dataGridBistaratu";
            dataGridBistaratu.ReadOnly = true;
            dataGridBistaratu.RowHeadersWidth = 51;
            dataGridBistaratu.RowTemplate.Height = 29;
            dataGridBistaratu.Size = new Size(678, 181);
            dataGridBistaratu.TabIndex = 20;
            // 
            // bajaEmandaErakutsi
            // 
            bajaEmandaErakutsi.AutoSize = true;
            bajaEmandaErakutsi.Location = new Point(20, 125);
            bajaEmandaErakutsi.Margin = new Padding(3, 2, 3, 2);
            bajaEmandaErakutsi.Name = "bajaEmandaErakutsi";
            bajaEmandaErakutsi.Size = new Size(216, 19);
            bajaEmandaErakutsi.TabIndex = 21;
            bajaEmandaErakutsi.Text = "Bajan emanda daudenak EZ erakutsi";
            bajaEmandaErakutsi.UseVisualStyleBackColor = true;
            bajaEmandaErakutsi.CheckedChanged += bajaEmandaErakutsi_CheckedChanged;
            // 
            // txtOrderBy
            // 
            txtOrderBy.Location = new Point(513, 56);
            txtOrderBy.Margin = new Padding(3, 2, 3, 2);
            txtOrderBy.Name = "txtOrderBy";
            txtOrderBy.Size = new Size(151, 23);
            txtOrderBy.TabIndex = 22;
            // 
            // btBistaratu
            // 
            btBistaratu.BackColor = Color.FromArgb(192, 255, 192);
            btBistaratu.Cursor = Cursors.Hand;
            btBistaratu.Location = new Point(299, 105);
            btBistaratu.Margin = new Padding(3, 2, 3, 2);
            btBistaratu.Name = "btBistaratu";
            btBistaratu.Size = new Size(118, 38);
            btBistaratu.TabIndex = 24;
            btBistaratu.Text = "Bistaratu";
            btBistaratu.UseVisualStyleBackColor = false;
            btBistaratu.Click += btBistaratu_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(431, 105);
            btReset.Margin = new Padding(3, 2, 3, 2);
            btReset.Name = "btReset";
            btReset.Size = new Size(112, 38);
            btReset.TabIndex = 25;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btIrten
            // 
            btIrten.BackColor = Color.LightCoral;
            btIrten.Location = new Point(594, 113);
            btIrten.Margin = new Padding(3, 2, 3, 2);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(69, 30);
            btIrten.TabIndex = 26;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = false;
            btIrten.Click += btIrten_Click;
            // 
            // comboBoxGailuMota
            // 
            comboBoxGailuMota.AccessibleRole = AccessibleRole.ScrollBar;
            comboBoxGailuMota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGailuMota.Location = new Point(100, 16);
            comboBoxGailuMota.Margin = new Padding(3, 2, 3, 2);
            comboBoxGailuMota.Name = "comboBoxGailuMota";
            comboBoxGailuMota.Size = new Size(151, 23);
            comboBoxGailuMota.TabIndex = 27;
            comboBoxGailuMota.SelectedIndexChanged += comboBoxGailuMota_SelectedIndexChanged;
            // 
            // comboBoxMintegia
            // 
            comboBoxMintegia.Cursor = Cursors.Hand;
            comboBoxMintegia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMintegia.FormattingEnabled = true;
            comboBoxMintegia.Location = new Point(513, 16);
            comboBoxMintegia.Margin = new Padding(3, 2, 3, 2);
            comboBoxMintegia.Name = "comboBoxMintegia";
            comboBoxMintegia.Size = new Size(151, 23);
            comboBoxMintegia.TabIndex = 28;
            // 
            // comboBoxEzaugarria
            // 
            comboBoxEzaugarria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEzaugarria.FormattingEnabled = true;
            comboBoxEzaugarria.Location = new Point(264, 16);
            comboBoxEzaugarria.Margin = new Padding(3, 2, 3, 2);
            comboBoxEzaugarria.Name = "comboBoxEzaugarria";
            comboBoxEzaugarria.Size = new Size(154, 23);
            comboBoxEzaugarria.TabIndex = 29;
            // 
            // comboBoxEzaugarriPosibleak
            // 
            comboBoxEzaugarriPosibleak.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEzaugarriPosibleak.FormattingEnabled = true;
            comboBoxEzaugarriPosibleak.Location = new Point(264, 55);
            comboBoxEzaugarriPosibleak.Margin = new Padding(3, 2, 3, 2);
            comboBoxEzaugarriPosibleak.Name = "comboBoxEzaugarriPosibleak";
            comboBoxEzaugarriPosibleak.Size = new Size(154, 23);
            comboBoxEzaugarriPosibleak.TabIndex = 30;
            // 
            // datuakBistaratu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxEzaugarriPosibleak);
            Controls.Add(comboBoxEzaugarria);
            Controls.Add(comboBoxMintegia);
            Controls.Add(comboBoxGailuMota);
            Controls.Add(btIrten);
            Controls.Add(btReset);
            Controls.Add(btBistaratu);
            Controls.Add(txtOrderBy);
            Controls.Add(bajaEmandaErakutsi);
            Controls.Add(dataGridBistaratu);
            Controls.Add(mintegia);
            Controls.Add(produktuMota);
            Controls.Add(orderBy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(718, 383);
            MinimizeBox = false;
            MinimumSize = new Size(718, 383);
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

        private Label orderBy;
        private Label produktuMota;
        private Label mintegia;
        private DataGridView dataGridBistaratu;
        private CheckBox bajaEmandaErakutsi;
        private TextBox txtOrderBy;
        private Button btBistaratu;
        private Button btReset;
        private Button btIrten;
        private ComboBox comboBoxGailuMota;
        private ComboBox comboBoxMintegia;
        private ComboBox comboBoxEzaugarria;
        private ComboBox comboBoxEzaugarriPosibleak;
    }
}