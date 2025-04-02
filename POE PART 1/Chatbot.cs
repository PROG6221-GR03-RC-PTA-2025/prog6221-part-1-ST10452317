using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1
{
    internal class Chatbot
    {
        public string name { get; set; } = "ChatBot"; 
        public DateTime startTime { get; set; } = DateTime.Now;

        public string getResponse(string userInput)
        {
            return "I'm still learning";
        }

        public string getGreeting()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 12)
            {
                return "Good morning!";
            }
            else if (hour < 16)
            {
                return "Good afetrnoon!";
            }
            else
            {
                return "Good evening!";
            }
        }
    }
}
