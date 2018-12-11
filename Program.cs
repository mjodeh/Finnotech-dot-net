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
                    NationalId = "0075409690",
                    ApplicationId = "testjodeh",
                    ApplicationSecret = "5957dd6a8126de729fd2"
                }
            };
            app.GetToken();
        }
    }
}
