using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_Datos;
using Capa_De_Soporte.Cache;


namespace Reglas_de_Negocio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user,pass);
        }

        public string recoverpassword(string userRequesting)
        {
            return userDao.recoverpassword(userRequesting);
        }
        public bool editPassword(int user, string pass)
        {
            if(user == UserLoginCache.IdUser)
            {

            }
            return true;
        }
        public void anyMeyhod()
        {

            // seguridad y permisos 
            if (UserLoginCache.Tipo == Tipos.Cliente)
            {

            }
            if (UserLoginCache.Tipo == Tipos.Tienda)
            {

            }

        }

    }

    

}
