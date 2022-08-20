using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CameraApp
{
    public class MailShare : ICameraSharable
    {
        public void Share()
        {
            Console.WriteLine("MAIL SHARE");
        }
    }
}
