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
    internal class HocVanController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<HocVan> hocVanList;
        public HocVanController()
        {
            hocVanList = new List<HocVan>();
        }
        public List<HocVan> Load(string MaUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from HocVan Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", MaUngVien);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maHocVan = int.Parse(reader["MaHocVan"].ToString());
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    string trinhDo = reader["TrinhDo"].ToString();
                    string nganhHoc = reader["NganhHoc"].ToString();
                    string truongHoc = reader["TruongHoc"].ToString();

                    HocVan hocvan = new HocVan(maHocVan,maUngVien,trinhDo,nganhHoc,truongHoc);
                    hocVanList.Add(hocvan);
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
            return hocVanList; //tra ve danh gom cac kho co trong csdl
        }
        public bool Add(HocVan hocvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into HocVan(MaUngVien,TrinhDo,NganhHoc,TruongHoc)Values(@MaUngVien,@TrinhDo,@NganhHoc,@TruongHoc)", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", hocvan.GetMaUngVien());
                cmd.Parameters.AddWithValue("@TrinhDo", hocvan.GetTrinhDo());
                cmd.Parameters.AddWithValue("@NganhHoc", hocvan.GetNganhHoc());
                cmd.Parameters.AddWithValue("@TruongHoc", hocvan.GetTruongHoc());
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
        public bool Edit(HocVan hocvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update HocVan Set TrinhDo=@TrinhDo,NganhHoc=@NganhHoc,TruongHoc=@TruongHoc where MaHocVan=@MaHocVan", conn);
                cmd.Parameters.AddWithValue("@TrinhDo", hocvan.GetTrinhDo());
                cmd.Parameters.AddWithValue("@NganhHoc", hocvan.GetNganhHoc());
                cmd.Parameters.AddWithValue("@TruongHoc", hocvan.GetTruongHoc());
                cmd.Parameters.AddWithValue("@MaHocVan", hocvan.GetMaHocVan());
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
        //
        public bool Delete(string maHocVan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from HocVan where MaHocVan=@MaHocVan", conn);
                cmd.Parameters.AddWithValue("@MaHocVan",maHocVan);
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
