# Install
Install-Package Newtonsoft.Json

# Frameworks
* .Net Core 2
* .Net framework 4+

# Usage example
var app = new FinnotechApplication()  
{  
    ApplicationCredentials = new ApplicationCredentials()  
    {  
        NationalId = "your national Id",  
        ApplicationId = "your application Id",  
        ApplicationSecret = "your application secret"  
    }  
};  
app.GetToken();  

# General notes
All the functions output are boolean, if the result is true then the function succeeded otherwize it failed, in this case it will through an exception.