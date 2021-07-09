namespace CUBonaventura.UI
{
    partial class FormKlaim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKlaim));
            this.cmbJenisKlaim = new MetroFramework.Controls.MetroComboBox();
            this.txtKodeKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtAlamatLengkap = new MetroFramework.Controls.MetroTextBox();
            this.txtPekerjaan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.btnSimpan = new MetroFramework.Controls.MetroButton();
            this.dtMeninggalKlaim = new MetroFramework.Controls.MetroDateTime();
            this.lblTglMeninggal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtLamaRawatKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtRSKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtSakitKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtNoHPKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtAlamatLengkapKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbJenisKelaminKlaim = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPekerjaanKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtNoBukuKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtTanggalLahirKlaim = new MetroFramework.Controls.MetroDateTime();
            this.txtTempatLahirKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNamaLengkapKlaim = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNoTelp = new MetroFramework.Controls.MetroTextBox();
            this.txtNamaLengkap = new MetroFramework.Controls.MetroTextBox();
            this.txtNoBuku = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.datagridviewKlaim = new System.Windows.Forms.DataGridView();
            this.gbProses = new System.Windows.Forms.GroupBox();
            this.btnCetak = new MetroFramework.Controls.MetroButton();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtIDAnggota = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tempRow = new MetroFramework.Controls.MetroTextBox();
            this.tempID = new MetroFramework.Controls.MetroTextBox();
            this.btnBatal = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewKlaim)).BeginInit();
            this.gbProses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJenisKlaim
            // 
            this.cmbJenisKlaim.FormattingEnabled = true;
            this.cmbJenisKlaim.ItemHeight = 23;
            this.cmbJenisKlaim.Location = new System.Drawing.Point(224, 208);
            this.cmbJenisKlaim.Name = "cmbJenisKlaim";
            this.cmbJenisKlaim.Size = new System.Drawing.Size(157, 29);
            this.cmbJenisKlaim.TabIndex = 2;
            this.cmbJenisKlaim.UseSelectable = true;
            this.cmbJenisKlaim.SelectedIndexChanged += new System.EventHandler(this.cmbJenisKlaim_SelectedIndexChanged);
            // 
            // txtKodeKlaim
            // 
            // 
            // 
            // 
            this.txtKodeKlaim.CustomButton.Image = null;
            this.txtKodeKlaim.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtKodeKlaim.CustomButton.Name = "";
            this.txtKodeKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtKodeKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKodeKlaim.CustomButton.TabIndex = 1;
            this.txtKodeKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKodeKlaim.CustomButton.UseSelectable = true;
            this.txtKodeKlaim.CustomButton.Visible = false;
            this.txtKodeKlaim.Lines = new string[0];
            this.txtKodeKlaim.Location = new System.Drawing.Point(141, 75);
            this.txtKodeKlaim.MaxLength = 32767;
            this.txtKodeKlaim.Name = "txtKodeKlaim";
            this.txtKodeKlaim.PasswordChar = '\0';
            this.txtKodeKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKodeKlaim.SelectedText = "";
            this.txtKodeKlaim.SelectionLength = 0;
            this.txtKodeKlaim.SelectionStart = 0;
            this.txtKodeKlaim.ShortcutsEnabled = true;
            this.txtKodeKlaim.Size = new System.Drawing.Size(183, 25);
            this.txtKodeKlaim.TabIndex = 1;
            this.txtKodeKlaim.UseSelectable = true;
            this.txtKodeKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKodeKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(28, 75);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(75, 19);
            this.metroLabel18.TabIndex = 84;
            this.metroLabel18.Text = "Kode Klaim";
            // 
            // txtAlamatLengkap
            // 
            // 
            // 
            // 
            this.txtAlamatLengkap.CustomButton.Image = null;
            this.txtAlamatLengkap.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtAlamatLengkap.CustomButton.Name = "";
            this.txtAlamatLengkap.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtAlamatLengkap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlamatLengkap.CustomButton.TabIndex = 1;
            this.txtAlamatLengkap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlamatLengkap.CustomButton.UseSelectable = true;
            this.txtAlamatLengkap.CustomButton.Visible = false;
            this.txtAlamatLengkap.Enabled = false;
            this.txtAlamatLengkap.Lines = new string[0];
            this.txtAlamatLengkap.Location = new System.Drawing.Point(475, 137);
            this.txtAlamatLengkap.MaxLength = 32767;
            this.txtAlamatLengkap.Name = "txtAlamatLengkap";
            this.txtAlamatLengkap.PasswordChar = '\0';
            this.txtAlamatLengkap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlamatLengkap.SelectedText = "";
            this.txtAlamatLengkap.SelectionLength = 0;
            this.txtAlamatLengkap.SelectionStart = 0;
            this.txtAlamatLengkap.ShortcutsEnabled = true;
            this.txtAlamatLengkap.Size = new System.Drawing.Size(183, 59);
            this.txtAlamatLengkap.TabIndex = 83;
            this.txtAlamatLengkap.TabStop = false;
            this.txtAlamatLengkap.UseSelectable = true;
            this.txtAlamatLengkap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlamatLengkap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPekerjaan
            // 
            // 
            // 
            // 
            this.txtPekerjaan.CustomButton.Image = null;
            this.txtPekerjaan.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtPekerjaan.CustomButton.Name = "";
            this.txtPekerjaan.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPekerjaan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPekerjaan.CustomButton.TabIndex = 1;
            this.txtPekerjaan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPekerjaan.CustomButton.UseSelectable = true;
            this.txtPekerjaan.CustomButton.Visible = false;
            this.txtPekerjaan.Enabled = false;
            this.txtPekerjaan.Lines = new string[0];
            this.txtPekerjaan.Location = new System.Drawing.Point(475, 106);
            this.txtPekerjaan.MaxLength = 32767;
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.PasswordChar = '\0';
            this.txtPekerjaan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPekerjaan.SelectedText = "";
            this.txtPekerjaan.SelectionLength = 0;
            this.txtPekerjaan.SelectionStart = 0;
            this.txtPekerjaan.ShortcutsEnabled = true;
            this.txtPekerjaan.Size = new System.Drawing.Size(183, 25);
            this.txtPekerjaan.TabIndex = 82;
            this.txtPekerjaan.TabStop = false;
            this.txtPekerjaan.UseSelectable = true;
            this.txtPekerjaan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPekerjaan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(362, 137);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(104, 19);
            this.metroLabel19.TabIndex = 81;
            this.metroLabel19.Text = "Alamat Lengkap";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(362, 106);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(65, 19);
            this.metroLabel20.TabIndex = 80;
            this.metroLabel20.Text = "Pekerjaan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(511, 494);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 25);
            this.btnSimpan.TabIndex = 78;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dtMeninggalKlaim
            // 
            this.dtMeninggalKlaim.CustomFormat = "  ";
            this.dtMeninggalKlaim.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtMeninggalKlaim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMeninggalKlaim.Location = new System.Drawing.Point(503, 435);
            this.dtMeninggalKlaim.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtMeninggalKlaim.Name = "dtMeninggalKlaim";
            this.dtMeninggalKlaim.Size = new System.Drawing.Size(183, 25);
            this.dtMeninggalKlaim.TabIndex = 14;
            this.dtMeninggalKlaim.Value = new System.DateTime(2019, 5, 29, 0, 0, 0, 0);
            this.dtMeninggalKlaim.ValueChanged += new System.EventHandler(this.dtMeninggalKlaim_ValueChanged);
            this.dtMeninggalKlaim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtMeninggalKlaim_KeyDown);
            // 
            // lblTglMeninggal
            // 
            this.lblTglMeninggal.AutoSize = true;
            this.lblTglMeninggal.Location = new System.Drawing.Point(374, 435);
            this.lblTglMeninggal.Name = "lblTglMeninggal";
            this.lblTglMeninggal.Size = new System.Drawing.Size(120, 19);
            this.lblTglMeninggal.TabIndex = 76;
            this.lblTglMeninggal.Text = "Tanggal Meninggal";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(587, 405);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(31, 19);
            this.metroLabel16.TabIndex = 75;
            this.metroLabel16.Text = "hari";
            // 
            // txtLamaRawatKlaim
            // 
            // 
            // 
            // 
            this.txtLamaRawatKlaim.CustomButton.Image = null;
            this.txtLamaRawatKlaim.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txtLamaRawatKlaim.CustomButton.Name = "";
            this.txtLamaRawatKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLamaRawatKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLamaRawatKlaim.CustomButton.TabIndex = 1;
            this.txtLamaRawatKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLamaRawatKlaim.CustomButton.UseSelectable = true;
            this.txtLamaRawatKlaim.CustomButton.Visible = false;
            this.txtLamaRawatKlaim.Lines = new string[0];
            this.txtLamaRawatKlaim.Location = new System.Drawing.Point(503, 405);
            this.txtLamaRawatKlaim.MaxLength = 32767;
            this.txtLamaRawatKlaim.Name = "txtLamaRawatKlaim";
            this.txtLamaRawatKlaim.PasswordChar = '\0';
            this.txtLamaRawatKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLamaRawatKlaim.SelectedText = "";
            this.txtLamaRawatKlaim.SelectionLength = 0;
            this.txtLamaRawatKlaim.SelectionStart = 0;
            this.txtLamaRawatKlaim.ShortcutsEnabled = true;
            this.txtLamaRawatKlaim.Size = new System.Drawing.Size(73, 25);
            this.txtLamaRawatKlaim.TabIndex = 13;
            this.txtLamaRawatKlaim.UseSelectable = true;
            this.txtLamaRawatKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLamaRawatKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(374, 405);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(109, 19);
            this.metroLabel15.TabIndex = 73;
            this.metroLabel15.Text = "Lama Rawat Inap";
            // 
            // txtRSKlaim
            // 
            // 
            // 
            // 
            this.txtRSKlaim.CustomButton.Image = null;
            this.txtRSKlaim.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtRSKlaim.CustomButton.Name = "";
            this.txtRSKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRSKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRSKlaim.CustomButton.TabIndex = 1;
            this.txtRSKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRSKlaim.CustomButton.UseSelectable = true;
            this.txtRSKlaim.CustomButton.Visible = false;
            this.txtRSKlaim.Lines = new string[0];
            this.txtRSKlaim.Location = new System.Drawing.Point(526, 374);
            this.txtRSKlaim.MaxLength = 32767;
            this.txtRSKlaim.Name = "txtRSKlaim";
            this.txtRSKlaim.PasswordChar = '\0';
            this.txtRSKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRSKlaim.SelectedText = "";
            this.txtRSKlaim.SelectionLength = 0;
            this.txtRSKlaim.SelectionStart = 0;
            this.txtRSKlaim.ShortcutsEnabled = true;
            this.txtRSKlaim.Size = new System.Drawing.Size(160, 25);
            this.txtRSKlaim.TabIndex = 12;
            this.txtRSKlaim.UseSelectable = true;
            this.txtRSKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRSKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(374, 374);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(142, 19);
            this.metroLabel14.TabIndex = 71;
            this.metroLabel14.Text = "RS. Tempat Rawat Inap";
            // 
            // txtSakitKlaim
            // 
            // 
            // 
            // 
            this.txtSakitKlaim.CustomButton.Image = null;
            this.txtSakitKlaim.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtSakitKlaim.CustomButton.Name = "";
            this.txtSakitKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSakitKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSakitKlaim.CustomButton.TabIndex = 1;
            this.txtSakitKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSakitKlaim.CustomButton.UseSelectable = true;
            this.txtSakitKlaim.CustomButton.Visible = false;
            this.txtSakitKlaim.Lines = new string[0];
            this.txtSakitKlaim.Location = new System.Drawing.Point(503, 343);
            this.txtSakitKlaim.MaxLength = 32767;
            this.txtSakitKlaim.Name = "txtSakitKlaim";
            this.txtSakitKlaim.PasswordChar = '\0';
            this.txtSakitKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSakitKlaim.SelectedText = "";
            this.txtSakitKlaim.SelectionLength = 0;
            this.txtSakitKlaim.SelectionStart = 0;
            this.txtSakitKlaim.ShortcutsEnabled = true;
            this.txtSakitKlaim.Size = new System.Drawing.Size(183, 25);
            this.txtSakitKlaim.TabIndex = 11;
            this.txtSakitKlaim.UseSelectable = true;
            this.txtSakitKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSakitKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(374, 343);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(117, 19);
            this.metroLabel13.TabIndex = 69;
            this.metroLabel13.Text = "Sakit yang diderita";
            // 
            // txtNoHPKlaim
            // 
            // 
            // 
            // 
            this.txtNoHPKlaim.CustomButton.Image = null;
            this.txtNoHPKlaim.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNoHPKlaim.CustomButton.Name = "";
            this.txtNoHPKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNoHPKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoHPKlaim.CustomButton.TabIndex = 1;
            this.txtNoHPKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoHPKlaim.CustomButton.UseSelectable = true;
            this.txtNoHPKlaim.CustomButton.Visible = false;
            this.txtNoHPKlaim.Lines = new string[0];
            this.txtNoHPKlaim.Location = new System.Drawing.Point(159, 435);
            this.txtNoHPKlaim.MaxLength = 32767;
            this.txtNoHPKlaim.Name = "txtNoHPKlaim";
            this.txtNoHPKlaim.PasswordChar = '\0';
            this.txtNoHPKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoHPKlaim.SelectedText = "";
            this.txtNoHPKlaim.SelectionLength = 0;
            this.txtNoHPKlaim.SelectionStart = 0;
            this.txtNoHPKlaim.ShortcutsEnabled = true;
            this.txtNoHPKlaim.Size = new System.Drawing.Size(183, 25);
            this.txtNoHPKlaim.TabIndex = 8;
            this.txtNoHPKlaim.UseSelectable = true;
            this.txtNoHPKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoHPKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(46, 435);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(90, 19);
            this.metroLabel12.TabIndex = 67;
            this.metroLabel12.Text = "No. Telp. / HP";
            // 
            // txtAlamatLengkapKlaim
            // 
            // 
            // 
            // 
            this.txtAlamatLengkapKlaim.CustomButton.Image = null;
            this.txtAlamatLengkapKlaim.CustomButton.Location = new System.Drawing.Point(99, 2);
            this.txtAlamatLengkapKlaim.CustomButton.Name = "";
            this.txtAlamatLengkapKlaim.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.txtAlamatLengkapKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlamatLengkapKlaim.CustomButton.TabIndex = 1;
            this.txtAlamatLengkapKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlamatLengkapKlaim.CustomButton.UseSelectable = true;
            this.txtAlamatLengkapKlaim.CustomButton.Visible = false;
            this.txtAlamatLengkapKlaim.Lines = new string[0];
            this.txtAlamatLengkapKlaim.Location = new System.Drawing.Point(159, 343);
            this.txtAlamatLengkapKlaim.MaxLength = 32767;
            this.txtAlamatLengkapKlaim.Name = "txtAlamatLengkapKlaim";
            this.txtAlamatLengkapKlaim.PasswordChar = '\0';
            this.txtAlamatLengkapKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlamatLengkapKlaim.SelectedText = "";
            this.txtAlamatLengkapKlaim.SelectionLength = 0;
            this.txtAlamatLengkapKlaim.SelectionStart = 0;
            this.txtAlamatLengkapKlaim.ShortcutsEnabled = true;
            this.txtAlamatLengkapKlaim.Size = new System.Drawing.Size(183, 86);
            this.txtAlamatLengkapKlaim.TabIndex = 7;
            this.txtAlamatLengkapKlaim.UseSelectable = true;
            this.txtAlamatLengkapKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlamatLengkapKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(46, 343);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(104, 19);
            this.metroLabel11.TabIndex = 65;
            this.metroLabel11.Text = "Alamat Lengkap";
            // 
            // cmbJenisKelaminKlaim
            // 
            this.cmbJenisKelaminKlaim.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbJenisKelaminKlaim.FormattingEnabled = true;
            this.cmbJenisKelaminKlaim.ItemHeight = 19;
            this.cmbJenisKelaminKlaim.Location = new System.Drawing.Point(592, 277);
            this.cmbJenisKelaminKlaim.Name = "cmbJenisKelaminKlaim";
            this.cmbJenisKelaminKlaim.Size = new System.Drawing.Size(94, 25);
            this.cmbJenisKelaminKlaim.TabIndex = 10;
            this.cmbJenisKelaminKlaim.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(495, 280);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(86, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "Jenis Kelamin";
            // 
            // txtPekerjaanKlaim
            // 
            // 
            // 
            // 
            this.txtPekerjaanKlaim.CustomButton.Image = null;
            this.txtPekerjaanKlaim.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtPekerjaanKlaim.CustomButton.Name = "";
            this.txtPekerjaanKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPekerjaanKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPekerjaanKlaim.CustomButton.TabIndex = 1;
            this.txtPekerjaanKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPekerjaanKlaim.CustomButton.UseSelectable = true;
            this.txtPekerjaanKlaim.CustomButton.Visible = false;
            this.txtPekerjaanKlaim.Lines = new string[0];
            this.txtPekerjaanKlaim.Location = new System.Drawing.Point(159, 312);
            this.txtPekerjaanKlaim.MaxLength = 32767;
            this.txtPekerjaanKlaim.Name = "txtPekerjaanKlaim";
            this.txtPekerjaanKlaim.PasswordChar = '\0';
            this.txtPekerjaanKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPekerjaanKlaim.SelectedText = "";
            this.txtPekerjaanKlaim.SelectionLength = 0;
            this.txtPekerjaanKlaim.SelectionStart = 0;
            this.txtPekerjaanKlaim.ShortcutsEnabled = true;
            this.txtPekerjaanKlaim.Size = new System.Drawing.Size(183, 25);
            this.txtPekerjaanKlaim.TabIndex = 6;
            this.txtPekerjaanKlaim.UseSelectable = true;
            this.txtPekerjaanKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPekerjaanKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(46, 312);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 61;
            this.metroLabel9.Text = "Pekerjaan";
            // 
            // txtNoBukuKlaim
            // 
            // 
            // 
            // 
            this.txtNoBukuKlaim.CustomButton.Image = null;
            this.txtNoBukuKlaim.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtNoBukuKlaim.CustomButton.Name = "";
            this.txtNoBukuKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNoBukuKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoBukuKlaim.CustomButton.TabIndex = 1;
            this.txtNoBukuKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoBukuKlaim.CustomButton.UseSelectable = true;
            this.txtNoBukuKlaim.CustomButton.Visible = false;
            this.txtNoBukuKlaim.Lines = new string[0];
            this.txtNoBukuKlaim.Location = new System.Drawing.Point(449, 246);
            this.txtNoBukuKlaim.MaxLength = 32767;
            this.txtNoBukuKlaim.Name = "txtNoBukuKlaim";
            this.txtNoBukuKlaim.PasswordChar = '\0';
            this.txtNoBukuKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoBukuKlaim.SelectedText = "";
            this.txtNoBukuKlaim.SelectionLength = 0;
            this.txtNoBukuKlaim.SelectionStart = 0;
            this.txtNoBukuKlaim.ShortcutsEnabled = true;
            this.txtNoBukuKlaim.Size = new System.Drawing.Size(237, 25);
            this.txtNoBukuKlaim.TabIndex = 9;
            this.txtNoBukuKlaim.UseSelectable = true;
            this.txtNoBukuKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoBukuKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(374, 246);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "No. Buku";
            // 
            // dtTanggalLahirKlaim
            // 
            this.dtTanggalLahirKlaim.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtTanggalLahirKlaim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTanggalLahirKlaim.Location = new System.Drawing.Point(304, 277);
            this.dtTanggalLahirKlaim.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtTanggalLahirKlaim.Name = "dtTanggalLahirKlaim";
            this.dtTanggalLahirKlaim.Size = new System.Drawing.Size(167, 25);
            this.dtTanggalLahirKlaim.TabIndex = 5;
            this.dtTanggalLahirKlaim.Value = new System.DateTime(2019, 5, 29, 0, 0, 0, 0);
            // 
            // txtTempatLahirKlaim
            // 
            // 
            // 
            // 
            this.txtTempatLahirKlaim.CustomButton.Image = null;
            this.txtTempatLahirKlaim.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtTempatLahirKlaim.CustomButton.Name = "";
            this.txtTempatLahirKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTempatLahirKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTempatLahirKlaim.CustomButton.TabIndex = 1;
            this.txtTempatLahirKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTempatLahirKlaim.CustomButton.UseSelectable = true;
            this.txtTempatLahirKlaim.CustomButton.Visible = false;
            this.txtTempatLahirKlaim.Lines = new string[0];
            this.txtTempatLahirKlaim.Location = new System.Drawing.Point(198, 280);
            this.txtTempatLahirKlaim.MaxLength = 32767;
            this.txtTempatLahirKlaim.Name = "txtTempatLahirKlaim";
            this.txtTempatLahirKlaim.PasswordChar = '\0';
            this.txtTempatLahirKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempatLahirKlaim.SelectedText = "";
            this.txtTempatLahirKlaim.SelectionLength = 0;
            this.txtTempatLahirKlaim.SelectionStart = 0;
            this.txtTempatLahirKlaim.ShortcutsEnabled = true;
            this.txtTempatLahirKlaim.Size = new System.Drawing.Size(100, 25);
            this.txtTempatLahirKlaim.TabIndex = 4;
            this.txtTempatLahirKlaim.UseSelectable = true;
            this.txtTempatLahirKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTempatLahirKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(46, 280);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(142, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "Tempat / Tanggal Lahir";
            // 
            // txtNamaLengkapKlaim
            // 
            // 
            // 
            // 
            this.txtNamaLengkapKlaim.CustomButton.Image = null;
            this.txtNamaLengkapKlaim.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNamaLengkapKlaim.CustomButton.Name = "";
            this.txtNamaLengkapKlaim.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNamaLengkapKlaim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaLengkapKlaim.CustomButton.TabIndex = 1;
            this.txtNamaLengkapKlaim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaLengkapKlaim.CustomButton.UseSelectable = true;
            this.txtNamaLengkapKlaim.CustomButton.Visible = false;
            this.txtNamaLengkapKlaim.Lines = new string[0];
            this.txtNamaLengkapKlaim.Location = new System.Drawing.Point(159, 246);
            this.txtNamaLengkapKlaim.MaxLength = 32767;
            this.txtNamaLengkapKlaim.Name = "txtNamaLengkapKlaim";
            this.txtNamaLengkapKlaim.PasswordChar = '\0';
            this.txtNamaLengkapKlaim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaLengkapKlaim.SelectedText = "";
            this.txtNamaLengkapKlaim.SelectionLength = 0;
            this.txtNamaLengkapKlaim.SelectionStart = 0;
            this.txtNamaLengkapKlaim.ShortcutsEnabled = true;
            this.txtNamaLengkapKlaim.Size = new System.Drawing.Size(183, 25);
            this.txtNamaLengkapKlaim.TabIndex = 3;
            this.txtNamaLengkapKlaim.UseSelectable = true;
            this.txtNamaLengkapKlaim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaLengkapKlaim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(46, 246);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 54;
            this.metroLabel6.Text = "Nama Lengkap";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(401, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "atas:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(195, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Mengajukan Permohonan Klaim";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(362, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "No. Telp. / HP";
            // 
            // txtNoTelp
            // 
            // 
            // 
            // 
            this.txtNoTelp.CustomButton.Image = null;
            this.txtNoTelp.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNoTelp.CustomButton.Name = "";
            this.txtNoTelp.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNoTelp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoTelp.CustomButton.TabIndex = 1;
            this.txtNoTelp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoTelp.CustomButton.UseSelectable = true;
            this.txtNoTelp.CustomButton.Visible = false;
            this.txtNoTelp.Enabled = false;
            this.txtNoTelp.Lines = new string[0];
            this.txtNoTelp.Location = new System.Drawing.Point(475, 75);
            this.txtNoTelp.MaxLength = 32767;
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.PasswordChar = '\0';
            this.txtNoTelp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoTelp.SelectedText = "";
            this.txtNoTelp.SelectionLength = 0;
            this.txtNoTelp.SelectionStart = 0;
            this.txtNoTelp.ShortcutsEnabled = true;
            this.txtNoTelp.Size = new System.Drawing.Size(183, 25);
            this.txtNoTelp.TabIndex = 50;
            this.txtNoTelp.TabStop = false;
            this.txtNoTelp.UseSelectable = true;
            this.txtNoTelp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoTelp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNamaLengkap
            // 
            // 
            // 
            // 
            this.txtNamaLengkap.CustomButton.Image = null;
            this.txtNamaLengkap.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNamaLengkap.CustomButton.Name = "";
            this.txtNamaLengkap.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNamaLengkap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaLengkap.CustomButton.TabIndex = 1;
            this.txtNamaLengkap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaLengkap.CustomButton.UseSelectable = true;
            this.txtNamaLengkap.CustomButton.Visible = false;
            this.txtNamaLengkap.Enabled = false;
            this.txtNamaLengkap.Lines = new string[0];
            this.txtNamaLengkap.Location = new System.Drawing.Point(141, 168);
            this.txtNamaLengkap.MaxLength = 32767;
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.PasswordChar = '\0';
            this.txtNamaLengkap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaLengkap.SelectedText = "";
            this.txtNamaLengkap.SelectionLength = 0;
            this.txtNamaLengkap.SelectionStart = 0;
            this.txtNamaLengkap.ShortcutsEnabled = true;
            this.txtNamaLengkap.Size = new System.Drawing.Size(183, 25);
            this.txtNamaLengkap.TabIndex = 49;
            this.txtNamaLengkap.TabStop = false;
            this.txtNamaLengkap.UseSelectable = true;
            this.txtNamaLengkap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaLengkap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNoBuku
            // 
            // 
            // 
            // 
            this.txtNoBuku.CustomButton.Image = null;
            this.txtNoBuku.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNoBuku.CustomButton.Name = "";
            this.txtNoBuku.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNoBuku.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoBuku.CustomButton.TabIndex = 1;
            this.txtNoBuku.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoBuku.CustomButton.UseSelectable = true;
            this.txtNoBuku.CustomButton.Visible = false;
            this.txtNoBuku.Enabled = false;
            this.txtNoBuku.Lines = new string[0];
            this.txtNoBuku.Location = new System.Drawing.Point(141, 137);
            this.txtNoBuku.MaxLength = 32767;
            this.txtNoBuku.Name = "txtNoBuku";
            this.txtNoBuku.PasswordChar = '\0';
            this.txtNoBuku.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoBuku.SelectedText = "";
            this.txtNoBuku.SelectionLength = 0;
            this.txtNoBuku.SelectionStart = 0;
            this.txtNoBuku.ShortcutsEnabled = true;
            this.txtNoBuku.Size = new System.Drawing.Size(183, 25);
            this.txtNoBuku.TabIndex = 48;
            this.txtNoBuku.TabStop = false;
            this.txtNoBuku.UseSelectable = true;
            this.txtNoBuku.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoBuku.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Nama Lengkap";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "No. Buku";
            // 
            // datagridviewKlaim
            // 
            this.datagridviewKlaim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridviewKlaim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridviewKlaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewKlaim.Location = new System.Drawing.Point(718, 75);
            this.datagridviewKlaim.Name = "datagridviewKlaim";
            this.datagridviewKlaim.Size = new System.Drawing.Size(504, 324);
            this.datagridviewKlaim.TabIndex = 87;
            this.datagridviewKlaim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewKlaim_CellClick);
            this.datagridviewKlaim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewKlaim_CellContentClick);
            this.datagridviewKlaim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.datagridviewKlaim_KeyUp);
            // 
            // gbProses
            // 
            this.gbProses.Controls.Add(this.btnCetak);
            this.gbProses.Controls.Add(this.btnHapus);
            this.gbProses.Controls.Add(this.btnUpdate);
            this.gbProses.Location = new System.Drawing.Point(718, 427);
            this.gbProses.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.gbProses.Name = "gbProses";
            this.gbProses.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.gbProses.Size = new System.Drawing.Size(504, 92);
            this.gbProses.TabIndex = 88;
            this.gbProses.TabStop = false;
            this.gbProses.Text = "Proses";
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(311, 35);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(130, 38);
            this.btnCetak.TabIndex = 92;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseSelectable = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(165, 35);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(130, 38);
            this.btnHapus.TabIndex = 91;
            this.btnHapus.Text = "Hapus Data Klaim";
            this.btnHapus.UseSelectable = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 38);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update Data Klaim";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(982, 402);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 89;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingSource1
            // 
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // txtIDAnggota
            // 
            // 
            // 
            // 
            this.txtIDAnggota.CustomButton.Image = null;
            this.txtIDAnggota.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtIDAnggota.CustomButton.Name = "";
            this.txtIDAnggota.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtIDAnggota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDAnggota.CustomButton.TabIndex = 1;
            this.txtIDAnggota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDAnggota.CustomButton.UseSelectable = true;
            this.txtIDAnggota.CustomButton.Visible = false;
            this.txtIDAnggota.Enabled = false;
            this.txtIDAnggota.Lines = new string[0];
            this.txtIDAnggota.Location = new System.Drawing.Point(141, 106);
            this.txtIDAnggota.MaxLength = 32767;
            this.txtIDAnggota.Name = "txtIDAnggota";
            this.txtIDAnggota.PasswordChar = '\0';
            this.txtIDAnggota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDAnggota.SelectedText = "";
            this.txtIDAnggota.SelectionLength = 0;
            this.txtIDAnggota.SelectionStart = 0;
            this.txtIDAnggota.ShortcutsEnabled = true;
            this.txtIDAnggota.Size = new System.Drawing.Size(183, 25);
            this.txtIDAnggota.TabIndex = 92;
            this.txtIDAnggota.TabStop = false;
            this.txtIDAnggota.UseSelectable = true;
            this.txtIDAnggota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDAnggota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(28, 106);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(76, 19);
            this.metroLabel21.TabIndex = 91;
            this.metroLabel21.Text = "ID Anggota";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tempRow
            // 
            // 
            // 
            // 
            this.tempRow.CustomButton.Image = null;
            this.tempRow.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tempRow.CustomButton.Name = "";
            this.tempRow.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tempRow.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tempRow.CustomButton.TabIndex = 1;
            this.tempRow.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tempRow.CustomButton.UseSelectable = true;
            this.tempRow.CustomButton.Visible = false;
            this.tempRow.Lines = new string[] {
        "tempRow"};
            this.tempRow.Location = new System.Drawing.Point(28, 493);
            this.tempRow.MaxLength = 32767;
            this.tempRow.Name = "tempRow";
            this.tempRow.PasswordChar = '\0';
            this.tempRow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tempRow.SelectedText = "";
            this.tempRow.SelectionLength = 0;
            this.tempRow.SelectionStart = 0;
            this.tempRow.ShortcutsEnabled = true;
            this.tempRow.Size = new System.Drawing.Size(75, 23);
            this.tempRow.TabIndex = 93;
            this.tempRow.Text = "tempRow";
            this.tempRow.UseSelectable = true;
            this.tempRow.Visible = false;
            this.tempRow.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tempRow.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tempID
            // 
            // 
            // 
            // 
            this.tempID.CustomButton.Image = null;
            this.tempID.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tempID.CustomButton.Name = "";
            this.tempID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tempID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tempID.CustomButton.TabIndex = 1;
            this.tempID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tempID.CustomButton.UseSelectable = true;
            this.tempID.CustomButton.Visible = false;
            this.tempID.Lines = new string[] {
        "tempID"};
            this.tempID.Location = new System.Drawing.Point(113, 493);
            this.tempID.MaxLength = 32767;
            this.tempID.Name = "tempID";
            this.tempID.PasswordChar = '\0';
            this.tempID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tempID.SelectedText = "";
            this.tempID.SelectionLength = 0;
            this.tempID.SelectionStart = 0;
            this.tempID.ShortcutsEnabled = true;
            this.tempID.Size = new System.Drawing.Size(75, 23);
            this.tempID.TabIndex = 94;
            this.tempID.Text = "tempID";
            this.tempID.UseSelectable = true;
            this.tempID.Visible = false;
            this.tempID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tempID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(592, 494);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 25);
            this.btnBatal.TabIndex = 95;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseSelectable = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormKlaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 550);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.tempID);
            this.Controls.Add(this.tempRow);
            this.Controls.Add(this.txtIDAnggota);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.gbProses);
            this.Controls.Add(this.datagridviewKlaim);
            this.Controls.Add(this.cmbJenisKlaim);
            this.Controls.Add(this.txtKodeKlaim);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txtAlamatLengkap);
            this.Controls.Add(this.txtPekerjaan);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dtMeninggalKlaim);
            this.Controls.Add(this.lblTglMeninggal);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.txtLamaRawatKlaim);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.txtRSKlaim);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtSakitKlaim);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtNoHPKlaim);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtAlamatLengkapKlaim);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.cmbJenisKelaminKlaim);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtPekerjaanKlaim);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtNoBukuKlaim);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtTanggalLahirKlaim);
            this.Controls.Add(this.txtTempatLahirKlaim);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtNamaLengkapKlaim);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.txtNoBuku);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormKlaim";
            this.Padding = new System.Windows.Forms.Padding(25, 65, 25, 27);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Permohonan Klaim";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.FormKlaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewKlaim)).EndInit();
            this.gbProses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbJenisKlaim;
        private MetroFramework.Controls.MetroTextBox txtKodeKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtAlamatLengkap;
        private MetroFramework.Controls.MetroTextBox txtPekerjaan;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroButton btnSimpan;
        private MetroFramework.Controls.MetroDateTime dtMeninggalKlaim;
        private MetroFramework.Controls.MetroLabel lblTglMeninggal;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtLamaRawatKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtRSKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtSakitKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtNoHPKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtAlamatLengkapKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbJenisKelaminKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPekerjaanKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtNoBukuKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtTanggalLahirKlaim;
        private MetroFramework.Controls.MetroTextBox txtTempatLahirKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNamaLengkapKlaim;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNoTelp;
        private MetroFramework.Controls.MetroTextBox txtNamaLengkap;
        private MetroFramework.Controls.MetroTextBox txtNoBuku;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView datagridviewKlaim;
        private System.Windows.Forms.GroupBox gbProses;
        private MetroFramework.Controls.MetroButton btnHapus;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroTextBox txtIDAnggota;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton btnCetak;
        private MetroFramework.Controls.MetroTextBox tempID;
        private MetroFramework.Controls.MetroTextBox tempRow;
        private MetroFramework.Controls.MetroButton btnBatal;
    }
}