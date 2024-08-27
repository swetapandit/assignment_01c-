using System;
using System.ComponentModel;

namespace Assignment1
{

    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("hello Duniya");
            //A1Q1 a1q1 = new A1Q1();
            //a1q1.function1();
            //Console.ReadLine();
            //A1Q2 a1q2 = new A1Q2();
            //a1q2.function1();
            //Console.ReadLine();
            //A1Q3 a1q3 = new A1Q3();
            //a1q3.deposit_amount();
            //a1q3.Withdraw();
            //Console.ReadLine();
            //A1Q4 a1q4 = new A1Q4();
            //a1q4.disp_grade()
            //Console.ReadLine();
            //A1Q5 a1q5 = new A1Q5();
            //a1q5.valid();
            //Console.ReadLine();
            //A1Q6 a1q6 = new A1Q6();
            //a1q6.valid();
            //Console.ReadLine();
            //A1Q7 a1q7 = new A1Q7();
            //a1q7.valid();
            //Console.ReadLine();
            //A1Q8 a1q8 = new A1Q8();
            //a1q8.valid();
            //Console.ReadLine();
            A1Q10 a1q10 = new A1Q10();
            a1q10.valid();
            Console.ReadLine();
        }
    }
}
//Write a C# program to calculate the total price of items in a shopping cart.
//The cart contains 5 items with different prices. Include a 10% discount if the total price
//exceeds Rs. 3000.


class A1Q1
{
    private int size;
    private float total_price;

    public void function1()
    {
        Console.WriteLine("Enter the size of the item_list: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] items = new int[size];
        total_price = 0.0f;
        Console.WriteLine("Enter the prices of items in the cart: ");
        for (int i = 0; i < size; i++)
        {

            items[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            total_price += items[i];
        }
        if(total_price>3000)
        {
            total_price =(float) (total_price - (total_price * (0.1)));
        }
        Console.WriteLine("Amount to be paid " + total_price);
    }
}

//Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit.
//If the input temperature is below 0°C, display a warning message about freezing temperatures

class A1Q2
{
    private float temp_cel;
    private float temp_fh;
    public void function1()
    {
        Console.WriteLine("Enter the temperature in celsius: ");
        temp_cel = (float)Convert.ToDouble(Console.ReadLine());
        if(temp_cel>0)
        {
            temp_fh = (9 * temp_cel + 160) / 5;
            Console.WriteLine("temperature in fah " + temp_fh);
        }
        else
        {
            Console.WriteLine("It is freezing temperature");
        }
    }
}

//Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money, and withdraw
//money. Ensure that the program checks for sufficient funds before allowing a withdrawal.

class A1Q3
{
    private float balance;
    private float deposit;
    private float withdraw;
    public void deposit_amount()
    {
        Console.WriteLine("Enter the amount to be deposited ");
        deposit = (float)Convert.ToDouble(Console.ReadLine());
        balance += deposit;
    }
    public bool CheckBalance(float withdraw)
    {
        if (balance > withdraw)
        {
            return true;
        }
        else return false;
    }
    public void Withdraw()
    {
        Console.WriteLine("Enter the amount to be withdraw ");
        withdraw = (float)Convert.ToDouble(Console.ReadLine());
        if (CheckBalance(withdraw)==true)
        {
            Console.WriteLine("Withdraw successfully");
            balance -= withdraw;
            Console.WriteLine("Current balance "+balance);
        }
    }
}

//Write a C# program to take the marks of five subjects from a user and calculate the average. Based on the average, determine
//and display the grade (A, B, C, D, or F).

class A1Q4
{
    private float total;
    private float temp;
    private char grade;
    public void disp_grade()
    {
        Console.WriteLine("Enter the marks ");
        for (int i=0;i<5;i++)
        {
            temp = (float)Convert.ToDouble(Console.ReadLine());
            total += temp;
        }
        total /= 5;
        if (total > 90) grade = 'A';
        else if (total > 80) grade = 'B';
        else if (total > 70) grade = 'C';
        else if (total > 50) grade = 'D';
        else grade = 'E';
        Console.WriteLine("Your grade is: " + grade);
    }
}

//Develop a C# application that asks the user to enter a password. The password should be validated based on the following
//criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter, and one number.
//Display appropriate messages based on the validation result

class A1Q5
{
    private string my_password;
    public void valid()
    {
        int isUppe = 0, islower = 0, isnum = 0;
        Console.WriteLine("Enter the password ");
        my_password = Console.ReadLine();
        if (my_password.Length >= 8)
        {
            for(int i=0;i<my_password.Length-1;i++)
            {
                if (my_password[i] >= 'A' && my_password[i] <= 'Z') isUppe++;
                else if (my_password[i] >= 'a' && my_password[i] <= 'z') islower++;
                else if (my_password[i] > '0' && my_password[i] <= '9') isnum++;
            }
        }
        if(isnum>0 && islower>0 && isUppe>0)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }
    }
}


//Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance traveled.
//The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged at a per-kilometer rate.
//Include a night surcharge if the ride occurs after 10 PM.

class A1Q6
{
    private int fare;
    private int distance;
    private int total;
    public void valid()
    {
        fare = 20;
        Console.WriteLine("Enter the Distance ");
        distance = Convert.ToInt32(Console.ReadLine());
        if (distance > 2)
        {
            total = distance * fare;
        }
        else total = fare;
        Console.WriteLine("Total fare= "+ total);
    }
}

//A school tracks the attendance of students over 5 days. The system should be able to record attendance, calculate the total
//number of days attended, and identify if a student has perfect attendance

class A1Q7
{

    private int size;
    private char ispresent;
    private int tot_att;
    public void valid()
    {
        size = 5;
        int[] student = new int[size];
        Console.WriteLine("Mark Y for present and N for absent ");
        for(int i=0;i<size;i++)
        {
            ispresent = Console.ReadLine()[0];
            if (ispresent == 'Y') tot_att++;
        }
        if (tot_att == size) Console.WriteLine("Perfect attendence");
        else Console.WriteLine("Not Perfect");
    }
}


//An individual tracks their expenses for each month in a year. They want to calculate the total expenses for the year
//and identify the month with the highest and lowest expenses.

class A1Q8
{

    private int size;
    private int sum;
    private int mx = int.MinValue;
    private int mn = int.MaxValue;
    public void valid()
    {
        size = 12;
        int[] expenses = new int[size];
        Console.WriteLine("Enter the expenses of all month of the year ");
        for(int i=0;i<size;i++)
        {
            expenses[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            sum += expenses[i];
            if (expenses[i] > mx) mx = expenses[i];
            if (expenses[i] < mn) mn = expenses[i];
        }
        Console.WriteLine("Total expense " + sum);
        Console.WriteLine("Maximum expense " + mx);
        Console.WriteLine("Minimum expense " + mn);
    }
}

//Implement a shopping cart system where a user can add items, remove items, and view the total price.
//Assume each item has a name and a price.
class CartItem
{
    string Name;
    double Price;
    public CartItem(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
class A1Q9
{
    CartItem[] items;
    int itemQuantity;
    //private int size;
    //method to add, method to remove, method to display cart
    //predefined data OR ask user for items
    //remove: display cart->get item remove it
    //price -> calculate cart
    public A1Q9(int size)
    {
        items = new CartItem[size];
        itemQuantity = 0;

    }

    public void AddCart(CartItem item)
    {
        itemQuantity++;

    }
    public void cart()
    {
        
    }
}
//Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of hours
//worked in a week. Consider that there are 4 weeks in a month.


class A1Q10
{
    public void valid()
    {
        const int weeksInMonth = 4;
        Console.Write("Enter hourly wage: ");
        decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter number of hours worked per week: ");
        int hoursPerWeek = Convert.ToInt32(Console.ReadLine());
        decimal weeklySalary = hourlyWage * hoursPerWeek;
        decimal monthlySalary = weeklySalary * weeksInMonth;
        Console.WriteLine($"\nThe monthly salary is: ${monthlySalary}");
    }
}


