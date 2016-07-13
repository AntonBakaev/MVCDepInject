using System.Collections.Generic;

namespace MVCDepInject.Models
{
	public class AccountManager : IAccountManager
	{
		private readonly IAccountRepository accountRepository;

		public AccountManager(IAccountRepository accountRepository)
		{
			this.accountRepository = accountRepository;
		}

		public IEnumerable<Account> GetAccounts()
		{
			return accountRepository.GetAccounts();
		}

		public void GetAccount(int accountId)
		{
			accountRepository.GetAccountById(accountId);
		}

		public void AddAccount(Account account)
		{
			accountRepository.InsertAccount(account);
		}

		public void DeleteAccount(int accountId)
		{
			accountRepository.DeleteAccount(accountId);
		}
	}
}