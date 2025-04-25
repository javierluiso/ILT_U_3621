using System.Security;
using ILTU3621.Model.Interfaces;

namespace ILTU3621.Model
{
    public class Creds : IModel
    {
        private string _username;
        private SecureString _password;

        public string Username
        {
            get { return _username;  }
            set { _username = value; }
        }

        public SecureString Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
