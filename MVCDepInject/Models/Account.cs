namespace MVCDepInject.Models
{
	public class Account
	{
		public Account(int id, string name, string password, int age)
		{
			this.Id = id;
			this.Name = name;
			this.Password = password;
			this.Age = age;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public int Age { get; set; }
	}
}