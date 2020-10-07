using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Dominio;

namespace WindowsFormsApp1.Negocio
{
    class clsLogin
    {
        public Boolean entrar(Login l) {
            if (l.User.Equals("william") && l.Pass.Equals("123"))
            {
                return true;
            }
            else {
                return false;
            }       
        }
    }
}
