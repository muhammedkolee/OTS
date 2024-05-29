namespace Otel_Takip_Sistemi
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            enter = new Button();
            sifre = new TextBox();
            nick = new TextBox();
            password = new Label();
            nickname = new Label();
            register = new Button();
            GirisYardim = new ToolTip(components);
            KayitYardim = new ToolTip(components);
            AdYardim = new ToolTip(components);
            SifreYardim = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(enter);
            groupBox1.Controls.Add(sifre);
            groupBox1.Controls.Add(nick);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(nickname);
            groupBox1.Controls.Add(register);
            groupBox1.Location = new Point(143, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // enter
            // 
            enter.Cursor = Cursors.Hand;
            enter.Location = new Point(68, 194);
            enter.Name = "enter";
            enter.Size = new Size(102, 62);
            enter.TabIndex = 6;
            enter.Text = "Giriş Yap";
            GirisYardim.SetToolTip(enter, "Odalarla ilgili işlem yapmak için \r\ngerekli menüye yönlendirir.");
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // sifre
            // 
            sifre.Cursor = Cursors.IBeam;
            sifre.Location = new Point(208, 94);
            sifre.MaxLength = 15;
            sifre.Name = "sifre";
            sifre.PasswordChar = '*';
            sifre.Size = new Size(188, 27);
            sifre.TabIndex = 5;
            GirisYardim.SetToolTip(sifre, "Şifrenizi giriniz.");
            // 
            // nick
            // 
            nick.Cursor = Cursors.IBeam;
            nick.Location = new Point(208, 53);
            nick.MaxLength = 20;
            nick.Name = "nick";
            nick.Size = new Size(188, 27);
            nick.TabIndex = 4;
            GirisYardim.SetToolTip(nick, "Kullanıcı adınızı giriniz.");
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial Black", 10.2F, FontStyle.Bold);
            password.Location = new Point(142, 94);
            password.Name = "password";
            password.Size = new Size(60, 24);
            password.TabIndex = 3;
            password.Text = "Şifre:";
            // 
            // nickname
            // 
            nickname.AutoSize = true;
            nickname.Font = new Font("Arial Black", 10.2F, FontStyle.Bold);
            nickname.Location = new Point(68, 56);
            nickname.Name = "nickname";
            nickname.Size = new Size(134, 24);
            nickname.TabIndex = 2;
            nickname.Text = "Kullanıcı Adı:";
            // 
            // register
            // 
            register.Cursor = Cursors.Hand;
            register.Location = new Point(279, 194);
            register.Name = "register";
            register.Size = new Size(117, 62);
            register.TabIndex = 1;
            register.Text = "Kayıt Ol";
            GirisYardim.SetToolTip(register, "Kayıt olmak için gerekli menüye yönlendirir.");
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // GirisYardim
            // 
            GirisYardim.AutoPopDelay = 500;
            GirisYardim.InitialDelay = 1000;
            GirisYardim.IsBalloon = true;
            GirisYardim.ReshowDelay = 100;
            GirisYardim.ToolTipIcon = ToolTipIcon.Info;
            GirisYardim.ToolTipTitle = "Bilgi";
            // 
            // KayitYardim
            // 
            KayitYardim.AutoPopDelay = 500;
            KayitYardim.InitialDelay = 1000;
            KayitYardim.IsBalloon = true;
            KayitYardim.ReshowDelay = 100;
            KayitYardim.ToolTipIcon = ToolTipIcon.Info;
            KayitYardim.ToolTipTitle = "Bilgi";
            // 
            // AdYardim
            // 
            AdYardim.AutoPopDelay = 500;
            AdYardim.InitialDelay = 1000;
            AdYardim.IsBalloon = true;
            AdYardim.ReshowDelay = 100;
            AdYardim.ToolTipIcon = ToolTipIcon.Info;
            AdYardim.ToolTipTitle = "Bilgi";
            // 
            // SifreYardim
            // 
            SifreYardim.AutoPopDelay = 500;
            SifreYardim.InitialDelay = 1000;
            SifreYardim.IsBalloon = true;
            SifreYardim.ReshowDelay = 100;
            SifreYardim.ToolTipIcon = ToolTipIcon.Info;
            SifreYardim.ToolTipTitle = "Bilgi";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Giris";
            Text = "Giriş";
            WindowState = FormWindowState.Maximized;
            KeyDown += Giris_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label password;
        private Label nickname;
        private Button register;
        private TextBox sifre;
        private TextBox nick;
        private Button enter;
        private ToolTip GirisYardim;
        private ToolTip KayitYardim;
        private ToolTip AdYardim;
        private ToolTip SifreYardim;
    }
}
