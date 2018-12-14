using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulasi_kursus
{
    public partial class biayaTetap : UserControl
    {
        public event EventHandler ButtonClicked;
        public event EventHandler tambahEvent;
        
        private static biayaTetap _instance;
        public static biayaTetap Instance { 
            get {
                if(_instance == null)
                    _instance = new biayaTetap();
                return _instance;
            }
        }
        public biayaTetap()
        {
            InitializeComponent();
        }

        private void biayaTetap_Load(object sender, EventArgs e)
        {
//        	if(tambahEvent != null)
  //      		tambahEvent(this,e);
  			load_data();
  
        }
        void load_data(){
        	MysqlClass db = new MysqlClass();
        	DataTable tb = db.GetData("select keterangan from tb_grade group by keterangan");
        	biayaTetap.Instance.bunifuCustomDataGrid1.Columns[0].Visible = false;
        	foreach(DataRow row in tb.Rows){
        		biayaTetap.Instance.cmbketerangan.AddItem(row["keterangan"].ToString());
        	}
        	
        	DataTable tb2 = db.GetData("select * from tb_dana_tetap");
        	
        	int num = 0;
        	for(int i = 0; i < tb2.Rows.Count;i++){
        		num++;
        		bunifuCustomDataGrid1.Rows.Add(tb2.Rows[i]["id"].ToString(), num.ToString(),tb2.Rows[i]["keterangan"].ToString(),tb2.Rows[i]["lama"].ToString(), tb2.Rows[i]["kat"].ToString(), tb2.Rows[i]["grade"].ToString(), tb2.Rows[i]["biaya"].ToString(), tb2.Rows[i]["total"].ToString());
        	}
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
			
        }

        private void btnGrade_Click_1(object sender, EventArgs e)
        {
            
            
        }

        
        void BtnGradeClick(object sender, EventArgs e)
        {
        	if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
        //public event EventHandler editingShowing;
        void BunifuCustomDataGrid1EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }
       
        
        
        
        void BunifuFlatButton4Click(object sender, EventArgs e)
        {
        	MysqlClass db = new MysqlClass();
        	db.Execute("INSERT INTO tb_dana_tetap (keterangan,lama,grade,kat, biaya) VALUES (@a, @b, @c, @d, @e)",
        	           new MySql.Data.MySqlClient.MySqlParameter("@a", bunifuMetroTextbox3.Text),
        	          new MySql.Data.MySqlClient.MySqlParameter("@b", txtlama.Text),
        	          new MySql.Data.MySqlClient.MySqlParameter("@d", cmbketerangan.selectedValue.ToString()),
        	          new MySql.Data.MySqlClient.MySqlParameter("@c", cmbgrade.selectedValue.ToString()),
        	          new MySql.Data.MySqlClient.MySqlParameter("@e", txtbiaya.Text)
        	          );
        	DataTable tb2 = db.GetData("select * from tb_dana_tetap");
        	int nub = 0;
        	bunifuCustomDataGrid1.Rows.Clear();
        	
        	for(int i = 0; i < tb2.Rows.Count;i++){
        		nub++;
        		bunifuCustomDataGrid1.Rows.Add(tb2.Rows[i]["id"].ToString(), nub.ToString(),tb2.Rows[i]["keterangan"].ToString(),tb2.Rows[i]["lama"].ToString(), tb2.Rows[i]["kat"].ToString(), tb2.Rows[i]["grade"].ToString(), tb2.Rows[i]["biaya"].ToString(), tb2.Rows[i]["total"].ToString());
        	}
        	foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
			{
        		row.Cells[7].Value = (double.Parse(row.Cells[3].Value.ToString()) * double.Parse(row.Cells[6].Value.ToString())).ToString();
			   //More code here
			}
        }
        
        void reload_input(){
        	bunifuMetroTextbox3.Text = "";
        	cmbketerangan.selectedIndex = -1;
        	txtlama.Text = "";
        	txtbiaya.Text = "";
        }
        void CmbketeranganonItemSelected(object sender, EventArgs e)
        {
        	if(cmbketerangan.selectedIndex != -1){
        		MysqlClass db = new MysqlClass();
	        	DataTable tb = db.GetData("select grade, biaya from tb_grade where keterangan = @ket",
	        	                          new MySql.Data.MySqlClient.MySqlParameter("@ket", cmbketerangan.selectedValue.ToString()));
	        	cmbgrade.Clear();
	        	
	        	foreach(DataRow row in tb.Rows){
	        		cmbgrade.AddItem(row["grade"].ToString() + " "+ string.Format("{0:N0}", double.Parse(row["biaya"].ToString())));
	        		
	        	}
        	} else {
        		cmbgrade.Clear();
        	}
        	
        }
        
        void CmbgradeonItemSelected(object sender, EventArgs e)
        {
        	MysqlClass db = new MysqlClass();
        	DataTable tb = db.GetData("select biaya from tb_grade where keterangan = @ket and grade = @gr",
        	                          new MySql.Data.MySqlClient.MySqlParameter("@ket", cmbketerangan.selectedValue.ToString()),
        	                          new MySql.Data.MySqlClient.MySqlParameter("@gr", cmbgrade.selectedValue.ToString().Substring(0,1)));
        	
        	//MessageBox.Show(tb.Rows.Count.ToString());
        	txtbiaya.Text = tb.Rows[0]["biaya"].ToString();
        }
        
        void BunifuMetroTextbox2OnValueChanged(object sender, EventArgs e)
        {
        	
        
        }
        
        void BunifuMetroTextbox2KeyPress(object sender, KeyPressEventArgs e)
        {
        	if (e.KeyChar == '.')
            {
                return;
            }

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        
        void TxtbiayaTextChanged(object sender, EventArgs e)
        {
			if(txtbiaya.Text == "")
        		txtbiaya.Text = "0";
        	txtbiaya.Text = string.Format("{0:N0}", double.Parse(txtbiaya.Text));
                txtbiaya.SelectionStart = txtbiaya.Text.Length;   
           // if(txtlama.Text != "")
            //	btntot.Text = (double.Parse(txtlama.Text) * double.Parse(txtbiaya.Text)).ToString();
        }
        
        void BunifuMetroTextbox1OnValueChanged(object sender, EventArgs e)
        {
        	
        }
        
        void BtntotTextChanged(object sender, EventArgs e)
        {
        	
        }
        
        void TxtlamaTextChanged(object sender, EventArgs e)
        {
			txtlama.Text = string.Format("{0:N0}", double.Parse(txtlama.Text));
			txtlama.SelectionStart = txtlama.Text.Length; 
                   
        	if(txtlama.Text == "")
        		txtlama.Text = "1";
        	//if(txtbiaya.Text != "" || txtbiaya.Text != "0")
        	//	btntot.Text = (double.Parse(txtlama.Text) * double.Parse(txtbiaya.Text)).ToString();        	
        }
        
        void BunifuFlatButton3Click(object sender, EventArgs e)
        {
        	if(bunifuCustomDataGrid1.SelectedRows.Count > 0){
        		var id_edit = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
        		MysqlClass db = new MysqlClass();
        		DataTable tb2 = db.GetData("select a.* ,b.biaya from tb_dana_tetap as a, tb_grade as b WHERE a.grade = b.grade AND a.kat = b.keterangan AND id = @id",
        		                           new MySql.Data.MySqlClient.MySqlParameter("@id", id_edit));
        		
        		
        	} else {
        		MessageBox.Show("Pilih Data");
        	}
        }
        
        void TxtlamaKeyPress(object sender, KeyPressEventArgs e)
        {
        	if (e.KeyChar == '.')
            {
                return;
            }

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        
        void TxtbiayaKeyPress(object sender, KeyPressEventArgs e)
        {
        	if (e.KeyChar == '.')
            {
                return;
            }

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
