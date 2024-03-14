using System;
using ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        // variables
        int age = 25;
        /*float weight = 65.5f;
        double height = 193.5;
        string name = "Bartek";
        bool isStudent = true;*/

        // if statements
        if (age > 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("under 18!!!");
        }

        // for loop
        int count = 15;
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");
        // while loop
        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }

        Console.WriteLine("");
        // array
        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("");
        Console.WriteLine(AddTwoVariables(5, 4));

        Person person1 = new Person();
        person1.setAge(20);
        person1.setName("Bartek");

        person1.printInfo();

        Dog dog = new Dog();
        dog.bark();
        dog.eat();
        
        // try catch finnaly

        try
        {
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(nums[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static int AddTwoVariables(int a, int b)
    {
        return a + b;
    }
}