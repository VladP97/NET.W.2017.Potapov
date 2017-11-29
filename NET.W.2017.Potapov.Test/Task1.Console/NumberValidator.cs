using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class NumberValidator : IValidate
    {
        public (bool, string) IsValid(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                return (false, $"{password} hasn't digits");
            }

            return (true, $"{password} valid");
        }
    }
}
