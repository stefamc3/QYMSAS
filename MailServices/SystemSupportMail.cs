<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSAS.MailServices
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "proyectoqym@gmail.com";
            password = "BASEDEDATOS12";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSAS.MailServices
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "proyectoqym@gmail.com";
            password = "BASEDEDATOS12";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
