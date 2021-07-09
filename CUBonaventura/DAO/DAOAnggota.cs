using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CUBonaventura.Model;
using CUBonaventura.Except;
using MySql.Data.MySqlClient;

namespace CUBonaventura.DAO
{
    class DAOAnggota
    {
        private static ShowException se = new ShowException();
        private static DBConnection db = new DBConnection();
        private static MySqlConnection conn = new MySqlConnection(db.connectionString());
        private static MySqlCommand cmd = new MySqlCommand();

        public MySqlDataAdapter ShowAnggota()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_anggota";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter SearchAnggota(string valID)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_anggota where Id_anggota RLIKE @keyword";
                cmd.Parameters.AddWithValue("@keyword", valID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public bool InsertAnggota(Anggota A)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandText = "insert into tbl_anggota values(@Id_anggota, @Nama_lengkap, @nama_panggilan, @jenis_identitas, @no_identitas, @Jenis_kelamin, @status_perkawinan, @Tempat_lahir, @Tanggal_lahir, @agama, @Alamat_lengkap, @telepon, @pendidikan, @Pekerjaan, @tempat_bekerja, @alamat_pekerjaan, @jenis_anggota, @No_buku)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Id_anggota", A.Id);
                cmd.Parameters.AddWithValue("@Nama_lengkap", A.Nama_lengkap);
                cmd.Parameters.AddWithValue("@nama_panggilan", A.Nama_panggilan);
                cmd.Parameters.AddWithValue("@jenis_identitas", A.Jenis_identitas);
                cmd.Parameters.AddWithValue("@no_identitas", A.No_identitas);
                cmd.Parameters.AddWithValue("@Jenis_kelamin", A.Jenis_kelamin);
                cmd.Parameters.AddWithValue("@status_perkawinan", A.Status_perkawinan);
                cmd.Parameters.AddWithValue("@Tempat_lahir", A.Tempat_lahir);
                cmd.Parameters.AddWithValue("@Tanggal_lahir", A.Tanggal_lahir);
                cmd.Parameters.AddWithValue("@agama", A.Agama);
                cmd.Parameters.AddWithValue("@Alamat_lengkap", A.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@telepon", A.Telepon);
                cmd.Parameters.AddWithValue("@pendidikan", A.Pendidikan);
                cmd.Parameters.AddWithValue("@Pekerjaan", A.Pekerjaan);
                cmd.Parameters.AddWithValue("@tempat_bekerja", A.Tempat_bekerja);
                cmd.Parameters.AddWithValue("@alamat_pekerjaan", A.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@jenis_anggota", A.Jenis_anggota);
                cmd.Parameters.AddWithValue("@No_buku", A.No_buku);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
        }
        public bool UpdateAnggota(Anggota A, string valID)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE tbl_anggota SET Nama_lengkap = @Nama_lengkap, nama_panggilan = @nama_panggilan, jenis_identitas = @jenis_identitas, no_identitas = @no_identitas, Jenis_kelamin = @Jenis_kelamin, status_perkawinan = @status_perkawinan, Tempat_lahir = @Tempat_lahir, Tanggal_lahir = @Tanggal_lahir, agama = @agama, Alamat_lengkap = @Alamat_lengkap, telepon = @telepon, pendidikan = @pendidikan, Pekerjaan = @Pekerjaan, tempat_bekerja = @tempat_bekerja, alamat_pekerjaan = @alamat_pekerjaan, jenis_anggota = @jenis_anggota, No_buku = @No_buku WHERE Id_anggota = @Id_anggota";

                cmd.Parameters.AddWithValue("@Id_anggota", valID);
                cmd.Parameters.AddWithValue("@Nama_lengkap", A.Nama_lengkap);
                cmd.Parameters.AddWithValue("@nama_panggilan", A.Nama_panggilan);
                cmd.Parameters.AddWithValue("@jenis_identitas", A.Jenis_identitas);
                cmd.Parameters.AddWithValue("@no_identitas", A.No_identitas);
                cmd.Parameters.AddWithValue("@Jenis_kelamin", A.Jenis_kelamin);
                cmd.Parameters.AddWithValue("@status_perkawinan", A.Status_perkawinan);
                cmd.Parameters.AddWithValue("@Tempat_lahir", A.Tempat_lahir);
                cmd.Parameters.AddWithValue("@Tanggal_lahir", A.Tanggal_lahir);
                cmd.Parameters.AddWithValue("@agama", A.Agama);
                cmd.Parameters.AddWithValue("@Alamat_lengkap", A.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@telepon", A.Telepon);
                cmd.Parameters.AddWithValue("@pendidikan", A.Pendidikan);
                cmd.Parameters.AddWithValue("@Pekerjaan", A.Pekerjaan);
                cmd.Parameters.AddWithValue("@tempat_bekerja", A.Tempat_bekerja);
                cmd.Parameters.AddWithValue("@alamat_pekerjaan", A.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@jenis_anggota", A.Jenis_anggota);
                cmd.Parameters.AddWithValue("@No_buku", A.No_buku);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public bool DeleteAnggota(string val)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from tbl_anggota where Id_anggota rlike @Id";
                cmd.Parameters.AddWithValue("@Id", val);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return false;
            }
            finally
            { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
        public MySqlDataAdapter GetJenisKelamin()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM TBL_JENIS_KELAMIN";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter GetJenisAnggota()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_jenis_anggota";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter RetrieveDataReport()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select id_anggota, no_buku, jenis_anggota, nama_lengkap, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat_lengkap, telepon, pekerjaan from tbl_anggota";
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DSAnggota dsAnggota = new DSAnggota();
                dsAnggota.Clear();
                adapter.Fill(dsAnggota, "tbl_anggota");
                return adapter;

            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter GetPendidikan()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_pendidikan";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter GetStatusPerkawinan()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_status_perkawinan";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter GetJenisIdentitas()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_jenis_id";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter GetAgama()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_agama";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public MySqlDataAdapter FilterAnggotaByJenis(string jenis_anggota)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_anggota where jenis_anggota RLIKE @keyword";
                cmd.Parameters.AddWithValue("@keyword", jenis_anggota);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
        public int getIDJenisAnggota(string types)
        {
            int id = 0;
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select id_jenis from tbl_jenis_anggota where Jenis_anggota = @types";
                cmd.Parameters.AddWithValue("@types", types);
                cmd.ExecuteNonQuery();
                return id;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
    }
}
