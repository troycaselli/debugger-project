using System;

public class CalculateNumbers
{
    /* 
    This code calculates the value of two numbers
    */
    public static void Run()
    {
        bool exit = false;
        var rand = new Random();
        int num1 = 5;
        int num2 = 5;

        do
        {
            num1 = rand.Next(1, 11);
            num2 = num1 + rand.Next(1, 51);
        } while (exit == false);
    }
}