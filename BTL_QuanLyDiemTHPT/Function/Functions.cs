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
    }
}
