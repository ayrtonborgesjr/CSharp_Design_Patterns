using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Cooking : IChannel
    {
        public string Channel()
        {
            return ("Tuned to the Cooking Channel");
        }

        public string Status()
        {
            return ("You're watching - MasterChef EUA");
        }
    }
}
