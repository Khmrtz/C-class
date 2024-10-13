// tamrin
    for (; ; )
    {
        Console.WriteLine("please enter mobile number:");
        string mobile = Console.ReadLine();
        if (mobile.Length == 11 && mobile.StartsWith("0"))
        {
               int mobile_m = int.Parse(mobile);
                Console.WriteLine("inter correct mobile number.");
                break;
        }
        else
        {
            Console.WriteLine("mobile number is wrong.");
        }

    }
