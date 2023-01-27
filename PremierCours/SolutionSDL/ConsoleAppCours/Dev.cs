using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCours
{
    public abstract class Dev : IPizzaEater
    {
        public String? Prenom {get; set;}

        public abstract void Develop();

        public void eatPizza()
        {
            throw new NotImplementedException();
        }

        public virtual void test() {;}
    }
}
