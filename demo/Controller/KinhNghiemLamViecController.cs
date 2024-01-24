using demo.Model;
using demo.Model.demo.Model;
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
    internal class KinhNghiemLamViecController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<KinhNghiemLamViec> kinhNghiemLamViecList;
        public KinhNghiemLamViecController()
        {
            kinhNghiemLamViecList = new List<KinhNghiemLamViec>();
        }
        public List<KinhNghiemLamViec> Load(string MaUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KinhNghiemLamViec Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", MaUngVien);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maKinhNghiem = int.Parse(reader["MaKinhNghiem"].ToString());
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    // Kiểm tra nếu cột "ThoiGianBatDau" và "ThoiGianKetThuc" có giá trị trước khi chuyển đổi
                    DateTime thoiGianBatDau = Convert.ToDateTime(reader["ThoiGianBatDau"].ToString());
                    DateTime thoiGianKetThuc = Convert.ToDateTime(reader["ThoiGianKetThuc"].ToString());
                    string mota = reader["MoTa"].ToString();

                    KinhNghiemLamViec knlv = new KinhNghiemLamViec(maKinhNghiem, maUngVien, thoiGianBatDau, thoiGianKetThuc,mota);
                    kinhNghiemLamViecList.Add(knlv);

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
            return kinhNghiemLamViecList; //tra ve danh gom cac kho co trong csdl
        }
        public bool Add(KinhNghiemLamViec kinhnghiemlamviec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into KinhNghiemLamViec(MaUngVien,ThoiGianBatDau,ThoiGianKetThuc,MoTa)Values(@MaUngVien,@ThoiGianBatDau,@ThoiGianKetThuc,@MoTa)", conn);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", kinhnghiemlamviec.GetThoiGianBatDau());
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", kinhnghiemlamviec.GetThoiGianKetThuc());
                cmd.Parameters.AddWithValue("@MoTa", kinhnghiemlamviec.GetMoTa());
                cmd.Parameters.AddWithValue("@MaUngVien", kinhnghiemlamviec.GetMaUngVien());
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
        public bool Edit(KinhNghiemLamViec kinhnghiemlamviec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update KinhNghiemLamViec Set ThoiGianBatDau=@ThoiGianBatDau,ThoiGianKetThuc=@ThoiGianKetThuc,MoTa=@MoTa where MaKinhNghiem=@MaKinhNghiem", conn);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", kinhnghiemlamviec.GetThoiGianBatDau());
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", kinhnghiemlamviec.GetThoiGianKetThuc());
                cmd.Parameters.AddWithValue("@MoTa", kinhnghiemlamviec.GetMoTa());
                cmd.Parameters.AddWithValue("@MaKinhNghiem", kinhnghiemlamviec.GetMaKinhNghiem());
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
        //
        public bool Delete(string maKinhNghiem)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from KinhNghiemLamViec where MaKinhNghiem=@MaKinhNghiem", conn);
                cmd.Parameters.AddWithValue("@MaKinhNghiem",maKinhNghiem);
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
