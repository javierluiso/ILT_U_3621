using ILTU3621.Controllers;
using ILTU3621.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ILTU3621.Content
{
    public static class RegistrationQuotes
    {
        public static async Task<string> GetQuoteAsync()
        {
            int status;
            string body;

            using (HttpResponseMessage response = await QuoteController.GetQuote())
            {
                status = (int)response.StatusCode;
                body = await response.Content.ReadAsStringAsync();
            }

            if (status == 200)
            {
                return body;
            }
            else if (status == 400)
            {
                throw new Exception(body);
            }
            else if (status == 500)
            {
                throw new ServerException();
            }
            else
            {
                throw new Exception("Uncaught status code");
            }
        }
    }
}
