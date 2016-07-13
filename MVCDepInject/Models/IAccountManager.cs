using System.Collections.Generic;

namespace MVCDepInject.Models
{
	public interface IAccountManager
	{
		IEnumerable<Account> GetAccounts();
		void GetAccount(int accountId);
		void AddAccount(Account account);
		void DeleteAccount(int accountId);
	}
}