using System;
using FinnoTech;

namespace TokenGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new FinnotechApplication()
            {
                ApplicationCredentials = new ApplicationCredentials()
                {
                    NationalId = "",
                    ApplicationId = "",
                    ApplicationSecret = ""
                }
            };
            app.GetToken();
        }
    }
}
