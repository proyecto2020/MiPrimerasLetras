using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class SoporteDeSistema:ServidorDeCorreo
    {
        public SoporteDeSistema()
        {
            senderMail = "misprimerasletras53@gmail.com";
            password = "Misprimerasletras";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtClient();
        }
     
    }
}
