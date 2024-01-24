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
    internal partial class Frm_CV : MetroSetForm
    {
        HoSoUngVienController hoSoUngVienController;
        KinhNghiemLamViecController kinhNghiemLamViecController;
        DuAnController duAnController;
        KyNangController kyNangController;
        NguoiDungController nguoiDungController;
        HocVanController hocVanController;
        List<KyNang> dsKyNang;
        List<KinhNghiemLamViec> dsKinhNghiemLamViec;
        List<HoSoUngVien> dsHoSoUngVien;
        List<DuAn> dsDuAn;
        List<NguoiDung> dsNguoiDung;
        List<HocVan> dsHocVan;
        public Frm_CV(HoSoUngVien hosoungvien)
        {
            InitializeComponent();
            hoSoUngVienController = new HoSoUngVienController();
            dsHoSoUngVien = new List<HoSoUngVien>();
            kinhNghiemLamViecController = new KinhNghiemLamViecController();
            dsKinhNghiemLamViec = new List<KinhNghiemLamViec>();
            duAnController = new DuAnController();
            kyNangController = new KyNangController();
            hocVanController = new HocVanController();
            dsHocVan = new List<HocVan>();
            dsKyNang = new List<KyNang>();
            dsDuAn = new List<DuAn>();
            nguoiDungController = new NguoiDungController();
            dsNguoiDung = new List<NguoiDung>();
            dsNguoiDung = nguoiDungController.LoadCV(hosoungvien.GetMaNguoiDung().ToString());
            LoadImageFromDatabase(hosoungvien.GetMaNguoiDung());
            //
            foreach (NguoiDung nguoidung in dsNguoiDung)
            {
                lbHoTen.Text = nguoidung.GetHoTen();
                txtDiaChi.Text = nguoidung.GetDiaChi();
                txtEmail.Text = nguoidung.Getmail();
                txtSoDienThoai.Text = nguoidung.GetSDT();
            }
            lbMucTieuNgheNghiep.Text = hosoungvien.GetMucTieuNgheNghiep().ToString();
            //
            dgKinhNghiem.ColumnCount = 3;
            dgKinhNghiem.Columns[0].Name = "Thời gian bắt đầu";
            dgKinhNghiem.Columns[1].Name = "Thời gian kết thúc";
            dgKinhNghiem.Columns[2].Name = "Mô tả công việc";    
            dsKinhNghiemLamViec = kinhNghiemLamViecController.Load(hosoungvien.GetMaUngVien().ToString());
            foreach (KinhNghiemLamViec knlv in dsKinhNghiemLamViec)
            {
                string[] row = { knlv.GetThoiGianBatDau().ToString("MM/dd/yyyy"), knlv.GetThoiGianKetThuc().ToString("MM/dd/yyyy"), knlv.GetMoTa() };
                dgKinhNghiem.Rows.Add(row);
            }
            //
            dgDuAn.ColumnCount = 2;
            dgDuAn.Columns[0].Name = "Tên dự án";
            dgDuAn.Columns[1].Name = "Mô tả dự án";
            dsDuAn = duAnController.Load(hosoungvien.GetMaUngVien().ToString());
            foreach (DuAn duan in dsDuAn)
            {
                string[] row = { duan.GetTenDuAn(), duan.GetMoTaDuAn() };
                dgDuAn.Rows.Add(row);
            }
            //
            dgKyNang.ColumnCount = 2;
            dgKyNang.Columns[0].Name = "Kỹ năng";
            dgKyNang.Columns[1].Name = "Mô tả kỹ năng";
            dsKyNang = kyNangController.Load(hosoungvien.GetMaUngVien().ToString());
            foreach (KyNang kynang in dsKyNang)
            {
                string[] row = { kynang.GetTenKyNang(), kynang.GetMoTaKyNang() };
                dgKyNang.Rows.Add(row);
            }
            //
            dgHocVan.ColumnCount = 3;
            dgHocVan.Columns[0].Name = "Trình độ";
            dgHocVan.Columns[1].Name = "Ngành học";
            dgHocVan.Columns[2].Name = "Trường học";
            dsHocVan = hocVanController.Load(hosoungvien.GetMaUngVien().ToString());
            foreach (HocVan hocvan in dsHocVan)
            {
                string[] row = { hocvan.GetTrinhDo(), hocvan.GetNganhHoc(), hocvan.GetTruongHoc() };
                dgHocVan.Rows.Add(row);
            }
        }
        private void LoadImageFromDatabase(int MaNguoiDung)
        {
            string imagePath = nguoiDungController.LayDuongDanAnhHoSo(MaNguoiDung);
            if (!string.IsNullOrEmpty(imagePath))
            {
                pc_AnhHoSo.SizeMode = PictureBoxSizeMode.Zoom;
                // Hiển thị hình ảnh
                pc_AnhHoSo.Image = Image.FromFile(imagePath);
            }
        }
    }
}
