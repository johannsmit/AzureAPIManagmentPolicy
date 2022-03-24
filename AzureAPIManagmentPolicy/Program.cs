//All models in AzureAPIManagementPolicy.Models are build from the documentation link below
//https://docs.microsoft.com/en-us/azure/api-management/api-management-policy-expressions#ref-iapi

using AzureAPIManagementPolicy.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

Context context = new Context();

SetupContextDefaults(context);
TestCodeBlock(context);

/// <summary>
/// Setup context defaults
/// </summary>
void SetupContextDefaults(Context context)
{
    context.Request = new Request()
    {
        Url = new Url() { Host = "sample.host", Path = "/sample/path", Scheme = "https" },
        Method = "GET"
    };
}

/// <summary>
/// Test you Azure API Management code block here
/// </summary>
string TestCodeBlock(Context context)
{
	//<policy-tag>@{
	return null;
	//}</policy-tag>
}