using FrontDoorManagement;
using System;
using System.Collections.Generic;

namespace AddCustomFrontDoorHostName
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontDoorManagement.ActiveDirectoryAuthentication.AuthMethod AuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal;

#if DEFAULTVALUES
            Dictionary<String, String> Parameters = new Dictionary<String, String>()
            {
                                {"SubscriptionId","XXXXX" },
                {"AddTenant","XXXXX" },
                {"ClientId","XXXXX" },
                {"ClientSecret","XXXXX" },
                {"ResourceGroup","XXXXX" },
                {"FrontDoor","XXXXX" },
                {"EndpointName","XXXXX" },
                {"HostName","XXXXX" }
            };
#else
            List<String> ParameterNames = new List<String>()
            {
                "SubscriptionId",
                "AddTenant",
                "ClientId",
                "ClientSecret",
                "ResourceGroup",
                "FrontDoor",
                "EndpointName",
                "HostName"
            };

            Dictionary<String, String> Parameters = new Dictionary<String, String>();

            foreach (String Parameter in ParameterNames)
            {
                Console.WriteLine($"{Parameter}:");

                String Input = String.Empty;
                do
                {
                    Input = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(Input));

                Parameters.Add(Parameter, Input.Trim());
            }


#endif

            try
            {
                FrontDoorManagementSdk ManagementInterface = new FrontDoorManagementSdk(
                    Parameters["SubscriptionId"], AuthenticationMethod,
                    Parameters["AddTenant"], Parameters["ClientId"], Parameters["ClientSecret"]);

                Boolean OperationResult = ManagementInterface.CreateFrontEnd(Parameters["ResourceGroup"],
                    Parameters["FrontDoor"], Parameters["EndpointName"], Parameters["HostName"]).Result;

                if (OperationResult)
                {
                    Console.WriteLine("Endpoint created succesfully");
                }
                else
                {
                    Console.WriteLine("Filed Endpoint creation");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
