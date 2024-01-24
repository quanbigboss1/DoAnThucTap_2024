using demo.Model;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Controller
{
    internal class ViTriCongViecController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<ViTriCongViec> viTriCongViecList;
        List<ViTriCongViec> viTriCongViecListAll;
        List<ViTriCongViec> viTriCongViecListDiaDiem;
        public ViTriCongViecController()
        {
            viTriCongViecList = new List<ViTriCongViec>();
            viTriCongViecListAll = new List<ViTriCongViec>();
            viTriCongViecListDiaDiem = new List<ViTriCongViec>();
        }
        public int GetSoLuong(string MaCongTy)
        {
            int soluong = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ViTriCongViec WHERE MaCongTy=@MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", MaCongTy);
                soluong = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị duy nhất trả về
                return soluong;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1; // Trả về giá trị mặc định hoặc báo lỗi
            }
            finally
            {
                conn.Close();
            }
        }
        public List<ViTriCongViec> LoadAll()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from ViTriCongViec", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return viTriCongViecList; //tra ve danh gom cac kho co trong csdl
        }
        public List<ViTriCongViec> Load(string MaCongTy)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from ViTriCongViec Where MaCongTy=@MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", MaCongTy);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec,yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecListAll.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return viTriCongViecListAll; //tra ve danh gom cac kho co trong csdl
        }
        public bool Add(ViTriCongViec vitricongviec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into ViTriCongViec(MaCongTy,TenViTri,MoTaCongViec,YeuCauCongViec,MucLuong,KinhNghiem,DiaDiemLamViec,NgayTao)Values(@MaCongTy,@TenViTri,@MoTaCongViec,@YeuCauCongViec,@MucLuong,@KinhNghiem,@DiaDiemLamViec,@NgayTao) ", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", vitricongviec.GetMaCongTy());
                cmd.Parameters.AddWithValue("@TenViTri", vitricongviec.GetTenViTri());
                cmd.Parameters.AddWithValue("@MoTaCongViec", vitricongviec.GetMoTaCongViec());
                cmd.Parameters.AddWithValue("@YeuCauCongViec", vitricongviec.GetYeuCauCongViec());
                cmd.Parameters.AddWithValue("@DiaDiemLamViec", vitricongviec.GetDiaDiemLamViec());
                cmd.Parameters.AddWithValue("@KinhNghiem", vitricongviec.GetKinhNghiem());
                cmd.Parameters.AddWithValue("@MucLuong", vitricongviec.GetMucLuong());
                cmd.Parameters.AddWithValue("@NgayTao", vitricongviec.GetNgayTao());
                int rowAffect = cmd.ExecuteNonQuery();
                if(rowAffect > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool Edit(ViTriCongViec vitricongviec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update ViTriCongViec set TenViTri=@TenViTri,MaCongTy=@MaCongTy," +
                    "MoTaCongViec=@MoTaCongViec,YeuCauCongViec=@YeuCauCongViec,DiaDiemLamViec=@DiaDiemLamViec," +
                    "MucLuong=@MucLuong,KinhNghiem=@KinhNghiem,NgayTao=@NgayTao Where MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaViTri", vitricongviec.GetMaViTri());
                cmd.Parameters.AddWithValue("@MaCongTy", vitricongviec.GetMaCongTy());
                cmd.Parameters.AddWithValue("@TenViTri", vitricongviec.GetTenViTri());
                cmd.Parameters.AddWithValue("@MoTaCongViec", vitricongviec.GetMoTaCongViec());
                cmd.Parameters.AddWithValue("@YeuCauCongViec", vitricongviec.GetYeuCauCongViec());
                cmd.Parameters.AddWithValue("@DiaDiemLamViec", vitricongviec.GetDiaDiemLamViec());
                cmd.Parameters.AddWithValue("@KinhNghiem", vitricongviec.GetKinhNghiem());
                cmd.Parameters.AddWithValue("@MucLuong", vitricongviec.GetMucLuong());
                cmd.Parameters.AddWithValue("@NgayTao", vitricongviec.GetNgayTao());
                int rowAffect = cmd.ExecuteNonQuery();
                if (rowAffect > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool Delete(ViTriCongViec vitricongviec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from ViTriCongViec where MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaViTri", vitricongviec.GetMaViTri());
                int rowAffect = cmd.ExecuteNonQuery();
                if (rowAffect > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public List<ViTriCongViec> FindByTenViTriLike(string TenViTri)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViTriCongViec WHERE TenViTri LIKE @TenViTri", conn);
                cmd.Parameters.AddWithValue("@TenViTri", "%" + TenViTri + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return viTriCongViecList; //tra ve danh gom cac kho co trong csdl
        }
        public List<ViTriCongViec> Find3TieuChi(ViTriCongViec vitricongviec,int MinLuong,int MaxLuong)
        {
            List<ViTriCongViec> viTriCongViecList = new List<ViTriCongViec>();

            try
            {
                conn.Open();

                // Câu truy vấn với bốn tiêu chí
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViTriCongViec WHERE TenViTri LIKE @TenViTri AND DiaDiemLamViec LIKE @DiaDiem AND MucLuong BETWEEN @MinMucLuong AND @MaxMucLuong AND KinhNghiem LIKE @KinhNghiem", conn);

                // Thêm các tham số tìm kiếm
                cmd.Parameters.AddWithValue("@TenViTri", "%" + vitricongviec.GetTenViTri() + "%");
                cmd.Parameters.AddWithValue("@DiaDiem", "%" + vitricongviec.GetDiaDiemLamViec() + "%");
                cmd.Parameters.AddWithValue("@MinMucLuong", MinLuong); 
                cmd.Parameters.AddWithValue("@MaxMucLuong", MaxLuong); 
                cmd.Parameters.AddWithValue("@KinhNghiem", "%" + vitricongviec.GetKinhNghiem() + "%");


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return viTriCongViecList;
        }
        public List<ViTriCongViec> TimMucLuong(int a, int b)
        {

            try
            {
                conn.Open();
                // Sử dụng stored procedure
                SqlCommand cmd = new SqlCommand("SearchViTriCongViecByMucLuongRange", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số tìm kiếm
                cmd.Parameters.AddWithValue("@MinMucLuong", a);
                cmd.Parameters.AddWithValue("@MaxMucLuong", b);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return viTriCongViecList;
        }
        public List<ViTriCongViec> TimDiaDiem(string diadiem)
        {

            try
            {
                conn.Open();
                // Sử dụng stored procedure
                SqlCommand cmd = new SqlCommand("Select * from ViTriCongViec where DiaDiemLamViec like @DiaDiemLamViec", conn);
                cmd.Parameters.AddWithValue("@DiaDiemLamViec", "%" + diadiem + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return viTriCongViecList;
        }
        public List<ViTriCongViec> TimKinhNghiem(string kinhnghiem)
        {

            try
            {
                conn.Open();
                // Sử dụng stored procedure
                SqlCommand cmd = new SqlCommand("Select * from ViTriCongViec where KinhNghiem like @KinhNghiem", conn);
                cmd.Parameters.AddWithValue("@KinhNghiem", "%" + kinhnghiem + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return viTriCongViecList;
        }
        public List<ViTriCongViec> LoadCongViecBangViTri(int mavitri)
        {

            try
            {
                conn.Open();
                // Sử dụng stored procedure
                SqlCommand cmd = new SqlCommand("Select * from ViTriCongViec where MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaViTri",mavitri);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return viTriCongViecList;
        }
        public List<ViTriCongViec> DeXuatCongViec(string tenCongViec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from ViTriCongViec where TenViTri=@TenViTri", conn);
                cmd.Parameters.AddWithValue("@TenViTri",tenCongViec);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Code giữ nguyên từ đoạn mã của bạn
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecList.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return viTriCongViecList;
        }
        // Tìm thông tin theo mã vị trí 
        public List<ViTriCongViec> LoadMaViTri(string MaViTri)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from ViTriCongViec Where MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaViTri", MaViTri);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    string tenViTri = reader["TenViTri"].ToString();
                    string moTaCongViec = reader["MoTaCongViec"].ToString();
                    string yeuCauCongViec = reader["YeuCauCongViec"].ToString();
                    string mucLuong = reader["MucLuong"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string diaDiemLamViec = reader["DiaDiemLamViec"].ToString();
                    DateTime ngayTao = DateTime.Parse(reader["NgayTao"].ToString());
                    ViTriCongViec vitri = new ViTriCongViec(maViTri, maCongTy, tenViTri, moTaCongViec, yeuCauCongViec, mucLuong, kinhNghiem, diaDiemLamViec, ngayTao);
                    viTriCongViecListAll.Add(vitri);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return viTriCongViecListAll; //tra ve danh gom cac kho co trong csdl
        }
    }
}
