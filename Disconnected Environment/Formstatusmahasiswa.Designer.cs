namespace Disconnected_Environment
{
    partial class Formstatusmahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.act6DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.act6DataSet = new Disconnected_Environment.act6DataSet();
            this.Labelll = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.Labell = new System.Windows.Forms.Label();
            this.Labellll = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Labelllll = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.act6DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(85, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 162);
            this.dataGridView1.TabIndex = 11;
            // 
            // act6DataSetBindingSource
            // 
            this.act6DataSetBindingSource.DataSource = this.act6DataSet;
            this.act6DataSetBindingSource.Position = 0;
            // 
            // act6DataSet
            // 
            this.act6DataSet.DataSetName = "act6DataSet";
            this.act6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Labelll
            // 
            this.Labelll.AutoSize = true;
            this.Labelll.Location = new System.Drawing.Point(141, 231);
            this.Labelll.Name = "Labelll";
            this.Labelll.Size = new System.Drawing.Size(91, 13);
            this.Labelll.TabIndex = 10;
            this.Labelll.Text = "Nama Mahasiswa";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(480, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(626, 40);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 33);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Labell
            // 
            this.Labell.AutoSize = true;
            this.Labell.Location = new System.Drawing.Point(141, 271);
            this.Labell.Name = "Labell";
            this.Labell.Size = new System.Drawing.Size(124, 13);
            this.Labell.TabIndex = 18;
            this.Labell.Text = "Nomor Induk Mahasiswa";
            // 
            // Labellll
            // 
            this.Labellll.AutoSize = true;
            this.Labellll.Location = new System.Drawing.Point(141, 314);
            this.Labellll.Name = "Labellll";
            this.Labellll.Size = new System.Drawing.Size(93, 13);
            this.Labellll.TabIndex = 19;
            this.Labellll.Text = "Status Mahasiswa";
            this.Labellll.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(480, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 33);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Labelllll
            // 
            this.Labelllll.AutoSize = true;
            this.Labelllll.Location = new System.Drawing.Point(141, 370);
            this.Labelllll.Name = "Labelllll";
            this.Labelllll.Size = new System.Drawing.Size(73, 13);
            this.Labelllll.TabIndex = 21;
            this.Labelllll.Text = "Tahun Masuk";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(267, 228);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(191, 21);
            this.cbxNama.TabIndex = 23;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(267, 311);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(191, 21);
            this.cbxStatusMahasiswa.TabIndex = 24;
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(267, 367);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(191, 21);
            this.cbxTahunMasuk.TabIndex = 25;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(271, 268);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(187, 20);
            this.txtNIM.TabIndex = 26;
            // 
            // Formstatusmahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.Labelllll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Labellll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Labell);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Labelll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Name = "Formstatusmahasiswa";
            this.Text = "Formstatusmahasiswa";
            this.Load += new System.EventHandler(this.Formstatusmahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource act6DataSetBindingSource;
        private act6DataSet act6DataSet;
        private System.Windows.Forms.Label Labelll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label Labell;
        private System.Windows.Forms.Label Labellll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Labelllll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.TextBox txtNIM;
    }
}