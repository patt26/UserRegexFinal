using System;
using System.Text.RegularExpressions;

namespace RegexFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice: \n 1: Name Validator\n 2: Email Validator\n 3: Mobile Number Validator\n 4: Password Validator");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Name pattern = new Name();
                    bool result = pattern.ValidateName(FirstName());
                    Console.WriteLine(result);
                    bool result1 = pattern.ValidateName(LastName());
                    Console.Write(result1);
                    break;
                case 2:
                    EmailId pattern1 = new EmailId();
                    Console.Write("Enter Email ID - ");
                    string name = Console.ReadLine();
                    bool result2 = pattern1.ValidateEmail(name);
                    Console.WriteLine(result2);
                    Console.ReadKey();
                    break;
                case 3:
                    PhoneNum pattern3 = new PhoneNum();
                    Console.Write("Enter Mobile Number - ");
                    string name1 = Console.ReadLine();
                    bool result3 = pattern3.PhoneValidator(name1);
                    Console.WriteLine(result3);
                    Console.ReadKey();
                    break;
                case 4:
                    Password pattern4 = new Password();
                    Console.Write("Enter Password - ");
                    string name2 = Console.ReadLine();
                    bool result4 = pattern4.Validate(name2);
                    Console.WriteLine(result4);
                    Console.ReadKey();
                    break;
            }
        }
        public static string LastName()
         {
            Console.WriteLine("Enter Last Name= ");
            string LName = Console.ReadLine();
            return LName;
         }

        public static string FirstName()
        {
            Console.WriteLine("Enter a First Name = ");
            string FName = Console.ReadLine();
            return FName;
        }
    }
}
    
