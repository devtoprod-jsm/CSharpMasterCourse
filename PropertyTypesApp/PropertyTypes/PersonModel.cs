using System;
namespace PropertyTypes
{
	public class PersonModel
	{

		public string FirstName { private get; set; }
		public string LastName { get; private set; }

		private string _password;

		public string Password
		{
			set
			{
				_password = value;
			}
		}

		private string _fullname;

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		private int _age;

		public int Age
		{
			get { return _age; }

			set
			{
				if (value >= 0 && value < 125)
				{
					_age = value;
				}

				else
				{
					throw new ArgumentOutOfRangeException("value", "Please enter a valid age.");
				}
			}
		}

		private string _ssn; // 123-45-6789

		public string SSN
		{
			get
			{
				return "***-**-" + _ssn.Substring(_ssn.Length - 4);
			}

			set
			{
				_ssn = value;
			}
		}

		public PersonModel()
		{

		}

		public PersonModel(string lastName)
		{
			LastName = lastName;
		}
	}
}

