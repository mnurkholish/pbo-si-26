namespace pertemuan_9
{
    partial class FormUser
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
            lblNama = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            tbUmur = new TextBox();
            lblUmur = new Label();
            tbAsal = new TextBox();
            lblAsal = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(12, 80);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(51, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(250, 38);
            label2.TabIndex = 1;
            label2.Text = "Tambah/Edit User";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(12, 103);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(439, 27);
            tbNama.TabIndex = 2;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // tbUmur
            // 
            tbUmur.Location = new Point(12, 176);
            tbUmur.Name = "tbUmur";
            tbUmur.Size = new Size(439, 27);
            tbUmur.TabIndex = 4;
            // 
            // lblUmur
            // 
            lblUmur.AutoSize = true;
            lblUmur.BackColor = Color.Transparent;
            lblUmur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUmur.ForeColor = Color.White;
            lblUmur.Location = new Point(12, 153);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(49, 20);
            lblUmur.TabIndex = 3;
            lblUmur.Text = "Umur";
            // 
            // tbAsal
            // 
            tbAsal.Location = new Point(12, 253);
            tbAsal.Name = "tbAsal";
            tbAsal.Size = new Size(439, 27);
            tbAsal.TabIndex = 6;
            // 
            // lblAsal
            // 
            lblAsal.AutoSize = true;
            lblAsal.BackColor = Color.Transparent;
            lblAsal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsal.ForeColor = Color.White;
            lblAsal.Location = new Point(12, 230);
            lblAsal.Name = "lblAsal";
            lblAsal.Size = new Size(39, 20);
            lblAsal.TabIndex = 5;
            lblAsal.Text = "Asal";
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(12, 307);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(tbAsal);
            Controls.Add(lblAsal);
            Controls.Add(tbUmur);
            Controls.Add(lblUmur);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(lblNama);
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label label2;
        private TextBox tbNama;
        private TextBox tbUmur;
        private Label lblUmur;
        private TextBox tbAsal;
        private Label lblAsal;
        private Button btnSimpan;
    }
}