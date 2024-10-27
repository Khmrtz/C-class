// fundamental class


using System.ComponentModel.Design;

class program
{
    static void Main()
    {
        int[,] matrix = new int[2, 2];
        {
            matrix[0,0] = 1;
            matrix[0,1] = 2;
            matrix[1,0] = 3;
            matrix[1,1] = 4;
        };
        Console.WriteLine(matrix);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(matrix[i, j]+"");
            }
            Console.WriteLine();
        }
    }
    
    
}






//namespace ConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StudentClass student = new StudentClass();
//            student.FirstName = "Test";
//            student.LastNmae = "";
//            student.Age= 30;
//            student.PhoneNumber = 09122117958;
//        }
//    }
//}


//Console.WriteLine("please enter your first name");
//StudentClass student = new StudentClass();
//Console.WriteLine("please enter first name");
//student.FirstName = Console.ReadLine()??"";
//Console.WriteLine("please enter your last name");
//student.LastNmae = Console.ReadLine() ?? "";

//do
//{
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine("Please enter your age");
//    student.Age = int.Parse(Console.ReadLine() ?? "");
//    if (student.Age < 18 || student.Age > 120)
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

//    student.PhoneNumber = int.Parce( Console.ReadLine());

//    if ((phoneNumber.Length == 11 && phoneNumber.StartsWith("0")) || (phoneNumber.Length == 10 && !phoneNumber.StartsWith("0")))
//    {
//        try
//        {
//            long phone = long.Parse(phoneNumber);
//            Console.WriteLine("correct phone number.");
//            break;
//        }
//        catch
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Invalid phone number.");
//        }
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Invalid phone number.");
//    }
//} while (true);



