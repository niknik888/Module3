using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Вам нужно будет написать программу, которая собирает небольшую анкету о вас: как вас зовут, возраст, дату рождения.
public class cFinalTask
    {
        public static void FinalTask()
        {
            Console.Write("Hello, what is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birthay date: ");
            var birthday = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Your name is {name} and age is {age}\nYour birtdate is {birthday}") ;
        }
        
    }

