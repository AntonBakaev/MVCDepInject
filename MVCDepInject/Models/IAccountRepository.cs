using System.Collections.Generic;

namespace MVCDepInject.Models
{
	public interface IAccountRepository
	{
		IEnumerable<Account> GetAccounts();
		Account GetAccountById(int accountId);
		void InsertAccount(Account account);
		void DeleteAccount(int accountId);
		void UpdateAccount(Account account);
	}
}