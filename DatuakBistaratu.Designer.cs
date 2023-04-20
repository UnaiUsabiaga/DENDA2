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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datuakBistaratu));
            orderBy = new Label();
            produktuMota = new Label();
            mintegia = new Label();
            dataGridView1 = new DataGridView();
            bajaEmandaErakutsi = new CheckBox();
            txtOrderBy = new TextBox();
            btBistaratu = new Button();
            btReset = new Button();
            btIrten = new Button();
            comboBoxGailuMota = new ComboBox();
            comboBoxMintegia = new ComboBox();
            comboBoxEzaugarria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // orderBy
            // 
            orderBy.AutoSize = true;
            orderBy.Location = new Point(509, 82);
            orderBy.Name = "orderBy";
            orderBy.Size = new Size(70, 20);
            orderBy.TabIndex = 0;
            orderBy.Text = "Order by:";
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
            mintegia.Location = new Point(509, 29);
            mintegia.Name = "mintegia";
            mintegia.Size = new Size(71, 20);
            mintegia.TabIndex = 5;
            mintegia.Text = "Mintegia:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 241);
            dataGridView1.TabIndex = 20;
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
            // txtOrderBy
            // 
            txtOrderBy.Location = new Point(586, 74);
            txtOrderBy.Name = "txtOrderBy";
            txtOrderBy.Size = new Size(172, 27);
            txtOrderBy.TabIndex = 22;
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
            // 
            // btReset
            // 
            btReset.Location = new Point(493, 140);
            btReset.Name = "btReset";
            btReset.Size = new Size(128, 51);
            btReset.TabIndex = 25;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
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
            comboBoxGailuMota.FormattingEnabled = true;
            comboBoxGailuMota.Location = new Point(114, 21);
            comboBoxGailuMota.Name = "comboBoxGailuMota";
            comboBoxGailuMota.Size = new Size(172, 28);
            comboBoxGailuMota.TabIndex = 27;
            // 
            // comboBoxMintegia
            // 
            comboBoxMintegia.Cursor = Cursors.Hand;
            comboBoxMintegia.FormattingEnabled = true;
            comboBoxMintegia.Location = new Point(586, 21);
            comboBoxMintegia.Name = "comboBoxMintegia";
            comboBoxMintegia.Size = new Size(172, 28);
            comboBoxMintegia.TabIndex = 28;
            // 
            // comboBoxEzaugarria
            // 
            comboBoxEzaugarria.FormattingEnabled = true;
            comboBoxEzaugarria.Location = new Point(302, 21);
            comboBoxEzaugarria.Name = "comboBoxEzaugarria";
            comboBoxEzaugarria.Size = new Size(175, 28);
            comboBoxEzaugarria.TabIndex = 29;
            // 
            // datuakBistaratu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxEzaugarria);
            Controls.Add(comboBoxMintegia);
            Controls.Add(comboBoxGailuMota);
            Controls.Add(btIrten);
            Controls.Add(btReset);
            Controls.Add(btBistaratu);
            Controls.Add(txtOrderBy);
            Controls.Add(bajaEmandaErakutsi);
            Controls.Add(dataGridView1);
            Controls.Add(mintegia);
            Controls.Add(produktuMota);
            Controls.Add(orderBy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "datuakBistaratu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datuak Bistaratu";
            Load += datuakBistaratu_Load;
            KeyPress += datuakBistaratu_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderBy;
        private Label produktuMota;
        private Label mintegia;
        private DataGridView dataGridView1;
        private CheckBox bajaEmandaErakutsi;
        private TextBox txtOrderBy;
        private Button btBistaratu;
        private Button btReset;
        private Button btIrten;
        private ComboBox comboBoxGailuMota;
        private ComboBox comboBoxMintegia;
        private ComboBox comboBoxEzaugarria;
    }
}