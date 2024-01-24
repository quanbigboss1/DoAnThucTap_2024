using CsvHelper;
using CsvHelper.Configuration;
using demo.Controller;
using demo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace demo.View
{
    public partial class Frm_Test : Form
    {
        /*ViTriCongViecController viTriCongViecController;
        List<ViTriCongViec> dsViTriCongViec;
        ViTriCongViec currentCongViec;*/

        public Frm_Test()
        {
            InitializeComponent();
            /*viTriCongViecController = new ViTriCongViecController();
            currentCongViec = new ViTriCongViec();
            dsViTriCongViec = viTriCongViecController.LoadAll();*/
        }

        private void btnSaveToCsv_Click(object sender, EventArgs e)
        {
           /* List<ViTriCongViecDto> dtos = ConvertToDto(dsViTriCongViec);

            // Lưu danh sách công việc vào file CSV
            SaveToCsv(dtos, @"C:\Users\hongh\OneDrive\Desktop\Tài liệu học năm 4\datasets.csv");*/
        }

        private List<ViTriCongViecDto> ConvertToDto(List<ViTriCongViec> data)
        {
            List<ViTriCongViecDto> dtos = new List<ViTriCongViecDto>();

            foreach (var item in data)
            {
                ViTriCongViecDto dto = new ViTriCongViecDto
                {
                    MaViTri = item.GetMaViTri(),
                    MaCongTy = item.GetMaCongTy(),
                    TenViTri = item.GetTenViTri(),
                    MoTaCongViec = item.GetMoTaCongViec(),
                    YeuCauCongViec = item.GetYeuCauCongViec(),
                    MucLuong = item.GetMucLuong(),
                    KinhNghiem = item.GetKinhNghiem(),
                    DiaDiemLamViec = item.GetDiaDiemLamViec(),
                    NgayTao = item.GetNgayTao()
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        private void SaveToCsv(List<ViTriCongViecDto> data, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream, new UTF8Encoding(true)))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ViTriCongViecDtoMap>();
                csv.WriteRecords(data);
            }
        }


    }

    public class ViTriCongViecDtoMap : ClassMap<ViTriCongViecDto>
    {
        public ViTriCongViecDtoMap()
        {
            Map(m => m.MaViTri).Name("MaViTri");
            Map(m => m.MaCongTy).Name("MaCongTy");
            Map(m => m.TenViTri).Name("TenViTri");
            Map(m => m.MoTaCongViec).Name("MoTaCongViec");
            Map(m => m.YeuCauCongViec).Name("YeuCauCongViec");
            Map(m => m.MucLuong).Name("MucLuong");
            Map(m => m.KinhNghiem).Name("KinhNghiem");
            Map(m => m.DiaDiemLamViec).Name("DiaDiemLamViec");
            Map(m => m.NgayTao).Name("NgayTao");
        }
    }

    public class ViTriCongViecDto
    {
        public int MaViTri { get; set; }
        public int MaCongTy { get; set; }
        public string TenViTri { get; set; }
        public string MoTaCongViec { get; set; }
        public string YeuCauCongViec { get; set; }
        public string MucLuong { get; set; }
        public string KinhNghiem { get; set; }
        public string DiaDiemLamViec { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
