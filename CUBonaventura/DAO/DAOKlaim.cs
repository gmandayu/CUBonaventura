using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CUBonaventura.Model;
using CUBonaventura.Except;
using MySql.Data.MySqlClient;
using System.Data;

namespace CUBonaventura.DAO
{
    class DAOKlaim
    {
        ShowException se = new ShowException();

        public MySqlDataAdapter GetJenisKlaim()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_jenis_klaim";
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
        public bool insertKlaim(Klaim K)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into tbl_klaim values(@kode_klaim, @no_buku, @jenis_klaim, @nama_lengkap, @tempat_lahir, @tanggal_lahir, @jenis_kelamin, @pekerjaan, @alamat_lengkap, @no_telepon, @sakit_diderita, @rumah_sakit, @lama_rawat, @tanggal_meninggal, @id_anggota)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@kode_klaim", K.Kode_klaim);
                cmd.Parameters.AddWithValue("@no_buku", K.No_buku);
                cmd.Parameters.AddWithValue("@jenis_klaim", K.Jenis_klaim);
                cmd.Parameters.AddWithValue("@nama_lengkap", K.Nama_lengkap);
                cmd.Parameters.AddWithValue("@tempat_lahir", K.Tempat_lahir);
                cmd.Parameters.AddWithValue("@tanggal_lahir", K.Tanggal_lahir);
                cmd.Parameters.AddWithValue("@jenis_kelamin", K.Jenis_kelamin);
                cmd.Parameters.AddWithValue("@pekerjaan", K.Pekerjaan);
                cmd.Parameters.AddWithValue("@alamat_lengkap", K.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@no_telepon", K.No_telp);
                cmd.Parameters.AddWithValue("@sakit_diderita", K.Sakit_diderita);
                cmd.Parameters.AddWithValue("@rumah_sakit", K.Rumah_sakit);
                cmd.Parameters.AddWithValue("@lama_rawat", K.Lama_rawat);
                cmd.Parameters.AddWithValue("@tanggal_meninggal", K.Tanggal_meninggal);
                cmd.Parameters.AddWithValue("@id_anggota", K.Id_anggota);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                se.ShowMessage(ex.ToString(), "Kesalahan");
                return false;
            }
            finally
            { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }

        public MySqlDataAdapter ShowKlaim()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select kode_klaim, no_buku, kode_jenis, nama_lengkap, tempat_lahir, tanggal_lahir, jenis_kelamin, pekerjaan, alamat_lengkap, no_telepon, sakit_diderita, rumah_sakit, lama_rawat, tanggal_meninggal, id_anggota from tbl_klaim";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return null; }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        public MySqlDataAdapter ShowPengajuKlaim(string id_anggota)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select no_buku, nama_lengkap, telepon, pekerjaan, alamat_lengkap from tbl_anggota where id_anggota = @id_anggota";
                cmd.Parameters.AddWithValue("@id_anggota", id_anggota);
                MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return null; }
            finally
            { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        public bool updateKlaim(Klaim K, string kode_klaim)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "update tbl_klaim set no_buku = @no_buku, kode_jenis = @kode_jenis, nama_lengkap = @nama_lengkap, tempat_lahir = @tempat_lahir, tanggal_lahir = @tanggal_lahir, jenis_kelamin = @jenis_kelamin, pekerjaan = @pekerjaan, alamat_lengkap = @alamat_lengkap, no_telepon = @no_telepon, sakit_diderita = @sakit_diderita, rumah_sakit = @rumah_sakit, lama_rawat = @lama_rawat, tanggal_meninggal = @tanggal_meninggal, id_anggota = @id_anggota where kode_klaim = @kode_klaim";
                cmd.Parameters.AddWithValue("@kode_klaim", kode_klaim);
                cmd.Parameters.AddWithValue("@no_buku", K.No_buku);
                cmd.Parameters.AddWithValue("@kode_jenis", K.Jenis_klaim);
                cmd.Parameters.AddWithValue("@nama_lengkap", K.Nama_lengkap);
                cmd.Parameters.AddWithValue("@tempat_lahir", K.Tempat_lahir);
                cmd.Parameters.AddWithValue("@tanggal_lahir", K.Tanggal_lahir);
                cmd.Parameters.AddWithValue("@jenis_kelamin", K.Jenis_kelamin);
                cmd.Parameters.AddWithValue("@pekerjaan", K.Pekerjaan);
                cmd.Parameters.AddWithValue("@alamat_lengkap", K.Alamat_lengkap);
                cmd.Parameters.AddWithValue("@no_telepon", K.No_telp);
                cmd.Parameters.AddWithValue("@sakit_diderita", K.Sakit_diderita);
                cmd.Parameters.AddWithValue("@rumah_sakit", K.Rumah_sakit);
                cmd.Parameters.AddWithValue("@lama_rawat", K.Lama_rawat);
                cmd.Parameters.AddWithValue("@tanggal_meninggal", K.Tanggal_meninggal);
                cmd.Parameters.AddWithValue("@id_anggota", K.Id_anggota);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return false; }
            finally
            { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }

        public bool deleteKlaim(string val)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from tbl_klaim where kode_klaim rlike @kode";
                cmd.Parameters.AddWithValue("@kode", val);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return false; }
            finally
            { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        public MySqlDataAdapter RetrieveDataReport()
        {
            DAO.DBConnection db = new DAO.DBConnection();
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(db.connectionString());
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select kode_klaim, no_buku, kode_jenis, nama_lengkap, jenis_kelamin, alamat_lengkap, no_telepon, sakit_diderita, rumah_sakit, lama_rawat, tanggal_meninggal, id_anggota from tbl_klaim";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return null; }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        public MySqlDataAdapter searchKlaim(string valID)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tbl_klaim where kode_jenis RLIKE @keyword";
                cmd.Parameters.AddWithValue("@keyword", valID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return null; }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        public MySqlDataAdapter GetDetailKlaim(string id)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select tbl_anggota.no_buku, tbl_anggota.nama_lengkap, tbl_anggota.telepon, tbl_anggota.pekerjaan, tbl_anggota.alamat_lengkap from tbl_anggota join tbl_klaim using(id_anggota) where id_anggota = @id_anggota";
                cmd.Parameters.AddWithValue("@id_anggota", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); return null; }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }
    }
}
