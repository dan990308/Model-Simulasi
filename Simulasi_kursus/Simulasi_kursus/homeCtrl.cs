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
    public partial class homeCtrl : UserControl
    {
        private static homeCtrl _instance;
        public static homeCtrl Instance {
            get {
                if (_instance == null) {
                    _instance = new homeCtrl();
                }
                return _instance;
            }
        }
        public homeCtrl()
        {
            InitializeComponent();
        }
    }
}
