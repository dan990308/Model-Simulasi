using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Simulasi_kursus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeEvent();
            slider.Width = 39;

            if(!panel2.Contains(homeCtrl.Instance)){
                panel2.Controls.Add(homeCtrl.Instance);
                homeCtrl.Instance.Dock = DockStyle.Fill;
                homeCtrl.Instance.BringToFront();
            }
            
           // settingGrade sg = new settingGrade();
           load_dataBiayaTetap();
           load_toSettingGrade(); //load tab control and datagridview to settinggrade
           
            
        }
        private void InitializeEvent(){
        	biayaTetap.Instance.ButtonClicked += biayaTetap1_ButtonClicked;
        	biayaTetap.Instance.tambahEvent += addBiaya_Show;
        	//addBiaya.Instance.back_btn += btnBiayaTetap_Click;
        	
        }
        
        private void load_dataBiayaTetap(){
        	MysqlClass db = new MysqlClass();
        	DataTable tb = db.GetData("SELECT cou.keterangan FROM(SELECT keterangan FROM tb_grade group by keterangan) as cou");
        	
        	//load
        }
        private void load_toSettingGrade(){
        	MysqlClass db = new MysqlClass();
        	DataTable tb = db.GetData("SELECT cou.keterangan FROM(SELECT keterangan FROM tb_grade group by keterangan) as cou");
        	
        	
            
        	//MessageBox.Show(tb.Rows.Count.ToString());
        	foreach(DataRow row in tb.Rows){
        		
        		TabPage tp = new TabPage(row["keterangan"].ToString());
	            Bunifu.Framework.UI.BunifuCustomDataGrid dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
	            dgv.Dock = DockStyle.Fill;
	            dgv.Columns.Add("no", "No");
	            dgv.Columns.Add("grade", "Grade");
	            dgv.Columns.Add("biaya", "Biaya");
				dgv.RowHeadersVisible = false;
				dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 20, 109);
				dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dgv.Dock = DockStyle.Fill;
	            dgv.Location = new Point(20, 10);
	            tp.Controls.Add(dgv);
	           // settingGrade1.tabControl1.TabPages.Add(tp);
        	}
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (slider.Width == 39)
            {
                slider.Visible = false;
                slider.Width = 189;
                PanelTransition.ShowSync(slider);
            }
            else
            {
                slider.Visible = false;
                slider.Width = 39;
                PanelTransition.ShowSync(slider);
            }
        }

        private void btnBiayaTetap_Click(object sender, EventArgs e)
        {
        	if (!panel2.Contains(biayaTetap.Instance))
            {
        		panel2.Controls.Clear();
                panel2.Controls.Add(biayaTetap.Instance);
                biayaTetap.Instance.Dock = DockStyle.Fill;
                biayaTetap.Instance.Visible = false;
                biayaTetap.Instance.BringToFront();
                biayaTransition.ShowSync(biayaTetap.Instance);
                biayaTetap.Instance.Visible = true;
            }
            /*else {
                biayaTetap.Instance.Visible = false;
                biayaTetap.Instance.BringToFront();
                biayaTransition.ShowSync(biayaTetap.Instance);
                biayaTetap.Instance.Visible = true;
        	}*/
           // biayaTransition.ShowSync(biayaTetap1);
           // biayaTetap1.Visible = true;
             //biayaTetap1.BringToFront();
        }

        private void biayaTetap1_ButtonClicked(object sender, EventArgs e)
        {
        	if (!panel2.Contains(settingGrade.Instance))
            {
        		panel2.Controls.Clear();
                panel2.Controls.Add(settingGrade.Instance);
                settingGrade.Instance.Dock = DockStyle.Fill;
                settingGrade.Instance.Visible = false;
                settingGrade.Instance.BringToFront();
                biayaTransition.ShowSync(settingGrade.Instance);
                settingGrade.Instance.Visible = true;
            }
            
        }

        private void settingGrade1_buttonClicked(object sender, EventArgs e)
        {
            /*biayaTransition.ShowSync(biayaTetap1);
            biayaTetap1.Visible = true;
            settingGrade1.Visible = false;
            settingGrade1.BringToFront();*/
            
        }
        private void settingGrade1_grade_Load(object sender, EventArgs e){
        	
        }

        private void btnBiayaPengadaan_Click(object sender, EventArgs e)
        {

           
            if (!panel2.Contains(biayaPengadaan.Instance))
            {
            	panel2.Controls.Clear();
                panel2.Controls.Add(biayaPengadaan.Instance);
                biayaPengadaan.Instance.Dock = DockStyle.Fill;
                biayaPengadaan.Instance.Visible = false;
                biayaPengadaan.Instance.BringToFront();
                biayaTransition.ShowSync(biayaPengadaan.Instance);
                biayaPengadaan.Instance.Visible = true;
            }/*
            else {
                biayaPengadaan.Instance.Visible = false;
                biayaPengadaan.Instance.BringToFront();
                biayaTransition.ShowSync(biayaPengadaan.Instance);
                biayaPengadaan.Instance.Visible = true;
            }*/
            //biayaTetap1.Visible = false;
            //settingGrade1.Visible = false;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (!panel2.Contains(homeCtrl.Instance))
            {
            	panel2.Controls.Clear();
                panel2.Controls.Add(homeCtrl.Instance);
                homeCtrl.Instance.Dock = DockStyle.Fill;
                homeCtrl.Instance.Visible = false;
                homeCtrl.Instance.BringToFront();
                biayaTransition.ShowSync(homeCtrl.Instance);
                homeCtrl.Instance.Visible = true;
            }/*
            else
            {
                homeCtrl.Instance.Visible = false;
                homeCtrl.Instance.BringToFront();
                biayaTransition.ShowSync(homeCtrl.Instance);
                homeCtrl.Instance.Visible = true;
            }*/
           // biayaTetap1.Visible = false;
            //settingGrade1.Visible = false;
        }
        
        void BunifuFlatButton9Click(object sender, EventArgs e)
        {
        	Environment.Exit(0);
        }
        
        void addBiaya_Show(object sender, EventArgs e){
        	
        	
        }
       
    }
}
