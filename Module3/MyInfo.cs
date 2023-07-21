using System;

public class cMyInfo
{
    public static void MyInfo()

    {
       string myName = "Nikita";
        int myAge = 25;
        bool myPet = false;
        float myLegSize = 42.5f;

        Console.WriteLine($"My name is {myName}");
        Console.WriteLine($"I'm {myAge} years old");
        Console.WriteLine($"Do I have a pet? {myPet}");
        Console.WriteLine($"My shoe size is {myLegSize}");

        Console.WriteLine($"Int takes value from {int.MinValue} to {int.MaxValue}");

        Console.ReadKey();
    }
}
