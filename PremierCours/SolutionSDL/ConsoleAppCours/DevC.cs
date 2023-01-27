using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCours
{
    public class DevC : Dev 
    {

        public DevC() { }

        public DevC(String prenom) { }

        public override void Develop()
        {
            Console.WriteLine("Je suis un dev C UwU");
        }

        public override void test()
        {
            base.test();
        }

    }
}
