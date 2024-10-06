// See https://aka.ms/new-console-template for more information
Console.WriteLine("please inter your first name");
string first_name=Console.ReadLine();
Console.WriteLine("please inter your last name");
string last_name = Console.ReadLine();
Console.WriteLine("please inter your age");
string age= Console.ReadLine();
int age_number = Int32.Parse(age);
if (age_number <15 || age_number >120)
{
    Console.WriteLine("you cnnot register");
}
Console.WriteLine("please inter your phone number");
string phone = Console.ReadLine();
int phone_number = phone.Length;
if (phone_number<11)
{
    Console.WriteLine("your number is invalid");
}
Console.ReadKey();


