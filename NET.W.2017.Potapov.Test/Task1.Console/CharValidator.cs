using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class CharValidator : IValidate
    {
        public (bool, string) IsValid(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                return (false, $"{password} hasn't alphanumerical chars");
            }

            return (true, $"{password} valid");
        }
    }
}
