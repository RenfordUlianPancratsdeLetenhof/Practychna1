using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1
{
    internal class SurnameArray
    {
        private string[] surnames;
        const int length = 5;

        public SurnameArray()
        {
            surnames = new string[length] { "Білик", "Павлюк", "Барабаш", "Найчук", "Петренко" };
        }


        public string[] GetAllSurnames()
        {
            return surnames;
        }

        public List<string> GetSurnamesByFirstLetter(string letter)
        {
            List<string> result = new List<string>();

            foreach (string surname in surnames)
            {
                if (!string.IsNullOrEmpty(surname) && surname.StartsWith(letter, StringComparison.CurrentCultureIgnoreCase))
                {
                    result.Add(surname);
                }
            }

            return result;
        }
    }
}
