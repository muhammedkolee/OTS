namespace Otel_Takip_Sistemi
{
    partial class Kayit
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
            groupBox1 = new GroupBox();
            number = new MaskedTextBox();
            save = new Button();
            password = new TextBox();
            tcLabel = new Label();
            numberLabel = new Label();
            passwordLabel = new Label();
            nicknameLabel = new Label();
            tcno = new TextBox();
            name = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            nickname = new TextBox();
            surname = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(number);
            groupBox1.Controls.Add(save);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(tcLabel);
            groupBox1.Controls.Add(numberLabel);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(nicknameLabel);
            groupBox1.Controls.Add(tcno);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(surnameLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(nickname);
            groupBox1.Controls.Add(surname);
            groupBox1.Location = new Point(183, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Ol";
            // 
            // number
            // 
            number.Location = new Point(129, 135);
            number.Mask = "0(999) 000-0000";
            number.Name = "number";
            number.Size = new Size(232, 27);
            number.TabIndex = 13;
            number.Text = "0";
            // 
            // save
            // 
            save.Location = new Point(267, 236);
            save.Name = "save";
            save.Size = new Size(94, 49);
            save.TabIndex = 12;
            save.Text = "Kaydet";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // password
            // 
            password.Location = new Point(129, 199);
            password.MaxLength = 15;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(232, 27);
            password.TabIndex = 11;
            // 
            // tcLabel
            // 
            tcLabel.AutoSize = true;
            tcLabel.Location = new Point(68, 37);
            tcLabel.Name = "tcLabel";
            tcLabel.Size = new Size(55, 20);
            tcLabel.TabIndex = 0;
            tcLabel.Text = "TC No.:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(35, 136);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(88, 20);
            numberLabel.TabIndex = 3;
            numberLabel.Text = "Telefon No.:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(81, 202);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(42, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Şifre:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(28, 169);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(95, 20);
            nicknameLabel.TabIndex = 4;
            nicknameLabel.Text = "Kullanıcı Adı:";
            // 
            // tcno
            // 
            tcno.Location = new Point(129, 34);
            tcno.MaxLength = 11;
            tcno.Name = "tcno";
            tcno.Size = new Size(232, 27);
            tcno.TabIndex = 6;
            tcno.KeyPress += tcno_KeyPress;
            // 
            // name
            // 
            name.Location = new Point(129, 67);
            name.MaxLength = 50;
            name.Name = "name";
            name.Size = new Size(232, 27);
            name.TabIndex = 7;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(70, 103);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(53, 20);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Soyad:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(92, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Ad:";
            // 
            // nickname
            // 
            nickname.Location = new Point(129, 166);
            nickname.MaxLength = 20;
            nickname.Name = "nickname";
            nickname.Size = new Size(232, 27);
            nickname.TabIndex = 10;
            // 
            // surname
            // 
            surname.Location = new Point(129, 100);
            surname.MaxLength = 50;
            surname.Name = "surname";
            surname.Size = new Size(232, 27);
            surname.TabIndex = 8;
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Kayit";
            Text = "Kayıt Ol";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox surname;
        private TextBox name;
        private TextBox tcno;
        private Label passwordLabel;
        private Label nicknameLabel;
        private Label numberLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private Label tcLabel;
        private Button save;
        private TextBox password;
        private TextBox nickname;
        private MaskedTextBox number;
    }
}