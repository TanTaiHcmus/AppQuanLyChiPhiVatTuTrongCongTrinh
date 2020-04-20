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
    public partial class DeleteQLCPVT : Form
    {
        QuanLyChiPhiVatTu mainScreen;
        private String account;
        private String strCongTrinh;
        private SqlConnection connection;
        public DeleteQLCPVT(QuanLyChiPhiVatTu screen, String acc, String strName)
        {
            account = acc;
            strCongTrinh = strName;
            connection = new SqlConnection(account);
            mainScreen = screen;
            InitializeComponent();
        }

        private void DeleteQLCPVT_Load(object sender, EventArgs e)
        {
            showSTT();
        }

        private void showSTT()
        {
            try
            {
                String sql = "Select STT from " + strCongTrinh;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                cbx_stt_delete_QLCPVT.DisplayMember = "STT";
                cbx_stt_delete_QLCPVT.DataSource = table;
            }
            catch (Exception) { return; }
        }

        private void btn_delete_QLCPVT_Click(object sender, EventArgs e)
        {
            int maxSTT = findSTT();
            String sql = "Delete from " + strCongTrinh + " where stt = " + cbx_stt_delete_QLCPVT.Text;
            connection.Open();
            SqlCommand comm = new SqlCommand(sql, connection);
            comm.ExecuteNonQuery();
            for (int i = int.Parse(cbx_stt_delete_QLCPVT.Text) + 1; i <= maxSTT; i++)
            {
                sql = "update " + strCongTrinh + " set STT = " + (i - 1).ToString() + " where STT = " + i.ToString();
                comm = new SqlCommand(sql, connection);
                comm.ExecuteNonQuery();
            }
            connection.Close();
            this.Close(); 
        }

        private int findSTT()
        {
            try
            {
                String sql = "select count(*) from " + strCongTrinh;
                connection.Open();
                SqlCommand com = new SqlCommand(sql, connection);
                int result = (int)com.ExecuteScalar();
                connection.Close();
                return result;
            }
            catch (Exception) {
                connection.Close();
                return 0; }
        }

        private void cbx_stt_delete_QLCPVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String stt = cbx_stt_delete_QLCPVT.Text;
                String sql = "Select * from " + strCongTrinh + " where STT = " + stt;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                DataRow dataRow = table.Rows[0];
                DateTime dateTime = Convert.ToDateTime(dataRow["ngay"]);
                datetime_delete_QLCPVT.Value = dateTime;
                txt_vattu_delete_QLCPVT.Text = dataRow["vattu"].ToString();
                txt_donvi_delete_QLCPVT.Text = dataRow["DVT"].ToString();
                txt_soluong_delete_QLCPVT.Text = dataRow["SoLuong"].ToString();
                txt_dongia_delete_QLCPVT.Text = dataRow["dongia"].ToString();
                txt_ghichu_delete_QLCPVT.Text = dataRow["ghichu"].ToString();
            }catch (Exception) { return; }
        }

        private void DeleteQLCPVT_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
            e.Cancel = false;
        }
    }
}
