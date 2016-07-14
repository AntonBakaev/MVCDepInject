using System.Collections.Generic;
using System.Linq;

namespace MVCDepInject.Models
{
	public class AccountRepository : IAccountRepository
	{
		private readonly List<Account> accounts;

		public AccountRepository()
		{
			accounts = new List<Account>
			{
				new Account(1, "Max", "pass", 30),
				new Account(2, "James", "12345", 21),
				new Account(3, "Mike", "mike123", 19),
				new Account(4, "Dan", "qwert", 48),
				new Account(5, "John", "password", 37)
			};
		}

		public IEnumerable<Account> GetAccounts()
		{
			return accounts;
		}

		public Account GetAccountById(int accountId)
		{
			return accounts.FirstOrDefault(a => a.Id == accountId);
		}

		public void InsertAccount(Account account)
		{
			accounts.Add(account);
		}

		public void DeleteAccount(int accountId)
		{
			accounts.Remove(accounts.Find(a => a.Id == accountId));
		}

		public void UpdateAccount(Account account)
		{
			var accountToUpdate = accounts.Find(a => a.Id == account.Id);
			accountToUpdate.Name = account.Name;
			accountToUpdate.Age = account.Age;
		}
	}
}