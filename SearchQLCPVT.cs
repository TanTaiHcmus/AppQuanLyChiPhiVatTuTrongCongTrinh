using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTrinh
{
    public partial class SearchQLCPVT : Form
    {
        private QuanLyChiPhiVatTu mainScreen;
        private String account;
        private String strCongTrinh;
        private SqlConnection connection;
        public SearchQLCPVT(QuanLyChiPhiVatTu screen, String acc, String strName)
        {
            account = acc;
            strCongTrinh = strName;
            connection = new SqlConnection(account);
            mainScreen = screen;
            InitializeComponent();
        }

        private void SearchQLCPVT_Load(object sender, EventArgs e)
        {
            btn_export_search_QLCPVT.Visible = false;
            txt_link_search_QLCPVT.Visible = false;
            lbl_link_search_QLCPVT.Visible = false;
        }

        private void showDateTime()
        {
            try
            {
                String sql = "Select ngay from " + strCongTrinh;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                cbx_datetime_search_QLCPVT.DisplayMember = "ngay";
                cbx_datetime_search_QLCPVT.DataSource = table;
            }
            catch (Exception) { return; }
        }

        private void cbx_vattu_search_QLCPVT_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String sql = "Select distinct(vattu) from " + strCongTrinh;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                cbx_vattu_search_QLCPVT.DisplayMember = "vattu";
                cbx_vattu_search_QLCPVT.DataSource = table;
            }
            catch (Exception) { return; }
        }

        private void cbx_datetime_search_QLCPVT_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String sql = "Select distinct(ngay) from " + strCongTrinh;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                cbx_datetime_search_QLCPVT.DisplayMember = "ngay";
                cbx_datetime_search_QLCPVT.DataSource = table;
            }
            catch (Exception) { return; }
        }

        private void btn_return_search_QLCPVT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search1_QLCPVT_Click(object sender, EventArgs e)
        {
            if (cbx_datetime_search_QLCPVT.Text == "" && cbx_vattu_search_QLCPVT.Text == "")
                MessageBox.Show("Vui lòng chọn ngày hoặc vật tư cần tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String sql = "Select * from " + strCongTrinh + " where ";
                String sql1 = "Select sum(thanhtien) from " + strCongTrinh + " where ";
                if (cbx_vattu_search_QLCPVT.Text != "")
                {
                    sql += "vattu = N'" + cbx_vattu_search_QLCPVT.Text + "' ";
                    if (cbx_datetime_search_QLCPVT.Text != "") sql += "and ";
                    sql1 += "vattu = N'" + cbx_vattu_search_QLCPVT.Text + "' ";
                    if (cbx_datetime_search_QLCPVT.Text != "") sql1 += "and ";
                }
                if (cbx_datetime_search_QLCPVT.Text != "")
                {
                    sql += "ngay = '" + cbx_datetime_search_QLCPVT.Text + "' ";
                    sql1 += "ngay = '" + cbx_datetime_search_QLCPVT.Text + "' ";
                }
                sql += "order by ngay, vattu";
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                grid_search_QLCPVT.DataSource = table;
                connection.Open();
                com = new SqlCommand(sql1, connection);
                int result = (int) com.ExecuteScalar();
                lb_tongtien_search_QLCPVT.Text = "Tổng tiền: " + result.ToString("#,##0") + " đồng";
                connection.Close();
                btn_export_search_QLCPVT.Visible = true;
                txt_link_search_QLCPVT.Visible = true;
                lbl_link_search_QLCPVT.Visible = true;
            }
        }

        private void SearchQLCPVT_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
            e.Cancel = false;
        }

        private void btn_export_search_QLCPVT_Click(object sender, EventArgs e)
        {
            if (grid_search_QLCPVT != null)
            {
                if (grid_search_QLCPVT.Text != "")
                    ExportToExcel.Export(grid_search_QLCPVT, txt_link_search_QLCPVT.Text + ".xls");
                else
                    MessageBox.Show("Chưa nhập link để lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Không thể xuất file excel", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
