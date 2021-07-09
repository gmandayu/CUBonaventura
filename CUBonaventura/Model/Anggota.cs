using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBonaventura.Model
{
    class Anggota
    {

        private string id, nama_lengkap, nama_panggilan, jenis_identitas, no_identitas,
            jenis_kelamin, status_perkawinan, tempat_lahir, /* Tanggal_lahir*/ agama, alamat_lengkap,
            telepon, pendidikan, pekerjaan, tempat_bekerja, alamat_pekerjaan, jenis_anggota,
            no_buku;
        private DateTime tanggal_lahir;

        public Anggota(string _id, string _nama_lengkap, string _nama_panggilan, string _jenis_identitas,
            string _no_identitas, string _jenis_kelamin, string _stat_perkawinan, string _tempat_lahir,
            DateTime _tanggal_lahir, string _agama, string _alamat_lengkap, string _telepon, string _pendidikan,
            string _pekerjaan, string _tempat_bekerja, string _alamat_pekerjaan, string _jenis_anggota, string _no_buku)
        {
            this.id = _id;
            this.nama_lengkap = _nama_lengkap;
            this.nama_panggilan = _nama_panggilan;
            this.jenis_identitas = _jenis_identitas;
            this.no_identitas = _no_identitas;
            this.jenis_kelamin = _jenis_kelamin;
            this.status_perkawinan = _stat_perkawinan;
            this.tempat_lahir = _tempat_lahir;
            this.tanggal_lahir = _tanggal_lahir;
            this.agama = _agama;
            this.alamat_lengkap = _alamat_lengkap;
            this.telepon = _telepon;
            this.pendidikan = _pendidikan;
            this.pekerjaan = _pekerjaan;
            this.tempat_bekerja = _tempat_bekerja;
            this.alamat_pekerjaan = _alamat_pekerjaan;
            this.jenis_anggota = _jenis_anggota;
            this.no_buku = _no_buku;
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nama_lengkap
        {
            get { return nama_lengkap; }
            set { nama_lengkap = value; }
        }

        public String Nama_panggilan
        {
            get { return nama_panggilan; }
            set { nama_panggilan = value; }
        }

        public String No_buku
        {
            get { return no_buku; }
            set { no_buku = value; }
        }

        public String Jenis_anggota
        {
            get { return jenis_anggota; }
            set { jenis_anggota = value; }
        }

        public String Alamat_pekerjaan
        {
            get { return alamat_pekerjaan; }
            set { alamat_pekerjaan = value; }
        }

        public String Tempat_bekerja
        {
            get { return tempat_bekerja; }
            set { tempat_bekerja = value; }
        }

        public String Pekerjaan
        {
            get { return pekerjaan; }
            set { pekerjaan = value; }
        }

        public String Pendidikan
        {
            get { return pendidikan; }
            set { pendidikan = value; }
        }

        public String Telepon
        {
            get { return telepon; }
            set { telepon = value; }
        }

        public String Alamat_lengkap
        {
            get { return alamat_lengkap; }
            set { alamat_lengkap = value; }
        }

        public String Agama
        {
            get { return agama; }
            set { agama = value; }
        }

        public String Tempat_lahir
        {
            get { return tempat_lahir; }
            set { tempat_lahir = value; }
        }

        public String Status_perkawinan
        {
            get { return status_perkawinan; }
            set { status_perkawinan = value; }
        }

        public String Jenis_kelamin
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }

        public String No_identitas
        {
            get { return no_identitas; }
            set { no_identitas = value; }
        }

        public String Jenis_identitas
        {
            get { return jenis_identitas; }
            set { jenis_identitas = value; }
        }

        public DateTime Tanggal_lahir
        {
            get { return tanggal_lahir; }
            set { tanggal_lahir = value; }
        }

    }
}
