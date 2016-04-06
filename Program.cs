using System;
using RestSharp;
using RestSharp.Authenticators;

namespace TwilioTestConsole01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            var request = new RestRequest("Accounts/" + EnvironmentVariables.TwilioAccountSid + "/Messages.json", Method.POST);
            request.AddParameter("To", EnvironmentVariables.ToNumber);
            request.AddParameter("From", EnvironmentVariables.FromNumber);
            request.AddParameter("Body", "Hey there, " + name + "!");
            client.BaseUrl = new Uri("https://api.twilio.com/2010-04-01");
            client.Authenticator = new HttpBasicAuthenticator(EnvironmentVariables.TwilioAccountSid, EnvironmentVariables.TwilioAuthToken);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }
    }
}
