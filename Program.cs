// fundamental class


using System.ComponentModel.Design;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            student student = new();
            student.firstNmae = "khm";
            student.lastNmae = "MRTZ";
            student.age = 30;
            student.phoneNumber = 09122117955;
        }
    }
}







//Console.WriteLine("please enter your first name");
//string? FirstName = Console.ReadLine();
//Console.WriteLine("please enter your last name");
//string LastName = Console.ReadLine() ?? "";

//do
//{
//    Console.ForegroundColor =ConsoleColor.White;
//    Console.WriteLine("Please enter your age");
//    int age = int.Parse(Console.ReadLine() ?? "");
//    if (age < 18 || age>120)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("You are not valid to register");
//    }
//    else
//    {
//        Console.WriteLine("You can register");
//        break;
//    }
//} while (true);


//do 
//{
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine("Please ente your phone number:");
//    string phoneNumber = Console.ReadLine() ?? string.Empty;
//    if ((phoneNumber.Length == 11 && phoneNumber.StartsWith("0")) || (phoneNumber.Length == 10 && !phoneNumber.StartsWith("0")))
//        {
//            try
//            {
//            long phone = long.Parse(phoneNumber);
//            Console.WriteLine("correct phone number.");
//            break;
//            }
//            catch
//            {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Invalid phone number.");
//            }
//        }
//    else
//        {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Invalid phone number.");
//        }
//} while(true);



