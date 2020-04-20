using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCongTrinh
{
    public partial class UpdateQLCPVT : Form
    {
        QuanLyChiPhiVatTu mainScreen;
        private String account;
        private SqlConnection connection;
        private String strCongTrinh;
        public UpdateQLCPVT(QuanLyChiPhiVatTu screen, String acc, String strName)
        {
            account = acc;
            strCongTrinh = strName;
            connection = new SqlConnection(account);
            mainScreen = screen;
            InitializeComponent();
        }

        private void UpdateQLCPVT_Load(object sender, EventArgs e)
        {
            showSTT();
        }

        private void showSTT()
        {
            String sql = "Select STT from " + strCongTrinh;
            SqlCommand com = new SqlCommand(sql, connection);
            SqlDataAdapter adapt = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapt.Fill(table);
            cbx_stt_update_QLCPVT.DisplayMember = "STT";
            cbx_stt_update_QLCPVT.DataSource = table;
        }

        private void cbx_stt_update_QLCPVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            String stt = cbx_stt_update_QLCPVT.Text;
            String sql = "Select * from " + strCongTrinh + " where STT = " + stt;
            SqlCommand com = new SqlCommand(sql, connection);
            SqlDataAdapter adapt = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapt.Fill(table);
            DataRow dataRow = table.Rows[0];
            DateTime dateTime = Convert.ToDateTime(dataRow["ngay"]);
            datetime_update_QLCPVT.Value = dateTime;
            txt_vattu_update_QLCPVT.Text = dataRow["vattu"].ToString();
            txt_donvi_update_QLCPVT.Text = dataRow["DVT"].ToString();
            txt_soluong_update_QLCPVT.Text = dataRow["SoLuong"].ToString();
            txt_dongia_update_QLCPVT.Text = dataRow["dongia"].ToString();
            txt_ghichu_update_QLCPVT.Text = dataRow["ghichu"].ToString();
        }

        private void btn_update1_QLCPVT_Click(object sender, EventArgs e)
        {
            String stt = cbx_stt_update_QLCPVT.Text;
            DateTime date = datetime_update_QLCPVT.Value;
            String dateTime = String.Format("{0:yyyy-MM-dd}", date);
            String sql = "update " + strCongTrinh + " set ";
            if (txt_vattu_update_QLCPVT.Text == "")
                MessageBox.Show("Vật tư không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_donvi_update_QLCPVT.Text == "")
                MessageBox.Show("Đơn vị giá không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_soluong_update_QLCPVT.Text == "")
                MessageBox.Show("Số lượng không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_dongia_update_QLCPVT.Text == "")
                MessageBox.Show("Đơn giá không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int soLuong = 0, donGia = 0;
                try
                {
                    soLuong = int.Parse(txt_soluong_update_QLCPVT.Text);
                    donGia = int.Parse(txt_dongia_update_QLCPVT.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int tien = soLuong * donGia;
                sql += "ngay = '" + dateTime + "', " + "vattu = N'" + txt_vattu_update_QLCPVT.Text + "', " + "dvt = N'" + txt_donvi_update_QLCPVT.Text
                    + "', " + "soluong = " + txt_soluong_update_QLCPVT.Text + ", " + "dongia = " + txt_dongia_update_QLCPVT.Text + ", " + "thanhtien = "
                    + tien.ToString() + ", " + "ghichu = N'" + txt_ghichu_update_QLCPVT.Text + "' where STT = " + stt;
                connection.Open();
                SqlCommand comm = new SqlCommand(sql, connection);
                comm.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }

        private void UpdateQLCPVT_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
            e.Cancel = false;
        }
    }
}
