using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTrinh
{
    public partial class QuanLyCongTrinhXayDUng : Form
    {
        private String account = @"server=DESKTOP-3SA2B2L; user id = sa; password = 080795; database=";
        public QuanLyCongTrinhXayDUng()
        {
            InitializeComponent();
        }

        private void btn_QLCPVT_Click(object sender, EventArgs e)
        {
            QuanLyChiPhiVatTu quanLyChiPhiVatTu = new QuanLyChiPhiVatTu(this, account + "QLCPVT");
            this.Hide();
            quanLyChiPhiVatTu.Show();
        }

        private void QuanLyCongTrinhXayDUng_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to exit?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
