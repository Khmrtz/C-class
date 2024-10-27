// fundamental class


//Console.WriteLine("please enter your first name");
//string? FirstName=Console.ReadLine();
//Console.WriteLine("please enter your last name"); 
//string LastName=Console.ReadLine() ??"";
//Console.WriteLine("Please enter your age");
//int age=int.Parse(Console.ReadLine()?? "" );
//if (age<18)
//{
//    Console.WriteLine("You are not valid to register");
//    return;
//}
Console.WriteLine("please enter your brithday month");
string BirthMonth = Console.ReadLine() ?? "";
BirthMonth = BirthMonth.Trim().ToLower();
//BirthMonth=BirthMonth.Trim();
//BirthMonth = BirthMonth.ToLower();





Console.WriteLine("please enter your mobile number");
string PhoneNumber = Console.ReadLine() ?? "";

//if (PhoneNumber==null || PhoneNumber=="")
//{
//    Console.WriteLine("Please enter valid mobile number (null or '')");
//}

if (string.IsNullOrEmpty(PhoneNumber))
{
    Console.WriteLine("Please enter valid mobile number (string.isnullorempty)");
}

PhoneNumber = PhoneNumber.Trim().Replace("+98", "0");

//PhoneNumber = PhoneNumber.TrimEnd(' ');
//PhoneNumber = PhoneNumber.TrimStart(' ');


//if (PhoneNumber.StartsWith("+98"))
//{
//    PhoneNumber = PhoneNumber.Replace("+98", "0");
//}
if (PhoneNumber.Length == 10 && !PhoneNumber.StartsWith("0"))
{
    PhoneNumber="0"+PhoneNumber;
}
else
{
    Console.WriteLine("Please enter valid mobile number");
}








Console.WriteLine("end");
