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
using CUBonaventura.Model;
using MySql.Data.MySqlClient;

namespace CUBonaventura.UI
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
            SetEnableForm();
            RefreshDatagridview();
        }

        

        int flagPerintah = 0;
        DataTable dt = new DataTable();
        ControllerAnggota ac = new ControllerAnggota();

        public void SetLabel(string text)
        { this.labelLogin.Text = "Login as: " + text; }
        public void SetFlag(int newFlag)
        { flagPerintah = newFlag; }
        private string getKolom(DataGridView dg, int i)
        { return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString(); }
        private string getKolomEdit(DataGridView dg, int i)
        { return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString(); }
        private string getRow(DataGridView dg)
        { return dg.CurrentRow.Index.ToString(); }

        private bool TextChecking()
        {
            bool temp = true;

            if (txtIDAnggota.Text == "")
            {
                errorProvider1.SetError(txtIDAnggota, "Masukkan ID Anggota!");
                txtIDAnggota.Focus();
                temp = false;
            }
            if (txtNamaLengkap.Text == "")
            {
                errorProvider1.SetError(txtNamaLengkap, "Masukkan Nama Lengkap!");
                txtNamaLengkap.Focus();
                temp = false;
            }
            if (txtNamaPanggilan.Text == "")
            {
                errorProvider1.SetError(txtNamaPanggilan, "Masukkan Nama Panggilan!");
                txtNamaPanggilan.Focus();
                temp = false;
            }
            if (txtNoBuku.Text == "")
            {
                errorProvider1.SetError(txtNoBuku, "Masukkan No. Buku!");
                txtNoBuku.Focus();
                temp = false;
            }
            if (txtNoIdentitas.Text == "")
            {
                errorProvider1.SetError(txtNoIdentitas, "Masukkan No. Identitas!");
                txtNoIdentitas.Focus();
                temp = false;
            }
            if (txtPekerjaan.Text == "")
            {
                errorProvider1.SetError(txtPekerjaan, "Masukkan Pekerjaan!");
                txtPekerjaan.Focus();
                temp = false;
            }
            if (txtTempatBekerja.Text == "")
            {
                errorProvider1.SetError(txtTempatBekerja, "Masukkan Tempat Bekerja!");
                txtTempatBekerja.Focus();
                temp = false;
            }
            if (txtTempatLahir.Text == "")
            {
                errorProvider1.SetError(txtTempatLahir, "Masukkan Tempat Lahir!");
                txtTempatLahir.Focus();
                temp = false;
            }
            if (txtAlamatKerja.Text == "")
            {
                errorProvider1.SetError(txtAlamatKerja, "Masukkan Alamat Kerja!");
                txtAlamatKerja.Focus();
                temp = false;
            }
            if (txtAlamatLengkap.Text == "")
            {
                errorProvider1.SetError(txtAlamatLengkap, "Masukkan Alamat Lengkap");
                txtAlamatLengkap.Focus();
                temp = false;
            }
            if (txtHPTelp.Text == "")
            {
                errorProvider1.SetError(txtHPTelp, "Masukkan No. HP / Telpon");
                txtHPTelp.Focus();
                temp = false;
            }
            if (cmbAgama.Text == "")
            {
                errorProvider1.SetError(cmbAgama, "Pilih Agama!");
                cmbAgama.Focus();
                temp = false;
            }
            if (cmbJenisAnggota.Text == "")
            {
                errorProvider1.SetError(cmbJenisAnggota, "Pilih Jenis Anggota!");
                cmbJenisAnggota.Focus();
                temp = false;
            }
            if (cmbJenisIdentitas.Text == "")
            {
                errorProvider1.SetError(cmbJenisIdentitas, "Pilih Jenis Identitas!");
                cmbJenisIdentitas.Focus();
                temp = false;
            }
            if (cmbJenisKelamin.Text == "")
            {
                errorProvider1.SetError(cmbJenisKelamin, "Pilih Jenis Kelamin!");
                cmbJenisKelamin.Focus();
                temp = false;
            }
            if (cmbPendidikan.Text == "")
            {
                errorProvider1.SetError(cmbPendidikan, "Pilih Pendidikan!");
                cmbPendidikan.Focus();
                temp = false;
            }
            if (cmbStatusPerkawinan.Text == "")
            {
                errorProvider1.SetError(cmbStatusPerkawinan, "Pilih Status Perkawinan!");
                cmbStatusPerkawinan.Focus();
                temp = false;
            }

            return temp;
        }
        private void TextClear()
        {
            txtIDAnggota.Clear();
            txtNamaLengkap.Clear();
            txtNamaPanggilan.Clear();
            txtNoBuku.Clear();
            txtNoIdentitas.Clear();
            txtPekerjaan.Clear();
            txtTempatBekerja.Clear();
            txtTempatLahir.Clear();
            cmbAgama.SelectedIndex = -1;
            txtAlamatKerja.Clear();
            txtAlamatLengkap.Clear();
            txtHPTelp.Clear();
            cmbJenisAnggota.SelectedIndex = -1;
            cmbJenisIdentitas.SelectedIndex = -1;
            cmbJenisKelamin.SelectedIndex = -1;
            cmbPendidikan.SelectedIndex = -1;
            cmbStatusPerkawinan.SelectedIndex = -1;
        }

        string temp_id_anggota = "";
        private void setValueTextBox(string id_anggota, string nama_lengkap, string nama_panggilan,
                    string jenis_id, string no_id, string jenis_kel, string stat_kawin, string tempat_lahir, string tanggal_lahir,
                    string agama, string alamat_lengkap, string telepon, string pendidikan, string pekerjaan, string tempat_kerja,
                    string alamat_kerja, string jenis_anggota, string no_buku)
        {
            temp_id_anggota = id_anggota;
            txtIDAnggota.Text = id_anggota;
            txtNamaLengkap.Text = nama_lengkap;
            txtNamaPanggilan.Text = nama_panggilan;
            cmbJenisIdentitas.Text = jenis_id;
            txtNoIdentitas.Text = no_id;
            cmbJenisKelamin.Text = jenis_kel;
            cmbStatusPerkawinan.Text = stat_kawin;
            txtTempatLahir.Text = tempat_lahir;
            dtTanggalLahir.Text = tanggal_lahir;
            cmbAgama.Text = agama;
            txtAlamatLengkap.Text = alamat_lengkap;
            txtHPTelp.Text = telepon;
            cmbPendidikan.Text = pendidikan;
            txtPekerjaan.Text = pekerjaan;
            txtTempatBekerja.Text = tempat_kerja;
            txtAlamatKerja.Text = alamat_kerja;
            cmbJenisAnggota.Text = jenis_anggota;
            txtNoBuku.Text = no_buku;
        }
        private void SetUpdateForm()
        {
            SetEnableForm();
            string id_anggota = getKolom(datagridviewAnggota, 0);
            string nama_lengkap = getKolom(datagridviewAnggota, 1);
            string nama_panggilan = getKolom(datagridviewAnggota, 2);
            string jenis_id = getKolom(datagridviewAnggota, 3);
            string no_id = getKolom(datagridviewAnggota, 4);
            string jenis_kel = getKolom(datagridviewAnggota, 5);
            string stat_kawin = getKolom(datagridviewAnggota, 6);
            string tempat_lahir = getKolom(datagridviewAnggota, 7);
            string tanggal_lahir = getKolom(datagridviewAnggota, 8);
            string agama = getKolom(datagridviewAnggota, 9);
            string alamat_lengkap = getKolom(datagridviewAnggota, 10);
            string telepon = getKolom(datagridviewAnggota, 11);
            string pendidikan = getKolom(datagridviewAnggota, 12);
            string pekerjaan = getKolom(datagridviewAnggota, 13);
            string tempat_kerja = getKolom(datagridviewAnggota, 14);
            string alamat_kerja = getKolom(datagridviewAnggota, 15);
            string jenis_anggota = getKolom(datagridviewAnggota, 16);
            string no_buku = getKolom(datagridviewAnggota, 17);

            setValueTextBox(id_anggota, nama_lengkap, nama_panggilan,
                jenis_id, no_id, jenis_kel, stat_kawin, tempat_lahir, tanggal_lahir,
                agama, alamat_lengkap, telepon, pendidikan, pekerjaan, tempat_kerja,
                alamat_kerja, jenis_anggota, no_buku);
            txtRow.Clear(); txtID.Clear();
        }
        private void SetDisableForm()
        {
            txtIDAnggota.Enabled = false;
            cmbJenisAnggota.Enabled = false;
            txtNoBuku.Enabled = false;
            gbDataDiri.Enabled = false;
            //btnBatal.Enabled = false;
            //btnSimpan.Enabled = false;

            btnTambah.Enabled = true;
            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;
            btnKlaim.Enabled = true;
            btnRefresh.Enabled = true;

            datagridviewAnggota.Enabled = true;

            txtSearch.Enabled = true;
            cmbFilterAnggota.Enabled = true;

            RefreshDatagridview();
            // (datagridviewAnggota.RowCount > 0)
            //
                /* Mencegah error jika data yg dihapus tinggal 1 */
            //    datagridviewAnggota.Rows[0].Selected = true;
            //    txtID.Text = getKolom(datagridviewAnggota, 0);
                //temp_id_anggota.Text = getKolom(datagridviewAnggota, 0);
            //}
            
        }
        private void SetEnableForm()
        {
            txtIDAnggota.Enabled = true;
            cmbJenisAnggota.Enabled = true;
            txtNoBuku.Enabled = true;
            btnBatal.Enabled = true;
            btnSimpan.Enabled = true;

            btnTambah.Enabled = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            btnKlaim.Enabled = false;
            btnRefresh.Enabled = false;

            datagridviewAnggota.Enabled = false;

            txtSearch.Enabled = false;
            cmbFilterAnggota.Enabled = false;
        }
        private void LoadCmbJenisAnggota()
        {
            DataTable dtJenisAnggota = new DataTable();
            MySqlDataAdapter adapterJenisAnggota = ac.GetJenisAnggota();
            adapterJenisAnggota.Fill(dtJenisAnggota);
            cmbJenisAnggota.DataSource = dtJenisAnggota;
            cmbJenisAnggota.DisplayMember = "jenis_anggota";
            cmbJenisAnggota.ValueMember = "id_jenis";
        }
        private void LoadCmbFilterJenisAnggota()
        {
            DataTable dtJenisAnggota = new DataTable();
            MySqlDataAdapter adapterJenisAnggota = ac.GetJenisAnggota();
            adapterJenisAnggota.Fill(dtJenisAnggota);
            cmbFilterAnggota.DataSource = dtJenisAnggota;
            cmbFilterAnggota.DisplayMember = "jenis_anggota";
            cmbFilterAnggota.ValueMember = "id_jenis";
        }
        private void LoadCmbPendidikan()
        {
            DataTable dtPendidikan = new DataTable();
            MySqlDataAdapter adapterPendidikan = ac.GetPendidikan();
            adapterPendidikan.Fill(dtPendidikan);
            cmbPendidikan.DataSource = dtPendidikan;
            cmbPendidikan.DisplayMember = "pendidikan";
        }
        private void LoadCmbAgama()
        {
            DataTable dtAgama = new DataTable();
            MySqlDataAdapter adapterAgama = ac.GetAgama();
            adapterAgama.Fill(dtAgama);
            cmbAgama.DataSource = dtAgama;
            cmbAgama.DisplayMember = "agama";
        }
        private void LoadCmbStatusPerkawinan()
        {
            DataTable dtStatusPerkawinan = new DataTable();
            MySqlDataAdapter adapterStatPerkawinan = ac.GetStatusPerkawinan();
            adapterStatPerkawinan.Fill(dtStatusPerkawinan);
            cmbStatusPerkawinan.DataSource = dtStatusPerkawinan;
            cmbStatusPerkawinan.DisplayMember = "status_perkawinan";
        }
        private void LoadCmbJenisKelamin()
        {
            DataTable dtJenisKelamin = new DataTable();
            MySqlDataAdapter adapterJenisKelamin = ac.GetJenisKelamin();
            adapterJenisKelamin.Fill(dtJenisKelamin);
            cmbJenisKelamin.DataSource = dtJenisKelamin;
            cmbJenisKelamin.DisplayMember = "Jenis_kelamin";
        }
        private void LoadCmbJenisIdentitas()
        {
            DataTable dtJenisIdentitas = new DataTable();
            MySqlDataAdapter adapterJenisID = ac.GetJenisIdentitas();
            adapterJenisID.Fill(dtJenisIdentitas);
            cmbJenisIdentitas.DataSource = dtJenisIdentitas;
            cmbJenisIdentitas.DisplayMember = "jenis_identitas";
        }

        /* Datagridview method */
        private void SetHeaderDatagridview(DataGridView dg)
        {
            foreach (DataGridViewColumn col in dg.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            datagridviewAnggota.Columns[0].HeaderText = "ID Anggota";
            datagridviewAnggota.Columns[1].HeaderText = "Nama Lengkap";
            datagridviewAnggota.Columns[2].HeaderText = "Nama Panggilan";
            datagridviewAnggota.Columns[3].HeaderText = "Jenis Identitas";
            datagridviewAnggota.Columns[4].HeaderText = "No. Identitas";
            datagridviewAnggota.Columns[5].HeaderText = "Jenis Kelamin";
            datagridviewAnggota.Columns[6].HeaderText = "Status Perkawinan";
            datagridviewAnggota.Columns[7].HeaderText = "Tempat Lahir";
            datagridviewAnggota.Columns[8].HeaderText = "Tanggal Lahir";
            datagridviewAnggota.Columns[9].HeaderText = "Agama";
            datagridviewAnggota.Columns[10].HeaderText = "Alamat Lengkap";
            datagridviewAnggota.Columns[11].HeaderText = "Telepon";
            datagridviewAnggota.Columns[12].HeaderText = "Pendidikan";
            datagridviewAnggota.Columns[13].HeaderText = "Pekerjaan";
            datagridviewAnggota.Columns[14].HeaderText = "Tempat Bekerja";
            datagridviewAnggota.Columns[15].HeaderText = "Alamat Pekerjaan";
            datagridviewAnggota.Columns[16].HeaderText = "Jenis Anggota";
            datagridviewAnggota.Columns[17].HeaderText = "No. Buku";
        }
        private void SetDatagridviewAnggota(DataGridView dg)
        {
            dt.Clear();
            MySqlDataAdapter adapterAnggota = ac.ShowAnggota();
            adapterAnggota.Fill(dt);
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

            datagridviewAnggota.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            SetHeaderDatagridview(dg);
        }
        private void SearchDatagridview(DataGridView dg, string id_anggota)
        {
            DataTable dtSearch = new DataTable();
            MySqlDataAdapter adapterSearch = ac.SearchAnggota(id_anggota);
            adapterSearch.Fill(dtSearch);
            dg.DataSource = dtSearch;

            /* Code data binding / paging */
            DataTable dtBinding = dtSearch;
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
                    if (counter == 15) /* 1 page 20 data */
                    { counter = 0; }
                }
            }
            bindingSource1.DataSource = ListTbl;
            bindingNavigator1.BindingSource = bindingSource1;

            datagridviewAnggota.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            SetHeaderDatagridview(dg);
            dg.DataSource = (dtBinding.Rows.Count > 0 ? ListTbl[bindingSource1.Position] : dtBinding);
        }
        private void FilterDatagridview(DataGridView dg, string jenis_anggota)
        {
            DataTable dtFilter = new DataTable();
            MySqlDataAdapter adapterFilter = ac.FilterAnggotaByJenis(jenis_anggota);
            adapterFilter.Fill(dtFilter);
            dg.DataSource = dtFilter;

            /* Code data binding / paging */
            DataTable dtBinding = dtFilter;
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
                    if (counter == 20) /* 1 page 20 data */
                    { counter = 0; }
                }
            }
            bindingSource1.DataSource = ListTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            dg.DataSource = (dtBinding.Rows.Count > 0 ? ListTbl[bindingSource1.Position] : dtBinding);

            datagridviewAnggota.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            SetHeaderDatagridview(dg);

        }
        private void RefreshDatagridview()
        { SetDatagridviewAnggota(datagridviewAnggota); }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtRow.Visible = false; txtID.Visible = false;
            gbDataDiri.Enabled = false;
            SetDisableForm();

            LoadCmbJenisAnggota();
            LoadCmbFilterJenisAnggota();
            LoadCmbPendidikan();
            LoadCmbAgama();
            LoadCmbStatusPerkawinan();
            LoadCmbJenisKelamin();
            LoadCmbJenisIdentitas();

            SetDatagridviewAnggota(this.datagridviewAnggota);
        }

        private void SetDisable()
        {
            gbDataDiri.Enabled = false;
            gbPendidikan.Enabled = false;
            btnTambah.Enabled = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            gbDataDiri.Enabled = true;
            SetFlag(1);
            SetEnableForm();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gbDataDiri.Enabled = true;
            SetFlag(2);
            SetEnableForm();
            SetUpdateForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Error: Silahkan pilih data anggota yang akan dihapus!", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    datagridviewAnggota.Focus();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Apakah data dengan ID anggota : " + getKolom(datagridviewAnggota, 0) + "?",
                        "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        ac.DeleteAnggota(txtID.Text);
                    }
                    txtID.Clear();
                    this.SetDisableForm();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Kesalahan: " + ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshDatagridview();
        }

        private void btnKlaim_Click(object sender, EventArgs e)
        {
            string id_anggota = getKolom(datagridviewAnggota, 0);
            string no_buku = getKolom(datagridviewAnggota, 17);
            string nama_lengkap = getKolom(datagridviewAnggota, 1);
            string no_telp = getKolom(datagridviewAnggota, 11);
            string pekerjaan = getKolom(datagridviewAnggota, 13);
            string alamat_lengkap = getKolom(datagridviewAnggota, 10);
            
            FormKlaim fk = new FormKlaim();
            fk.SetFlag(1);
            fk.SetEnable();
            fk.setTextbox(id_anggota, no_buku, nama_lengkap, no_telp, pekerjaan, alamat_lengkap);
            fk.ShowDialog();
            txtRow.Clear();
            txtID.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id_anggota = txtIDAnggota.Text;
            string nama_lengkap = txtNamaLengkap.Text;
            string nama_panggilan = txtNamaPanggilan.Text;
            string no_buku = txtNoBuku.Text;
            string jenis_anggota = cmbJenisAnggota.Text;
            string alamat_pekerjaan = txtAlamatKerja.Text;
            string tempat_bekerja = txtTempatBekerja.Text;
            string pekerjaan = txtPekerjaan.Text;
            string pendidikan = cmbPendidikan.Text;
            string telepon = txtHPTelp.Text;
            string alamat_lengkap = txtAlamatLengkap.Text;
            string agama = cmbAgama.Text;
            string tempat_lahir = txtTempatLahir.Text;
            string status_perkawinan = cmbStatusPerkawinan.Text;
            string jenis_kelamin = cmbJenisKelamin.Text;
            string no_identitas = txtNoIdentitas.Text;
            string jenis_identitas = cmbJenisIdentitas.Text;
            string tanggal_lahir = dtTanggalLahir.Text;

            if (flagPerintah == 1)
            {
                if (TextChecking() == true)
                {
                    errorProvider1.Clear();
                    Anggota A = new Anggota(id_anggota, nama_lengkap, nama_panggilan, jenis_identitas,
                                no_identitas, jenis_kelamin, status_perkawinan, tempat_lahir, DateTime.Parse(tanggal_lahir),
                                agama, alamat_lengkap, telepon, pendidikan, pekerjaan, tempat_bekerja, alamat_pekerjaan,
                                jenis_anggota, no_buku);
                    ac.InsertAnggota(A);
                    DialogResult dr = MessageBox.Show("Data anggota dengan ID Anggota: " + txtIDAnggota.Text + " berhasil ditambahkan!",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        TextClear();
                        FormMain mf = new FormMain();
                        mf.Refresh();
                        SetDisableForm();
                    }
                }
            }
            else
            {
                if (TextChecking() == true)
                {
                    errorProvider1.Clear();
                    Anggota A = new Anggota(id_anggota, nama_lengkap, nama_panggilan, jenis_identitas,
                        no_identitas, jenis_kelamin, status_perkawinan, tempat_lahir, DateTime.Parse(tanggal_lahir),
                        agama, alamat_lengkap, telepon, pendidikan, pekerjaan, tempat_bekerja, alamat_pekerjaan,
                        jenis_anggota, no_buku);

                    DialogResult dr = MessageBox.Show("Apakah Anda akan mengubah data anggota dengan ID Anggota: " + txtIDAnggota.Text, "Peringatan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        ac.UpdateAnggota(A, txtIDAnggota.Text);
                        MessageBox.Show("Data anggota dengan ID Anggota: " + txtIDAnggota.Text + " berhasil diubah!",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextClear();
                        FormMain mf = new FormMain();
                        mf.Refresh();
                        SetDisableForm();
                    }
                }
            }
            //RefreshDatagridview();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            gbDataDiri.Enabled = false;
            gbProses.Enabled = true;
            TextClear();
            errorProvider1.Clear();
            SetDisableForm();
            RefreshDatagridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDatagridview();
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.SearchDatagridview(datagridviewAnggota, this.txtSearch.Text);
            if (txtSearch.Text == "")
            { this.SetDatagridviewAnggota(datagridviewAnggota); }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Restart(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void dataAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        { RefreshDatagridview(); }

        private void cmbFilterAnggota_SelectedIndexChanged(object sender, EventArgs e)
        { FilterDatagridview(datagridviewAnggota, cmbFilterAnggota.Text); }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDatagridview(datagridviewAnggota, txtSearch.Text);
        }

        private void laporanDataAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportAnggota fra = new FormReportAnggota();
            fra.ShowDialog();
        }

        private void laporanDataKlaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportKlaim frk = new FormReportKlaim();
            frk.ShowDialog();
        }

        private void dgAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(datagridviewAnggota, 0);
            txtRow.Text = getRow(datagridviewAnggota);
        }

        private void dgAnggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(datagridviewAnggota, 0);
            txtRow.Text = getRow(datagridviewAnggota);
        }

        private void dgAnggota_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(datagridviewAnggota, 0);
            txtRow.Text = getRow(datagridviewAnggota);
        }

        private void dataKlaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKlaim fk = new FormKlaim();
            fk.ShowDialog();
        }
    }
}
