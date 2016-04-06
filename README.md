# Twilio Console Test

#### Send a text with Twilio, 06 April 2016
#### By Jill Kuchman

## Description

_Console application that will send a "hello" text to a Twilio-verified phone number using RestSharp, a Rest Client for C#_

## Setup/Installation Requirements

Download this code, then in the project directory, create the the file _EnvironmentVariables.cs_ which will look like this:

```
namespace TwilioTestConsole01
{
    class EnvironmentVariables
    {
        public static string TwilioAccountSid = "{{INSERT YOUR TWILIO ACCOUNT SID HERE}}";
        public static string TwilioAuthToken = "{{INSERT YOUR TWILIO AUTH TOKEN HERE}}";
        public static string ToNumber = "{{INSERT TWILIO-VERIFIED PHONE NUBMER HERE}};
        public static string FromNumber = "{{INSERT YOUR TWILIO-ISSUED PHONE NUMBER HERE}}";
    }
}
```

## Technologies Used
C#, RestSharp