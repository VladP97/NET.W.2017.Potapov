using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordChekerService
    {
        private List<IValidate> validators = new List<IValidate>();

        private IRepository repository;

        public PasswordChekerService(IRepository repository, params IValidate[] validators)
        {
            this.repository = repository;
            foreach (var validator in validators)
            {
                this.validators.Add(validator);
            }
        }

        public (bool, string) VerifyPassword(string password)
        {
            bool isValid;
            string message;
            foreach (var validator in validators)
            {
                (isValid, message) = validator.IsValid(password);
                if (!isValid)
                {
                    return (false, message);
                }
            }
            return (false, "Password is Ok.User was created");
        }
    }
}
