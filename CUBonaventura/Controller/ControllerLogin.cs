using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CUBonaventura.DAO;

namespace CUBonaventura.Controller
{
    class ControllerLogin
    {
        DAOLogin daoLogin = new DAOLogin();
        public string validateLogin(string username, string password)
        { return daoLogin.validateLogin(username, password); }
        public bool validateUser(string username, string email)
        { return daoLogin.validateUser(username, email); }
        public bool updatePassword(string username, string password)
        { return daoLogin.updatePass(username, password); }
        public string GetRoleUser(string username, string password)
        { return daoLogin.GetRoleUser(username, password); }
    }
}
