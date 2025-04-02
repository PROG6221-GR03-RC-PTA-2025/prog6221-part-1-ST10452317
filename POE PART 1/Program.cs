using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace POE_PART_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer soundPlayer = new SoundPlayer("Greeting.wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();

                if (input.ToLower().Equals("exit"))
                {
                    break;
                }

                string response = chatbotObj.getResponse(input, UserObj);

                newSession.logMessage("User: " + input);
                newSession.logMessage("User: " + chatbotObj.getResponse(input, UserObj));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Chatbot: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(chatbotObj.getResponse(input, UserObj));
            }
            newSession.endSession();
        }
    }
}
