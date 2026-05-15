namespace pertemuan_9 {
    partial class FormDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            LbJudul = new Label();
            dgv1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            umur = new DataGridViewTextBoxColumn();
            asal = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            hapus = new DataGridViewButtonColumn();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // LbJudul
            // 
            LbJudul.AutoSize = true;
            LbJudul.BackColor = Color.Transparent;
            LbJudul.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudul.ForeColor = Color.Beige;
            LbJudul.Location = new Point(48, 35);
            LbJudul.Name = "LbJudul";
            LbJudul.Size = new Size(344, 46);
            LbJudul.TabIndex = 2;
            LbJudul.Text = "Halaman Dashboard";
            // 
            // dgv1
            // 
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.BackgroundColor = Color.White;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { id, nama, umur, asal, edit, hapus });
            dgv1.Location = new Point(54, 218);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(814, 273);
            dgv1.TabIndex = 3;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // umur
            // 
            umur.DataPropertyName = "umur";
            umur.HeaderText = "Umur";
            umur.MinimumWidth = 6;
            umur.Name = "umur";
            umur.ReadOnly = true;
            // 
            // asal
            // 
            asal.DataPropertyName = "asal";
            asal.HeaderText = "Asal";
            asal.MinimumWidth = 6;
            asal.Name = "asal";
            asal.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.Text = "edit";
            edit.UseColumnTextForButtonValue = true;
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            // 
            // hapus
            // 
            hapus.HeaderText = "Hapus";
            hapus.Text = "hapus";
            hapus.UseColumnTextForButtonValue = true;
            hapus.MinimumWidth = 6;
            hapus.Name = "hapus";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.Highlight;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(774, 168);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnTambah);
            Controls.Add(dgv1);
            Controls.Add(LbJudul);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbJudul;
        private DataGridView dgv1;
        private Button btnTambah;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn umur;
        private DataGridViewTextBoxColumn asal;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn hapus;
    }
}