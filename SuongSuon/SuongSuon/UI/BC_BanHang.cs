using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuongSuon.UI
{
    public partial class BC_BanHang : UserControl
    {
        public BC_BanHang()
        {
            InitializeComponent();
            loadForm();
            
        }
        public void loadForm()
        {
            cbo_BC_DT.SelectedIndex = 0;
            cbo_BC_Loai_BC.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
