using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using CUBonaventura.Except;

namespace CUBonaventura.DAO
{
    class DAOLogin
    {
        ShowException se = new ShowException();
        public string validateLogin(string username, string password)
        {
            string id_user = "";
            
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nama_pengguna FROM tbl_user WHERE Username = @Username AND Password = @Password";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                id_user = cmd.ExecuteScalar().ToString();
                return id_user;
                
                //if (id_user != "")
                //{ isLogin = true; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return id_user;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        public string GetRoleUser(string username, string password)
        {
            string role = "";
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT tbl_role.ID_ROLE FROM tbl_role JOIN tbl_user ON tbl_role.ID_ROLE = tbl_user.ID_ROLE WHERE tbl_user.USERNAME = @username AND tbl_user.PASSWORD = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                role = cmd.ExecuteScalar().ToString();

                return role;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return role;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        public bool validateUser(string username, string email)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nama_pengguna FROM tbl_user WHERE username = @user AND email = @Email";
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public bool updatePass(string username, string password)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE tbl_user SET Username = @user, Password = @Password WHERE Username = @user";
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
