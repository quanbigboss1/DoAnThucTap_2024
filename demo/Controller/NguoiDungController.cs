using demo.Model;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Controller
{
    public class NguoiDungController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<NguoiDung> nguoiDungList;
        public NguoiDungController()
        {
            nguoiDungList = new List<NguoiDung>();
        }
        // Kiểm tra tài khoản và mật khẩu của người dùng đăng nhập
        public List<NguoiDung> CheckLogin(NguoiDung nguoidung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from NguoiDung Where TenDangNhap=@TenDangNhap and MatKhau=@MatKhau", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", nguoidung.GetTenDangNhap());
                cmd.Parameters.AddWithValue("@MatKhau", nguoidung.GetMatKhau());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int maNguoiDung = Convert.ToInt32(reader["MaNguoiDung"].ToString());
                    string tenDangNhap = reader["TenDangNhap"].ToString();
                    string matKhau = reader["MatKhau"].ToString();
                    string email = reader["Email"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string diaChi = reader["DiaChi"].ToString();
                    string soDienThoai = reader["SoDienThoai"].ToString();
                    string hinhAnhHoSo = reader["HinhAnhHoSo"].ToString();
                    string viTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string loaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    NguoiDung nguoidung1 = new NguoiDung(maNguoiDung,tenDangNhap,matKhau,email,hoTen,diaChi,soDienThoai,hinhAnhHoSo,viTriMongMuon,loaiNguoiDung);
                    nguoiDungList.Add(nguoidung1);
                    return nguoiDungList;
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        // Load tất cả người dùng
        public List<NguoiDung> Load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NguoiDung", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                    string username = reader["TenDangNhap"].ToString();
                    string password = reader["MatKhau"].ToString();
                    string Email = reader["Email"].ToString();
                    string HoTen = reader["HoTen"].ToString();
                    string DiaChi = reader["DiaChi"].ToString();
                    string SoDienThoai = reader["SoDienThoai"].ToString();
                    string HinhAnhHoSo = reader["HinhAnhHoSo"].ToString();
                    string ViTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string LoaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    NguoiDung nguoidung = new NguoiDung(maNguoiDung,username,password,Email,HoTen,DiaChi,SoDienThoai,HinhAnhHoSo,ViTriMongMuon,LoaiNguoiDung);
                    nguoiDungList.Add(nguoidung);

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
            return nguoiDungList;
        }
        // Đổi mật khẩu của người dùng
        public bool DoiMatKhau(NguoiDung nguoidung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update NguoiDung Set MatKhau=@MatKhau Where TenDangNhap=@TenDangNhap", conn);
                cmd.Parameters.AddWithValue("@MatKhau", nguoidung.GetMatKhau());
                cmd.Parameters.AddWithValue("@TenDangNhap", nguoidung.GetTenDangNhap());
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
        // Chỉnh sửa thông tin người dùng
        public bool Edit(NguoiDung nguoidung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NguoiDung SET Email=@Email, HoTen=@HoTen, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, ViTriMongMuon=@ViTriMongMuon WHERE MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@Email", nguoidung.Getmail());
                cmd.Parameters.AddWithValue("@HoTen", nguoidung.GetHoTen());
                cmd.Parameters.AddWithValue("@DiaChi", nguoidung.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", nguoidung.GetSDT());
                cmd.Parameters.AddWithValue("@ViTriMongMuon", nguoidung.GetViTriMongMuon());
                cmd.Parameters.AddWithValue("@MaNguoiDung", nguoidung.GetMaNguoiDung());

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
                // Ghi lỗi vào log hoặc xử lý nó tùy vào yêu cầu của bạn
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        // Kiểm tra tài khoản người dùng
        public bool CheckTaiKhoan(string username)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from NguoiDung WHERE TenDangNhap=@TenDangNhap", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
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
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        // Đăng ký tài khoản
        public bool DangKyTaiKhoan(string username,string password,string LoaiNguoiDung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into NguoiDung(TenDangNhap,MatKhau,LoaiNguoiDung)Values(@TenDangNhap,@MatKhau,@LoaiNguoiDung)", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", LoaiNguoiDung);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
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
        // Load CV người dùng qua mã người dùng
        public List<NguoiDung> LoadCV(string maNguoiDung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NguoiDung Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["TenDangNhap"].ToString();
                    string password = reader["MatKhau"].ToString();
                    string Email = reader["Email"].ToString();
                    string HoTen = reader["HoTen"].ToString();
                    string DiaChi = reader["DiaChi"].ToString();
                    string SoDienThoai = reader["SoDienThoai"].ToString();
                    string HinhAnhHoSo = reader["HinhAnhHoSo"].ToString();
                    string ViTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string LoaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    NguoiDung nguoidung = new NguoiDung(username, password, Email, HoTen, DiaChi, SoDienThoai, HinhAnhHoSo, ViTriMongMuon, LoaiNguoiDung);
                    nguoiDungList.Add(nguoidung);

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
            return nguoiDungList;
        }
        // lấy thông tin người dùng
        public List<NguoiDung> GetInfoUser(NguoiDung nguoidung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from NguoiDung Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", nguoidung.GetMaNguoiDung());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int maNguoiDung = Convert.ToInt32(reader["MaNguoiDung"].ToString());
                    string tenDangNhap = reader["TenDangNhap"].ToString();
                    string matKhau = reader["MatKhau"].ToString();
                    string email = reader["Email"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string diaChi = reader["DiaChi"].ToString();
                    string soDienThoai = reader["SoDienThoai"].ToString();
                    string hinhAnhHoSo = reader["HinhAnhHoSo"].ToString();
                    string viTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string loaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    NguoiDung nguoidung1 = new NguoiDung(maNguoiDung, tenDangNhap, matKhau, email, hoTen, diaChi, soDienThoai, hinhAnhHoSo, viTriMongMuon, loaiNguoiDung);
                    nguoiDungList.Add(nguoidung1);
                    return nguoiDungList;
                }
                else
                {
                    return null;
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
            return null;
        }
        // Thêm ảnh hồ sơ của người dùng
        public bool ThemAnhHoSo(int maNguoiDung, string hinhanhhoso)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update NguoiDung set HinhAnhHoSo=@HinhAnhHoSo where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.Parameters.AddWithValue("@HinhAnhHoSo", hinhanhhoso);

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
        // Lấy đường dẫn ảnh hồ sơ
        public string LayDuongDanAnhHoSo(int maNguoiDung)
        {
            string duongDan = null;

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT HinhAnhHoSo FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung;", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

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
        // Thêm người dùng mới:
        public bool Add_User(NguoiDung nguoidung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into NguoiDung(TenDangNhap,MatKhau,Email,HoTen,DiaChi,SoDienThoai,ViTriMongMuon,LoaiNguoiDung)Values(@TenDangNhap,@MatKhau,@Email,@HoTen,@DiaChi,@SoDienThoai,@ViTriMongMuon,@LoaiNguoiDung)", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", nguoidung.GetTenDangNhap());
                cmd.Parameters.AddWithValue("@MatKhau", nguoidung.GetMatKhau());
                cmd.Parameters.AddWithValue("@Email", nguoidung.Getmail());
                cmd.Parameters.AddWithValue("@HoTen", nguoidung.GetHoTen());
                cmd.Parameters.AddWithValue("@DiaChi", nguoidung.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", nguoidung.GetSDT());
                cmd.Parameters.AddWithValue("@ViTriMongMuon", nguoidung.GetViTriMongMuon());
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", nguoidung.GetLoaiNguoiDung());
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
        // Chỉnh sửa thông tin người dùng
        public bool Edit_User(NguoiDung nguoidung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update NguoiDung set TenDangNhap=@TenDangNhap,MatKhau=@MatKhau,Email=@Email,HoTen=@HoTen,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,HinhAnhHoSo=@HinhAnhHoSo,ViTriMongMuon=@ViTriMongMuon,LoaiNguoiDung=@LoaiNguoiDung where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", nguoidung.GetTenDangNhap());
                cmd.Parameters.AddWithValue("@MatKhau", nguoidung.GetMatKhau());
                cmd.Parameters.AddWithValue("@Email", nguoidung.Getmail());
                cmd.Parameters.AddWithValue("@HoTen", nguoidung.GetHoTen());
                cmd.Parameters.AddWithValue("@DiaChi", nguoidung.GetDiaChi());
                cmd.Parameters.AddWithValue("@SoDienThoai", nguoidung.GetSDT());
                cmd.Parameters.AddWithValue("@HinhAnhHoSo", nguoidung.GetHinhAnhHoSo());
                cmd.Parameters.AddWithValue("@ViTriMongMuon", nguoidung.GetViTriMongMuon());
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", nguoidung.GetLoaiNguoiDung());
                cmd.Parameters.AddWithValue("@MaNguoiDung", nguoidung.GetMaNguoiDung());
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
        public bool Delete_User(NguoiDung nguoidung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from NguoiDung Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", nguoidung.GetMaNguoiDung());
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
        // Tìm tên người dùng
        public List<NguoiDung> Find(string tenNguoiDung)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NguoiDung Where HoTen like @HoTen", conn);
                cmd.Parameters.AddWithValue("@HoTen", "%" + tenNguoiDung + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                    string username = reader["TenDangNhap"].ToString();
                    string password = reader["MatKhau"].ToString();
                    string Email = reader["Email"].ToString();
                    string HoTen = reader["HoTen"].ToString();
                    string DiaChi = reader["DiaChi"].ToString();
                    string SoDienThoai = reader["SoDienThoai"].ToString();
                    string HinhAnhHoSo = reader["HinhAnhHoSo"].ToString();
                    string ViTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string LoaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    NguoiDung nguoidung = new NguoiDung(maNguoiDung, username, password, Email, HoTen, DiaChi, SoDienThoai, HinhAnhHoSo, ViTriMongMuon, LoaiNguoiDung);
                    nguoiDungList.Add(nguoidung);
                }
                return nguoiDungList;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return nguoiDungList;
        }
    }
}
