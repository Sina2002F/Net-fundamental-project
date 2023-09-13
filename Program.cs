
Console.ForegroundColor = ConsoleColor.DarkYellow;

namespace Net_project1._1
{ 

    internal class Program
    {
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
            int choice = Convert.ToInt32(Console.ReadLine());

            int age = DateTime.Now.Year - birthyear;

            bool isEligibleForService = gender == "male" && age >= 18 && age <= 50;

            if (choice == 1)
            {
                Console.WriteLine($"Full Name: {firstname}{lastname} ");            
                Console.WriteLine($"Age:  {age}");         
                
                if (isEligibleForService)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("You must go to military service!");
                    Console.WriteLine("********************************");
                }

                Console.WriteLine($"Father name:  {fathername}");
                Console.WriteLine($"Gender (Male or Female):  {gender}");
                Console.WriteLine($"Phone number: {phonenumber}");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Full name:  {firstname}{lastname}");
            }
            else
            {
                Console.WriteLine("Invalid chioce!");
            }
            Console.ReadLine();
        }
    }
    
}

