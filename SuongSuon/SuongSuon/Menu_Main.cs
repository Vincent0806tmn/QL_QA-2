using DevExpress.XtraBars;
using SuongSuon.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuongSuon
{
    public partial class Menu_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Menu_Main()
        {
            InitializeComponent();
        }
        private void ctrl_BanHang_BC_Click(object sender, EventArgs e)
        {
            BC_BanHang form_test = new BC_BanHang();
            form_test.Dock = DockStyle.Fill;
            main_contain.Controls.Add(form_test);
            form_test.BringToFront();
        }
    }
}
