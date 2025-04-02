using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1
{
    internal class Session
    {
        public User chatUser { get; set; }
        public Chatbot bot { get; set; }
        public DateTime sessionStart { get; set; }

        public ArrayList chatHistory { get; set; }

        public Session(User user, Chatbot bot)
        {
            this.chatUser = user;
            this.bot = bot;
            this.chatHistory = new ArrayList();
        }

        public void startSession()
        {
            sessionStart = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chatbot: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(bot.getGreeting() + "  " + chatUser.name + " How can i assist you today");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Session started at: " + sessionStart);
            Console.WriteLine("Type exit to end the session");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void endSession()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Session ended. Total messages exchanged: " + chatHistory.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void logMessage(string message)
        {
            chatHistory.Add(message);
            chatUser.lastInteration = DateTime.Now;
        }
    }
}
