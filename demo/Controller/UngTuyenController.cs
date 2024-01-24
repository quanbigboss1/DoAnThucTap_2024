using demo.Model;
using demo.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Controller
{
    internal class UngTuyenController
    {
        SqlConnection conn = DatabaseHelper.getConnection();
        List<UngTuyen> dsUngTuyenList;
        public UngTuyenController()
        {
            dsUngTuyenList = new List<UngTuyen>();
        }

        public int GetSoLuongCV_CongTy(string mavitri)
        {
            int soluong = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from UngTuyen where MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaViTri", mavitri);
                soluong = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị duy nhất trả về
                return soluong;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return soluong;
        }
        public int GetSoLuongCV_UngVien(string maungvien)
        {
            int soluong = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from UngTuyen where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", maungvien);
                soluong = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị duy nhất trả về
                return soluong;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return soluong;
        }
        //
        public bool Add(UngTuyen ungtuyen)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into UngTuyen(MaUngVien,MaViTri,NgayUngTuyen)Values(@MaUngVien,@MaViTri,@NgayUngTuyen)", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", ungtuyen.GetMaUngVien());
                cmd.Parameters.AddWithValue("@MaViTri", ungtuyen.GetMaViTri());
                cmd.Parameters.AddWithValue("@NgayUngTuyen", ungtuyen.GetNgayUngTuyen());
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
                Console.WriteLine("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; //tra ve danh gom cac kho co trong csdl
        }
        public bool CheckUngTuyen(UngTuyen ungtuyen)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from UngTuyen Where MaUngVien=@MaUngVien and MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", ungtuyen.GetMaUngVien());
                cmd.Parameters.AddWithValue("@MaViTri", ungtuyen.GetMaViTri());
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
                Console.WriteLine("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; //tra ve danh gom cac kho co trong csdl
        }
        public List<UngTuyen> LoadUngTuyen(int maCongTy)
        {
            List<UngTuyen> dsUngTuyenList = new List<UngTuyen>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("XemDanhSachUngVienTheoCongTy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    string hoTen = reader["HoTen"].ToString();
                    int maViTri = int.Parse(reader["MaViTri"].ToString());
                    string TenViTri = reader["TenViTri"].ToString();
                    DateTime ngayUngTuyen = DateTime.Parse(reader["NgayUngTuyen"].ToString());
                    string trangThaiUngTuyen = reader["TrangThaiUngTuyen"].ToString();       
                    UngTuyen ut = new UngTuyen(maUngVien,hoTen, maViTri,TenViTri, ngayUngTuyen, trangThaiUngTuyen);
                    dsUngTuyenList.Add(ut);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dsUngTuyenList;
        }
        public bool Edit(UngTuyen ungtuyen)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update UngTuyen set TrangThaiUngTuyen=@TrangThaiUngTuyen Where MaUngVien=@MaUngVien and MaViTri=@MaViTri", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", ungtuyen.GetMaUngVien());
                cmd.Parameters.AddWithValue("@MaViTri", ungtuyen.GetMaViTri());
                cmd.Parameters.AddWithValue("@TrangThaiUngTuyen", ungtuyen.GetTrangThaiUngTuyen());
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
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public List<UngTuyen> GetCVDaNop_UngVien(string maungvien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetUngTuyenInfoByMaNguoiDung", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNguoiDung", maungvien);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenvitri = reader["TenViTri"].ToString();
                    string tencongty = reader["TenCongTy"].ToString();
                    DateTime ngayUngTuyen = DateTime.Parse(reader["NgayUngTuyen"].ToString());
                    string tinhtrangungtuyen = reader["TrangThaiUngTuyen"].ToString();
                    UngTuyen ut = new UngTuyen(tenvitri, tencongty, ngayUngTuyen, tinhtrangungtuyen);
                    dsUngTuyenList.Add(ut);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dsUngTuyenList;
        }
        // Xem tất cả ứng tuyển
        public List<UngTuyen> LoadAll()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from UngTuyen",conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maUngTuyen = int.Parse(reader["MaUngTuyen"].ToString());
                    int MaUngVien = int.Parse(reader["MaUngVien"].ToString());
                    int MaViTri = int.Parse(reader["MaViTri"].ToString());
                    DateTime ngayUngTuyen = DateTime.Parse(reader["NgayUngTuyen"].ToString());
                    string tinhtrangungtuyen = reader["TrangThaiUngTuyen"].ToString();
                    UngTuyen ut = new UngTuyen(maUngTuyen,MaUngVien,MaViTri, ngayUngTuyen, tinhtrangungtuyen);
                    dsUngTuyenList.Add(ut);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dsUngTuyenList;
        }
        // xóa ứng tuyển
        public bool Delete(string maUngTuyen)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from UngTuyen where MaUngTuyen=@MaUngTuyen", conn);
                cmd.Parameters.AddWithValue("@MaUngTuyen", maUngTuyen);
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
                Console.WriteLine("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false; //tra ve danh gom cac kho co trong csdl
        }
    }
}
