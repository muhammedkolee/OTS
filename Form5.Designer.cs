namespace Otel_Takip_Sistemi
{
    partial class Form5
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
            cikisTarih = new DateTimePicker();
            girisTarih = new DateTimePicker();
            CocukSayi = new ComboBox();
            label17 = new Label();
            yetiskinSayi = new ComboBox();
            label16 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            musteriTc = new TextBox();
            fiyat = new TextBox();
            odaNo = new TextBox();
            grup = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            kaydet = new Button();
            groupBox2 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            kadinRadioButton = new RadioButton();
            erkekRadioButton = new RadioButton();
            mail = new TextBox();
            yas = new TextBox();
            uyruk = new TextBox();
            Soyad = new TextBox();
            Ad = new TextBox();
            tcNo = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            helpProvider1 = new HelpProvider();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cikisTarih);
            groupBox1.Controls.Add(girisTarih);
            groupBox1.Controls.Add(CocukSayi);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(yetiskinSayi);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(musteriTc);
            groupBox1.Controls.Add(fiyat);
            groupBox1.Controls.Add(odaNo);
            groupBox1.Controls.Add(grup);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon Bilgileri";
            // 
            // cikisTarih
            // 
            cikisTarih.Location = new Point(177, 214);
            cikisTarih.Name = "cikisTarih";
            cikisTarih.Size = new Size(272, 27);
            cikisTarih.TabIndex = 36;
            cikisTarih.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // girisTarih
            // 
            girisTarih.Location = new Point(177, 169);
            girisTarih.Name = "girisTarih";
            girisTarih.Size = new Size(272, 27);
            girisTarih.TabIndex = 35;
            // 
            // CocukSayi
            // 
            CocukSayi.DropDownStyle = ComboBoxStyle.DropDownList;
            CocukSayi.FormattingEnabled = true;
            CocukSayi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            CocukSayi.Location = new Point(486, 77);
            CocukSayi.Name = "CocukSayi";
            CocukSayi.Size = new Size(57, 28);
            CocukSayi.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(383, 77);
            label17.Name = "label17";
            label17.Size = new Size(66, 28);
            label17.TabIndex = 15;
            label17.Text = "Çocuk";
            // 
            // yetiskinSayi
            // 
            yetiskinSayi.DropDownStyle = ComboBoxStyle.DropDownList;
            yetiskinSayi.FormattingEnabled = true;
            yetiskinSayi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            yetiskinSayi.Location = new Point(486, 36);
            yetiskinSayi.Name = "yetiskinSayi";
            yetiskinSayi.Size = new Size(57, 28);
            yetiskinSayi.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(383, 35);
            label16.Name = "label16";
            label16.Size = new Size(77, 28);
            label16.TabIndex = 13;
            label16.Text = "Yetişkin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 122);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 12;
            label6.Text = "Müşteri TC No.";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "$", "€", "₺" });
            comboBox1.Location = new Point(308, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(57, 28);
            comboBox1.TabIndex = 2;
            // 
            // musteriTc
            // 
            musteriTc.Location = new Point(177, 126);
            musteriTc.Name = "musteriTc";
            musteriTc.ReadOnly = true;
            musteriTc.Size = new Size(125, 27);
            musteriTc.TabIndex = 11;
            // 
            // fiyat
            // 
            fiyat.Location = new Point(177, 261);
            fiyat.Name = "fiyat";
            fiyat.ReadOnly = true;
            fiyat.Size = new Size(125, 27);
            fiyat.TabIndex = 9;
            // 
            // odaNo
            // 
            odaNo.Location = new Point(177, 36);
            odaNo.Name = "odaNo";
            odaNo.ReadOnly = true;
            odaNo.Size = new Size(125, 27);
            odaNo.TabIndex = 5;
            // 
            // grup
            // 
            grup.Location = new Point(177, 81);
            grup.Name = "grup";
            grup.ReadOnly = true;
            grup.Size = new Size(125, 27);
            grup.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 257);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 4;
            label5.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 212);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 3;
            label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 167);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 1;
            label2.Text = "Grup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Oda No.";
            // 
            // kaydet
            // 
            kaydet.Location = new Point(895, 436);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(116, 55);
            kaydet.TabIndex = 10;
            kaydet.Text = "Kaydet";
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(kadinRadioButton);
            groupBox2.Controls.Add(erkekRadioButton);
            groupBox2.Controls.Add(mail);
            groupBox2.Controls.Add(yas);
            groupBox2.Controls.Add(uyruk);
            groupBox2.Controls.Add(Soyad);
            groupBox2.Controls.Add(Ad);
            groupBox2.Controls.Add(tcNo);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(708, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 418);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(143, 291);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(137, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // kadinRadioButton
            // 
            kadinRadioButton.AutoSize = true;
            kadinRadioButton.Location = new Point(187, 208);
            kadinRadioButton.Name = "kadinRadioButton";
            kadinRadioButton.Size = new Size(39, 24);
            kadinRadioButton.TabIndex = 31;
            kadinRadioButton.TabStop = true;
            kadinRadioButton.Text = "K";
            kadinRadioButton.UseVisualStyleBackColor = true;
            kadinRadioButton.CheckedChanged += kadinRadioButton_CheckedChanged;
            // 
            // erkekRadioButton
            // 
            erkekRadioButton.AutoSize = true;
            erkekRadioButton.Location = new Point(143, 208);
            erkekRadioButton.Name = "erkekRadioButton";
            erkekRadioButton.Size = new Size(38, 24);
            erkekRadioButton.TabIndex = 30;
            erkekRadioButton.TabStop = true;
            erkekRadioButton.Text = "E";
            erkekRadioButton.UseVisualStyleBackColor = true;
            erkekRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // mail
            // 
            mail.Location = new Point(143, 380);
            mail.Name = "mail";
            mail.Size = new Size(137, 27);
            mail.TabIndex = 29;
            // 
            // yas
            // 
            yas.Location = new Point(143, 251);
            yas.MaxLength = 4;
            yas.Name = "yas";
            yas.Size = new Size(137, 27);
            yas.TabIndex = 27;
            yas.KeyPress += yas_KeyPress;
            // 
            // uyruk
            // 
            uyruk.Location = new Point(143, 165);
            uyruk.Name = "uyruk";
            uyruk.Size = new Size(137, 27);
            uyruk.TabIndex = 25;
            // 
            // Soyad
            // 
            Soyad.Location = new Point(143, 122);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(137, 27);
            Soyad.TabIndex = 24;
            Soyad.TextChanged += Soyad_TextChanged;
            // 
            // Ad
            // 
            Ad.Location = new Point(143, 81);
            Ad.Name = "Ad";
            Ad.Size = new Size(137, 27);
            Ad.TabIndex = 23;
            // 
            // tcNo
            // 
            tcNo.Location = new Point(143, 36);
            tcNo.MaxLength = 11;
            tcNo.Name = "tcNo";
            tcNo.Size = new Size(137, 27);
            tcNo.TabIndex = 22;
            tcNo.TextChanged += tcNo_TextChanged;
            tcNo.KeyPress += tcNo_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(8, 376);
            label15.Name = "label15";
            label15.Size = new Size(77, 28);
            label15.TabIndex = 21;
            label15.Text = "E-Posta";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(8, 333);
            label14.Name = "label14";
            label14.Size = new Size(129, 28);
            label14.TabIndex = 20;
            label14.Text = "Doğum Tarihi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(8, 290);
            label13.Name = "label13";
            label13.Size = new Size(110, 28);
            label13.TabIndex = 19;
            label13.Text = "Telefon No.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(8, 247);
            label12.Name = "label12";
            label12.Size = new Size(39, 28);
            label12.TabIndex = 18;
            label12.Text = "Yaş";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(8, 204);
            label11.Name = "label11";
            label11.Size = new Size(80, 28);
            label11.TabIndex = 17;
            label11.Text = "Cinsiyet";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(8, 161);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 16;
            label10.Text = "Uyruk";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 118);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 15;
            label9.Text = "Soyad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(37, 28);
            label8.TabIndex = 14;
            label8.Text = "Ad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 32);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 13;
            label7.Text = "Tc No.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 333);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 705);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(kaydet);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox musteriTc;
        private TextBox fiyat;
        private TextBox grup;
        private TextBox odaNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button kaydet;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox uyruk;
        private TextBox Soyad;
        private TextBox Ad;
        private TextBox tcNo;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox mail;
        private TextBox yas;
        private RadioButton kadinRadioButton;
        private RadioButton erkekRadioButton;
        private MaskedTextBox maskedTextBox1;
        private ComboBox CocukSayi;
        private Label label17;
        private ComboBox yetiskinSayi;
        private Label label16;
        private DateTimePicker cikisTarih;
        private DateTimePicker girisTarih;
        private HelpProvider helpProvider1;
    }
}