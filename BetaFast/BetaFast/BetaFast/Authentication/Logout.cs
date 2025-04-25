using ILTU3621.Controllers;
using ILTU3621.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ILTU3621.Authentication
{
    public static class Logout
    {
        public static async Task LogoutAsync()
        {
            HttpResponseMessage response = await SessionController.Logout();
            int status = (int)response.StatusCode;

            if (status == 200)
            {
                // Successful logout
            }
            else if (status == 401)
            {
                throw new UnauthenticatedException();
            }
            else
            {
                throw new Exception("An error occurred");
            }
        }
    }
}
