using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class FormTest : Form
    {
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        Classes.ConnectData data = new Classes.ConnectData();
        public FormTest()
        {
            InitializeComponent();
            LoadData();
           
        }

        public void LoadData()
        {
            // Fill Combobox
            DataTable dtNV = data.ReadData("Select * from tblNhanVien");
            functions.FillComboBox(cbMaNV, dtNV, "Manhanvien", "Manhanvien");
            DataTable dtKH = data.ReadData("Select * from tblKhach");
            functions.FillComboBox(cbMaKH, dtKH, "Makhach", "Makhach");
            DataTable dtHang = data.ReadData("Select * from tblHang");
            functions.FillComboBox(cbMaHang, dtHang, "Mahang", "Mahang");
            DataTable dtHDB = data.ReadData("Select * from tblHDBan");
            functions.FillComboBox(cbMaHD, dtHDB, "MaHDBan", "MaHDBan");
        }
        private void ResetValue()
        {
            txtMaHD.Text = "";
            cbMaNV.Text = "";
            txtTenNV.Text = "";
            cbMaKH.Text = "";
            txtTenNV.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            txtGiamGia.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            dgvHoaDonBan.DataSource = null;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaHD.Text = cbMaHD.Text;
            DataTable dtHDB = data.ReadData("Select tblHDBan.NgayBan, TongTien,tblHDBan.MaNhanVien,Tennhanvien,tblHDBan.MaKhach, TenKhach," +
                "tblKhach.DiaChi, tblKhach.DienThoai from tblHDBan inner join tblKhach on tblHDBan.Makhach = tblKhach.Makhach " +
                "inner join tblNhanVien on tblHDBan.MaNhanVien = tblNhanVien.Manhanvien where tblHDBan.MaHDBan='" +
                cbMaHD.Text + "'");
            dtpNgayBan.Text = dtHDB.Rows[0]["NgayBan"].ToString();
            cbMaNV.SelectedValue = dtHDB.Rows[0]["MaNhanVien"].ToString();
            txtTenNV.Text = dtHDB.Rows[0]["Tennhanvien"].ToString();
            cbMaKH.SelectedValue = dtHDB.Rows[0]["MaKhach"].ToString();
            txtTenKH.Text = dtHDB.Rows[0]["TenKhach"].ToString();
            txtDiaChi.Text = dtHDB.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dtHDB.Rows[0]["DienThoai"].ToString();

            DataTable dtChiTietHDB = data.ReadData("select tblChiTietHDBan.MaHang,TenHang, tblChiTietHDBan.SoLuong," +
               "DonGiaBan, GiamGia, ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang = tblHang.MaHang " +
               "where MaHDban = '" + cbMaHD.Text + "'");
            dgvHoaDonBan.DataSource = dtChiTietHDB;
            txtTongTien.Text = dtHDB.Rows[0]["TongTien"].ToString();

        }

        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbMaHang.SelectedValue = dgvHoaDonBan.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dgvHoaDonBan.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dgvHoaDonBan.CurrentRow.Cells[2].Value.ToString();
                txtDonGia.Text = dgvHoaDonBan.CurrentRow.Cells[3].Value.ToString();
                txtGiamGia.Text = dgvHoaDonBan.CurrentRow.Cells[4].Value.ToString();
                txtThanhTien.Text = dgvHoaDonBan.CurrentRow.Cells[5].Value.ToString();
              
            }catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaHD.Text = functions.AutoCode("tblHDBan", "MaHDban", "HDB" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());          

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtMaNV = data.ReadData("Select * from tblNhanVien where Manhanvien='" + cbMaNV.Text + "'");
            txtTenNV.Text = dtMaNV.Rows[0]["Tennhanvien"].ToString();
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtMaKH = data.ReadData("Select * from tblKhach where Makhach='" + cbMaKH.Text + "'");
            txtTenKH.Text = dtMaKH.Rows[0]["TenKhach"].ToString();
            txtDiaChi.Text = dtMaKH.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dtMaKH.Rows[0]["DienThoai"].ToString();

        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtMaHang = data.ReadData("Select * from tblHang where Mahang='" + cbMaHang.Text + "'");
            txtTenHang.Text = dtMaHang.Rows[0]["TenHang"].ToString();
            txtDonGia.Text = dtMaHang.Rows[0]["DonGiaBan"].ToString();

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn phải nhập chữ số !!");
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            float soLuong, giamGia, donGia, thanhTien;
            if(txtSoLuong.Text.Trim() == "")
            {
                soLuong = 0;
            } else
            {
                soLuong = int.Parse(txtSoLuong.Text);
            }
            if(txtGiamGia.Text.Trim() == "")
            {
                giamGia = 0;
            } else
            {
                giamGia = float.Parse(txtGiamGia.Text);
            }
            donGia = int.Parse(txtDonGia.Text);
            thanhTien = soLuong * donGia * (1 - giamGia / 100);
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsertHDBan;
            float soLuongMua, soLuongCon, tongTien;
            // Kiểm tra tính đầy đủ của dữ liệu
            if(cbMaNV.Text == "")
            {
                MessageBox.Show("Chưa có thông tin nhân viên bán");
                return;
            }
            if(cbMaKH.Text == "")
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return; 
            }
            if(cbMaHang.Text == "")
            {
                MessageBox.Show("Chưa có thông tin sản phẩm");
                return;
            }
            if(txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                txtSoLuong.Focus();
                return; 
            }

            // Khi lưu hóa đơn xảy ra hai trường hợp : 
            // TH1 : tblHDBan đã có hóa đơn với mã vừa sinh --> Update lại tổng tiền
            // TH2 : Chưa có hóa đơn : insert hóa đơn
            DataTable dtHDBan = data.ReadData("Select * from tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
            if(dtHDBan.Rows.Count == 0)
            {
                sqlinsertHDBan = "insert into tblHDBan values('" + txtMaHD.Text + "','" + cbMaNV.SelectedValue +
                    "','" + dtpNgayBan.Value.ToString("yyyy/MM/dd") + "','" + cbMaKH.SelectedValue + "','" + txtThanhTien.Text + "')";
                data.UpdateData(sqlinsertHDBan);

            }
            // tblHD đã tồn tại 
            // 1.Kiểm tra số lượng hàng còn hay không
            DataTable dtHang = data.ReadData("Select * from tblHang where MaHang='" + cbMaHang.SelectedValue + "'");
            soLuongCon = float.Parse(dtHang.Rows[0]["SoLuong"].ToString());
            soLuongMua = float.Parse(txtSoLuong.Text);
            if(soLuongCon < soLuongMua)
            {
                MessageBox.Show("Không còn đủ số lượng sản phẩm ");
                txtSoLuong.Focus();
                return;
            }
            soLuongCon = soLuongCon - soLuongMua;
            // insert vào bảng tblChiTiet
            try
            {
                data.UpdateData("insert into tblChiTietHDBan values('" + txtMaHD.Text + "','" + cbMaHang.SelectedValue + "','"
               + (int)soLuongMua + "','" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')");
            } catch
            {
                return; 
            }
            // update lại bảng tblHang 
            data.UpdateData("update tblHang set SoLuong='" + (int)soLuongCon + "' where MaHang='" + cbMaHang.SelectedValue + "'");
            // update tblCTHDBan cho tong tien 
            DataTable dtChiTiet = data.ReadData("Select * from tblChiTietHDBan where MaHDBan='" + txtMaHD.Text + "'");
            tongTien = 0;
            for(int i = 0; i < dtChiTiet.Rows.Count; i++)
            {
                tongTien = tongTien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
            }
            data.UpdateData("update tblHDBan set TongTien='" + tongTien.ToString() + "' where MaHDBan='" + txtMaHD.Text + "'");
            // Hiện thị dữ liệu
            dgvHoaDonBan.DataSource = dtChiTiet;
            DataTable dtHDB = data.ReadData("Select * from tblHDBan");
            functions.FillComboBox(cbMaHD, dtHDB, "MaHDBan", "MaHDBan");
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã hóa đơn");
                return;
            }
            if(MessageBox.Show("Bạn chắn chắn muốn xóa hóa đơn này không ?","Xóa hóa đơn",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    data.UpdateData("Delete from tblChiTietHDBan where MaHDBan='" + txtMaHD.Text + "'");
                    data.UpdateData("Delete from tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
                    MessageBox.Show("Xóa thành công !!");
                    dgvHoaDonBan.DataSource = null;
                    LoadData();
                    ResetValue();
                } catch
                {
                    MessageBox.Show("Có lỗi j đó :)");
                }
               
            }
            
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
