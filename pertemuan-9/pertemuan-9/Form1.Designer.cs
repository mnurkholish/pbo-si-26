namespace pertemuan_9 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BtnLogin = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            LbLogin = new Label();
            LbPassword = new Label();
            LbUsername = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(LbLogin);
            panel1.Controls.Add(LbPassword);
            panel1.Controls.Add(LbUsername);
            panel1.Location = new Point(281, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 303);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.LOGO_UNEJ;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(94, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.OliveDrab;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Location = new Point(90, 228);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(73, 31);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = SystemColors.Menu;
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Location = new Point(27, 170);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(200, 23);
            TbPassword.TabIndex = 4;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = SystemColors.Menu;
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Location = new Point(27, 115);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(200, 23);
            TbUsername.TabIndex = 3;
            // 
            // LbLogin
            // 
            LbLogin.AutoSize = true;
            LbLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLogin.Location = new Point(72, 63);
            LbLogin.Name = "LbLogin";
            LbLogin.Size = new Size(110, 19);
            LbLogin.TabIndex = 2;
            LbLogin.Text = "FORM LOGIN";
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPassword.Location = new Point(27, 149);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(77, 18);
            LbPassword.TabIndex = 1;
            LbPassword.Text = "Password";
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbUsername.Location = new Point(27, 94);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(80, 18);
            LbUsername.TabIndex = 0;
            LbUsername.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LbLogin;
        private Label LbPassword;
        private Label LbUsername;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private PictureBox pictureBox1;
        private Button BtnLogin;
    }
}
