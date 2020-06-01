using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Acceso_Datos.ServiciosCorreo
{
    class SoporteCorreos:servidorCorreoMaestro
    {
        public SoporteCorreos()
        {
            senderMail = "babyeasy2020@gmail.com";
            password = "eLL4La71";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializedSmtpClient();
    }
        

     }
}

