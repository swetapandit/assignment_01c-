//internal class Program
//{
//    private static void Main(string[] args)
//    {

//        Console.WriteLine("hello Duniya");
//        Console.Read();
//    }
//}



//1.Imagine you are developing a basic calculator for a financial application. You need to calculate the total sum of all the transactions recorded in a day. Write a C# program to find the sum of all elements in an integer array using a loop.
//Input: int[] transactions = { 200, -150, 340, 500, -100 };


//using System;
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int size = Convert.ToInt32(Console.ReadLine());
//        int[] transactions=new int[size];
//        int sum = 0;
//        for(int i=0;i<size;i++)
//        {
//            transactions[i] =Convert.ToInt32(Console.ReadLine());
//        }
//        for (int i = 0; i < size; i++)
//        {
//            sum += transactions[i];
//        }
//        Console.WriteLine(sum);
//        Console.Read();
//    }
//}

//You are working on an analytics tool that needs to find the average score of a class from a list of floating-point numbers. Create a C# program that calculates the average of values in a floating-point array using a loop.
//Input: float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };

//using System;
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int size = Convert.ToInt32(Console.ReadLine());
//        float[] transactions = new float[size];
//        float sum = 0;
//        for (int i = 0; i < size; i++)
//        {
//            transactions[i] = (float)Convert.ToDouble(Console.ReadLine());
//        }
//        for (int i = 0; i < size; i++)
//        {
//            sum += transactions[i];
//        }
//        Console.WriteLine(sum/size);
//        Console.Read();
//    }
//}

//input a list of 10 numbers and find the second largest number.

using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] transactions = new int[size];
        for (int i = 0; i < size; i++)
        {
            transactions[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(transactions);
        Console.WriteLine("last 2nd largest element is "+ transactions[size-2]);
        Console.Read();
    }
}