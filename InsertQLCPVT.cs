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
    public partial class InsertQLCPVT : Form
    {
        QuanLyChiPhiVatTu mainScreen;
        private String account;
        private SqlConnection connection;
        private String strCongTrinh;
        public InsertQLCPVT(QuanLyChiPhiVatTu screen, String acc, String strName)
        {
            account = acc;
            strCongTrinh = strName;
            connection = new SqlConnection(account);
            mainScreen = screen;
            InitializeComponent();
        }

        private void InsertQLCPVT_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert1_QLCPVT_Click(object sender, EventArgs e)
        {
            int stt = findSTT() + 1;
            DateTime date = datetime_insert_QLCPVT.Value;
            String dateTime = String.Format("{0:yyyy-MM-dd}", date);
            String sql = "insert into " + strCongTrinh + " values (";
            if (txt_vattu_insert_QLCPVT.Text == "")
                MessageBox.Show("Vật tư không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_donvi_insert_QLCPVT.Text == "")
                MessageBox.Show("Đơn vị giá không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_soluong_insert_QLCPVT.Text == "")
                MessageBox.Show("Số lượng không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_dongia_insert_QLCPVT.Text == "")
                MessageBox.Show("Đơn giá không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int soLuong = 0, donGia = 0;
                try
                {
                    soLuong = int.Parse(txt_soluong_insert_QLCPVT.Text);
                    donGia = int.Parse(txt_dongia_insert_QLCPVT.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int tien = soLuong * donGia;
                sql += stt.ToString() + "," + " '" + dateTime + "',  N'" + txt_vattu_insert_QLCPVT.Text + "', N'" + txt_donvi_insert_QLCPVT.Text + "', " + txt_soluong_insert_QLCPVT.Text + ", "
                    + txt_dongia_insert_QLCPVT.Text + ", " + tien.ToString() + ", N'" + txt_ghichu_insert_QLCPVT.Text + "')";
                connection.Open();
                SqlCommand comm = new SqlCommand(sql, connection);
                comm.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }

        private int findSTT()
        {
            
            String sql = "select count(*) from " + strCongTrinh;
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            int result = (int)com.ExecuteScalar();
            connection.Close();
            return result;
        }

        private void InsertQLCPVT_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
            e.Cancel = false;
        }
    }
}
