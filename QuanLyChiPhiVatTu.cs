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
using System.IO;

namespace QuanLyCongTrinh
{
    public partial class QuanLyChiPhiVatTu : Form
    {
        private QuanLyCongTrinhXayDUng mainScreen;
        private String account;
        private SqlConnection connection;
        public QuanLyChiPhiVatTu(QuanLyCongTrinhXayDUng screen, String acc)
        {
            account = acc;
            connection = new SqlConnection(account);
            mainScreen = screen;
            InitializeComponent();
        }

        private void showGridView(String strCongTrinh)
        {
            try
            {
                String sql = "Select * from " + strCongTrinh;
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                grid_QLCPVT.DataSource = table;
            }
            catch (Exception )
            { return; }
        }

        private void AddANewTable(String strNameTable)
        {
            String sql = "Create table " + strNameTable;
            sql +=
                "(STT int, " +
                "ngay date, " +
                "vattu nvarchar(50), " +
                "dvt nvarchar(30), " +
                "soluong int, " +
                "dongia int, " +
                "thanhtien int, " +
                "ghichu nvarchar(100), " +
                "primary key(STT))";
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand(sql, connection);
                com.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi tên công trình", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
            connection.Close();
        }

        private void btn_updateQLCPVT_Click(object sender, EventArgs e)
        {
            UpdateQLCPVT updateQLCPVT = new UpdateQLCPVT(this, account, cbx_QLCPVT.Text);
            this.Hide();
            updateQLCPVT.Show();
        }

        private void btn_insertQLCPVT_Click(object sender, EventArgs e)
        {
            InsertQLCPVT insertQLCPVT = new InsertQLCPVT(this, account, cbx_QLCPVT.Text);
            this.Hide();
            insertQLCPVT.Show();
        }

        private void btn_deleteQLCPVT_Click(object sender, EventArgs e)
        {
            DeleteQLCPVT deleteQLCPVT = new DeleteQLCPVT(this, account, cbx_QLCPVT.Text);
            this.Hide();
            deleteQLCPVT.Show();
        }

        private void btn_searchQLCPVT_Click(object sender, EventArgs e)
        {
            SearchQLCPVT searchQLCPVT = new SearchQLCPVT(this, account, cbx_QLCPVT.Text);
            this.Hide();
            searchQLCPVT.Show();
        }

        private void QuanLyChiPhiVatTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
            e.Cancel = false;
        }

        private void QuanLyChiPhiVatTu_Activated(object sender, EventArgs e)
        {
            if (cbx_QLCPVT.Text != "")
                showGridView(cbx_QLCPVT.Text);
            else showCongTrinh();
        }

        private void showCongTrinh()
        {
            try
            {
                String sql = "select table_name from information_schema.tables";
                SqlCommand com = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adapt.Fill(table);
                table.Rows.Add("Add");
                cbx_QLCPVT.DisplayMember = "table_name";
                cbx_QLCPVT.DataSource = table;
            } catch(Exception)
            { return; }
        }

        private void cbx_QLCPVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_QLCPVT.Text == "Add")
            {
                lbl_congtrinh_QLCPVT.Visible = true;
                txt_tencongtrinh_QLCPVT.Visible = true;
                btn_add_congtrinh_QLCPVT.Visible = true;
                btn_delete_congtrinh_QLCPVT.Visible = false;
                btn_export_QLCPVT.Visible = false;
                txt_link_QLCPVT.Visible = false;
                lbl_link_QLCPVT.Visible = false;
                grid_QLCPVT.DataSource = null;
            }
            else
            {
                showGridView(cbx_QLCPVT.Text);
                btn_delete_congtrinh_QLCPVT.Visible = true;
                btn_export_QLCPVT.Visible = true;
                lbl_link_QLCPVT.Visible = true;
                txt_link_QLCPVT.Visible = true;
                lbl_congtrinh_QLCPVT.Visible = false;
                txt_tencongtrinh_QLCPVT.Visible = false;
                btn_add_congtrinh_QLCPVT.Visible = false;
            }
        }

        private void add_congtrinh_QLCPVT_Click(object sender, EventArgs e)
        {
            if (txt_tencongtrinh_QLCPVT.Text != "")
            {
                AddANewTable(txt_tencongtrinh_QLCPVT.Text);
                showCongTrinh();
                txt_tencongtrinh_QLCPVT.Text = "";
                lbl_congtrinh_QLCPVT.Visible = false;
                txt_tencongtrinh_QLCPVT.Visible = false;
                btn_add_congtrinh_QLCPVT.Visible = false;
            }
            else
            {
                MessageBox.Show("Chưa nhập tên công trình cần thêm", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_congtrinh_QLCPVT_Click(object sender, EventArgs e)
        {
            if (cbx_QLCPVT.Text == "" || cbx_QLCPVT.Text == "Add")
                MessageBox.Show("Chưa chọn công trình cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = "Drop table " + cbx_QLCPVT.Text;
                try
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);
                    com.ExecuteNonQuery();
                    connection.Close();
                    showCongTrinh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }
        

        private void btn_export_QLCPVT_Click(object sender, EventArgs e)
        {
            if (grid_QLCPVT != null)
            {
                if (txt_link_QLCPVT.Text != "")
                    ExportToExcel.Export(grid_QLCPVT, txt_link_QLCPVT.Text + ".xls");
                else
                    MessageBox.Show("Chưa nhập link để lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Không thể xuất file excel", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
