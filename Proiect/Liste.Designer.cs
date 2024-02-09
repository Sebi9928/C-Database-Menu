namespace Proiect
{
    partial class Liste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeprodusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsenoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiectDataSet5 = new Proiect.ProiectDataSet5();
            this.produseTableAdapter = new Proiect.DataSet1TableAdapters.ProduseTableAdapter();
            this.produse_noiTableAdapter = new Proiect.ProiectDataSet5TableAdapters.Produse_noiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsenoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdDataGridViewTextBoxColumn,
            this.numeprodusDataGridViewTextBoxColumn,
            this.categorieprodusDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.codprodusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 180);
            this.dataGridView1.TabIndex = 13;
            // 
            // idProdDataGridViewTextBoxColumn
            // 
            this.idProdDataGridViewTextBoxColumn.DataPropertyName = "Id_Prod";
            this.idProdDataGridViewTextBoxColumn.HeaderText = "Id_Prod";
            this.idProdDataGridViewTextBoxColumn.Name = "idProdDataGridViewTextBoxColumn";
            this.idProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeprodusDataGridViewTextBoxColumn
            // 
            this.numeprodusDataGridViewTextBoxColumn.DataPropertyName = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn.HeaderText = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn.Name = "numeprodusDataGridViewTextBoxColumn";
            this.numeprodusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieprodusDataGridViewTextBoxColumn
            // 
            this.categorieprodusDataGridViewTextBoxColumn.DataPropertyName = "Categorie_produs";
            this.categorieprodusDataGridViewTextBoxColumn.HeaderText = "Categorie_produs";
            this.categorieprodusDataGridViewTextBoxColumn.Name = "categorieprodusDataGridViewTextBoxColumn";
            this.categorieprodusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codprodusDataGridViewTextBoxColumn
            // 
            this.codprodusDataGridViewTextBoxColumn.DataPropertyName = "Cod_produs";
            this.codprodusDataGridViewTextBoxColumn.HeaderText = "Cod_produs";
            this.codprodusDataGridViewTextBoxColumn.Name = "codprodusDataGridViewTextBoxColumn";
            this.codprodusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numeprodusDataGridViewTextBoxColumn1,
            this.categorieDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn1,
            this.descriereDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.produsenoiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(151, 414);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 180);
            this.dataGridView2.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeprodusDataGridViewTextBoxColumn1
            // 
            this.numeprodusDataGridViewTextBoxColumn1.DataPropertyName = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn1.HeaderText = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn1.Name = "numeprodusDataGridViewTextBoxColumn1";
            this.numeprodusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn1
            // 
            this.pretDataGridViewTextBoxColumn1.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn1.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn1.Name = "pretDataGridViewTextBoxColumn1";
            this.pretDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produsenoiBindingSource
            // 
            this.produsenoiBindingSource.DataMember = "Produse_noi";
            this.produsenoiBindingSource.DataSource = this.proiectDataSet5;
            // 
            // proiectDataSet5
            // 
            this.proiectDataSet5.DataSetName = "ProiectDataSet5";
            this.proiectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // produse_noiTableAdapter
            // 
            this.produse_noiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(556, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(289, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "LISTA PRODUSE STOC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(301, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "LISTA PRODUSE NOI";
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsenoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodusDataGridViewTextBoxColumn;
        private ProiectDataSet5 proiectDataSet5;
        private System.Windows.Forms.BindingSource produsenoiBindingSource;
        private ProiectDataSet5TableAdapters.Produse_noiTableAdapter produse_noiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeprodusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}