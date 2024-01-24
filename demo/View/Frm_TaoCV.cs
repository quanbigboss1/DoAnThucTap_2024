using demo.Controller;
using demo.Model;
using demo.Model.demo.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.View
{
    public partial class Frm_TaoCV : MetroSetForm
    {
        HoSoUngVienController hoSoUngVienController;
        KinhNghiemLamViecController kinhNghiemLamViecController;
        DuAnController duAnController;
        KyNangController kyNangController;
        HocVanController hocVanController;
        List<KyNang> dsKyNang;
        List<KinhNghiemLamViec> dsKinhNghiemLamViec;
        List<HoSoUngVien> dsHoSoUngVien;
        List<DuAn> dsDuAn;
        List<HocVan> dsHocVan;
        HoSoUngVien currentHoSo;
        NguoiDung currentNguoiDung;
        NguoiDungController nguoiDungController;

        public Frm_TaoCV(NguoiDung nguoidung)
        {
            InitializeComponent();
            nguoiDungController = new NguoiDungController();    
            hoSoUngVienController = new HoSoUngVienController();
            dsHoSoUngVien = new List<HoSoUngVien>();
            kinhNghiemLamViecController = new KinhNghiemLamViecController();
            dsKinhNghiemLamViec = new List<KinhNghiemLamViec>();
            duAnController = new DuAnController();
            kyNangController = new KyNangController();
            dsKyNang = new List<KyNang>();
            dsDuAn = new List<DuAn>();
            hocVanController = new HocVanController();
            dsHocVan = new List<HocVan>();
            currentHoSo = new HoSoUngVien();
            currentNguoiDung = new NguoiDung();
            currentNguoiDung = nguoidung;
            txtHoTen.Text = nguoidung.GetHoTen();
            txtDiaChi.Text = nguoidung.GetDiaChi();
            txtEmail.Text = nguoidung.Getmail();
            txtSoDienThoai.Text = nguoidung.GetSDT();
            //Load thông tin hồ sơ ứng viên đã tồn tại hay chưa
            txtMaNguoiDung.Text = nguoidung.GetMaNguoiDung().ToString();
            dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
            foreach (HoSoUngVien hosoungvien in dsHoSoUngVien)
            {
                txtMaUngVien.Text = hosoungvien.GetMaUngVien().ToString();
                txtMucTieuNgheNghiep.Text = hosoungvien.GetMucTieuNgheNghiep();
            }
            //Thêm mã hồ sơ cho ứng viên
            if (string.IsNullOrEmpty(txtMaUngVien.Text))
            {
                tileMaSoUngVien.TileCount = int.Parse(GenerateMaUngVien());
                currentHoSo = new HoSoUngVien(tileMaSoUngVien.TileCount, int.Parse(txtMaNguoiDung.Text), txtMucTieuNgheNghiep.Text);
                hoSoUngVienController.Add(currentHoSo);
                txtMaUngVien.Text = tileMaSoUngVien.TileCount.ToString();
            }
            else
            {
                tileMaSoUngVien.TileCount = int.Parse(txtMaUngVien.Text);
            }            
            // Thiết kế cho datagridview Kinh nghiệm làm việc
            dgKinhNghiemLamViec.ColumnCount = 4;
            dgKinhNghiemLamViec.Columns[0].Name = "Thời gian bắt đầu";
            dgKinhNghiemLamViec.Columns[1].Name = "Thời gian kết thúc";
            dgKinhNghiemLamViec.Columns[2].Name = "Mô tả công việc";
            dgKinhNghiemLamViec.Columns[3].Name = "Mã kinh nghiệm";
            dgKinhNghiemLamViec.Columns[3].Visible = false;
            dsKinhNghiemLamViec = kinhNghiemLamViecController.Load(txtMaUngVien.Text);
            foreach (KinhNghiemLamViec knlv in dsKinhNghiemLamViec)
            {
                string[] row = { knlv.GetThoiGianBatDau().ToString("MM/dd/yyyy"), knlv.GetThoiGianKetThuc().ToString("MM/dd/yyyy"), knlv.GetMoTa(), knlv.GetMaKinhNghiem().ToString()  };
                dgKinhNghiemLamViec.Rows.Add(row);
            }
            //
            dgDuAn.ColumnCount = 3;
            dgDuAn.Columns[0].Name = "Tên dự án";
            dgDuAn.Columns[1].Name = "Mô tả dự án";
            dgDuAn.Columns[2].Name = "Mã dự án";
            dgDuAn.Columns[2].Visible = false ;
            dsDuAn = duAnController.Load(txtMaUngVien.Text);
            foreach (DuAn duan in dsDuAn)
            {
                string[] row = {  duan.GetTenDuAn(), duan.GetMoTaDuAn(), duan.GetMaDuAn().ToString() };
                dgDuAn.Rows.Add(row);
            }
            //
            dgKyNang.ColumnCount = 3;
            dgKyNang.Columns[0].Name = "Kỹ năng";
            dgKyNang.Columns[1].Name = "Mô tả kỹ năng";
            dgKyNang.Columns[2].Name = "Mã kỹ năng";
            dgKyNang.Columns[2].Visible = false;
            dsKyNang = kyNangController.Load(txtMaUngVien.Text);
            foreach (KyNang kynang in dsKyNang)
            {
                string[] row = { kynang.GetTenKyNang(), kynang.GetMoTaKyNang(), kynang.GetMaKyNang().ToString() };
                dgKyNang.Rows.Add(row);
            }
            //
            dgHocVan.ColumnCount = 4;
            dgHocVan.Columns[0].Name = "Trình độ";
            dgHocVan.Columns[1].Name = "Ngành Học";
            dgHocVan.Columns[2].Name = "Trường học";
            dgHocVan.Columns[3].Name = "Mã học vấn";
            dgHocVan.Columns[3].Visible = false ;
            dsHocVan = hocVanController.Load(txtMaUngVien.Text);
            foreach (HocVan hocvan in dsHocVan)
            {
                string[] row = { hocvan.GetTrinhDo(), hocvan.GetNganhHoc(), hocvan.GetTruongHoc(), hocvan.GetMaHocVan().ToString() };
                dgHocVan.Rows.Add(row);
            }
            //
            LoadImageFromDatabase();
        }

        private void btnLuuMucTieuNgheNghiep_Click(object sender, EventArgs e)
        {
            HoSoUngVien currentHoSo = new HoSoUngVien(int.Parse(txtMaNguoiDung.Text), txtMucTieuNgheNghiep.Text);
            if (hoSoUngVienController.Edit(currentHoSo))
            {
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }

        private void dgKinhNghiemLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgKinhNghiemLamViec.Rows[e.RowIndex];
                dtThoiGianBatDau.Text = DateTime.Parse(selectRow.Cells[0].Value.ToString()).ToString("MM/dd/yyyy");
                dtThoiGianKetThuc.Text = DateTime.Parse(selectRow.Cells[1].Value.ToString()).ToString("MM/dd/yyyy");
                txtMoTaCongViec.Text = selectRow.Cells[2].Value.ToString();
                txtMaKinhNghiem.Text = selectRow.Cells[3].Value.ToString();
            }
        }
        private void btnSuaKinhNghiem_Click(object sender, EventArgs e)
        {
            KinhNghiemLamViec current = new KinhNghiemLamViec(int.Parse(txtMaKinhNghiem.Text),int.Parse(txtMaUngVien.Text), DateTime.Parse(dtThoiGianBatDau.Text), DateTime.Parse(dtThoiGianKetThuc.Text), txtMoTaCongViec.Text);         
            if (kinhNghiemLamViecController.Edit(current))
            {
                dsKinhNghiemLamViec.Clear();
                dgKinhNghiemLamViec.Rows.Clear();
                dsKinhNghiemLamViec = kinhNghiemLamViecController.Load(txtMaUngVien.Text);
                foreach (KinhNghiemLamViec knlv in dsKinhNghiemLamViec)
                {
                    string[] row = {
                    knlv.GetThoiGianBatDau().ToString("MM/dd/yyyy"),
                    knlv.GetThoiGianKetThuc().ToString("MM/dd/yyyy"),
                    knlv.GetMoTa(),
                    knlv.GetMaKinhNghiem().ToString()
                };
                    dgKinhNghiemLamViec.Rows.Add(row);
                }
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!");
            }
        }

        private void btnThemKNLV_Click(object sender, EventArgs e)
        {
            KinhNghiemLamViec current = new KinhNghiemLamViec(int.Parse(txtMaUngVien.Text), DateTime.Parse(dtThoiGianBatDau.Text), DateTime.Parse(dtThoiGianKetThuc.Text), txtMoTaCongViec.Text);
            if (kinhNghiemLamViecController.Add(current))
            {
                dsKinhNghiemLamViec.Clear();
                dgKinhNghiemLamViec.Rows.Clear();
                dsKinhNghiemLamViec = kinhNghiemLamViecController.Load(txtMaUngVien.Text);
                foreach (KinhNghiemLamViec knlv in dsKinhNghiemLamViec)
                {
                    string[] row = {
                    knlv.GetThoiGianBatDau().ToString("MM/dd/yyyy"),
                    knlv.GetThoiGianKetThuc().ToString("MM/dd/yyyy"),
                    knlv.GetMoTa(),
                    knlv.GetMaKinhNghiem().ToString()
                };
                    dgKinhNghiemLamViec.Rows.Add(row);
                }
                MessageBox.Show("Thêm thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo!");
            }
        }

        private void dgDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgDuAn.Rows[e.RowIndex];
                txtTenDuAn.Text = selectRow.Cells[0].Value.ToString();
                txtMoTaDuAn.Text = selectRow.Cells[1].Value.ToString();
                txtMaDuAn.Text = selectRow.Cells[2].Value.ToString();
            }
        }

        private void btnSuaDuAn_Click(object sender, EventArgs e)
        {
            DuAn current = new DuAn(int.Parse(txtMaDuAn.Text),int.Parse(txtMaUngVien.Text),txtTenDuAn.Text, txtMoTaDuAn.Text);
            if (duAnController.Edit(current))
            {
                dsDuAn.Clear();
                dgDuAn.Rows.Clear();
                dsDuAn = duAnController.Load(txtMaUngVien.Text);
                foreach (DuAn duan in dsDuAn)
                {
                    string[] row = {
                    duan.GetTenDuAn().ToString(),
                    duan.GetMoTaDuAn().ToString(),
                    duan.GetMaDuAn().ToString()
                };
                    dgDuAn.Rows.Add(row);
                }
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!");
            }
        }

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            DuAn current = new DuAn(int.Parse(txtMaUngVien.Text), txtTenDuAn.Text, txtMoTaDuAn.Text);
            if (duAnController.Add(current))
            {
                dsDuAn.Clear();
                dgDuAn.Rows.Clear();
                dsDuAn = duAnController.Load(txtMaUngVien.Text);
                foreach (DuAn duan in dsDuAn)
                {
                    string[] row = {
                    duan.GetTenDuAn().ToString(),
                    duan.GetMoTaDuAn().ToString(),
                    duan.GetMaDuAn().ToString()
                };
                    dgDuAn.Rows.Add(row);
                }
                MessageBox.Show("Thêm thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo!");
            }
        }

        private void btnSuaKyNang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKyNang.Text))
            {
                KyNang current = new KyNang(int.Parse(txtMaKyNang.Text), int.Parse(txtMaUngVien.Text), txtTenKyNang.Text, txtMoTaKyNang.Text);
                if (kyNangController.Edit(current))
                {
                    dsKyNang.Clear();
                    dgKyNang.Rows.Clear();
                    dsKyNang = kyNangController.Load(txtMaUngVien.Text);
                    foreach (KyNang kynang in dsKyNang)
                    {
                        string[] row = {
                    kynang.GetTenKyNang().ToString(),
                    kynang.GetMoTaKyNang().ToString(),
                    kynang.GetMaKyNang().ToString()
                };
                        dgKyNang.Rows.Add(row);
                    }
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn sửa","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnThemKyNang_Click(object sender, EventArgs e)
        {
            KyNang current = new KyNang(int.Parse(txtMaUngVien.Text), txtTenKyNang.Text, txtMoTaKyNang.Text);
            if (kyNangController.Add(current))
            {
                dsKyNang.Clear();
                dgKyNang.Rows.Clear();
                dsKyNang = kyNangController.Load(txtMaUngVien.Text);
                foreach (KyNang kynang in dsKyNang)
                {
                    string[] row = {
                    kynang.GetTenKyNang().ToString(),
                    kynang.GetMoTaKyNang().ToString(),
                    kynang.GetMaKyNang().ToString()
                };
                    dgKyNang.Rows.Add(row);
                }
                MessageBox.Show("Thêm thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo!");
            }
        }

        private void dgKyNang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgKyNang.Rows[e.RowIndex];
                txtTenKyNang.Text = selectRow.Cells[0].Value.ToString();
                txtMoTaKyNang.Text = selectRow.Cells[1].Value.ToString();
                txtMaKyNang.Text = selectRow.Cells[2].Value.ToString();
            }
        }


        private void txtCV_Click(object sender, EventArgs e)
        {
            dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
            foreach (HoSoUngVien hoSoUngVien in dsHoSoUngVien)
            {

                /* int.Parse(txtMaUngVien.Text);*/
                int maUngVien = tileMaSoUngVien.TileCount;
                int maNguoiDung = int.Parse(hoSoUngVien.GetMaNguoiDung().ToString());
                string mucTieuNgheNghiep = hoSoUngVien.GetMucTieuNgheNghiep();
                currentHoSo = new HoSoUngVien(maUngVien, maNguoiDung, mucTieuNgheNghiep);
                
               
            }
            Frm_CV f = new Frm_CV(currentHoSo);
            f.ShowDialog();
            this.Close();
        }

        private void btnSuaHocVan_Click(object sender, EventArgs e)
        {
            HocVan current = new HocVan(int.Parse(txtMaHocVan.Text), int.Parse(txtMaUngVien.Text), txtTrinhDo.Text, txtNganhHoc.Text, txtTruongHoc.Text);
            if (hocVanController.Edit(current))
            {
                dsHocVan.Clear();
                dgHocVan.Rows.Clear();
                dsHocVan = hocVanController.Load(txtMaUngVien.Text);
                foreach (HocVan hocvan in dsHocVan)
                {
                    string[] row = {
                    hocvan.GetTrinhDo().ToString(),
                    hocvan.GetNganhHoc().ToString(),
                    hocvan.GetTruongHoc().ToString(),
                    hocvan.GetMaHocVan().ToString()
                };
                    dgHocVan.Rows.Add(row);
                }
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!");
            }
        }

        private void btnThemHocVan_Click(object sender, EventArgs e)
        {
            HocVan current = new HocVan(int.Parse(txtMaUngVien.Text), txtTrinhDo.Text, txtNganhHoc.Text, txtTruongHoc.Text);
            if (hocVanController.Add(current))
            {
                dsHocVan.Clear();
                dgHocVan.Rows.Clear();
                dsHocVan = hocVanController.Load(txtMaUngVien.Text);
                foreach (HocVan hocvan in dsHocVan)
                {
                    string[] row = {
                    hocvan.GetTrinhDo().ToString(),
                    hocvan.GetNganhHoc().ToString(),
                    hocvan.GetTruongHoc().ToString(),
                    hocvan.GetMaHocVan().ToString()
                };
                    dgHocVan.Rows.Add(row);
                }
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!");
            }
        }

        private void dgHocVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgHocVan.Rows[e.RowIndex];
                txtTrinhDo.Text = selectRow.Cells[0].Value.ToString();
                txtNganhHoc.Text = selectRow.Cells[1].Value.ToString();
                txtTruongHoc.Text = selectRow.Cells[2].Value.ToString();
                txtMaHocVan.Text = selectRow.Cells[3].Value.ToString();
            }
        }

        // chọn mã ứng viên ngẫu nhiên 7 ký tự
        public static string GenerateMaUngVien()
        {
            // Sử dụng Guid để tạo một chuỗi duy nhất ngẫu nhiên
            Guid guid = Guid.NewGuid();

            // Chuyển Guid thành chuỗi và chỉ lấy các chữ số
            string maUngVien = new string(guid.ToString().Where(char.IsDigit).ToArray());

            // Giới hạn độ dài của mã ứng viên từ 1 đến 8 ký tự
            maUngVien = maUngVien.Substring(0, Math.Min(maUngVien.Length, 7));

            return maUngVien;
        }
        private void LoadImageFromDatabase()
        {
            string imagePath = nguoiDungController.LayDuongDanAnhHoSo(int.Parse(txtMaNguoiDung.Text));
            if (!string.IsNullOrEmpty(imagePath))
            {
                pc_AnhNguoiDung.SizeMode = PictureBoxSizeMode.Zoom;
                // Hiển thị hình ảnh
                pc_AnhNguoiDung.Image = Image.FromFile(imagePath);
            }
        }

        private void btnXoaKNLV_Click(object sender, EventArgs e)
        {
            if (kinhNghiemLamViecController.Delete(txtMaKinhNghiem.Text))
            {
                dsKinhNghiemLamViec.Clear();
                dgKinhNghiemLamViec.Rows.Clear();
                dsKinhNghiemLamViec = kinhNghiemLamViecController.Load(txtMaUngVien.Text);
                foreach (KinhNghiemLamViec knlv in dsKinhNghiemLamViec)
                {
                    string[] row = {
                    knlv.GetThoiGianBatDau().ToString("MM/dd/yyyy"),
                    knlv.GetThoiGianKetThuc().ToString("MM/dd/yyyy"),
                    knlv.GetMoTa(),
                    knlv.GetMaKinhNghiem().ToString()
                };
                    dgKinhNghiemLamViec.Rows.Add(row);
                }
                MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDuAn_Click(object sender, EventArgs e)
        {
            if (duAnController.Delete(txtMaDuAn.Text))
            {
                dsDuAn.Clear();
                dgDuAn.Rows.Clear();
                dsDuAn = duAnController.Load(txtMaUngVien.Text);
                foreach (DuAn duan in dsDuAn)
                {
                    string[] row = {
                    duan.GetTenDuAn().ToString(),
                    duan.GetMoTaDuAn().ToString(),
                    duan.GetMaDuAn().ToString()
                };
                    dgDuAn.Rows.Add(row);
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHocVan_Click(object sender, EventArgs e)
        {
            if (hocVanController.Delete(txtMaHocVan.Text))
            {
                dsHocVan.Clear();
                dgHocVan.Rows.Clear();
                dsHocVan = hocVanController.Load(txtMaUngVien.Text);
                foreach (HocVan hocvan in dsHocVan)
                {
                    string[] row = {
                    hocvan.GetTrinhDo().ToString(),
                    hocvan.GetNganhHoc().ToString(),
                    hocvan.GetTruongHoc().ToString(),
                    hocvan.GetMaHocVan().ToString()
                };
                    dgHocVan.Rows.Add(row);
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKyNang_Click(object sender, EventArgs e)
        {
            if (kyNangController.Delete(txtMaKyNang.Text))
            {
                dsKyNang.Clear();
                dgKyNang.Rows.Clear();
                dsKyNang = kyNangController.Load(txtMaUngVien.Text);
                foreach (KyNang kynang in dsKyNang)
                {
                    string[] row = {
                    kynang.GetTenKyNang().ToString(),
                    kynang.GetMoTaKyNang().ToString(),
                    kynang.GetMaKyNang().ToString()
                };
                    dgKyNang.Rows.Add(row);
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
