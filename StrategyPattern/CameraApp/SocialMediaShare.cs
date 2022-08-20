using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CameraApp
{
    public class SocialMediaShare : ICameraSharable
    {
        public void Share()
        {
            Console.WriteLine("Social Media Share");
        }
    }
}
