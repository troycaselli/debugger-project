using System;

public class ChangeValue
{
    /*
    This code instantiates a value and then calls the ChangeValue method
    to update the value. The code then prints the updated value to the console.
    */
    public static void Run()
    {
        int x = 5;

        x = ChangeValue(x);

        Console.WriteLine(x);

        static int ChangeValue(int value)
        {
            value = 10;
            return value;
        }
    }
}