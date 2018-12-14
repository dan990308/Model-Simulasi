/*
 * Created by SharpDevelop.
 * User: Danang Saputra
 * Date: 27/11/2018
 * Time: 02.32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simulasi_kursus
{
	partial class addBiaya
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBiaya));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnback = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(20)))), ((int)(((byte)(109)))));
			this.panel1.Controls.Add(this.btnback);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(746, 27);
			this.panel1.TabIndex = 3;
			// 
			// btnback
			// 
			this.btnback.Activecolor = System.Drawing.Color.Transparent;
			this.btnback.BackColor = System.Drawing.Color.Transparent;
			this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnback.BorderRadius = 0;
			this.btnback.ButtonText = "  BACK";
			this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnback.DisabledColor = System.Drawing.Color.Gray;
			this.btnback.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.Iconcolor = System.Drawing.Color.Transparent;
			this.btnback.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnback.Iconimage")));
			this.btnback.Iconimage_right = null;
			this.btnback.Iconimage_right_Selected = null;
			this.btnback.Iconimage_Selected = null;
			this.btnback.IconMarginLeft = 0;
			this.btnback.IconMarginRight = 0;
			this.btnback.IconRightVisible = true;
			this.btnback.IconRightZoom = 0D;
			this.btnback.IconVisible = true;
			this.btnback.IconZoom = 25D;
			this.btnback.IsTab = false;
			this.btnback.Location = new System.Drawing.Point(12, 2);
			this.btnback.Name = "btnback";
			this.btnback.Normalcolor = System.Drawing.Color.Transparent;
			this.btnback.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
			this.btnback.OnHoverTextColor = System.Drawing.Color.White;
			this.btnback.selected = false;
			this.btnback.Size = new System.Drawing.Size(73, 22);
			this.btnback.TabIndex = 3;
			this.btnback.Text = "  BACK";
			this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnback.Textcolor = System.Drawing.Color.White;
			this.btnback.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.Click += new System.EventHandler(this.BtnbackClick);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 54);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 22);
			this.bunifuCustomLabel1.TabIndex = 5;
			this.bunifuCustomLabel1.Text = "Keterangan";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(41, 163);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 22);
			this.bunifuCustomLabel2.TabIndex = 7;
			this.bunifuCustomLabel2.Text = "Lama";
			// 
			// bunifuMetroTextbox2
			// 
			this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox2.BorderThickness = 3;
			this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox2.isPassword = false;
			this.bunifuMetroTextbox2.Location = new System.Drawing.Point(41, 189);
			this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
			this.bunifuMetroTextbox2.Size = new System.Drawing.Size(167, 32);
			this.bunifuMetroTextbox2.TabIndex = 6;
			this.bunifuMetroTextbox2.Text = "bunifuMetroTextbox2";
			this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 242);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(113, 22);
			this.bunifuCustomLabel3.TabIndex = 9;
			this.bunifuCustomLabel3.Text = "Keterangan";
			// 
			// bunifuMetroTextbox3
			// 
			this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox3.BorderThickness = 3;
			this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox3.isPassword = false;
			this.bunifuMetroTextbox3.Location = new System.Drawing.Point(41, 268);
			this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
			this.bunifuMetroTextbox3.Size = new System.Drawing.Size(167, 32);
			this.bunifuMetroTextbox3.TabIndex = 8;
			this.bunifuMetroTextbox3.Text = "bunifuMetroTextbox3";
			this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuDropdown1
			// 
			this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown1.BorderRadius = 3;
			this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
			this.bunifuDropdown1.Items = new string[0];
			this.bunifuDropdown1.Location = new System.Drawing.Point(41, 79);
			this.bunifuDropdown1.Name = "bunifuDropdown1";
			this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuDropdown1.selectedIndex = -1;
			this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
			this.bunifuDropdown1.TabIndex = 10;
			// 
			// addBiaya
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bunifuDropdown1);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.bunifuMetroTextbox3);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuMetroTextbox2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.panel1);
			this.Name = "addBiaya";
			this.Size = new System.Drawing.Size(746, 479);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
		private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuFlatButton btnback;
		private System.Windows.Forms.Panel panel1;
	}
}
