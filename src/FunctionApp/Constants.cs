using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    public static class Constants
    {
        public static string Auth0Domain => GetEnvironmentVariable("https://sergiotest.eu.auth0.com");
        public static string Audience => GetEnvironmentVariable("https://sergiosayshi.azurewebsites.net/");

        private static string GetEnvironmentVariable(string name)
        {
            var result = Environment.GetEnvironmentVariable(name);
            if (string.IsNullOrEmpty(result))
                throw new InvalidOperationException($"Missing app setting {name}");
            return result;
        }
    }
}
