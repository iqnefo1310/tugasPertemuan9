namespace TUGAS_PERTEMUAN_9
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelCilok = new System.Windows.Forms.Label();
            this.hargaCilok = new System.Windows.Forms.Label();
            this.labelCireng = new System.Windows.Forms.Label();
            this.hargaCireng = new System.Windows.Forms.Label();
            this.labelKaredok = new System.Windows.Forms.Label();
            this.hargakaredok = new System.Windows.Forms.Label();
            this.labelCibay = new System.Windows.Forms.Label();
            this.hargaCibay = new System.Windows.Forms.Label();
            this.labelPilihan = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.pilihan = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.tombolTotal = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Red;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(56, 26);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(467, 46);
            this.labelJudul.TabIndex = 1;
            this.labelJudul.Text = "Mau Jajan Apa Hari Ini?";
            // 
            // labelCilok
            // 
            this.labelCilok.AutoSize = true;
            this.labelCilok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCilok.Location = new System.Drawing.Point(86, 132);
            this.labelCilok.Name = "labelCilok";
            this.labelCilok.Size = new System.Drawing.Size(73, 24);
            this.labelCilok.TabIndex = 2;
            this.labelCilok.Text = "1.Cilok";
            // 
            // hargaCilok
            // 
            this.hargaCilok.AutoSize = true;
            this.hargaCilok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaCilok.Location = new System.Drawing.Point(375, 132);
            this.hargaCilok.Name = "hargaCilok";
            this.hargaCilok.Size = new System.Drawing.Size(86, 24);
            this.hargaCilok.TabIndex = 2;
            this.hargaCilok.Text = "Rp 5000";
            // 
            // labelCireng
            // 
            this.labelCireng.AutoSize = true;
            this.labelCireng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCireng.Location = new System.Drawing.Point(86, 165);
            this.labelCireng.Name = "labelCireng";
            this.labelCireng.Size = new System.Drawing.Size(86, 24);
            this.labelCireng.TabIndex = 2;
            this.labelCireng.Text = "2.cireng";
            // 
            // hargaCireng
            // 
            this.hargaCireng.AutoSize = true;
            this.hargaCireng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaCireng.Location = new System.Drawing.Point(375, 165);
            this.hargaCireng.Name = "hargaCireng";
            this.hargaCireng.Size = new System.Drawing.Size(86, 24);
            this.hargaCireng.TabIndex = 2;
            this.hargaCireng.Text = "Rp 4000";
            // 
            // labelKaredok
            // 
            this.labelKaredok.AutoSize = true;
            this.labelKaredok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKaredok.Location = new System.Drawing.Point(86, 199);
            this.labelKaredok.Name = "labelKaredok";
            this.labelKaredok.Size = new System.Drawing.Size(184, 24);
            this.labelKaredok.TabIndex = 2;
            this.labelKaredok.Text = "3.karedok Basreng";
            this.labelKaredok.Click += new System.EventHandler(this.label5_Click);
            // 
            // hargakaredok
            // 
            this.hargakaredok.AutoSize = true;
            this.hargakaredok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargakaredok.Location = new System.Drawing.Point(375, 199);
            this.hargakaredok.Name = "hargakaredok";
            this.hargakaredok.Size = new System.Drawing.Size(86, 24);
            this.hargakaredok.TabIndex = 2;
            this.hargakaredok.Text = "Rp 5000";
            this.hargakaredok.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelCibay
            // 
            this.labelCibay.AutoSize = true;
            this.labelCibay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCibay.Location = new System.Drawing.Point(86, 238);
            this.labelCibay.Name = "labelCibay";
            this.labelCibay.Size = new System.Drawing.Size(79, 24);
            this.labelCibay.TabIndex = 2;
            this.labelCibay.Text = "4.Cibay";
            // 
            // hargaCibay
            // 
            this.hargaCibay.AutoSize = true;
            this.hargaCibay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaCibay.Location = new System.Drawing.Point(375, 238);
            this.hargaCibay.Name = "hargaCibay";
            this.hargaCibay.Size = new System.Drawing.Size(86, 24);
            this.hargaCibay.TabIndex = 2;
            this.hargaCibay.Text = "Rp 4000";
            // 
            // labelPilihan
            // 
            this.labelPilihan.AutoSize = true;
            this.labelPilihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilihan.Location = new System.Drawing.Point(86, 293);
            this.labelPilihan.Name = "labelPilihan";
            this.labelPilihan.Size = new System.Drawing.Size(73, 24);
            this.labelPilihan.TabIndex = 2;
            this.labelPilihan.Text = "Pilihan";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(86, 334);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(149, 24);
            this.labelJumlah.TabIndex = 2;
            this.labelJumlah.Text = "Berapa Banyak";
            // 
            // pilihan
            // 
            this.pilihan.Location = new System.Drawing.Point(311, 293);
            this.pilihan.Name = "pilihan";
            this.pilihan.Size = new System.Drawing.Size(150, 20);
            this.pilihan.TabIndex = 3;
            this.pilihan.TextChanged += new System.EventHandler(this.pilihan_TextChanged);
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(311, 334);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(150, 20);
            this.jumlah.TabIndex = 3;
            this.jumlah.TextChanged += new System.EventHandler(this.jumlah_TextChanged);
            // 
            // tombolTotal
            // 
            this.tombolTotal.BackColor = System.Drawing.Color.Lime;
            this.tombolTotal.ForeColor = System.Drawing.Color.Black;
            this.tombolTotal.Location = new System.Drawing.Point(208, 494);
            this.tombolTotal.Name = "tombolTotal";
            this.tombolTotal.Size = new System.Drawing.Size(75, 23);
            this.tombolTotal.TabIndex = 4;
            this.tombolTotal.Text = "Total";
            this.tombolTotal.UseVisualStyleBackColor = false;
            this.tombolTotal.Click += new System.EventHandler(this.tombolTotal_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.BackColor = System.Drawing.Color.Red;
            this.tombolKeluar.Location = new System.Drawing.Point(379, 558);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(75, 23);
            this.tombolKeluar.TabIndex = 4;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = false;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(311, 494);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(150, 20);
            this.total.TabIndex = 3;
            this.total.TextChanged += new System.EventHandler(this.jumlah_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 683);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolTotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.pilihan);
            this.Controls.Add(this.hargaCibay);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelPilihan);
            this.Controls.Add(this.labelCibay);
            this.Controls.Add(this.hargakaredok);
            this.Controls.Add(this.labelKaredok);
            this.Controls.Add(this.hargaCireng);
            this.Controls.Add(this.labelCireng);
            this.Controls.Add(this.hargaCilok);
            this.Controls.Add(this.labelCilok);
            this.Controls.Add(this.labelJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelCilok;
        private System.Windows.Forms.Label hargaCilok;
        private System.Windows.Forms.Label labelCireng;
        private System.Windows.Forms.Label hargaCireng;
        private System.Windows.Forms.Label labelKaredok;
        private System.Windows.Forms.Label hargakaredok;
        private System.Windows.Forms.Label labelCibay;
        private System.Windows.Forms.Label hargaCibay;
        private System.Windows.Forms.Label labelPilihan;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.TextBox pilihan;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Button tombolTotal;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.TextBox total;
    }
}