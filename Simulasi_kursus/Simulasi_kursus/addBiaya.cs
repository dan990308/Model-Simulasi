/*
 * Created by SharpDevelop.
 * User: Danang Saputra
 * Date: 27/11/2018
 * Time: 02.32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Simulasi_kursus
{
	/// <summary>
	/// Description of addBiaya.
	/// </summary>
	public partial class addBiaya : UserControl
	{
		public event EventHandler back_btn;
		private static addBiaya _instance;
		public static addBiaya Instance {
			get{
				if(_instance == null)
					_instance = new addBiaya();
				return _instance;
			}
		}
		public addBiaya()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnbackClick(object sender, EventArgs e)
		{
			if(back_btn != null)
				back_btn(this,e);
		}
		
		void BunifuMetroTextbox1OnValueChanged(object sender, EventArgs e)
		{
					
		}
	}
}
