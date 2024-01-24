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
    internal class HoSoUngVienController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<HoSoUngVien> HoSoUngVienList;
        public HoSoUngVienController()
        {
            HoSoUngVienList = new List<HoSoUngVien>();
        }
        public List<HoSoUngVien> LoadAll()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from HoSoUngVien", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    int maNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                    String mucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();

                    HoSoUngVien hosoungvien = new HoSoUngVien(maUngVien, maNguoiDung, mucTieuNgheNghiep);
                    HoSoUngVienList.Add(hosoungvien);

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
            return HoSoUngVienList; //tra ve danh gom cac kho co trong csdl
        }
        public List<HoSoUngVien> Load(string MaNguoiDung)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from HoSoUngVien Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", MaNguoiDung);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    int maNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                    String mucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();

                    HoSoUngVien hosoungvien = new HoSoUngVien(maUngVien,maNguoiDung,mucTieuNgheNghiep);
                    HoSoUngVienList.Add(hosoungvien);

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
            return HoSoUngVienList; //tra ve danh gom cac kho co trong csdl
        }
        public bool Edit(HoSoUngVien hosoungvien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update HoSoUngVien set MucTieuNgheNghiep=@MucTieuNgheNghiep Where MaNguoiDung=@MaNguoiDung", conn);
                cmd.Parameters.AddWithValue("@MucTieuNgheNghiep", hosoungvien.GetMucTieuNgheNghiep());
                cmd.Parameters.AddWithValue("@MaNguoiDung", hosoungvien.GetMaNguoiDung());
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
        public bool Add(HoSoUngVien hosoungvien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into HoSoUngVien(MaUngVien,MaNguoiDung,MucTieuNgheNghiep)values(@MaUngVien,@MaNguoiDung,@MucTieuNgheNghiep)", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", hosoungvien.GetMaUngVien());
                cmd.Parameters.AddWithValue("@MaNguoiDung", hosoungvien.GetMaNguoiDung());
                cmd.Parameters.AddWithValue("@MucTieuNgheNghiep", hosoungvien.GetMucTieuNgheNghiep());
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
        public List<HoSoUngVien> LoadMaUngVien(string MaUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from HoSoUngVien Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", MaUngVien);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    int maNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                    String mucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();

                    HoSoUngVien hosoungvien = new HoSoUngVien(maUngVien, maNguoiDung, mucTieuNgheNghiep);
                    HoSoUngVienList.Add(hosoungvien);

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
            return HoSoUngVienList; //tra ve danh gom cac kho co trong csdl
        }
        // xóa 
        public bool Delete(string maUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from HoSoUngVien Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", maUngVien);
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
    }
}
