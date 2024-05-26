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
            groupBox1 = new GroupBox();
            enter = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            password = new Label();
            nickname = new Label();
            register = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(enter);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(nickname);
            groupBox1.Controls.Add(register);
            groupBox1.Location = new Point(203, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // enter
            // 
            enter.Location = new Point(68, 152);
            enter.Name = "enter";
            enter.Size = new Size(102, 47);
            enter.TabIndex = 6;
            enter.Text = "Giriş Yap";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(169, 91);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(169, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 4;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(121, 94);
            password.Name = "password";
            password.Size = new Size(42, 20);
            password.TabIndex = 3;
            password.Text = "Şifre:";
            // 
            // nickname
            // 
            nickname.AutoSize = true;
            nickname.Location = new Point(68, 56);
            nickname.Name = "nickname";
            nickname.Size = new Size(95, 20);
            nickname.TabIndex = 2;
            nickname.Text = "Kullanıcı Adı:";
            // 
            // register
            // 
            register.Location = new Point(255, 152);
            register.Name = "register";
            register.Size = new Size(102, 47);
            register.TabIndex = 1;
            register.Text = "Kayıt Ol";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Giris";
            Text = "Giriş";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label password;
        private Label nickname;
        private Button register;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button enter;
    }
}
