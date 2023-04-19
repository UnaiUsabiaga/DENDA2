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
            produktuId = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pantailaTamaina = new Label();
            mintegia = new Label();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            bajaEmandaErakutsi = new CheckBox();
            txtOrderBy = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // orderBy
            // 
            orderBy.AutoSize = true;
            orderBy.Location = new Point(357, 90);
            orderBy.Name = "orderBy";
            orderBy.Size = new Size(70, 20);
            orderBy.TabIndex = 0;
            orderBy.Text = "Order by:";
            // 
            // produktuId
            // 
            produktuId.AutoSize = true;
            produktuId.Location = new Point(28, 47);
            produktuId.Name = "produktuId";
            produktuId.Size = new Size(90, 20);
            produktuId.TabIndex = 1;
            produktuId.Text = "Produktu ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 4;
            // 
            // pantailaTamaina
            // 
            pantailaTamaina.AutoSize = true;
            pantailaTamaina.Location = new Point(28, 86);
            pantailaTamaina.Name = "pantailaTamaina";
            pantailaTamaina.Size = new Size(64, 20);
            pantailaTamaina.TabIndex = 3;
            pantailaTamaina.Text = "Pantaila:";
            // 
            // mintegia
            // 
            mintegia.AutoSize = true;
            mintegia.Location = new Point(357, 51);
            mintegia.Name = "mintegia";
            mintegia.Size = new Size(71, 20);
            mintegia.TabIndex = 5;
            mintegia.Text = "Mintegia:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Informatika", "Administraritza", "Zurgintza", "Mekanika e.m.", "Mekanika g.m.", "Mekatronika", "Arreta", "FOL eta Inglesa", "Zuzendaritza" });
            listBox1.Location = new Point(458, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 24);
            listBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 266);
            dataGridView1.TabIndex = 20;
            // 
            // bajaEmandaErakutsi
            // 
            bajaEmandaErakutsi.AutoSize = true;
            bajaEmandaErakutsi.Location = new Point(28, 133);
            bajaEmandaErakutsi.Name = "bajaEmandaErakutsi";
            bajaEmandaErakutsi.Size = new Size(271, 24);
            bajaEmandaErakutsi.TabIndex = 21;
            bajaEmandaErakutsi.Text = "Bajan emanda daudenak EZ erakutsi";
            bajaEmandaErakutsi.UseVisualStyleBackColor = true;
            bajaEmandaErakutsi.CheckedChanged += bajaEmandaErakutsi_CheckedChanged;
            // 
            // txtOrderBy
            // 
            txtOrderBy.Location = new Point(458, 87);
            txtOrderBy.Name = "txtOrderBy";
            txtOrderBy.Size = new Size(172, 27);
            txtOrderBy.TabIndex = 22;
            // 
            // datuakBistaratu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOrderBy);
            Controls.Add(bajaEmandaErakutsi);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(mintegia);
            Controls.Add(textBox2);
            Controls.Add(pantailaTamaina);
            Controls.Add(textBox1);
            Controls.Add(produktuId);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderBy;
        private Label produktuId;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label pantailaTamaina;
        private Label mintegia;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private CheckBox bajaEmandaErakutsi;
        private TextBox txtOrderBy;
    }
}