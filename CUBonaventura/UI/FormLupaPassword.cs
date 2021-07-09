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
using CUBonaventura.DAO;

namespace CUBonaventura.UI
{
    public partial class FormLupaPassword : MetroFramework.Forms.MetroForm
    {
        public FormLupaPassword()
        {
            InitializeComponent();
            SetDisable();
        }

        ControllerLogin cl = new ControllerLogin();
        private void ClearText()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtKonfPassword.Clear();
            txtEmail.Clear();
        } 
        private void SetEnable()
        {
            metroLabel5.Visible = true;
            metroLabel4.Visible = true;
            btnUpdatePassword.Enabled = true;
            btnBatal.Enabled = true;
            txtKonfPassword.Visible = true;
            txtPassword.Visible = true;
        } 
        private void SetDisable()
        {
            metroLabel5.Visible = false;
            metroLabel4.Visible = false;
            btnUpdatePassword.Enabled = false;
            btnBatal.Enabled = false;
            txtKonfPassword.Visible = false;
            txtPassword.Visible = false;
        } 
        private void FormLupaPassword_Load(object sender, EventArgs e)
        {

        }

        private void linkCari_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            if (cl.validateUser(username, email) == true)
            { SetEnable(); }
            else
            { MessageBox.Show("Username atau email tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string konfirmasiPassword = txtKonfPassword.Text.Trim();
            string username = txtUsername.Text.Trim();

            if (username != null && password != null)
            {
                if (konfirmasiPassword.Equals(password))
                {
                    cl.updatePassword(username, password);
                    MessageBox.Show("Password diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                { MessageBox.Show("Konfirmasi password tidak sama.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            { MessageBox.Show("Pastikan informasi login benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
