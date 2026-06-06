using System;

class Factorial
{
    public void Multiply(int n)
    {
        long factorial = 1;
        if(n > 0)
        {
            for(int i=1; i<=n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of "+n+" is "+factorial);
        }
        else
        {
            Console.WriteLine("Factorial is not possible for this number");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        Factorial factorial = new Factorial();
        factorial.Multiply(num);
    }
}