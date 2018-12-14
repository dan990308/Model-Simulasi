namespace Simulasi_kursus
{
    partial class Form1
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
        	BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
        	BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
        	this.slider = new Bunifu.Framework.UI.BunifuGradientPanel();
        	this.btnBiayaTetap = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.btnhome = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
        	this.btnMenu = new System.Windows.Forms.PictureBox();
        	this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.btnBiayaPengadaan = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
        	this.label2 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
        	this.biayaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
        	this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
        	this.slider.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// bunifuElipse1
        	// 
        	this.bunifuElipse1.ElipseRadius = 5;
        	this.bunifuElipse1.TargetControl = this;
        	// 
        	// slider
        	// 
        	this.slider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slider.BackgroundImage")));
        	this.slider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.slider.Controls.Add(this.btnBiayaTetap);
        	this.slider.Controls.Add(this.btnhome);
        	this.slider.Controls.Add(this.bunifuFlatButton3);
        	this.slider.Controls.Add(this.bunifuSeparator1);
        	this.slider.Controls.Add(this.btnMenu);
        	this.slider.Controls.Add(this.bunifuFlatButton6);
        	this.slider.Controls.Add(this.bunifuFlatButton5);
        	this.slider.Controls.Add(this.bunifuFlatButton4);
        	this.slider.Controls.Add(this.btnBiayaPengadaan);
        	this.slider.Controls.Add(this.label1);
        	this.biayaTransition.SetDecoration(this.slider, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.slider, BunifuAnimatorNS.DecorationType.None);
        	this.slider.Dock = System.Windows.Forms.DockStyle.Left;
        	this.slider.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(5)))), ((int)(((byte)(86)))));
        	this.slider.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(150)))), ((int)(((byte)(181)))));
        	this.slider.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(118)))));
        	this.slider.GradientTopRight = System.Drawing.Color.Purple;
        	this.slider.Location = new System.Drawing.Point(0, 0);
        	this.slider.Name = "slider";
        	this.slider.Quality = 10;
        	this.slider.Size = new System.Drawing.Size(191, 498);
        	this.slider.TabIndex = 0;
        	// 
        	// btnBiayaTetap
        	// 
        	this.btnBiayaTetap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnBiayaTetap.BackColor = System.Drawing.Color.Transparent;
        	this.btnBiayaTetap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btnBiayaTetap.BorderRadius = 0;
        	this.btnBiayaTetap.ButtonText = "  BIAYA TETAP";
        	this.btnBiayaTetap.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.btnBiayaTetap, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.btnBiayaTetap, BunifuAnimatorNS.DecorationType.None);
        	this.btnBiayaTetap.DisabledColor = System.Drawing.Color.Gray;
        	this.btnBiayaTetap.ForeColor = System.Drawing.SystemColors.Control;
        	this.btnBiayaTetap.Iconcolor = System.Drawing.Color.Transparent;
        	this.btnBiayaTetap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBiayaTetap.Iconimage")));
        	this.btnBiayaTetap.Iconimage_right = null;
        	this.btnBiayaTetap.Iconimage_right_Selected = null;
        	this.btnBiayaTetap.Iconimage_Selected = null;
        	this.btnBiayaTetap.IconMarginLeft = 0;
        	this.btnBiayaTetap.IconMarginRight = 0;
        	this.btnBiayaTetap.IconRightVisible = true;
        	this.btnBiayaTetap.IconRightZoom = 0D;
        	this.btnBiayaTetap.IconVisible = true;
        	this.btnBiayaTetap.IconZoom = 40D;
        	this.btnBiayaTetap.IsTab = true;
        	this.btnBiayaTetap.Location = new System.Drawing.Point(1, 129);
        	this.btnBiayaTetap.Name = "btnBiayaTetap";
        	this.btnBiayaTetap.Normalcolor = System.Drawing.Color.Transparent;
        	this.btnBiayaTetap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnBiayaTetap.OnHoverTextColor = System.Drawing.Color.White;
        	this.btnBiayaTetap.selected = false;
        	this.btnBiayaTetap.Size = new System.Drawing.Size(187, 38);
        	this.btnBiayaTetap.TabIndex = 14;
        	this.btnBiayaTetap.Text = "  BIAYA TETAP";
        	this.btnBiayaTetap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.btnBiayaTetap.Textcolor = System.Drawing.Color.White;
        	this.btnBiayaTetap.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnBiayaTetap.Click += new System.EventHandler(this.btnBiayaTetap_Click);
        	// 
        	// btnhome
        	// 
        	this.btnhome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btnhome.BorderRadius = 0;
        	this.btnhome.ButtonText = "  HOME";
        	this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
        	this.btnhome.DisabledColor = System.Drawing.Color.Gray;
        	this.btnhome.ForeColor = System.Drawing.SystemColors.Control;
        	this.btnhome.Iconcolor = System.Drawing.Color.Transparent;
        	this.btnhome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnhome.Iconimage")));
        	this.btnhome.Iconimage_right = null;
        	this.btnhome.Iconimage_right_Selected = null;
        	this.btnhome.Iconimage_Selected = null;
        	this.btnhome.IconMarginLeft = 0;
        	this.btnhome.IconMarginRight = 0;
        	this.btnhome.IconRightVisible = true;
        	this.btnhome.IconRightZoom = 0D;
        	this.btnhome.IconVisible = true;
        	this.btnhome.IconZoom = 40D;
        	this.btnhome.IsTab = true;
        	this.btnhome.Location = new System.Drawing.Point(2, 87);
        	this.btnhome.Name = "btnhome";
        	this.btnhome.Normalcolor = System.Drawing.Color.Transparent;
        	this.btnhome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnhome.OnHoverTextColor = System.Drawing.Color.White;
        	this.btnhome.selected = true;
        	this.btnhome.Size = new System.Drawing.Size(187, 36);
        	this.btnhome.TabIndex = 13;
        	this.btnhome.Text = "  HOME";
        	this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.btnhome.Textcolor = System.Drawing.Color.White;
        	this.btnhome.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
        	// 
        	// bunifuFlatButton3
        	// 
        	this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.bunifuFlatButton3.BorderRadius = 0;
        	this.bunifuFlatButton3.ButtonText = "  SETTING DATA";
        	this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
        	this.bunifuFlatButton3.ForeColor = System.Drawing.SystemColors.Control;
        	this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
        	this.bunifuFlatButton3.Iconimage_right = null;
        	this.bunifuFlatButton3.Iconimage_right_Selected = null;
        	this.bunifuFlatButton3.Iconimage_Selected = null;
        	this.bunifuFlatButton3.IconMarginLeft = 0;
        	this.bunifuFlatButton3.IconMarginRight = 0;
        	this.bunifuFlatButton3.IconRightVisible = true;
        	this.bunifuFlatButton3.IconRightZoom = 0D;
        	this.bunifuFlatButton3.IconVisible = true;
        	this.bunifuFlatButton3.IconZoom = 40D;
        	this.bunifuFlatButton3.IsTab = true;
        	this.bunifuFlatButton3.Location = new System.Drawing.Point(2, 396);
        	this.bunifuFlatButton3.Name = "bunifuFlatButton3";
        	this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
        	this.bunifuFlatButton3.selected = false;
        	this.bunifuFlatButton3.Size = new System.Drawing.Size(187, 34);
        	this.bunifuFlatButton3.TabIndex = 12;
        	this.bunifuFlatButton3.Text = "  SETTING DATA";
        	this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
        	this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	// 
        	// bunifuSeparator1
        	// 
        	this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
        	this.PanelTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
        	this.biayaTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.bunifuSeparator1.LineThickness = 1;
        	this.bunifuSeparator1.Location = new System.Drawing.Point(-2, 333);
        	this.bunifuSeparator1.Name = "bunifuSeparator1";
        	this.bunifuSeparator1.Size = new System.Drawing.Size(191, 14);
        	this.bunifuSeparator1.TabIndex = 11;
        	this.bunifuSeparator1.Transparency = 255;
        	this.bunifuSeparator1.Vertical = false;
        	// 
        	// btnMenu
        	// 
        	this.btnMenu.BackColor = System.Drawing.Color.Transparent;
        	this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
        	this.biayaTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
        	this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
        	this.btnMenu.Location = new System.Drawing.Point(8, 11);
        	this.btnMenu.Name = "btnMenu";
        	this.btnMenu.Size = new System.Drawing.Size(22, 19);
        	this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.btnMenu.TabIndex = 10;
        	this.btnMenu.TabStop = false;
        	this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
        	// 
        	// bunifuFlatButton6
        	// 
        	this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.bunifuFlatButton6.BorderRadius = 0;
        	this.bunifuFlatButton6.ButtonText = "   SIMULASI";
        	this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
        	this.bunifuFlatButton6.ForeColor = System.Drawing.SystemColors.Control;
        	this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
        	this.bunifuFlatButton6.Iconimage_right = null;
        	this.bunifuFlatButton6.Iconimage_right_Selected = null;
        	this.bunifuFlatButton6.Iconimage_Selected = null;
        	this.bunifuFlatButton6.IconMarginLeft = 0;
        	this.bunifuFlatButton6.IconMarginRight = 0;
        	this.bunifuFlatButton6.IconRightVisible = true;
        	this.bunifuFlatButton6.IconRightZoom = 0D;
        	this.bunifuFlatButton6.IconVisible = true;
        	this.bunifuFlatButton6.IconZoom = 40D;
        	this.bunifuFlatButton6.IsTab = true;
        	this.bunifuFlatButton6.Location = new System.Drawing.Point(-2, 353);
        	this.bunifuFlatButton6.Name = "bunifuFlatButton6";
        	this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
        	this.bunifuFlatButton6.selected = false;
        	this.bunifuFlatButton6.Size = new System.Drawing.Size(187, 37);
        	this.bunifuFlatButton6.TabIndex = 9;
        	this.bunifuFlatButton6.Text = "   SIMULASI";
        	this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
        	this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	// 
        	// bunifuFlatButton5
        	// 
        	this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.bunifuFlatButton5.BorderRadius = 0;
        	this.bunifuFlatButton5.ButtonText = "  TRANSAKSI";
        	this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
        	this.bunifuFlatButton5.ForeColor = System.Drawing.SystemColors.Control;
        	this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
        	this.bunifuFlatButton5.Iconimage_right = null;
        	this.bunifuFlatButton5.Iconimage_right_Selected = null;
        	this.bunifuFlatButton5.Iconimage_Selected = null;
        	this.bunifuFlatButton5.IconMarginLeft = 0;
        	this.bunifuFlatButton5.IconMarginRight = 0;
        	this.bunifuFlatButton5.IconRightVisible = true;
        	this.bunifuFlatButton5.IconRightZoom = 0D;
        	this.bunifuFlatButton5.IconVisible = true;
        	this.bunifuFlatButton5.IconZoom = 40D;
        	this.bunifuFlatButton5.IsTab = true;
        	this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 261);
        	this.bunifuFlatButton5.Name = "bunifuFlatButton5";
        	this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
        	this.bunifuFlatButton5.selected = false;
        	this.bunifuFlatButton5.Size = new System.Drawing.Size(187, 34);
        	this.bunifuFlatButton5.TabIndex = 8;
        	this.bunifuFlatButton5.Text = "  TRANSAKSI";
        	this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
        	this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	// 
        	// bunifuFlatButton4
        	// 
        	this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.bunifuFlatButton4.BorderRadius = 0;
        	this.bunifuFlatButton4.ButtonText = "  BIAYA RUTINITAS";
        	this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
        	this.bunifuFlatButton4.ForeColor = System.Drawing.SystemColors.Control;
        	this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
        	this.bunifuFlatButton4.Iconimage_right = null;
        	this.bunifuFlatButton4.Iconimage_right_Selected = null;
        	this.bunifuFlatButton4.Iconimage_Selected = null;
        	this.bunifuFlatButton4.IconMarginLeft = 0;
        	this.bunifuFlatButton4.IconMarginRight = 0;
        	this.bunifuFlatButton4.IconRightVisible = true;
        	this.bunifuFlatButton4.IconRightZoom = 0D;
        	this.bunifuFlatButton4.IconVisible = true;
        	this.bunifuFlatButton4.IconZoom = 40D;
        	this.bunifuFlatButton4.IsTab = true;
        	this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 217);
        	this.bunifuFlatButton4.Name = "bunifuFlatButton4";
        	this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
        	this.bunifuFlatButton4.selected = false;
        	this.bunifuFlatButton4.Size = new System.Drawing.Size(187, 38);
        	this.bunifuFlatButton4.TabIndex = 7;
        	this.bunifuFlatButton4.Text = "  BIAYA RUTINITAS";
        	this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
        	this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	// 
        	// btnBiayaPengadaan
        	// 
        	this.btnBiayaPengadaan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnBiayaPengadaan.BackColor = System.Drawing.Color.Transparent;
        	this.btnBiayaPengadaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btnBiayaPengadaan.BorderRadius = 0;
        	this.btnBiayaPengadaan.ButtonText = "  BIAYA PENGADAAN";
        	this.btnBiayaPengadaan.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.btnBiayaPengadaan, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.btnBiayaPengadaan, BunifuAnimatorNS.DecorationType.None);
        	this.btnBiayaPengadaan.DisabledColor = System.Drawing.Color.Gray;
        	this.btnBiayaPengadaan.ForeColor = System.Drawing.SystemColors.Control;
        	this.btnBiayaPengadaan.Iconcolor = System.Drawing.Color.Transparent;
        	this.btnBiayaPengadaan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBiayaPengadaan.Iconimage")));
        	this.btnBiayaPengadaan.Iconimage_right = null;
        	this.btnBiayaPengadaan.Iconimage_right_Selected = null;
        	this.btnBiayaPengadaan.Iconimage_Selected = null;
        	this.btnBiayaPengadaan.IconMarginLeft = 0;
        	this.btnBiayaPengadaan.IconMarginRight = 0;
        	this.btnBiayaPengadaan.IconRightVisible = true;
        	this.btnBiayaPengadaan.IconRightZoom = 0D;
        	this.btnBiayaPengadaan.IconVisible = true;
        	this.btnBiayaPengadaan.IconZoom = 40D;
        	this.btnBiayaPengadaan.IsTab = true;
        	this.btnBiayaPengadaan.Location = new System.Drawing.Point(0, 173);
        	this.btnBiayaPengadaan.Name = "btnBiayaPengadaan";
        	this.btnBiayaPengadaan.Normalcolor = System.Drawing.Color.Transparent;
        	this.btnBiayaPengadaan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
        	this.btnBiayaPengadaan.OnHoverTextColor = System.Drawing.Color.White;
        	this.btnBiayaPengadaan.selected = false;
        	this.btnBiayaPengadaan.Size = new System.Drawing.Size(187, 38);
        	this.btnBiayaPengadaan.TabIndex = 6;
        	this.btnBiayaPengadaan.Text = "  BIAYA PENGADAAN";
        	this.btnBiayaPengadaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.btnBiayaPengadaan.Textcolor = System.Drawing.Color.White;
        	this.btnBiayaPengadaan.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnBiayaPengadaan.Click += new System.EventHandler(this.btnBiayaPengadaan_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
        	this.biayaTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
        	this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(45, 11);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(47, 18);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "MENU";
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.Transparent;
        	this.panel1.Controls.Add(this.bunifuFlatButton9);
        	this.panel1.Controls.Add(this.label2);
        	this.biayaTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(191, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(711, 31);
        	this.panel1.TabIndex = 9;
        	// 
        	// bunifuFlatButton9
        	// 
        	this.bunifuFlatButton9.Activecolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.bunifuFlatButton9.BackColor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.bunifuFlatButton9.BorderRadius = 0;
        	this.bunifuFlatButton9.ButtonText = "";
        	this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.biayaTransition.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
        	this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
        	this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton9.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton9.Iconimage")));
        	this.bunifuFlatButton9.Iconimage_right = null;
        	this.bunifuFlatButton9.Iconimage_right_Selected = null;
        	this.bunifuFlatButton9.Iconimage_Selected = null;
        	this.bunifuFlatButton9.IconMarginLeft = 0;
        	this.bunifuFlatButton9.IconMarginRight = 0;
        	this.bunifuFlatButton9.IconRightVisible = true;
        	this.bunifuFlatButton9.IconRightZoom = 0D;
        	this.bunifuFlatButton9.IconVisible = true;
        	this.bunifuFlatButton9.IconZoom = 30D;
        	this.bunifuFlatButton9.IsTab = false;
        	this.bunifuFlatButton9.Location = new System.Drawing.Point(678, 4);
        	this.bunifuFlatButton9.Name = "bunifuFlatButton9";
        	this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.Transparent;
        	this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
        	this.bunifuFlatButton9.selected = false;
        	this.bunifuFlatButton9.Size = new System.Drawing.Size(22, 22);
        	this.bunifuFlatButton9.TabIndex = 11;
        	this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
        	this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.bunifuFlatButton9.Click += new System.EventHandler(this.BunifuFlatButton9Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.Transparent;
        	this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
        	this.biayaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
        	this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Black;
        	this.label2.Location = new System.Drawing.Point(282, 9);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(151, 17);
        	this.label2.TabIndex = 10;
        	this.label2.Text = "MODEL DAN SIMULASI";
        	// 
        	// panel2
        	// 
        	this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
        	this.biayaTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel2.Location = new System.Drawing.Point(191, 31);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(711, 467);
        	this.panel2.TabIndex = 12;
        	// 
        	// PanelTransition
        	// 
        	this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
        	this.PanelTransition.Cursor = null;
        	animation2.AnimateOnlyDifferences = true;
        	animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
        	animation2.LeafCoeff = 0F;
        	animation2.MaxTime = 1F;
        	animation2.MinTime = 0F;
        	animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
        	animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
        	animation2.MosaicSize = 0;
        	animation2.Padding = new System.Windows.Forms.Padding(0);
        	animation2.RotateCoeff = 0F;
        	animation2.RotateLimit = 0F;
        	animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
        	animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
        	animation2.TimeCoeff = 0F;
        	animation2.TransparencyCoeff = 1F;
        	this.PanelTransition.DefaultAnimation = animation2;
        	this.PanelTransition.Interval = 1;
        	this.PanelTransition.MaxAnimationTime = 1000;
        	// 
        	// biayaTransition
        	// 
        	this.biayaTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
        	this.biayaTransition.Cursor = null;
        	animation1.AnimateOnlyDifferences = true;
        	animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
        	animation1.LeafCoeff = 0F;
        	animation1.MaxTime = 1F;
        	animation1.MinTime = 0F;
        	animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
        	animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
        	animation1.MosaicSize = 0;
        	animation1.Padding = new System.Windows.Forms.Padding(0);
        	animation1.RotateCoeff = 0F;
        	animation1.RotateLimit = 0F;
        	animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
        	animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
        	animation1.TimeCoeff = 0F;
        	animation1.TransparencyCoeff = 0F;
        	this.biayaTransition.DefaultAnimation = animation1;
        	this.biayaTransition.Interval = 5;
        	this.biayaTransition.MaxAnimationTime = 1000;
        	// 
        	// bunifuDragControl1
        	// 
        	this.bunifuDragControl1.Fixed = true;
        	this.bunifuDragControl1.Horizontal = true;
        	this.bunifuDragControl1.TargetControl = this.panel1;
        	this.bunifuDragControl1.Vertical = true;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(902, 498);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.slider);
        	this.biayaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
        	this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Form1";
        	this.slider.ResumeLayout(false);
        	this.slider.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel slider;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btnBiayaPengadaan;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.PictureBox btnMenu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnhome;
        private Bunifu.Framework.UI.BunifuFlatButton btnBiayaTetap;
        public System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition biayaTransition;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

