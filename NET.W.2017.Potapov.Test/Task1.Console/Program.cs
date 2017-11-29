using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordChekerService pcs = new PasswordChekerService(new SomeRepository(), new CharValidator(), new NumberValidator(), new LengthValidator());
            System.Console.WriteLine($"{pcs.VerifyPassword("password").Item2}");
            System.Console.WriteLine($"{pcs.VerifyPassword("pas1").Item2}");
            System.Console.WriteLine($"{pcs.VerifyPassword("password12").Item2}");
            System.Console.WriteLine($"{pcs.VerifyPassword("passsssssssssssssssss12").Item2}");
            System.Console.ReadLine();
        }
    }
}
