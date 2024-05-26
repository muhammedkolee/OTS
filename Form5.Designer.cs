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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            odaNo = new TextBox();
            grup = new TextBox();
            girisTarih = new TextBox();
            cikisTarih = new TextBox();
            fiyat = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(fiyat);
            groupBox1.Controls.Add(cikisTarih);
            groupBox1.Controls.Add(girisTarih);
            groupBox1.Controls.Add(grup);
            groupBox1.Controls.Add(odaNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon Bilgileri";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 171);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 3;
            label4.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 221);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 4;
            label5.Text = "Fiyat";
            // 
            // odaNo
            // 
            odaNo.Location = new Point(162, 33);
            odaNo.Name = "odaNo";
            odaNo.Size = new Size(125, 27);
            odaNo.TabIndex = 5;
            // 
            // grup
            // 
            grup.Location = new Point(162, 81);
            grup.Name = "grup";
            grup.Size = new Size(125, 27);
            grup.TabIndex = 6;
            // 
            // girisTarih
            // 
            girisTarih.Location = new Point(162, 128);
            girisTarih.Name = "girisTarih";
            girisTarih.Size = new Size(125, 27);
            girisTarih.TabIndex = 7;
            // 
            // cikisTarih
            // 
            cikisTarih.Location = new Point(162, 175);
            cikisTarih.Name = "cikisTarih";
            cikisTarih.Size = new Size(125, 27);
            cikisTarih.TabIndex = 8;
            // 
            // fiyat
            // 
            fiyat.Location = new Point(162, 225);
            fiyat.Name = "fiyat";
            fiyat.Size = new Size(125, 27);
            fiyat.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "$", "t", "g", "h" });
            textBox1.Location = new Point(293, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 27);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(566, 236);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 705);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox fiyat;
        private TextBox cikisTarih;
        private TextBox girisTarih;
        private TextBox grup;
        private TextBox odaNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}