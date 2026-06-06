using System;
class Fibonacci
{
    #region Find fibonacci series of the given length
    //public void Value(int n)
    //{
    //    int firstValue = 0;
    //    int secondValue = 1;
    //    for(int i = 1; i<n; i++)
    //    {
    //        Console.WriteLine(firstValue + " ");
    //        int next = firstValue + secondValue;
    //        firstValue = secondValue;
    //        secondValue = next;
    //    }
    //}
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the value:");
    //    int i = int.Parse(Console.ReadLine());
    //    Fibonacci fibonacci = new Fibonacci();
    //    fibonacci.Value(i);
    //    Console.Read();
    //}
    #endregion
    #region Find fibonacci value of the given number
    public void value(int n)
    {
        int first = 0; int second = 1;
        if(n == 0)
        {
            Console.WriteLine(first);
        }
        else if(n == 1)
        {
            Console.WriteLine(second);
        }
        else
        {
            for(int i = 2; i<= n; i++)
            {
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine("Fibonacci number is: "+second);
        }
    }
    static void Main(string[] args)
    {
        Fibonacci fibonacci = new Fibonacci();
        fibonacci.value(10);
        Console.Read();
    }
    #endregion
}