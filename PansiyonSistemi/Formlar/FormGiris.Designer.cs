namespace PansiyonSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.picclose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.pctsiftregöster = new System.Windows.Forms.PictureBox();
            this.grbgiris = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblhata = new System.Windows.Forms.Label();
            this.hata = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsiftregöster)).BeginInit();
            this.grbgiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // picclose
            // 
            this.picclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picclose.BackColor = System.Drawing.Color.Transparent;
            this.picclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(1238, 12);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(50, 50);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 0;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseHover += new System.EventHandler(this.picclose_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(918, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btngiris
            // 
            this.btngiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(206)))), ((int)(((byte)(19)))));
            this.btngiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.btngiris.FlatAppearance.BorderSize = 0;
            this.btngiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.btngiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.Black;
            this.btngiris.Location = new System.Drawing.Point(72, 317);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(257, 36);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // pctsiftregöster
            // 
            this.pctsiftregöster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(206)))), ((int)(((byte)(19)))));
            this.pctsiftregöster.Image = ((System.Drawing.Image)(resources.GetObject("pctsiftregöster.Image")));
            this.pctsiftregöster.Location = new System.Drawing.Point(335, 220);
            this.pctsiftregöster.Name = "pctsiftregöster";
            this.pctsiftregöster.Size = new System.Drawing.Size(36, 36);
            this.pctsiftregöster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctsiftregöster.TabIndex = 5;
            this.pctsiftregöster.TabStop = false;
            this.pctsiftregöster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pctsiftregöster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // grbgiris
            // 
            this.grbgiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbgiris.BackgroundImage")));
            this.grbgiris.Controls.Add(this.pctsiftregöster);
            this.grbgiris.Controls.Add(this.btngiris);
            this.grbgiris.Controls.Add(this.pictureBox4);
            this.grbgiris.Controls.Add(this.txtsifre);
            this.grbgiris.Controls.Add(this.txtad);
            this.grbgiris.Controls.Add(this.pictureBox3);
            this.grbgiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(206)))), ((int)(((byte)(19)))));
            this.grbgiris.Location = new System.Drawing.Point(38, 143);
            this.grbgiris.Name = "grbgiris";
            this.grbgiris.Size = new System.Drawing.Size(491, 401);
            this.grbgiris.TabIndex = 2;
            this.grbgiris.TabStop = false;
            this.grbgiris.Text = "Kullanıcı adı şifre giriniz";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 221);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // txtsifre
            // 
            this.txtsifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsifre.Location = new System.Drawing.Point(72, 221);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(257, 35);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.Text = "0000";
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // txtad
            // 
            this.txtad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtad.Location = new System.Drawing.Point(72, 108);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(257, 35);
            this.txtad.TabIndex = 0;
            this.txtad.Text = "Kullancı adı";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(206)))), ((int)(((byte)(19)))));
            this.label3.Location = new System.Drawing.Point(922, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoşgeldiniz";
            // 
            // lblhata
            // 
            this.lblhata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhata.AutoSize = true;
            this.lblhata.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(9)))));
            this.lblhata.Location = new System.Drawing.Point(33, 98);
            this.lblhata.Name = "lblhata";
            this.lblhata.Size = new System.Drawing.Size(0, 28);
            this.lblhata.TabIndex = 6;
            // 
            // hata
            // 
            this.hata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hata.BackColor = System.Drawing.Color.Transparent;
            this.hata.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(9)))));
            this.hata.Location = new System.Drawing.Point(38, 98);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(3, 2);
            this.hata.TabIndex = 7;
            this.hata.Text = null;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.txtad;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.txtsifre;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.pctsiftregöster;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(206)))), ((int)(((byte)(19)))));
            this.panel2.Location = new System.Drawing.Point(711, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 700);
            this.panel2.TabIndex = 3;
            // 
            // FormGiris
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.hata);
            this.Controls.Add(this.lblhata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbgiris);
            this.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsiftregöster)).EndInit();
            this.grbgiris.ResumeLayout(false);
            this.grbgiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.PictureBox pctsiftregöster;
        private System.Windows.Forms.GroupBox grbgiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblhata;
        private Guna.UI2.WinForms.Guna2HtmlLabel hata;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel2;
    }
}

