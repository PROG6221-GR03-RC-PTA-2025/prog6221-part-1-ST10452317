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
        public Dictionary<string, string> BotResponses = new Dictionary<string, string> {
            { "what is your purpose", "My purpose is to keep you safe online" },
            { "thanks", "You're welcome! have a good day"}
        };

        public string getResponse(string userInput, User newUser)
        {
            userInput = userInput.ToLower();

            if (userInput.Contains("hello") || userInput.Contains("hi"))
            {
                return "hello " + newUser.name + ", How can i assist you today?";
            }
            else if (userInput.Contains("how are you"))
            {
                return "i'm just a bot, but i'm doing great! how about you?";
            }
            else if (userInput.Contains("good") || userInput.Contains("fine") || userInput.Contains("great") || userInput.Contains("okay"))
            {
                return "That's good, how can i assist you today";
            }
            else if (BotResponses.TryGetValue(userInput, out string value))
            {
                return value;
            }
            else
            {
                return "could you please paraphrase";
            }
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
