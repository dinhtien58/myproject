using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmHDB : Form
    {
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        Classes.ConnectData data = new Classes.ConnectData();
        public frmHDB()
        {
            InitializeComponent();
            //fill data in comboboxes
            DataTable dtNV = data.ReadData("select * from tblNhanVien");
            DataTable dtKH = data.ReadData("select * from tblKhach");
            DataTable dtHang = data.ReadData("select * from tblHang");
            DataTable dtHDB = data.ReadData("select * from tblHDBan");
            functions.FillComboBox(cmbMaNV, dtNV, "MaNhanVien", "MaNhanVien");
            functions.FillComboBox(cmbMaKH, dtKH,"MaKhach", "MaKhach");
            functions.FillComboBox(cmbMaHang, dtHang, "MaHang", "MaHang");
            functions.FillComboBox(cmbTimKiem, dtHDB, "MaHDBan", "MaHDBan");

        }

        private void frmHDB_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtHdban = data.ReadData("select * from tblHDBan where MaHDBan = '" + cmbTimKiem.Text + "'");
            DataTable dtChiTietHDB = data.ReadData("select tblChiTietHDBan.MaHang,TenHang, tblChiTietHDBan.SoLuong," +
                "DonGiaBan, GiamGia, ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang = tblHang.MaHang " +
                "where MaHDban = '" + cmbTimKiem.Text + "'");
            txtMaHD.Text = cmbTimKiem.Text;
            dtpNgayNhap.Text = dtHdban.Rows[0]["NgayBan"].ToString();
            cmbMaNV.SelectedValue = dtHdban.Rows[0]["MaNhanVien"].ToString();
            cmbMaKH.SelectedValue = dtHdban.Rows[0]["MaKhach"].ToString();
            dgvSP.DataSource = dtChiTietHDB;
            label16.Text = dtHdban.Rows[0]["TongTien"].ToString();

        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable daNV = data.ReadData("select TenNhanVien from tblNhanVien where MaNhanVien = '" + cmbMaNV.SelectedValue + "'");
                txtTenNV.Text = daNV.Rows[0]["TenNhanVien"].ToString();
            }
            catch
            {

            }
            
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable daKH = data.ReadData("select * from tblKhach where MaKhach = '" + cmbMaKH.SelectedValue + "'");
                txtTenKH.Text = daKH.Rows[0]["TenKhach"].ToString();
                txtDiaChi.Text = daKH.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = daKH.Rows[0]["DienThoai"].ToString();
            }
            catch
            {

            }
            
        }

        private void cmbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable daHang = data.ReadData("select * from tblHang where MaHang = '" + cmbMaHang.SelectedValue + "'");
                txtTenHang.Text = daHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = daHang.Rows[0]["DonGiaBan"].ToString();
            }
            catch
            {

            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ban chi duoc nhap so nguyen");
                e.Handled = true;
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            float sl, dg, gg, tt;
            try
            {
                if(txtGiamGia.Text.Trim() == "")
                {
                    gg = 0;
                }
                else
                {
                    gg = float.Parse(txtGiamGia.Text);
                }
                if(txtSL.Text.Trim() == "")
                {
                    sl = 0;
                }
                else
                {
                    sl = float.Parse(txtSL.Text);
                }
                dg = float.Parse(txtDonGia.Text);
                tt = dg * sl * (1 - gg / 100);
                txtThanhTien.Text = tt.ToString();
            }
            catch
            {

            }
        }
        void ResetValue()
        {
            txtMaHD.Text = "";
            dtpNgayNhap.Text = "";
            cmbMaHang.Text = "";
            cmbMaNV.Text = "";
            cmbMaKH.Text = "";
            txtTenNV.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtDonGia.Text = "";
            txtTenHang.Text = "";
            txtSL.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            label16.Text = "";
            dgvSP.DataSource = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaHD.Text = functions.AutoCode("tblHDBan", "MaHDban", "HDB" + DateTime.Now.Day.ToString() +DateTime.Now.Month.ToString()+DateTime.Now.Year.ToString());
        }

        
    }
}
