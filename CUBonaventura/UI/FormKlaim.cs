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
using MySql.Data.MySqlClient;
using CUBonaventura.Model;

namespace CUBonaventura.UI
{
    public partial class FormKlaim : MetroFramework.Forms.MetroForm
    {
        public FormKlaim()
        {
            InitializeComponent();

            //SetEnableForm();
            SetEnable();
            RefreshDatagridview();
        }

        DataTable dt = new DataTable();
        ControllerAnggota ac = new ControllerAnggota();
        ControllerKlaim kc = new ControllerKlaim();
        private void loadCmbJenisKelamin()
        {
            DataTable dtJenisKelamin = new DataTable();
            MySqlDataAdapter adapterJenisKelamin = ac.GetJenisKelamin();
            adapterJenisKelamin.Fill(dtJenisKelamin);
            cmbJenisKelaminKlaim.DataSource = dtJenisKelamin;
            cmbJenisKelaminKlaim.DisplayMember = "Jenis_kelamin";
        }
        private void loadJenisKlaim()
        {
            DataTable dtJenisKlaim = new DataTable();
            MySqlDataAdapter adapterJenisKlaim = kc.GetJenisKlaim();
            adapterJenisKlaim.Fill(dtJenisKlaim);
            cmbJenisKlaim.DataSource = dtJenisKlaim;
            cmbJenisKlaim.DisplayMember = "kode_jenis";
        }

        int FlagPerintah = 0;
        public void SetFlag(int newFlag)
        { FlagPerintah = newFlag; }
        private bool TextChecking()
        {
            bool temp = true;

            if (txtKodeKlaim.Text == "")
            {
                errorProvider1.SetError(txtKodeKlaim, "Masukkan Kode Klaim!");
                txtKodeKlaim.Focus();
                temp = false;
            }
            if (cmbJenisKlaim.Text == "")
            {
                errorProvider1.SetError(cmbJenisKlaim, "Pilih Jenis Klaim!");
                cmbJenisKlaim.Focus();
                temp = false;
            }
            if (txtNamaLengkapKlaim.Text == "")
            {
                errorProvider1.SetError(txtNamaLengkapKlaim, "Masukkan nama lengkap!");
                txtNamaLengkapKlaim.Focus();
                temp = false;
            }
            if (txtTempatLahirKlaim.Text == "")
            {
                errorProvider1.SetError(txtTempatLahirKlaim, "Masukkan tempat lahir!");
                txtTempatLahirKlaim.Focus();
                temp = false;
            }
            if (txtPekerjaanKlaim.Text == "")
            {
                errorProvider1.SetError(txtPekerjaanKlaim, "Masukkan pekerjaan!");
                txtPekerjaanKlaim.Focus();
                temp = false;
            }
            if (txtAlamatLengkapKlaim.Text == "")
            {
                errorProvider1.SetError(txtAlamatLengkapKlaim, "Masukkan alamat lengkap!");
                txtAlamatLengkapKlaim.Focus();
                temp = false;
            }
            if (txtNoHPKlaim.Text == "")
            {
                errorProvider1.SetError(txtNoHPKlaim, "Masukkan No. HP/Telpon lengkap!");
                txtNoHPKlaim.Focus();
                temp = false;
            }
            if (txtNoBukuKlaim.Text == "")
            {
                errorProvider1.SetError(txtNoBukuKlaim, "Masukkan No. Buku!");
                txtNoBukuKlaim.Focus();
                temp = false;
            }
            if (cmbJenisKelaminKlaim.Text == "")
            {
                errorProvider1.SetError(cmbJenisKelaminKlaim, "Pilih jenis kelamin!");
                cmbJenisKelaminKlaim.Focus();
                temp = false;
            }
            if (txtSakitKlaim.Text == "")
            {
                errorProvider1.SetError(txtSakitKlaim, "Masukkan sakit yang diderita!");
                txtSakitKlaim.Focus();
                temp = false;
            }
            if (txtRSKlaim.Text == "")
            {
                errorProvider1.SetError(txtRSKlaim, "Masukkan rumah sakit!");
                txtRSKlaim.Focus();
                temp = false;
            }
            if (txtLamaRawatKlaim.Text == "")
            {
                errorProvider1.SetError(txtLamaRawatKlaim, "Masukkan lama rawat!");
                txtLamaRawatKlaim.Focus();
                temp = false;
            }
            return temp;
        }
        public void setTextbox(string id_anggota, string no_buku, string nama_lengkap, string no_telp, string pekerjaan, string alamat_lengkap)
        {
            txtIDAnggota.Text = id_anggota;
            txtNoBuku.Text = no_buku;
            txtNamaLengkap.Text = nama_lengkap;
            txtNoTelp.Text = no_telp;
            txtPekerjaan.Text = pekerjaan;
            txtAlamatLengkap.Text = alamat_lengkap;
        }
        private string getKolom(DataGridView dg, int i)
        { return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString(); }
        private string getKolomEdit(DataGridView dg, int i)
        { return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString(); }
        private string getRow(DataGridView dg)
        { return dg.CurrentRow.Index.ToString(); }

        public void SetEnable()
        {

        }

        private void SetDisable()
        {
            if (datagridviewKlaim.RowCount > 0)
            {
                /* Mencegah error jika data yg dihapus tinggal 1 */
                datagridviewKlaim.Rows[0].Selected = true;
                tempID.Text = getKolom(datagridviewKlaim, 0);
            }
        }

        //private void SetDisableForm()
        //{
        //    btnBatal.Enabled = true;
        //    btnSimpan.Enabled = true;
        //    btnUpdate.Enabled = true;
        //    btnHapus.Enabled = true;

        //    datagridviewKlaim.Enabled = true;

        //    RefreshDatagridview();
        //    if (datagridviewKlaim.RowCount > 0)
        //    {
        //        /* Mencegah error jika data yg dihapus tinggal 1 */
        //        datagridviewKlaim.Rows[0].Selected = true;
        //        tempID.Text = getKolom(datagridviewKlaim, 0);
        //    }

        //}
        //private void SetEnableForm()
        //{
        //    btnBatal.Enabled = true;
        //    btnSimpan.Enabled = true;
        //    btnUpdate.Enabled = true;
        //    btnHapus.Enabled = true;

        //    datagridviewKlaim.Enabled = true;
        //}

        private void SetHeaderDatagridview(DataGridView dg)
        {
            foreach (DataGridViewColumn col in dg.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            datagridviewKlaim.Columns[0].HeaderText = "Kode Klaim";
            datagridviewKlaim.Columns[1].HeaderText = "No. Buku";
            datagridviewKlaim.Columns[2].HeaderText = "Jenis Klaim";
            datagridviewKlaim.Columns[3].HeaderText = "Nama Lengkap";
            datagridviewKlaim.Columns[4].HeaderText = "Tempat Lahir";
            datagridviewKlaim.Columns[5].HeaderText = "Tanggal Lahir";
            datagridviewKlaim.Columns[6].HeaderText = "Jenis Kelamin";
            datagridviewKlaim.Columns[7].HeaderText = "Pekerjaan";
            datagridviewKlaim.Columns[8].HeaderText = "Alamat Lengkap";
            datagridviewKlaim.Columns[9].HeaderText = "No. Telp/HP";
            datagridviewKlaim.Columns[10].HeaderText = "Sakit Diderita";
            datagridviewKlaim.Columns[11].HeaderText = "Rumah Sakit";
            datagridviewKlaim.Columns[12].HeaderText = "Lama Rawat (hari)";
            datagridviewKlaim.Columns[13].HeaderText = "Tanggal Meninggal";
            datagridviewKlaim.Columns[14].HeaderText = "Pengaju Klaim";
        }
        private void SetDatagridview(DataGridView dg)
        {
            dt.Clear();
            MySqlDataAdapter adapterKlaim = kc.ShowKlaim();
            adapterKlaim.Fill(dt);
            dg.DataSource = dt;

            /* Code data binding / paging */
            DataTable dtBinding = dt;
            BindingList<DataTable> ListTbl = new BindingList<DataTable>();
            if (dtBinding.Rows.Count > 0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in dtBinding.Rows)
                {
                    if (counter == 0)
                    {
                        ListTbl.Add(dtBinding.Clone());
                        subTblIndex++;
                    }
                    ListTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    if (counter == 10) /* 1 page 10 data */
                    { counter = 0; }
                }
            }
            bindingSource1.DataSource = ListTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            dg.DataSource = (dtBinding.Rows.Count > 0 ? ListTbl[bindingSource1.Position] : dtBinding);

            datagridviewKlaim.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            SetHeaderDatagridview(dg);
        }
        private void RefreshDatagridview()
        { SetDatagridview(datagridviewKlaim); }

        private void cmbJenisKlaim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenisKlaim.Text == "SOLDUTA")
            {
                lblTglMeninggal.Enabled = true;
                dtMeninggalKlaim.Enabled = true;
                dtMeninggalKlaim.Format = DateTimePickerFormat.Short;
            }
            else
            {
                lblTglMeninggal.Enabled = false;
                dtMeninggalKlaim.Enabled = false;
                dtMeninggalKlaim.Format = DateTimePickerFormat.Custom;
                dtMeninggalKlaim.CustomFormat = " ";
            }
        }

        private void dtMeninggalKlaim_ValueChanged(object sender, EventArgs e)
        {
            dtMeninggalKlaim.CustomFormat = "MM/dd/yyyy";
        }

        private void dtMeninggalKlaim_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            { dtMeninggalKlaim.CustomFormat = " "; }
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            //this.SearchDatagridview(dgAnggota, this.txtSearch.Text);
            //if (txtSearch.Text == "")
            this.SetDatagridview(datagridviewKlaim);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagridviewKlaim.RowCount < 0)
                { MessageBox.Show("Kesalahan: Tidak ada data.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (tempID.Text == "")
                {
                    MessageBox.Show("Error: Silahkan pilih data klaim yang akan dihapus!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    datagridviewKlaim.Focus();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Apakah Anda yakin menghapus data dengan kode klaim: " + getKolom(datagridviewKlaim, 0) + "?",
                            "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        kc.DeleteKlaim(tempID.Text);
                    }
                    tempID.Clear();
                    //this.SetDisableForm();
                    this.SetDisable();
                }
            }
            catch (MySqlException ex)
            { MessageBox.Show("Kesalahan: " + ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshDatagridview();
        }
        private void TextClear()
        {
            txtNamaLengkap.Clear();
            txtNoBuku.Clear();
            txtNoBuku.Clear();
            txtNamaLengkap.Clear();
            txtNoTelp.Clear();
            txtPekerjaan.Clear();
            txtAlamatLengkap.Clear();

            txtTempatLahirKlaim.Clear();
            txtKodeKlaim.Clear();
            txtNoBukuKlaim.Clear();
            cmbJenisKlaim.SelectedIndex = -1;
            txtNamaLengkapKlaim.Clear();
            cmbJenisKelaminKlaim.SelectedIndex = -1;
            txtPekerjaanKlaim.Clear();
            txtAlamatLengkapKlaim.Clear();
            txtNoHPKlaim.Clear();
            txtSakitKlaim.Clear();
            txtRSKlaim.Clear();
            txtLamaRawatKlaim.Clear();
            txtIDAnggota.Clear();

            //dtMeninggalKlaim.Format = DateTimePickerFormat.Custom;
            //dtMeninggalKlaim.CustomFormat = " ";
        }
        private void datagridviewKlaim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID.Text = getKolom(datagridviewKlaim, 0);
            tempRow.Text = getRow(datagridviewKlaim);
        }
        private void datagridviewKlaim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID.Text = getKolom(datagridviewKlaim, 0);
            tempRow.Text = getRow(datagridviewKlaim);
        }
        private void datagridviewKlaim_KeyUp(object sender, KeyEventArgs e)
        {
            tempID.Text = getKolom(datagridviewKlaim, 0);
            tempRow.Text = getRow(datagridviewKlaim);
        }
        private void SetValueTextBox(string kode_klaim, string no_buku, string jenis_klaim, string nama_lengkap,
            string tempat_lahir, string tanggal_lahir, string jenis_kelamin, string pekerjaan, string alamat_lengkap,
            string no_telpon, string sakit_diderita, string rumah_sakit, string lama_rawat, string tanggal_meninggal,
            string id_anggota)
        {
            try
            {
                txtKodeKlaim.Text = kode_klaim;
                txtNoBukuKlaim.Text = no_buku;
                cmbJenisKlaim.Text = jenis_klaim;
                txtNamaLengkapKlaim.Text = nama_lengkap;
                txtTempatLahirKlaim.Text = tempat_lahir;
                dtTanggalLahirKlaim.Text = tanggal_lahir;
                cmbJenisKelaminKlaim.Text = jenis_kelamin;
                txtPekerjaanKlaim.Text = pekerjaan;
                txtAlamatLengkapKlaim.Text = alamat_lengkap;
                txtNoHPKlaim.Text = no_telpon;
                txtSakitKlaim.Text = sakit_diderita;
                txtRSKlaim.Text = rumah_sakit;
                txtLamaRawatKlaim.Text = lama_rawat;
                dtMeninggalKlaim.Text = tanggal_meninggal;
                txtIDAnggota.Text = id_anggota;
            }
            catch (Exception ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); }
            
        }
        private void SetUpdateForm()
        {
            try
            {
                string kode_klaim = getKolom(datagridviewKlaim, 0);
                string no_buku = getKolom(datagridviewKlaim, 1);
                string jenis_klaim = getKolom(datagridviewKlaim, 2);
                string nama_lengkap = getKolom(datagridviewKlaim, 3);
                string tempat_lahir = getKolom(datagridviewKlaim, 4);
                string tanggal_lahir = getKolom(datagridviewKlaim, 5);
                string jenis_kelamin = getKolom(datagridviewKlaim, 6);
                string pekerjaan = getKolom(datagridviewKlaim, 7);
                string alamat_lengkap = getKolom(datagridviewKlaim, 8);
                string no_telpon = getKolom(datagridviewKlaim, 9);
                string sakit_diderita = getKolom(datagridviewKlaim, 10);
                string rumah_sakit = getKolom(datagridviewKlaim, 11);
                string lama_rawat = getKolom(datagridviewKlaim, 12);
                string tanggal_meninggal = getKolom(datagridviewKlaim, 13);
                string id_anggota = getKolom(datagridviewKlaim, 14);

                SetValueTextBox(kode_klaim, no_buku, jenis_klaim, nama_lengkap, tempat_lahir,
                    tanggal_lahir, jenis_kelamin, pekerjaan, alamat_lengkap, no_telpon, sakit_diderita,
                    rumah_sakit, lama_rawat, tanggal_meninggal, id_anggota);

                SetTextBoxDetailKlaim(id_anggota);
            }
            catch (Exception ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); }
            
            tempRow.Clear(); tempID.Clear();
        }
        private void FormKlaim_Load(object sender, System.EventArgs e)
        {
            tempID.Visible = false;
            tempRow.Visible = false;

            loadCmbJenisKelamin();
            loadJenisKlaim();
            SetDatagridview(datagridviewKlaim);
        }

        private void btnBatal_Click(object sender, System.EventArgs e)
        {
            TextClear();
            gbProses.Enabled = true;
        }

        private void btnSimpan_Click(object sender, System.EventArgs e)
        {
            string kode_klaim = txtKodeKlaim.Text;
            string no_buku = txtNoBuku.Text;
            string jenis_klaim = cmbJenisKlaim.Text;
            string nama_lengkap = txtNamaLengkapKlaim.Text;
            string tempat_lahir = txtTempatLahirKlaim.Text;
            string tanggal_lahir = dtTanggalLahirKlaim.Text;
            string jenis_kelamin = cmbJenisKelaminKlaim.Text;
            string pekerjaan = txtPekerjaanKlaim.Text;
            string alamat_lengkap = txtAlamatLengkapKlaim.Text;
            string no_telpon = txtNoHPKlaim.Text;
            string sakit_diderita = txtSakitKlaim.Text;
            string rumah_sakit = txtRSKlaim.Text;
            string lama_rawat = txtLamaRawatKlaim.Text;
            string tanggal_meninggal = dtMeninggalKlaim.Text;
            string id_anggota = txtIDAnggota.Text;
            
            try
            {
                if (FlagPerintah == 1)
                {
                    if (TextChecking() == true)
                    {
                        errorProvider1.Clear();
                        Klaim K = new Klaim(kode_klaim, no_buku, jenis_klaim, nama_lengkap, tempat_lahir,
                            DateTime.Parse(tanggal_lahir), jenis_kelamin, pekerjaan, alamat_lengkap, no_telpon,
                            sakit_diderita, rumah_sakit, int.Parse(lama_rawat), tanggal_meninggal, id_anggota);
                        kc.insertKlaim(K);
                        DialogResult dr = MessageBox.Show("Data klaim dengan kode: " + txtKodeKlaim.Text + " berhasil ditambahkan!",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            TextClear();
                            FormKlaim kf = new FormKlaim();
                            kf.Refresh();
                        }
                    }
                }
                else
                {
                    if (TextChecking() == true)
                    {
                        errorProvider1.Clear();
                        Klaim K = new Klaim(kode_klaim, no_buku, jenis_klaim, nama_lengkap, tempat_lahir,
                            DateTime.Parse(tanggal_lahir), jenis_kelamin, pekerjaan, alamat_lengkap, no_telpon,
                            sakit_diderita, rumah_sakit, int.Parse(lama_rawat), tanggal_meninggal, id_anggota);

                        DialogResult dr = MessageBox.Show("Apakah Anda akan mengubah data klaim dengan kode: " + txtKodeKlaim.Text, "Peringatan",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            kc.UpdateKlaim(K, txtKodeKlaim.Text);
                            TextClear();
                            FormKlaim kf = new FormKlaim();
                            kf.Refresh();
                        }
                    }
                }
                RefreshDatagridview();
            }
            catch (Exception ex)
            { MessageBox.Show(this, "Kesalahan: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            gbProses.Enabled = true;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            gbProses.Enabled = false;
            SetEnable();
            SetUpdateForm();
            SetFlag(2);
        }
        CUBonaventura.Except.ShowException se = new Except.ShowException();
        private void SetTextBoxDetailKlaim(string id_agt)
        {
            CUBonaventura.DAO.DBConnection db = new DAO.DBConnection();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = ("SELECT * FROM tbl_anggota JOIN tbl_klaim ON tbl_anggota.id_anggota = tbl_klaim.id_anggota WHERE tbl_klaim.id_anggota = @id");
                cmd.Parameters.AddWithValue("@id", id_agt);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtIDAnggota.Text = id_agt;
                    txtNoBuku.Text = (read["NO_BUKU"].ToString());
                    txtNamaLengkap.Text = (read["NAMA_LENGKAP"].ToString());
                    txtNoTelp.Text = (read["TELEPON"].ToString());
                    txtPekerjaan.Text = (read["PEKERJAAN"].ToString());
                    txtAlamatLengkap.Text = (read["ALAMAT_LENGKAP"].ToString());
                }
                read.Close();
            }
            catch (MySqlException ex)
            { se.ShowMessage(ex.ToString(), "Kesalahan"); }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            FormReportKlaim frk = new FormReportKlaim();
            frk.ShowDialog();
        }
    }
}
