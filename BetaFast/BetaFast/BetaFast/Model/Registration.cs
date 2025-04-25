using System.Security;
using ILTU3621.Model.Interfaces;

namespace ILTU3621.Model
{
    class Registration : IModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}
