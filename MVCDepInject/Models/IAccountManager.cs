using System.Collections.Generic;

namespace MVCDepInject.Models
{
	public interface IAccountManager
	{
		IEnumerable<Account> GetAccounts();
		IEnumerable<Account> GetNextAccounts(int offset, int number);
		void GetAccount(int accountId);
		void AddAccount(Account account);
		void DeleteAccount(int accountId);
	}
}