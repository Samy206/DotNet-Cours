using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCours.Core
{
    // Au lieu d'étendre un type  on lui ajoute simplement une méthode
    public static class StringExtensions
    {
        // 'this TYPE' veut dire qu'on étend le type
        public static string GetData(this string value)
        {
            // return value + DateTime.Now;
            // OU
            // return String.format("{0} {1}", value, DateTime.Now);
            // OU
            // C'est une chaîne interpollé
            return $"{value}{DateTime.Now}";
        }

    }
}
