using BLL.ServiceImplementation;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{   
    [TestFixture]
    public class BLLTests
    {
        [Test]
        public void CallAccountNumberCreateService()
        {
            var mock = new Mock<IAccountNumberCreateService>();
            var createService = mock.Object;

            createService.GenerateAccountNumber(new List<Account>());

            mock.Verify(cs => cs.GenerateAccountNumber(It.IsAny<IEnumerable<Account>>()));
        }

        [Test]
        public void AccountNumberCreateService_ReturnAnyInt()
        {
            var mock = new Mock<IAccountNumberCreateService>();
            var createService = mock.Object;

            createService.GenerateAccountNumber(new List<Account>());

            mock.Setup(cs => cs.GenerateAccountNumber(It.IsAny<IEnumerable<Account>>())).Returns(It.IsAny<int>);
        }

        [Test]
        public void AccountService()
        {
            var mock = new Mock<IAccountService>();
            var mockCreator = new Mock<IAccountNumberCreateService>();
            var mockAccountType = new Mock<AccountType>();
            var createService = mock.Object;

            createService.OpenAccount("Account owner 1", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 2", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 3", mockAccountType.Object, mockCreator.Object);

            mock.Verify(cs => cs.OpenAccount(It.IsAny<string>(), mockAccountType.Object, mockCreator.Object), Times.Exactly(3));
        }

        [Test]
        public void AccountServiceGetAllAccounts()
        {
            var mock = new Mock<IAccountService>();
            var mockCreator = new Mock<IAccountNumberCreateService>();
            var mockAccountType = new Mock<AccountType>();
            var createService = mock.Object;

            createService.OpenAccount("Account owner 1", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 2", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 3", mockAccountType.Object, mockCreator.Object);
            createService.GetAllAccounts();

            mock.Verify(cs => cs.GetAllAccounts());
        }

        [Test]
        public void AccountServiceGetAllAccountsReturnsIEnumerable()
        {
            var mock = new Mock<IAccountService>();
            var mockCreator = new Mock<IAccountNumberCreateService>();
            var mockAccountType = new Mock<AccountType>();
            var createService = mock.Object;

            createService.OpenAccount("Account owner 1", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 2", mockAccountType.Object, mockCreator.Object);
            createService.OpenAccount("Account owner 3", mockAccountType.Object, mockCreator.Object);

            mock.Setup(cs => cs.GetAllAccounts()).Returns(It.IsAny<IEnumerable<Account>>());
        }
    }
}
