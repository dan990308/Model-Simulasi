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
    public partial class settingGrade : UserControl
    {
        private static settingGrade _instance;
        public static settingGrade Instance {
            get {
                if (_instance == null)
                    _instance = new settingGrade();
                return _instance;
            }
        }
        public settingGrade()
        {
            InitializeComponent();
        }

        public event EventHandler buttonClicked;
        public event EventHandler grade_Load;
        private void btnback_Click(object sender, EventArgs e)
        {
            if (buttonClicked != null)
                buttonClicked(this, e);
        }
		
        private void settingGrade_Load(object sender, EventArgs e)
        {
        	if (grade_Load != null)
                grade_Load(this, e);

        }
    }
}
