using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class LengthValidator : IValidate
    {
        public (bool, string) IsValid(string password)
        {
            if (password.Length <= 7 || password.Length >= 15)
            {
                return (false, $"{password} langth incorrect");
            }

            return (true, $"{password} valid");
        }
    }
}
