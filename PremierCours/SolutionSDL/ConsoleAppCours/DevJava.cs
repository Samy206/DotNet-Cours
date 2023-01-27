using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCours
{
    public class DevJava : Dev, IPizzaEater
    {
        
        public DevJava() { }

        public DevJava(string prenom) { Prenom = prenom; }

        public override void test()
        {
            base.test();
        }

        public override void Develop()
        {
            Console.WriteLine("Je suis un dev java UwU");
           // throw new NotImplementedException();
        }

        public void eatPizza()
        {
            throw new NotImplementedException();
        }
    }
}
