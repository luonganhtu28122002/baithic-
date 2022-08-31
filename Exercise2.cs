
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class program
    {
        public static void Main(string[] cmd)
        {
            Console.WriteLine("------------");
            Lion lion = new Lion();
            lion.Show();
            Console.WriteLine("------------");
            Tiger tiger = new Tiger();
            tiger.Show();
            Console.WriteLine("------------");

        }
    }
}