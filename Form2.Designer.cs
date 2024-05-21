namespace Otel_Takip_Sistemi
{
    partial class Form2
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
            tc = new Label();
            name = new Label();
            surname = new Label();
            number = new Label();
            nickname = new Label();
            password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            save = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(save);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(nickname);
            groupBox1.Controls.Add(number);
            groupBox1.Controls.Add(surname);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(tc);
            groupBox1.Location = new Point(183, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Ol";
            // 
            // tc
            // 
            tc.AutoSize = true;
            tc.Location = new Point(68, 50);
            tc.Name = "tc";
            tc.Size = new Size(55, 20);
            tc.TabIndex = 0;
            tc.Text = "TC No.:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(92, 80);
            name.Name = "name";
            name.Size = new Size(31, 20);
            name.TabIndex = 1;
            name.Text = "Ad:";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(73, 110);
            surname.Name = "surname";
            surname.Size = new Size(53, 20);
            surname.TabIndex = 2;
            surname.Text = "Soyad:";
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(38, 139);
            number.Name = "number";
            number.Size = new Size(88, 20);
            number.TabIndex = 3;
            number.Text = "Telefon No.:";
            // 
            // nickname
            // 
            nickname.AutoSize = true;
            nickname.Location = new Point(31, 171);
            nickname.Name = "nickname";
            nickname.Size = new Size(95, 20);
            nickname.TabIndex = 4;
            nickname.Text = "Kullanıcı Adı:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(81, 201);
            password.Name = "password";
            password.Size = new Size(42, 20);
            password.TabIndex = 5;
            password.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 198);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(232, 27);
            textBox6.TabIndex = 11;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label password;
        private Label nickname;
        private Label number;
        private Label surname;
        private Label name;
        private Label tc;
        private Button save;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}