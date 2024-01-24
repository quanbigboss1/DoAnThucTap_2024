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
    internal class DuAnController
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        SqlConnection conn = DatabaseHelper.getConnection();
        List<DuAn> duAnList;
        public DuAnController()
        {
            duAnList = new List<DuAn>();
        }
        public List<DuAn> Load(string MaUngVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from DuAn Where MaUngVien=@MaUngVien", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", MaUngVien);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maDuAn = int.Parse(reader["MaDuAn"].ToString());
                    int maUngVien = int.Parse(reader["MaUngVien"].ToString());
                    string tenDuAn = reader["TenDuAn"].ToString();
                    string mota = reader["MoTaDuAn"].ToString();

                    DuAn duan = new DuAn(maDuAn,maUngVien,tenDuAn,mota);
                    duAnList.Add(duan);
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
            return duAnList; //tra ve danh gom cac kho co trong csdl
        }
        public bool Add(DuAn duan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into DuAn(MaUngVien,TenDuAn,MoTaDuAn)Values(@MaUngVien,@TenDuAn,@MoTaDuAn)", conn);
                cmd.Parameters.AddWithValue("@MaUngVien", duan.GetMaUngVien());
                cmd.Parameters.AddWithValue("@TenDuAn", duan.GetTenDuAn());
                cmd.Parameters.AddWithValue("@MoTaDuAn", duan.GetMoTaDuAn());
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
        public bool Edit(DuAn duan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update DuAn Set TenDuAn=@TenDuAn,MoTaDuAn=@MoTaDuAn where MaDuAn=@MaDuAn", conn);
                cmd.Parameters.AddWithValue("@TenDuAn", duan.GetTenDuAn());
                cmd.Parameters.AddWithValue("@MoTaDuAn", duan.GetMoTaDuAn());
                cmd.Parameters.AddWithValue("@MaDuAn", duan.GetMaDuAn());
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
        public bool Delete(string maDuAn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from DuAn where MaDuAn=@MaDuAn", conn);
                cmd.Parameters.AddWithValue("@MaDuAn",maDuAn);
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
