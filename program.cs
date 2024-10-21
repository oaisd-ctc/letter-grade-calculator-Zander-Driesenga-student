using System;


public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Input your grade (0 - 100)");
       int grade = int.Parse(Console.ReadLine());
       if (grade >= 100)
       {
        Console.WriteLine("Letter Grade: A+");
        Console.WriteLine("Wow! 100...That's impresive!");
       }
       else if (grade >= 90)
       {
        Console.WriteLine("Letter Grade: A");
        Console.WriteLine("Very nice!");
       }
       else if (grade >= 80)
       {
        Console.WriteLine("Letter Grade: B");
        Console.WriteLine("Keep it up!");
       }
       else if (grade >= 70)
       {
        Console.WriteLine("Letter Grade: C");
        Console.WriteLine("You got this, jeep working!");
       }
       else if (grade >= 60)
       {
        Console.WriteLine("Letter Grade: D");
        Console.WriteLine("Keep trying!");
       }
       else
       {
        Console.WriteLine("Letter Grade: E");
        Console.WriteLine("Don't give up!");
       }
    }
}
