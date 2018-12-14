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
    public partial class biayaPengadaan : UserControl
    {
        private static biayaPengadaan _instance;
        public static biayaPengadaan Instance {
            get {
                if (_instance == null)
                    _instance = new biayaPengadaan();
                return _instance;
            }
        }
        public biayaPengadaan()
        {
            InitializeComponent();
        }
    }
}
