using System;

public class Greetings
{
    /*
    This method uses a names array and corresponding methods to display
    greeting messages
    */
    public static void Run()
    {

        string[] names = ["Sophia", "Andrew", "AllGreetings"];

        string messageText = "";

        foreach (string name in names)
        {
            if (name == "Sophia")
                messageText = SophiaMessage();
            else if (name == "Andrew")
                messageText = AndrewMessage();
            else if (name == "AllGreetings")
                messageText = SophiaMessage() + "\n\r" + AndrewMessage();

            Console.WriteLine(messageText + "\n\r");
        }

        static string SophiaMessage()
        {
            return "Hello, my name is Sophia.";
        }

        static string AndrewMessage()
        {
            return "Hi, my name is Andrew. Good to meet you.";
        }
    }
}