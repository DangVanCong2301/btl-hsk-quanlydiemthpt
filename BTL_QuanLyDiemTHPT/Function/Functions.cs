using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyDiemTHPT.Connection;

namespace BTL_QuanLyDiemTHPT.Function
{
    class Functions
    {

        public static DataTable getDataToTable(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn); // Định nghĩa đối tượng thuộc lớp SqlAdapter                                              
                    // Khai báo đối tượng table thuộc lớp DataTable
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return table;
        }

        public static void runSql(string sql)
        {
            using(SqlConnection conn = DBConnection.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();     
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }
        }

        public static void runSqlDel(string sql)
        {
            using (SqlConnection conn = DBConnection.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void fillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            using (SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cbo.DataSource = table;
                    cbo.ValueMember = ma; // Trường giá trị
                    cbo.DisplayMember = ten; // Trường hiển thị
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }
        }

        public static string getFileValues(string sql)
        {
            string ma = "";
            using(SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ma = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }
            return ma;
        }

        public static bool checkKey(string sql)
        {
            using(SqlConnection conn = DBConnection.getConnection())
            {               
                conn.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool runProc(string proc, SqlCommand cmd)
        {
            using (SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = proc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        public static bool runProcDel(string proc, SqlCommand cmd)
        {
            using (SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = proc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        public static DataTable timKiem(string proc, SqlCommand cmd)
        {
            DataTable table = new DataTable();
            using(SqlConnection conn = DBConnection.getConnection())
            {
                try
                {
                    conn.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = proc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                    }
                } catch (Exception ex)
                {

                } finally
                {
                    conn.Close();
                }
            }
            return table;
        }

        public static DataTable getReport(string proc)
        {
            DataTable table = new DataTable();
            using(SqlConnection conn = DBConnection.getConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            return table;
        }

        public static string CreateKey(string tienTo)
        {
            string key = tienTo;
            //string[] partsDay;
            //partsDay = DateTime.Now.ToShortDateString().Split('/');
            //// Ví dụ 2022/12/12
            //string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            //key = key + d;
            string[] partsTime = DateTime.Now.ToLongTimeString().Split(':');
            // Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
            {
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            }
            if (partsTime[2].Substring(3, 2) == "AM")
            {
                if (partsTime[0].Length == 1)
                {
                    partsTime[0] = "0" + partsTime[0];
                }
            }
            // Xoá ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;

            }
            return h;
        }
    }
}
