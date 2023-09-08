using System;

Console.ForegroundColor = ConsoleColor.DarkYellow;

namespace Net_project
{
    internal class Program
    {
        string firstname;
        string lastname;
        int birthyear;
        string fathername;
        string phonenumber;
        string gender;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:  ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Last name:  ");
            string lastname = Console.ReadLine();

            Console.WriteLine("your birth year:  ");
            int birthyear = int.Parse(Console.ReadLine());

            Console.WriteLine("Father's name:  ");
            string fathername = Console.ReadLine();

            Console.WriteLine("Your gender (Male or Female):  ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter your phone number:  ");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Enter 1 for complete info and 2 for summary:");
            string choice = Console.ReadLine();

            static string normalizephonenumber(string phonenumber)
            {
                if (phonenumber.StartsWith("+98"))
                {
                    phonenumber = phonenumber.Replace("+98", "0");

                }
                return phonenumber;

                if (phonenumber.Length == 10)
                {
                    phonenumber = "0" + phonenumber;
                }
                return phonenumber;
            }

            if (choice == "1")
            {
                //full info
                Console.WriteLine("*************  ************");
                Console.WriteLine($"Name:  {firstname}");
                Console.WriteLine($"Last name:  {lastname}");
                Console.WriteLine($"Father name:  {fathername}");              
                Console.WriteLine($"Gender:  {gender}");
                Console.WriteLine($"Phone number:  {phonenumber}");
                Console.WriteLine("*************  *************"); 
                
                int currentyear = DateTime.Now.Year;
                int age = currentyear - birthyear;
                Console.WriteLine($"Age :  {age} years");


                if (age >= 18 && age <= 50)
                {
                    Console.WriteLine("Must go to military service!");
                }
                else
                {
                    Console.WriteLine("No military service");
                }
                Console.ReadLine();
                
            }
            else if (choice == "2")
            {
                Console.WriteLine($"Name:  {firstname}");
                Console.WriteLine($"Last name:  {lastname}");
            }
            else
            {
                Console.WriteLine("Not accepted!!");
            }
            Console.ReadLine();                                                         

        }
    }
}

    
