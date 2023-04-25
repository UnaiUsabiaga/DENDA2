namespace ERRONKA7
{
    partial class bErregistroBerria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bErregistroBerria));
            gailuMota = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtModeloa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPantaila = new TextBox();
            txtDeskribapena = new TextBox();
            btErregistroBerria = new Button();
            btDatuakBerritu = new Button();
            btBajaEman = new Button();
            btIrten = new Button();
            dataGridView1 = new DataGridView();
            erosketaDataPicker = new DateTimePicker();
            label6 = new Label();
            markaLabel = new Label();
            txtMarka = new TextBox();
            comboBoxGailuMota = new ComboBox();
            cBoxMintegia = new ComboBox();
            txtKantitatea = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gailuMota
            // 
            gailuMota.AutoSize = true;
            gailuMota.Location = new Point(44, 19);
            gailuMota.Name = "gailuMota";
            gailuMota.Size = new Size(85, 20);
            gailuMota.TabIndex = 0;
            gailuMota.Text = "Gailu mota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 68);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Kantitatea:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 24);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Mintegia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Modeloa:";
            // 
            // txtModeloa
            // 
            txtModeloa.Cursor = Cursors.IBeam;
            txtModeloa.Location = new Point(172, 114);
            txtModeloa.Name = "txtModeloa";
            txtModeloa.Size = new Size(171, 27);
            txtModeloa.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 114);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 10;
            label4.Text = "Pantaila tamaina:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 164);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 12;
            label5.Text = "Deskribapena:";
            label5.Click += label5_Click;
            // 
            // txtPantaila
            // 
            txtPantaila.CharacterCasing = CharacterCasing.Upper;
            txtPantaila.Cursor = Cursors.IBeam;
            txtPantaila.Location = new Point(555, 114);
            txtPantaila.Name = "txtPantaila";
            txtPantaila.Size = new Size(171, 27);
            txtPantaila.TabIndex = 13;
            // 
            // txtDeskribapena
            // 
            txtDeskribapena.CharacterCasing = CharacterCasing.Upper;
            txtDeskribapena.Cursor = Cursors.IBeam;
            txtDeskribapena.Location = new Point(555, 161);
            txtDeskribapena.Name = "txtDeskribapena";
            txtDeskribapena.Size = new Size(171, 27);
            txtDeskribapena.TabIndex = 14;
            // 
            // btErregistroBerria
            // 
            btErregistroBerria.BackColor = Color.FromArgb(192, 255, 192);
            btErregistroBerria.Location = new Point(44, 213);
            btErregistroBerria.Name = "btErregistroBerria";
            btErregistroBerria.Size = new Size(142, 52);
            btErregistroBerria.TabIndex = 15;
            btErregistroBerria.Text = "Erregistro Berria";
            btErregistroBerria.UseVisualStyleBackColor = false;
            btErregistroBerria.Click += btErregistroBerria_Click;
            // 
            // btDatuakBerritu
            // 
            btDatuakBerritu.Location = new Point(238, 213);
            btDatuakBerritu.Name = "btDatuakBerritu";
            btDatuakBerritu.Size = new Size(142, 52);
            btDatuakBerritu.TabIndex = 16;
            btDatuakBerritu.Text = "Datuak Berritu";
            btDatuakBerritu.UseVisualStyleBackColor = true;
            // 
            // btBajaEman
            // 
            btBajaEman.BackColor = Color.FromArgb(255, 192, 192);
            btBajaEman.Location = new Point(431, 213);
            btBajaEman.Name = "btBajaEman";
            btBajaEman.Size = new Size(142, 52);
            btBajaEman.TabIndex = 17;
            btBajaEman.Text = "Baja Eman";
            btBajaEman.UseVisualStyleBackColor = false;
            // 
            // btIrten
            // 
            btIrten.BackColor = Color.FromArgb(255, 128, 128);
            btIrten.Location = new Point(672, 213);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(81, 52);
            btIrten.TabIndex = 18;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = false;
            btIrten.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 169);
            dataGridView1.TabIndex = 19;
            // 
            // erosketaDataPicker
            // 
            erosketaDataPicker.Location = new Point(172, 163);
            erosketaDataPicker.Name = "erosketaDataPicker";
            erosketaDataPicker.Size = new Size(268, 27);
            erosketaDataPicker.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 170);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 22;
            label6.Text = "Erosketa Data:";
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new Point(44, 68);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new Size(53, 20);
            markaLabel.TabIndex = 23;
            markaLabel.Text = "Marka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(172, 61);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(171, 27);
            txtMarka.TabIndex = 24;
            // 
            // comboBoxGailuMota
            // 
            comboBoxGailuMota.AccessibleRole = AccessibleRole.ScrollBar;
            comboBoxGailuMota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGailuMota.Location = new Point(171, 16);
            comboBoxGailuMota.Name = "comboBoxGailuMota";
            comboBoxGailuMota.Size = new Size(172, 28);
            comboBoxGailuMota.TabIndex = 28;
            // 
            // cBoxMintegia
            // 
            cBoxMintegia.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxMintegia.FormattingEnabled = true;
            cBoxMintegia.Location = new Point(554, 16);
            cBoxMintegia.Name = "cBoxMintegia";
            cBoxMintegia.Size = new Size(172, 28);
            cBoxMintegia.TabIndex = 29;
            // 
            // txtKantitatea
            // 
            txtKantitatea.CharacterCasing = CharacterCasing.Upper;
            txtKantitatea.Cursor = Cursors.IBeam;
            txtKantitatea.Location = new Point(554, 68);
            txtKantitatea.Name = "txtKantitatea";
            txtKantitatea.Size = new Size(171, 27);
            txtKantitatea.TabIndex = 30;
            // 
            // bErregistroBerria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 469);
            Controls.Add(txtKantitatea);
            Controls.Add(cBoxMintegia);
            Controls.Add(comboBoxGailuMota);
            Controls.Add(txtMarka);
            Controls.Add(markaLabel);
            Controls.Add(label6);
            Controls.Add(erosketaDataPicker);
            Controls.Add(dataGridView1);
            Controls.Add(btIrten);
            Controls.Add(btBajaEman);
            Controls.Add(btDatuakBerritu);
            Controls.Add(btErregistroBerria);
            Controls.Add(txtDeskribapena);
            Controls.Add(txtPantaila);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtModeloa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gailuMota);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(817, 516);
            MinimumSize = new Size(817, 516);
            Name = "bErregistroBerria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Erregistroa";
            TopMost = true;
            Load += bErregistroBerria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gailuMota;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtModeloa;
        private Label label4;
        private Label label5;
        private TextBox txtPantaila;
        private TextBox txtDeskribapena;
        private Button btErregistroBerria;
        private Button btDatuakBerritu;
        private Button btBajaEman;
        private Button btIrten;
        private DataGridView dataGridView1;
        private DateTimePicker erosketaDataPicker;
        private Label label6;
        private Label markaLabel;
        private TextBox txtMarka;
        private ComboBox comboBoxGailuMota;
        private ComboBox cBoxMintegia;
        private TextBox txtKantitatea;
    }
}