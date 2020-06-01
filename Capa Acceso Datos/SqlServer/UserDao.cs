using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_De_Soporte.Cache;

namespace Capa_Acceso_Datos
{
    public class UserDao:ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where LoginName =@user and password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Tipo = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);


                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
           
        }

        public string recoverpassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where LoginName=@user or Email= @mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new ServiciosCorreo.SoporteCorreos();
                        mailService.sendMail(
                            subject: "SYSTEM: Solicitud de recuperacion de Contraseña",
                            body: " Hola, " + userName + "\n Solicitud de Recuperacion de Contraseña. \n" +
                            "Tu contraseña es: " + accountPassword +
                            "\n Por Motivos de Seguridad una vez Ingrese a su cuenta se le recomienda cambiar su Contraseña",
                            recipientMail: new List<string> { userMail }

                            );

                        return " Hola, " + userName + "\n Solicitud de Recuperacion de Contraseña. \n" + "Por favor Revisa tu correo: " +
                            userMail + "\n Por Motivos de Seguridad una vez Ingrese a su cuenta se le recomienda cambiar su Contraseña";
                    }
                    else
                        return " Lo sentimos No tiene una Cuenta con este correo o nombre de usuario";
                }
            }
        }
        public void anyMeyhod()
        {
            if (UserLoginCache.Tipo == Tipos.Cliente) 
            {
            
            }
            if(UserLoginCache.Tipo == Tipos.Tienda)
            {

            }
        }
    }
}
