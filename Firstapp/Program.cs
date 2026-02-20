using System;
class Program
{
    static void Main ()
    {
     Console.WriteLine("Custom Password Generator");
     Console.Write("Enter your name: ");
     string name = Console.ReadLine();

     Console.Write("Enter your phone number: ");
     string phone = Console.ReadLine();

     string last4= phone.Length >=4 ? phone.Substring(phone.Length -4 ):phone;

     string Password = name + last4;

     Console.WriteLine("your generated password is : "+ Password);
     Console.ReadKey();
    }
}