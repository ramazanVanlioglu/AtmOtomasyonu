namespace AtmOtomasyonu
{
    partial class Ana_Menü
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Menü));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button_paraCek = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label_bakiye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_paraYatir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_paraGonder = new System.Windows.Forms.Button();
            this.button_paraGonderOnay = new System.Windows.Forms.Button();
            this.button_paraYatirOnay = new System.Windows.Forms.Button();
            this.button_paraCekOnay = new System.Windows.Forms.Button();
            this.textBox_cekilecekMiktar = new System.Windows.Forms.TextBox();
            this.textBox_yatirilacakMiktar = new System.Windows.Forms.TextBox();
            this.textBox_gonderilecekMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_isim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_cikisYap = new System.Windows.Forms.Button();
            this.label_dolar = new System.Windows.Forms.Label();
            this.label_euro = new System.Windows.Forms.Label();
            this.richTextBox_durum = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_gonderilecekKartNumara = new System.Windows.Forms.TextBox();
            this.dataGridView_Durumlar = new System.Windows.Forms.DataGridView();
            this.Column_Islem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_YapilmaZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_YapanKisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Durumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam bakiyeniz: ";
            // 
            // button_paraCek
            // 
            this.button_paraCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_paraCek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_paraCek.ImageKey = "newParaCekme.ico";
            this.button_paraCek.ImageList = this.imageList1;
            this.button_paraCek.Location = new System.Drawing.Point(20, 263);
            this.button_paraCek.Name = "button_paraCek";
            this.button_paraCek.Size = new System.Drawing.Size(146, 39);
            this.button_paraCek.TabIndex = 0;
            this.button_paraCek.Tag = "";
            this.button_paraCek.Text = "Para Çek";
            this.button_paraCek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_paraCek.UseVisualStyleBackColor = true;
            this.button_paraCek.Click += new System.EventHandler(this.button_paraCek_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "paraCekme.ico");
            this.imageList1.Images.SetKeyName(1, "paraGonderme.ico");
            this.imageList1.Images.SetKeyName(2, "paraYatirma.ico");
            this.imageList1.Images.SetKeyName(3, "exit.ico");
            this.imageList1.Images.SetKeyName(4, "newParaCekme.ico");
            this.imageList1.Images.SetKeyName(5, "atm.ico");
            // 
            // label_bakiye
            // 
            this.label_bakiye.AutoSize = true;
            this.label_bakiye.BackColor = System.Drawing.Color.Khaki;
            this.label_bakiye.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bakiye.Location = new System.Drawing.Point(238, 102);
            this.label_bakiye.Name = "label_bakiye";
            this.label_bakiye.Size = new System.Drawing.Size(90, 27);
            this.label_bakiye.TabIndex = 2;
            this.label_bakiye.Text = "bakiye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 3;
            this.label3.Tag = "0";
            this.label3.Text = "Çekmek istediğiniz miktarı yazın:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 5;
            this.label4.Tag = "1";
            this.label4.Text = "Yatırmak istedğiniz miktarı girin";
            this.label4.Visible = false;
            // 
            // button_paraYatir
            // 
            this.button_paraYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_paraYatir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_paraYatir.ImageKey = "paraYatirma.ico";
            this.button_paraYatir.ImageList = this.imageList1;
            this.button_paraYatir.Location = new System.Drawing.Point(20, 323);
            this.button_paraYatir.Name = "button_paraYatir";
            this.button_paraYatir.Size = new System.Drawing.Size(146, 39);
            this.button_paraYatir.TabIndex = 1;
            this.button_paraYatir.Tag = "";
            this.button_paraYatir.Text = "Para Yatır";
            this.button_paraYatir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_paraYatir.UseVisualStyleBackColor = true;
            this.button_paraYatir.Click += new System.EventHandler(this.button_paraYatir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 16);
            this.label5.TabIndex = 7;
            this.label5.Tag = "2";
            this.label5.Text = "Gönderilecek kişinin kart numarasını yazın:";
            this.label5.Visible = false;
            // 
            // button_paraGonder
            // 
            this.button_paraGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_paraGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_paraGonder.ImageKey = "paraGonderme.ico";
            this.button_paraGonder.ImageList = this.imageList1;
            this.button_paraGonder.Location = new System.Drawing.Point(19, 375);
            this.button_paraGonder.Name = "button_paraGonder";
            this.button_paraGonder.Size = new System.Drawing.Size(151, 39);
            this.button_paraGonder.TabIndex = 2;
            this.button_paraGonder.Text = "Para Gönder";
            this.button_paraGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_paraGonder.UseVisualStyleBackColor = true;
            this.button_paraGonder.Click += new System.EventHandler(this.button_paraGonder_Click);
            // 
            // button_paraGonderOnay
            // 
            this.button_paraGonderOnay.Location = new System.Drawing.Point(606, 417);
            this.button_paraGonderOnay.Name = "button_paraGonderOnay";
            this.button_paraGonderOnay.Size = new System.Drawing.Size(100, 28);
            this.button_paraGonderOnay.TabIndex = 9;
            this.button_paraGonderOnay.Tag = "2";
            this.button_paraGonderOnay.Text = "Para Gönder";
            this.button_paraGonderOnay.UseVisualStyleBackColor = true;
            this.button_paraGonderOnay.Visible = false;
            this.button_paraGonderOnay.Click += new System.EventHandler(this.button_paraGonderOnay_Click);
            // 
            // button_paraYatirOnay
            // 
            this.button_paraYatirOnay.Location = new System.Drawing.Point(660, 321);
            this.button_paraYatirOnay.Name = "button_paraYatirOnay";
            this.button_paraYatirOnay.Size = new System.Drawing.Size(109, 31);
            this.button_paraYatirOnay.TabIndex = 6;
            this.button_paraYatirOnay.Tag = "1";
            this.button_paraYatirOnay.Text = "Para Yatır";
            this.button_paraYatirOnay.UseVisualStyleBackColor = true;
            this.button_paraYatirOnay.Visible = false;
            this.button_paraYatirOnay.Click += new System.EventHandler(this.button_paraYatirOnay_Click);
            // 
            // button_paraCekOnay
            // 
            this.button_paraCekOnay.Location = new System.Drawing.Point(660, 269);
            this.button_paraCekOnay.Name = "button_paraCekOnay";
            this.button_paraCekOnay.Size = new System.Drawing.Size(109, 33);
            this.button_paraCekOnay.TabIndex = 4;
            this.button_paraCekOnay.Tag = "0";
            this.button_paraCekOnay.Text = "Para Çek";
            this.button_paraCekOnay.UseVisualStyleBackColor = true;
            this.button_paraCekOnay.Visible = false;
            this.button_paraCekOnay.Click += new System.EventHandler(this.button_paraCekOnay_Click);
            // 
            // textBox_cekilecekMiktar
            // 
            this.textBox_cekilecekMiktar.Location = new System.Drawing.Point(381, 274);
            this.textBox_cekilecekMiktar.Name = "textBox_cekilecekMiktar";
            this.textBox_cekilecekMiktar.Size = new System.Drawing.Size(244, 22);
            this.textBox_cekilecekMiktar.TabIndex = 3;
            this.textBox_cekilecekMiktar.Tag = "0";
            this.textBox_cekilecekMiktar.Visible = false;
            // 
            // textBox_yatirilacakMiktar
            // 
            this.textBox_yatirilacakMiktar.Location = new System.Drawing.Point(381, 325);
            this.textBox_yatirilacakMiktar.Name = "textBox_yatirilacakMiktar";
            this.textBox_yatirilacakMiktar.Size = new System.Drawing.Size(244, 22);
            this.textBox_yatirilacakMiktar.TabIndex = 5;
            this.textBox_yatirilacakMiktar.Tag = "1";
            this.textBox_yatirilacakMiktar.Visible = false;
            // 
            // textBox_gonderilecekMiktar
            // 
            this.textBox_gonderilecekMiktar.Location = new System.Drawing.Point(462, 420);
            this.textBox_gonderilecekMiktar.Name = "textBox_gonderilecekMiktar";
            this.textBox_gonderilecekMiktar.Size = new System.Drawing.Size(128, 22);
            this.textBox_gonderilecekMiktar.TabIndex = 8;
            this.textBox_gonderilecekMiktar.Tag = "2";
            this.textBox_gonderilecekMiktar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 12;
            this.label2.Tag = "2";
            this.label2.Text = "Miktarı belirtin:";
            this.label2.Visible = false;
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isim.Location = new System.Drawing.Point(222, 18);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(75, 33);
            this.label_isim.TabIndex = 14;
            this.label_isim.Text = "isim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hoş geldiniz,";
            // 
            // button_cikisYap
            // 
            this.button_cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikisYap.ForeColor = System.Drawing.Color.Red;
            this.button_cikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cikisYap.ImageKey = "exit.ico";
            this.button_cikisYap.ImageList = this.imageList1;
            this.button_cikisYap.Location = new System.Drawing.Point(690, 497);
            this.button_cikisYap.Name = "button_cikisYap";
            this.button_cikisYap.Size = new System.Drawing.Size(134, 48);
            this.button_cikisYap.TabIndex = 16;
            this.button_cikisYap.Text = "Çıkış Yap";
            this.button_cikisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cikisYap.UseVisualStyleBackColor = true;
            this.button_cikisYap.Click += new System.EventHandler(this.button_cikisYap_Click);
            // 
            // label_dolar
            // 
            this.label_dolar.AutoSize = true;
            this.label_dolar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dolar.Location = new System.Drawing.Point(7, 203);
            this.label_dolar.Name = "label_dolar";
            this.label_dolar.Size = new System.Drawing.Size(207, 27);
            this.label_dolar.TabIndex = 17;
            this.label_dolar.Text = "Dolar Karşılığı";
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_euro.Location = new System.Drawing.Point(7, 158);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(194, 27);
            this.label_euro.TabIndex = 18;
            this.label_euro.Text = "Euro Karşılığı";
            // 
            // richTextBox_durum
            // 
            this.richTextBox_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBox_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_durum.Location = new System.Drawing.Point(830, 63);
            this.richTextBox_durum.Name = "richTextBox_durum";
            this.richTextBox_durum.Size = new System.Drawing.Size(513, 220);
            this.richTextBox_durum.TabIndex = 19;
            this.richTextBox_durum.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(825, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Durum";
            // 
            // textBox_gonderilecekKartNumara
            // 
            this.textBox_gonderilecekKartNumara.Location = new System.Drawing.Point(462, 380);
            this.textBox_gonderilecekKartNumara.Name = "textBox_gonderilecekKartNumara";
            this.textBox_gonderilecekKartNumara.Size = new System.Drawing.Size(244, 22);
            this.textBox_gonderilecekKartNumara.TabIndex = 21;
            this.textBox_gonderilecekKartNumara.Tag = "2";
            this.textBox_gonderilecekKartNumara.Visible = false;
            // 
            // dataGridView_Durumlar
            // 
            this.dataGridView_Durumlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView_Durumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Durumlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Islem,
            this.Column_YapilmaZamani,
            this.Column_YapanKisi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Durumlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Durumlar.Location = new System.Drawing.Point(830, 289);
            this.dataGridView_Durumlar.Name = "dataGridView_Durumlar";
            this.dataGridView_Durumlar.RowHeadersWidth = 51;
            this.dataGridView_Durumlar.RowTemplate.Height = 24;
            this.dataGridView_Durumlar.Size = new System.Drawing.Size(511, 256);
            this.dataGridView_Durumlar.TabIndex = 22;
            // 
            // Column_Islem
            // 
            this.Column_Islem.HeaderText = "İşlem";
            this.Column_Islem.MinimumWidth = 6;
            this.Column_Islem.Name = "Column_Islem";
            this.Column_Islem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Islem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Islem.Width = 125;
            // 
            // Column_YapilmaZamani
            // 
            this.Column_YapilmaZamani.HeaderText = "Yapılma Zamanı";
            this.Column_YapilmaZamani.MinimumWidth = 6;
            this.Column_YapilmaZamani.Name = "Column_YapilmaZamani";
            this.Column_YapilmaZamani.Width = 125;
            // 
            // Column_YapanKisi
            // 
            this.Column_YapanKisi.HeaderText = "Gönderen Kişi";
            this.Column_YapanKisi.MinimumWidth = 6;
            this.Column_YapanKisi.Name = "Column_YapanKisi";
            this.Column_YapanKisi.Width = 125;
            // 
            // Ana_Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 557);
            this.Controls.Add(this.dataGridView_Durumlar);
            this.Controls.Add(this.textBox_gonderilecekKartNumara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_durum);
            this.Controls.Add(this.label_euro);
            this.Controls.Add(this.label_dolar);
            this.Controls.Add(this.button_cikisYap);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_gonderilecekMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_yatirilacakMiktar);
            this.Controls.Add(this.textBox_cekilecekMiktar);
            this.Controls.Add(this.button_paraGonderOnay);
            this.Controls.Add(this.button_paraYatirOnay);
            this.Controls.Add(this.button_paraCekOnay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_paraGonder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_paraYatir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_bakiye);
            this.Controls.Add(this.button_paraCek);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ana_Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana_Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ana_Menü_FormClosing);
            this.Load += new System.EventHandler(this.Ana_Menü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Durumlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_paraCek;
        private System.Windows.Forms.Label label_bakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_paraYatir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_paraGonder;
        private System.Windows.Forms.Button button_paraGonderOnay;
        private System.Windows.Forms.Button button_paraYatirOnay;
        private System.Windows.Forms.Button button_paraCekOnay;
        private System.Windows.Forms.TextBox textBox_cekilecekMiktar;
        private System.Windows.Forms.TextBox textBox_yatirilacakMiktar;
        private System.Windows.Forms.TextBox textBox_gonderilecekMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_cikisYap;
        private System.Windows.Forms.Label label_dolar;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox_durum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_gonderilecekKartNumara;
        private System.Windows.Forms.DataGridView dataGridView_Durumlar;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Islem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_YapilmaZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_YapanKisi;
    }
}