//  exercise session 4 

using System.ComponentModel;

class program
{
    public static void Main()
    {
        // sum two number
        Console.WriteLine("please enter first number: ");
        int  num1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter second number");
        int num2= Convert.ToInt32(Console.ReadLine());
        int result=add (num1, num2);
        Console.WriteLine(" the sum of two numbers is " + result);
        // is divisible 
        bool divisible =IsDivisible(num1, num2);
        if (divisible)
        {
            Console.WriteLine($"{num1} is divisible by {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} is not divisible by {num2}");
        }
        // number is odd or even
        Console.WriteLine("please enter a number: ");
        int number  =Convert.ToInt32(Console.ReadLine());
        bool isEven=IsEven(number);
        if (isEven)
        {
            Console.WriteLine($"{number} is an even number");
        }
        else
        {
            Console.WriteLine($"{number} is an oddd number");
        }
        //  find smallest number
        Console.WriteLine("How many numbers do you want to enter?");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] numbers=new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"please enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int smallestNumber = FindSmallest(numbers);
        Console.WriteLine($"the smallest number is :{smallestNumber}");              


    }

    static int add (int num1, int num2)
    { 
        return num1 + num2;
    }
    
    static bool IsDivisible (int num1, int num2)
    {
        return num1 % num2==0;
    }
    static bool IsEven(int num1)
    {
        return num1 % 2 == 0;
    }

    static int FindSmallest(int[] nums)
    {
        // supose first number is smallest
        int smallest = nums[0];
        for(int i=1;i<nums.Length; i++)
        {
            if (nums[i] < smallest)
            {
                smallest = nums[i];
            }
        }            
        return smallest;
    }



}

