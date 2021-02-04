namespace businessCard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_TümSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Sil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_KayıtPaneli = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_KayıtSayısı = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Güncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lbl_User = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TümSil
            // 
            this.btn_TümSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_TümSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TümSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_TümSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TümSil.BorderRadius = 0;
            this.btn_TümSil.ButtonText = "Tümünü Sil";
            this.btn_TümSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TümSil.DisabledColor = System.Drawing.Color.Gray;
            this.btn_TümSil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_TümSil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_TümSil.Iconimage")));
            this.btn_TümSil.Iconimage_right = null;
            this.btn_TümSil.Iconimage_right_Selected = null;
            this.btn_TümSil.Iconimage_Selected = null;
            this.btn_TümSil.IconMarginLeft = 0;
            this.btn_TümSil.IconMarginRight = 0;
            this.btn_TümSil.IconRightVisible = true;
            this.btn_TümSil.IconRightZoom = 0D;
            this.btn_TümSil.IconVisible = true;
            this.btn_TümSil.IconZoom = 90D;
            this.btn_TümSil.IsTab = false;
            this.btn_TümSil.Location = new System.Drawing.Point(822, 167);
            this.btn_TümSil.Name = "btn_TümSil";
            this.btn_TümSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_TümSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_TümSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_TümSil.selected = false;
            this.btn_TümSil.Size = new System.Drawing.Size(129, 37);
            this.btn_TümSil.TabIndex = 1;
            this.btn_TümSil.Text = "Tümünü Sil";
            this.btn_TümSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TümSil.Textcolor = System.Drawing.Color.White;
            this.btn_TümSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TümSil.Click += new System.EventHandler(this.btn_TümSil_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sil.BorderRadius = 0;
            this.btn_Sil.ButtonText = "Sil";
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Iconimage")));
            this.btn_Sil.Iconimage_right = null;
            this.btn_Sil.Iconimage_right_Selected = null;
            this.btn_Sil.Iconimage_Selected = null;
            this.btn_Sil.IconMarginLeft = 0;
            this.btn_Sil.IconMarginRight = 0;
            this.btn_Sil.IconRightVisible = true;
            this.btn_Sil.IconRightZoom = 0D;
            this.btn_Sil.IconVisible = true;
            this.btn_Sil.IconZoom = 90D;
            this.btn_Sil.IsTab = false;
            this.btn_Sil.Location = new System.Drawing.Point(687, 167);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Sil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Sil.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sil.selected = false;
            this.btn_Sil.Size = new System.Drawing.Size(129, 37);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Textcolor = System.Drawing.Color.White;
            this.btn_Sil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_KayıtPaneli
            // 
            this.btn_KayıtPaneli.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_KayıtPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_KayıtPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_KayıtPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_KayıtPaneli.BorderRadius = 0;
            this.btn_KayıtPaneli.ButtonText = "Kayıt Paneli";
            this.btn_KayıtPaneli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KayıtPaneli.DisabledColor = System.Drawing.Color.Gray;
            this.btn_KayıtPaneli.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_KayıtPaneli.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_KayıtPaneli.Iconimage")));
            this.btn_KayıtPaneli.Iconimage_right = null;
            this.btn_KayıtPaneli.Iconimage_right_Selected = null;
            this.btn_KayıtPaneli.Iconimage_Selected = null;
            this.btn_KayıtPaneli.IconMarginLeft = 0;
            this.btn_KayıtPaneli.IconMarginRight = 0;
            this.btn_KayıtPaneli.IconRightVisible = true;
            this.btn_KayıtPaneli.IconRightZoom = 0D;
            this.btn_KayıtPaneli.IconVisible = true;
            this.btn_KayıtPaneli.IconZoom = 90D;
            this.btn_KayıtPaneli.IsTab = false;
            this.btn_KayıtPaneli.Location = new System.Drawing.Point(552, 167);
            this.btn_KayıtPaneli.Name = "btn_KayıtPaneli";
            this.btn_KayıtPaneli.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_KayıtPaneli.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_KayıtPaneli.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_KayıtPaneli.selected = false;
            this.btn_KayıtPaneli.Size = new System.Drawing.Size(129, 37);
            this.btn_KayıtPaneli.TabIndex = 3;
            this.btn_KayıtPaneli.Text = "Kayıt Paneli";
            this.btn_KayıtPaneli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KayıtPaneli.Textcolor = System.Drawing.Color.White;
            this.btn_KayıtPaneli.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KayıtPaneli.Click += new System.EventHandler(this.btn_KayıtPaneli_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kayıt Sayısı";
            // 
            // lbl_KayıtSayısı
            // 
            this.lbl_KayıtSayısı.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_KayıtSayısı.AutoSize = true;
            this.lbl_KayıtSayısı.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KayıtSayısı.Location = new System.Drawing.Point(108, 181);
            this.lbl_KayıtSayısı.Name = "lbl_KayıtSayısı";
            this.lbl_KayıtSayısı.Size = new System.Drawing.Size(18, 20);
            this.lbl_KayıtSayısı.TabIndex = 5;
            this.lbl_KayıtSayısı.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 22;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.DimGray;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(20, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 242);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Güncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Güncelle.BorderRadius = 0;
            this.btn_Güncelle.ButtonText = "Yenile";
            this.btn_Güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Güncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Güncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Güncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Güncelle.Iconimage")));
            this.btn_Güncelle.Iconimage_right = null;
            this.btn_Güncelle.Iconimage_right_Selected = null;
            this.btn_Güncelle.Iconimage_Selected = null;
            this.btn_Güncelle.IconMarginLeft = 0;
            this.btn_Güncelle.IconMarginRight = 0;
            this.btn_Güncelle.IconRightVisible = true;
            this.btn_Güncelle.IconRightZoom = 0D;
            this.btn_Güncelle.IconVisible = true;
            this.btn_Güncelle.IconZoom = 90D;
            this.btn_Güncelle.IsTab = false;
            this.btn_Güncelle.Location = new System.Drawing.Point(417, 167);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Güncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Güncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Güncelle.selected = false;
            this.btn_Güncelle.Size = new System.Drawing.Size(129, 37);
            this.btn_Güncelle.TabIndex = 44;
            this.btn_Güncelle.Text = "Yenile";
            this.btn_Güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Güncelle.Textcolor = System.Drawing.Color.White;
            this.btn_Güncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label11.Location = new System.Drawing.Point(179, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 1);
            this.label11.TabIndex = 48;
            // 
            // txt_ara
            // 
            this.txt_ara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ara.BackColor = System.Drawing.Color.White;
            this.txt_ara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.ForeColor = System.Drawing.Color.Gray;
            this.txt_ara.Location = new System.Drawing.Point(179, 175);
            this.txt_ara.Multiline = true;
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(218, 26);
            this.txt_ara.TabIndex = 47;
            this.metroToolTip1.SetToolTip(this.txt_ara, "İsimSoyisim  Ve Meslek e  Göre Arama Yapar");
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_User.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_User.Location = new System.Drawing.Point(719, 33);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(211, 21);
            this.lbl_User.TabIndex = 50;
            this.lbl_User.Text = "Kullanıcı";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(936, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 472);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_KayıtSayısı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KayıtPaneli);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_TümSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Business Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_TümSil;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sil;
        private Bunifu.Framework.UI.BunifuFlatButton btn_KayıtPaneli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KayıtSayısı;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Güncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_ara;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

