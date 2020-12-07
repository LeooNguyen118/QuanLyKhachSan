using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public static class SQLConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=|DataDirectory|\QuanLyKhachSan.mdf");
        }
        public static DataTable Select(string column, string table)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM " + table, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable SelectWhere(string column, string table, string where)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM " + table + " WHERE " + where, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Insert(string table, string column, string value)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO " + table + " (" + column + ")" +
                    " VALUES (" + value + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(string table, string value, string where)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("UPDATE " + table + " " +
                    "SET " + value + " " +
                    "WHERE " + where, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static int IncrID(string table, string column)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM " + table + " ORDER BY " + column + " DESC", con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    try
                    {
                        return Convert.ToInt32(sdr[column].ToString()) + 1;
                    }
                    catch {
                        return 0;
                    }
                }
            }
        }

        public static bool isExist(string table, string column, string value)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM " + table, con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        if (sdr[column].ToString().Equals(value))
                            return true;
                    }
                    return false;
                }
            }
        }

        public static string SelectOne(string column, string table, string where)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM " + table + " WHERE " + where, con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    try
                    {
                        return sdr[column].ToString();
                    }
                    catch { return "NULL";}
                }
            }
        }

        public static string SelectTS(string column)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT " + column + " FROM THAMSO", con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    try
                    {
                        return sdr[column].ToString();
                    }
                    catch { return "NULL"; }
                }
            }
        }

        public static void Delete(string table, string where)
        {
            SqlConnection con = GetConnection();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE " + where, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
