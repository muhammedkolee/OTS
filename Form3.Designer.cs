namespace Otel_Takip_Sistemi
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(216, 221);
            button1.Name = "button1";
            button1.Size = new Size(200, 175);
            button1.TabIndex = 0;
            button1.Text = "Rezervasyon";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(422, 221);
            button2.Name = "button2";
            button2.Size = new Size(200, 175);
            button2.TabIndex = 1;
            button2.Text = "Oda İşlemleri";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(216, 402);
            button3.Name = "button3";
            button3.Size = new Size(200, 175);
            button3.TabIndex = 2;
            button3.Text = "Oda İşlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(628, 221);
            button4.Name = "button4";
            button4.Size = new Size(200, 175);
            button4.TabIndex = 3;
            button4.Text = "Müşteri İşlemleri";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(422, 402);
            button5.Name = "button5";
            button5.Size = new Size(200, 175);
            button5.TabIndex = 4;
            button5.Text = "Oda İşlemleri";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(628, 402);
            button6.Name = "button6";
            button6.Size = new Size(200, 175);
            button6.TabIndex = 5;
            button6.Text = "Oda İşlemleri";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(152, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 750);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 703);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
    }
}