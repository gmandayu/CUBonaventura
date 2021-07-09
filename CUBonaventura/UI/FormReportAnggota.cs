using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CUBonaventura.Report;
using CUBonaventura.Controller;
using MySql.Data.MySqlClient;

namespace CUBonaventura.UI
{
    public partial class FormReportAnggota : MetroFramework.Forms.MetroForm
    {
        public FormReportAnggota()
        {
            InitializeComponent();
            RefreshReport();
        }

        ControllerAnggota ac = new ControllerAnggota();
        ReportAnggota ra = new ReportAnggota();
        DataTable dt = new DataTable();
        private void LoadCmbJenisAnggota()
        {
            DataTable dtJenisAnggota = new DataTable();
            MySqlDataAdapter adapterJenisAnggota = ac.GetJenisAnggota();
            adapterJenisAnggota.Fill(dtJenisAnggota);
            cmbJenisAnggota.DataSource = dtJenisAnggota;
            cmbJenisAnggota.DisplayMember = "jenis_anggota";
            cmbJenisAnggota.ValueMember = "id_jenis";
        }
        private void RetrieveDataReport()
        {
            dt.Clear();
            ReportAnggota reportAnggota = new ReportAnggota();
            MySqlDataAdapter adapter = ac.RetrieveReportAnggota();
            adapter.Fill(dt);
            reportAnggota.SetDataSource(dt);
            crystalReportViewer1.ReportSource = reportAnggota;

            //dt.Clear();
            //MySqlDataAdapter adapter = ac.RetrieveReportAnggota();
            //adapter.Fill(dt);
            //ra.SetDataSource(dt);

            //crystalReportViewer1.ReportSource = ra;
            //crystalReportViewer1.Show();
        }
        private void RefreshReport()
        { RetrieveDataReport(); }
        private void FilterDataReport()
        {
            dt.Clear();
            MySqlDataAdapter adapter = ac.FilterAnggotaByJenis(cmbJenisAnggota.Text);
            adapter.Fill(dt);
            ra.SetDataSource(dt);
            crystalReportViewer1.ReportSource = ra;
            crystalReportViewer1.Show();
        }
        private void FormReportAnggota_Load(object sender, EventArgs e)
        {
            LoadCmbJenisAnggota();
            RetrieveDataReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterDataReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}
