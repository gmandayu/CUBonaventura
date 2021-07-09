using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CUBonaventura.DAO;
using MySql.Data.MySqlClient;
using CUBonaventura.Model;

namespace CUBonaventura.Controller
{
    class ControllerAnggota
    {
        DAOAnggota ad = new DAOAnggota();

        public MySqlDataAdapter GetStatusPerkawinan()
        { return ad.GetStatusPerkawinan(); }
        public MySqlDataAdapter GetPendidikan()
        { return ad.GetPendidikan(); }
        public MySqlDataAdapter GetJenisIdentitas()
        { return ad.GetJenisIdentitas(); }
        public MySqlDataAdapter GetAgama()
        { return ad.GetAgama(); }
        public MySqlDataAdapter GetJenisKelamin()
        { return ad.GetJenisKelamin(); }
        public MySqlDataAdapter GetJenisAnggota()
        { return ad.GetJenisAnggota(); }
        public MySqlDataAdapter RetrieveReportAnggota()
        { return ad.RetrieveDataReport(); }
        public MySqlDataAdapter ShowAnggota()
        { return ad.ShowAnggota(); }
        public bool InsertAnggota(Anggota A)
        { return ad.InsertAnggota(A); }
        public bool UpdateAnggota(Anggota A, string id_anggota)
        { return ad.UpdateAnggota(A, id_anggota); }
        public bool DeleteAnggota(string id_anggota)
        { return ad.DeleteAnggota(id_anggota); }
        public MySqlDataAdapter SearchAnggota(string id_anggota)
        { return ad.SearchAnggota(id_anggota); }
        public MySqlDataAdapter FilterAnggotaByJenis(string jenis_anggota)
        { return ad.FilterAnggotaByJenis(jenis_anggota); }


    }
}
