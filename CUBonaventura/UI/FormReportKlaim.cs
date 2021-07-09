using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CUBonaventura.Controller;
using CUBonaventura.Report;
using MySql.Data.MySqlClient;
using CUBonaventura.Except;

namespace CUBonaventura.UI
{
    public partial class FormReportKlaim : MetroFramework.Forms.MetroForm
    {
        public FormReportKlaim()
        {
            InitializeComponent();
        }

        ControllerKlaim kc = new ControllerKlaim();
        ReportKlaim rk = new ReportKlaim();
        DataTable dt = new DataTable();

        private void LoadCmbJenisKlaim()
        {
            DataTable dtJenisKlaim = new DataTable();
            MySqlDataAdapter adapterJenisKlaim = kc.GetJenisKlaim();
            adapterJenisKlaim.Fill(dtJenisKlaim);
            cmbJenisKlaim.DataSource = dtJenisKlaim;
            cmbJenisKlaim.DisplayMember = "kode_jenis";
            cmbJenisKlaim.ValueMember = "deskripsi";
        }
        private void RetrieveDataReport()
        {
            try
            {
                Report.ReportKlaim rk = new ReportKlaim();
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlDataAdapter adapter = kc.RetrieveDataReport();
                adapter.Fill(dt);
                rk.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rk;
                crystalReportViewer1.Show();
            }
            catch (MySqlException ex)
            {
                ShowException se = new ShowException();
                se.ShowMessage("Kesalahan: " + ex.ToString(), "Kesalahan");
            }
        }

        private void FilterDataReport()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            MySqlDataAdapter adapter = kc.SearchKlaim(cmbJenisKlaim.Text);
            adapter.Fill(dt);
            ReportKlaim rk = new ReportKlaim();
            rk.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rk;
            crystalReportViewer1.Show();
        }

        private void FormReportKlaim_Load(object sender, EventArgs e)
        {
            LoadCmbJenisKlaim();
            RetrieveDataReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterDataReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RetrieveDataReport();
        }
    }
}
