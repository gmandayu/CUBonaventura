using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBonaventura.Model
{
    class Klaim
    {
        private string kode_klaim, nama_lengkap, tempat_lahir, pekerjaan, alamat_lengkap,
            no_telp, jenis_kelamin, no_buku, jenis_klaim, sakit_diderita, rumah_sakit;
        private string id_anggota;

        public string Id_anggota
        {
            get { return id_anggota; }
            set { id_anggota = value; }
        }
        public string Rumah_sakit
        {
            get { return rumah_sakit; }
            set { rumah_sakit = value; }
        }

        public string Sakit_diderita
        {
            get { return sakit_diderita; }
            set { sakit_diderita = value; }
        }

        public string Jenis_klaim
        {
            get { return jenis_klaim; }
            set { jenis_klaim = value; }
        }

        public string No_buku
        {
            get { return no_buku; }
            set { no_buku = value; }
        }

        public string Jenis_kelamin
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }

        public string No_telp
        {
            get { return no_telp; }
            set { no_telp = value; }
        }

        public string Alamat_lengkap
        {
            get { return alamat_lengkap; }
            set { alamat_lengkap = value; }
        }

        public string Pekerjaan
        {
            get { return pekerjaan; }
            set { pekerjaan = value; }
        }

        public string Tempat_lahir
        {
            get { return tempat_lahir; }
            set { tempat_lahir = value; }
        }

        public string Nama_lengkap
        {
            get { return nama_lengkap; }
            set { nama_lengkap = value; }
        }

        public string Kode_klaim
        {
            get { return kode_klaim; }
            set { kode_klaim = value; }
        }

        private int lama_rawat;

        public int Lama_rawat
        {
            get { return lama_rawat; }
            set { lama_rawat = value; }
        }

        private DateTime tanggal_lahir;
        private string tanggal_meninggal;

        public string Tanggal_meninggal
        {
            get { return tanggal_meninggal; }
            set { tanggal_meninggal = value; }
        }

        public DateTime Tanggal_lahir
        {
            get { return tanggal_lahir; }
            set { tanggal_lahir = value; }
        }

        public Klaim(string kode_klaim, string no_buku, string jenis_klaim,
            string nama_lengkap, string tempat_lahir, DateTime tanggal_lahir,
            string jenis_kelamin, string pekerjaan, string alamat_lengkap,
            string no_telepon, string sakit_diderita, string rumah_sakit,
            int lama_rawat, string tanggal_meninggal, string id_anggota)
        {
            this.kode_klaim = kode_klaim;
            this.no_buku = no_buku;
            this.jenis_klaim = jenis_klaim;
            this.nama_lengkap = nama_lengkap;
            this.tempat_lahir = tempat_lahir;
            this.tanggal_lahir = tanggal_lahir;
            this.jenis_kelamin = jenis_kelamin;
            this.pekerjaan = pekerjaan;
            this.alamat_lengkap = alamat_lengkap;
            this.no_telp = no_telepon;
            this.sakit_diderita = sakit_diderita;
            this.rumah_sakit = rumah_sakit;
            this.lama_rawat = lama_rawat;
            this.tanggal_meninggal = tanggal_meninggal;
            this.id_anggota = id_anggota;
        }


    }
}
