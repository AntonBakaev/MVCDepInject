using System.Collections.Generic;
using System.Linq;
using Moq;
using MVCDepInject.Models;
using NUnit.Framework;

namespace MVCDepInject.UnitTests
{
	[TestFixture]
	public class AccountManagerTests
	{
		private void CompareAccountsLists(IEnumerable<Account> actualList, IEnumerable<Account> expectedList)
		{
			Assert.That(actualList, Is.EquivalentTo(expectedList));
		}

		[TestCase(1, 2)]
		[TestCase(0, 1)]
		[TestCase(0, 4)]
		[TestCase(0, 0)]
		[TestCase(-2, -1)]
		public void GetNextAccounts_VariousInputs_ReturnsIEnumerableAccounts(int offset, int number)
		{
			var mock = new Mock<IAccountRepository>();
			var list = new List<Account>
			{
				new Account(4, "Brian", "12345", 55),
				new Account(5, "James", "qwerty", 23),
				new Account(7, "Nick", "123", 16),
				new Account(7, "qqq", "1223", 16)
			};
			mock.Setup(ar => ar.GetAccounts()).Returns(list);
			var accountManager = new AccountManager(mock.Object);
			var expectedList = list.Skip(offset).Take(number);
			var actualList = accountManager.GetNextAccounts(offset, number);
			CompareAccountsLists(actualList, expectedList);
		}
	}
}