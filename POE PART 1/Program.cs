using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;

            Console.Write("Enter your name: ");
            Name = Console.ReadLine();

            User UserObj = new User();

            UserObj.name = Name;
            UserObj.userId = Guid.NewGuid().ToString();

            Chatbot chatbotObj = new Chatbot();
            Session newSession = new Session(UserObj, chatbotObj); //same as obj method

            newSession.startSession();

            while (true)
            {
                Console.Write("User: ");
                string input = Console.ReadLine();

                if (input.ToLower().Equals("exit"))
                {
                    break;
                }

                string response = chatbotObj.getResponse(input);

               // Console.ForegroundColor = ConsoleColor.Red;
                newSession.logMessage("User: " + input);
               // Console.ForegroundColor = ConsoleColor.Green;
                newSession.logMessage("User: " + chatbotObj.getResponse(input));
                Console.WriteLine("Chatbot: "+chatbotObj.getResponse(input));
            }
            newSession.endSession();
        }
    }
}
