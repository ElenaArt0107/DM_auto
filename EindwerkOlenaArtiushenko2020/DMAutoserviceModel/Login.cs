using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoserviceModel
{
    public class Login
    {
		private string _loginName;

		public string LoginName
		{
			get { return _loginName; }
			set { _loginName = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private Role _role;

		public Role Role 
		{
			get { return _role; }
			set { _role = value; }
		}

		private Person _persoon;

		public Person Persoon
		{
			get { return _persoon; }
			set { _persoon = value; }
		}
	}
}
