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
        public Dictionary<string, string> BotResponses = new Dictionary<string, string> 
        {
            { "what is your purpose", "My purpose is to keep you safe online" },
            { "what can i ask you about", "You can ask me about cybersecurity, password safety, phishing, and how to browse safely" },
            { "what is password safety", "The use of strong, unique credentials combined with proper management techniques to protect digital accounts from unauthorised access" },
            { "tips about password safety", "Use strong password with at least 12 characters, including uppercase, lowercase, numbers, and symbols" },
            { "what is phishing", "Phishing is a cyber attack where attackers trick you into providing personal information. Always verify email sources before clicking links." },
            { "how can i browse safely", "Keep your browser updated, use HTTPS websites, and avoid clicking on suspicious links." },
            { "thanks", "You're welcome! have a good day"},
        };

        public string getResponse(string userInput, User newUser)
        {
            userInput = userInput.ToLower();
           
           
            if (userInput.Contains("hello")) //|| userInput.Contains("hi"))
            {
                return "hello " + newUser.name + ", How can i assist you today?";
            }
            else if (userInput.Contains("how are you"))
            {
                return "i'm just a bot, but i'm doing great! how about you?";
            }
            else if (userInput.Contains("good") || userInput.Contains("fine") || userInput.Contains("great") || userInput.Contains("okay"))
            {
                return "That's good, how can i assist you today?";
            }

            else if (BotResponses.TryGetValue(userInput, out string value))
            {

                return value;

            }
            //validating empty user Input
            else if (string.IsNullOrEmpty(userInput))
            {
              return ("input cannot be empty");
            }
            else
            {
                return "could you please paraphrase";
            }
        }

    }
}
