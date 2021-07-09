using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CUBonaventura.Model;
using CUBonaventura.DAO;

namespace CUBonaventura.Controller
{
    class ControllerKlaim
    {
        CUBonaventura.DAO.DAOKlaim jk = new DAO.DAOKlaim();
        public MySql.Data.MySqlClient.MySqlDataAdapter GetJenisKlaim()
        { return jk.GetJenisKlaim(); }
        public bool insertKlaim(Klaim K)
        { return jk.insertKlaim(K); }

        public MySql.Data.MySqlClient.MySqlDataAdapter ShowKlaim()
        { return jk.ShowKlaim(); }

        public MySql.Data.MySqlClient.MySqlDataAdapter RetrieveDataReport()
        { return jk.RetrieveDataReport(); }

        public MySql.Data.MySqlClient.MySqlDataAdapter GetDetailKlaim(string id)
        { return jk.GetDetailKlaim(id); }

        public MySql.Data.MySqlClient.MySqlDataAdapter SearchKlaim(string kode_jenis)
        { return jk.searchKlaim(kode_jenis); }

        public bool DeleteKlaim(string kode)
        { return jk.deleteKlaim(kode); }

        public bool UpdateKlaim(Model.Klaim K, string kode_klaim)
        { return jk.updateKlaim(K, kode_klaim); }

        public MySql.Data.MySqlClient.MySqlDataAdapter ShowPengajuKlaim(string id_anggota)
        { return jk.ShowPengajuKlaim(id_anggota); }
    }
}
