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
    
    internal class CongTyController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<CongTy> congtyList;
        List<CongTy> congtyList2;
        public CongTyController()
        {
            congtyList = new List<CongTy>();
            congtyList2 = new List<CongTy>();
        }
        public List<CongTy> Load()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CongTy", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString() ;
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(maCongTy,manguoidung,tencongty,motacongty,diachi,sodienthoai,emaillienhe,logoUrl);
                    congtyList.Add(congty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            return congtyList; //tra ve danh gom cac kho co trong csdl
        }
        public List<CongTy> ThongTinCongTy(string maCongTy)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CongTy Where MaCongTy=@MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(manguoidung, tencongty, motacongty, diachi, sodienthoai, emaillienhe, logoUrl);
                    congtyList.Add(congty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            return congtyList; //tra ve danh gom cac kho co trong csdl
        }
        public List<CongTy> TimKiemCongTy(string tenCongTy, string diaChi)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            List<CongTy> congtyList = new List<CongTy>();

            try
            {
                conn.Open();
                // Thay đổi câu truy vấn để có thể tìm kiếm theo cả tên công ty và địa chỉ
                SqlCommand cmd = new SqlCommand("SELECT * FROM CongTy WHERE TenCongTy LIKE @TenCongTy AND DiaChi LIKE @DiaChi", conn);
                cmd.Parameters.AddWithValue("@TenCongTy", "%" + tenCongTy + "%");
                cmd.Parameters.AddWithValue("@DiaChi", "%" + diaChi + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int macongty = int.Parse(reader["MaCongTy"].ToString());
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(macongty, manguoidung, tencongty, motacongty, diachi, sodienthoai, emaillienhe, logoUrl);
                    congtyList.Add(congty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return congtyList;
        }
        public List<CongTy> CongTyInfo(string maNguoiDung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CongTy Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(maCongTy,manguoidung, tencongty, motacongty, diachi, sodienthoai, emaillienhe, logoUrl);
                    congtyList2.Add(congty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            return congtyList2; //tra ve danh gom cac kho co trong csdl
        }
        public bool Edit(CongTy congty)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update CongTy Set TenCongTy=@TenCongTy,MoTaCongTy=@MoTaCongTy,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,EmailLienHe=@EmailLienHe,LogoURL=@LogoURL Where MaNguoiDung=@MaNguoiDung ", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", congty.GetMaNguoiDung());
                cmd.Parameters.AddWithValue("@TenCongTy", congty.GetTenCongTy());
                cmd.Parameters.AddWithValue("@MoTaCongTy", congty.GetMoTaCongTy());
                cmd.Parameters.AddWithValue("@DiaChi", congty.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", congty.GetSoDienThoai());
                cmd.Parameters.AddWithValue("@EmailLienHe", congty.GetEmailLienHe());
                cmd.Parameters.AddWithValue("@LogoURL", congty.GetLogoURL());
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
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; //tra ve danh gom cac kho co trong csdl
        }
        public List<CongTy> LoadRandom()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 6 * FROM CongTy ORDER BY NEWID()", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(maCongTy, manguoidung, tencongty, motacongty, diachi, sodienthoai, emaillienhe, logoUrl);
                    congtyList.Add(congty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            return congtyList; //tra ve danh gom cac kho co trong csdl
        }
        public int SoLuongCVNop(int maCongTy)
        {
            int SoLuongUngVien = 0;
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TinhSoLuongUngVienTheoCongTy", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SoLuongUngVien = Convert.ToInt32(reader["SoLuongUngVien"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return SoLuongUngVien;
        }
        public bool Add(CongTy congty)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into CongTy(MaCongTy,MaNguoiDung)values(@MaCongTy,@MaNguoiDung) ", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", congty.GetMaCongTy());
                cmd.Parameters.AddWithValue("@MaNguoiDung", congty.GetMaNguoiDung());
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
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; //tra ve danh gom cac kho co trong csdl
        }
        //
        public bool ThemAnhHoSo(int maCongTy, string logo)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update CongTy set LogoUrl=@LogoUrl where MaCongTy=@MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                cmd.Parameters.AddWithValue("@LogoUrl", logo);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
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
                // Ghi lỗi vào log hoặc xử lý nó tùy vào yêu cầu của bạn
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        ///
        public string LayDuongDanAnhHoSo(int maCongTy)
        {
            string duongDan = null;

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT LogoUrl FROM CongTy WHERE MaCongTy = @MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);

                // Thực hiện truy vấn để lấy đường dẫn hình ảnh
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    duongDan = result.ToString();
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi tùy theo yêu cầu
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return duongDan;
        }
        // Thêm công ty :
        public bool AddCongTy(CongTy congty)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CongTy(MaCongTy,MaNguoiDung, TenCongTy, MoTaCongTy, DiaChi, SoDienThoai, EmailLienHe) VALUES (@MaCongTy,@MaNguoiDung, @TenCongTy, @MoTaCongTy, @DiaChi, @SoDienThoai, @EmailLienHe)", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", congty.GetMaCongTy());
                cmd.Parameters.AddWithValue("@MaNguoiDung", congty.GetMaNguoiDung());
                cmd.Parameters.AddWithValue("@TenCongTy", congty.GetTenCongTy());
                cmd.Parameters.AddWithValue("@MoTaCongTy", congty.GetMoTaCongTy());
                cmd.Parameters.AddWithValue("@DiaChi", congty.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", congty.GetSoDienThoai());
                cmd.Parameters.AddWithValue("@EmailLienHe", congty.GetEmailLienHe());

                int rowAffected = cmd.ExecuteNonQuery();
                if(rowAffected > 0)
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
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; // Trả về danh sách các công ty có trong CSDL
        }
        // Chỉnh sửa thông tin công ty :
        public bool EditCongTy(CongTy congty)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update CongTy Set MaNguoiDung=@MaNguoiDung, TenCongTy=@TenCongTy, MoTaCongTy=@MoTaCongTy, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, EmailLienHe=@EmailLienHe where MaCongTy=@MaCongTy", conn);

                cmd.Parameters.AddWithValue("@MaNguoiDung", congty.GetMaNguoiDung());
                cmd.Parameters.AddWithValue("@TenCongTy", congty.GetTenCongTy());
                cmd.Parameters.AddWithValue("@MoTaCongTy", congty.GetMoTaCongTy());
                cmd.Parameters.AddWithValue("@DiaChi", congty.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", congty.GetSoDienThoai());
                cmd.Parameters.AddWithValue("@EmailLienHe", congty.GetEmailLienHe());
                cmd.Parameters.AddWithValue("@MaCongTy", congty.GetMaCongTy());

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
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
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; // Trả về danh sách các công ty có trong CSDL
        }
        // Xóa thông tin công ty :
        public bool DeleteCongTy(CongTy congty)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from CongTy where MaCongTy=@MaCongTy", conn);
                cmd.Parameters.AddWithValue("@MaCongTy", congty.GetMaCongTy());

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
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
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; // Trả về danh sách các công ty có trong CSDL
        }
        // Tìm kiếm theo tên công ty
        public List<CongTy> Find(string tenCongTy)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CongTy Where TenCongTy Like @TenCongTy", conn);
                cmd.Parameters.AddWithValue("@TenCongTy", "%" + tenCongTy + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maCongTy = int.Parse(reader["MaCongTy"].ToString());
                    int manguoidung = int.Parse(reader["MaNguoiDung"].ToString());
                    string tencongty = reader["TenCongTy"].ToString();
                    string motacongty = reader["MoTaCongTy"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string sodienthoai = reader["SoDienThoai"].ToString();
                    string emaillienhe = reader["EmailLienHe"].ToString();
                    string logoUrl = reader["LogoURL"].ToString();
                    CongTy congty = new CongTy(maCongTy, manguoidung, tencongty, motacongty, diachi, sodienthoai, emaillienhe, logoUrl);
                    congtyList.Add(congty);
                }
                return congtyList;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return congtyList;
        }
    }
}
