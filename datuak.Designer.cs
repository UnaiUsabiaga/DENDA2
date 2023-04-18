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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bErregistroBerria));
            bIzena = new Label();
            txtIzena = new TextBox();
            label1 = new Label();
            listBoxKantitatea = new ListBox();
            listBoxMintegi = new ListBox();
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
            mySqlDataReaderBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mySqlDataReaderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bIzena
            // 
            bIzena.AutoSize = true;
            bIzena.Location = new Point(44, 42);
            bIzena.Name = "bIzena";
            bIzena.Size = new Size(110, 20);
            bIzena.TabIndex = 0;
            bIzena.Text = "Produktu Izena:";
            // 
            // txtIzena
            // 
            txtIzena.CharacterCasing = CharacterCasing.Upper;
            txtIzena.Cursor = Cursors.IBeam;
            txtIzena.Location = new Point(172, 43);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(171, 27);
            txtIzena.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 86);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Kantitatea:";
            // 
            // listBoxKantitatea
            // 
            listBoxKantitatea.FormattingEnabled = true;
            listBoxKantitatea.ItemHeight = 20;
            listBoxKantitatea.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            listBoxKantitatea.Location = new Point(492, 86);
            listBoxKantitatea.Name = "listBoxKantitatea";
            listBoxKantitatea.Size = new Size(171, 24);
            listBoxKantitatea.TabIndex = 4;
            // 
            // listBoxMintegi
            // 
            listBoxMintegi.FormattingEnabled = true;
            listBoxMintegi.ItemHeight = 20;
            listBoxMintegi.Items.AddRange(new object[] { "Informatika", "Administraritza", "Zurgintza", "Mekanika e.m.", "Mekanika g.m.", "Mekatronika", "Arreta", "FOL eta Inglesa", "Zuzendaritza" });
            listBoxMintegi.Location = new Point(492, 43);
            listBoxMintegi.Name = "listBoxMintegi";
            listBoxMintegi.Size = new Size(171, 24);
            listBoxMintegi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 43);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Mintegia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 89);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Modeloa:";
            // 
            // txtModeloa
            // 
            txtModeloa.CharacterCasing = CharacterCasing.Upper;
            txtModeloa.Cursor = Cursors.IBeam;
            txtModeloa.Location = new Point(172, 86);
            txtModeloa.Name = "txtModeloa";
            txtModeloa.Size = new Size(171, 27);
            txtModeloa.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 139);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 10;
            label4.Text = "Pantaila tamaina:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 139);
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
            txtPantaila.Location = new Point(172, 132);
            txtPantaila.Name = "txtPantaila";
            txtPantaila.Size = new Size(171, 27);
            txtPantaila.TabIndex = 13;
            // 
            // txtDeskribapena
            // 
            txtDeskribapena.CharacterCasing = CharacterCasing.Upper;
            txtDeskribapena.Cursor = Cursors.IBeam;
            txtDeskribapena.Location = new Point(492, 136);
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
            // mySqlDataReaderBindingSource
            // 
            mySqlDataReaderBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlDataReader);
            // 
            // bErregistroBerria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 469);
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
            Controls.Add(listBoxMintegi);
            Controls.Add(label2);
            Controls.Add(listBoxKantitatea);
            Controls.Add(label1);
            Controls.Add(txtIzena);
            Controls.Add(bIzena);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(817, 516);
            MinimumSize = new Size(817, 516);
            Name = "bErregistroBerria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Erregistroa";
            TopMost = true;
            Load += bErregistroBerria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mySqlDataReaderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bIzena;
        private TextBox txtIzena;
        private Label label1;
        private ListBox listBoxKantitatea;
        private ListBox listBoxMintegi;
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
        private BindingSource mySqlDataReaderBindingSource;
    }
}