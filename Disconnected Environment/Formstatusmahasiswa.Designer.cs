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
            this.cbxNama = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.Label();
            this.cbxStatusMahasiswa = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxTahunMasuk = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // cbxNama
            // 
            this.cbxNama.AutoSize = true;
            this.cbxNama.Location = new System.Drawing.Point(141, 231);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(62, 13);
            this.cbxNama.TabIndex = 10;
            this.cbxNama.Text = "Nama Prodi";
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
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(141, 271);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(124, 13);
            this.txtNIM.TabIndex = 18;
            this.txtNIM.Text = "Nomor Induk Mahasiswa";
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.AutoSize = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(141, 314);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(93, 13);
            this.cbxStatusMahasiswa.TabIndex = 19;
            this.cbxStatusMahasiswa.Text = "Status Mahasiswa";
            this.cbxStatusMahasiswa.Click += new System.EventHandler(this.label2_Click);
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
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.AutoSize = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(141, 370);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(73, 13);
            this.cbxTahunMasuk.TabIndex = 21;
            this.cbxTahunMasuk.Text = "Tahun Masuk";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(267, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(267, 367);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 26;
            // 
            // Formstatusmahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxNama);
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
        private System.Windows.Forms.Label cbxNama;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Label cbxStatusMahasiswa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label cbxTahunMasuk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}