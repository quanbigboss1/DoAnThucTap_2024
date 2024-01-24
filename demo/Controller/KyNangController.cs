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
    internal class KyNangController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<KyNang> kyNangList;
        public KyNangController()
        {
            kyNangList = new List<KyNang>();
        }
        public List<KyNang> Load(string MaUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KyNang Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", MaUngVien);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    int maKyNang = int.Parse(reader["MaKyNang"].ToString());
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    string tenKyNang = reader["TenKyNang"].ToString();
                    string moTaKyNang = reader["MoTaKyNang"].ToString();

                    KyNang kynang = new KyNang(maKyNang,maUngVien,tenKyNang,moTaKyNang);
                    kyNangList.Add(kynang);
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
            return kyNangList; //tra ve danh gom cac kho co trong csdl
        }
        public bool Add(KyNang kynang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into KyNang(MaUngVien,TenKyNang,MoTaKyNang)Values(@MaUngVien,@TenKyNang,@MoTaKyNang)", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", kynang.GetMaUngVien());
                cmd.Parameters.AddWithValue("@TenKyNang", kynang.GetTenKyNang());
                cmd.Parameters.AddWithValue("@MoTaKyNang", kynang.GetMoTaKyNang());
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
        public bool Edit(KyNang kynang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update KyNang Set TenKyNang=@TenKyNang,MoTaKyNang=@MoTaKyNang where MaKyNang=@MaKyNang", conn);
                cmd.Parameters.AddWithValue("@TenKyNang", kynang.GetTenKyNang());
                cmd.Parameters.AddWithValue("@MoTaKyNang", kynang.GetMoTaKyNang());
                cmd.Parameters.AddWithValue("@MaKyNang", kynang.GetMaKyNang());
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
        public bool Delete(string maKyNang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from KyNang where MaKyNang=@MaKyNang", conn);
                cmd.Parameters.AddWithValue("@MaKyNang", maKyNang);
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
