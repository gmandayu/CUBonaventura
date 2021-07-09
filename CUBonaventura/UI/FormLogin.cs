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

namespace CUBonaventura.UI
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        ControllerLogin cl = new ControllerLogin();

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cl.validateLogin(txtUsername.Text, txtPassword.Text) != "")
            {
                string role = cl.GetRoleUser(txtUsername.Text, txtPassword.Text);
                if (role == "Administrator")
                {
                    this.Hide();
                    FormMain fm = new FormMain();
                    fm.SetLabel(txtUsername.Text);
                    fm.ShowDialog();
                    this.Close();
                }
                else if (role == "Staff")
                {
                    this.Hide();
                    FormMain fm = new FormMain();
                    fm.SetLabel(txtUsername.Text);
                    fm.ShowDialog();
                    this.Close();
                }
                else
                { MessageBox.Show("Kesalahan: Tidak memiliki role.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Error: Username atau Password Salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkForgotPass_Click(object sender, EventArgs e)
        {
            FormLupaPassword flp = new FormLupaPassword();
            flp.ShowDialog();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            { btnLogin_Click(sender, e); }
            if (e.KeyChar == 39)
            { e.Handled = true; }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            { btnLogin_Click(sender, e); }
            if (e.KeyChar == 39)
            { e.Handled = true; }
        }
    }
}
