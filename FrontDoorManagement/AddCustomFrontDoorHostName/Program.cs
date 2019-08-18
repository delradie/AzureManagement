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

            foreach (KeyValuePair<String, String> Parameter in Parameters)
            {
                Console.WriteLine($"{Parameter.Key}:");

                String Input = String.Empty;
                do
                {
                    Input = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(Input));

                Parameters.Add(Parameter.Key, Input.Trim());
            }

            try
            {
                FrontDoorManagementSdk ManagementInterface = new FrontDoorManagementSdk(
                    Parameters["SubscriptionId"], AuthenticationMethod,
                    Parameters["AddTenant"], Parameters["ClientId"], Parameters["ClientSecret"]);

                Boolean OperationResult = ManagementInterface.CreateFrontEnd(Parameters["ResourceGroup"],
                    Parameters["FrontDoor"], Parameters["EndpointName"], Parameters["HostName"]).Result;

                if(OperationResult)
                {
                    Console.WriteLine("Endpoint created succesfully");
                }
                else
                {
                    Console.WriteLine("Filed Endpoint creation");
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
