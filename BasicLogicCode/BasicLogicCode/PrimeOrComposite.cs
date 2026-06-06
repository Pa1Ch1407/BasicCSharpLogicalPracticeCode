using System;

class PrimeOrComposite
{
    #region Find given number Prime or not 
    //Find wether the given number is Prime or not
    //public void PrimeOrNot(int n)
    //{
    //    if(n > 1)
    //    {
    //        int count = 0;
    //        for(int i = 1; i<=n; i++)
    //        {
    //            if(n%i  == 0)
    //            {
    //                count++;
    //            }
    //        }
    //        if(count == 2)
    //        {
    //           Console.WriteLine(n + " is Prime Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(n +" is Composite Number");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine(n + "Given Number is not Prime or Composite");
    //    }
    //}

    //static void Main(String[] args)
    //{
    //    Console.Write("Enter the Number:");
    //    int num = int.Parse(Console.ReadLine());
    //    Find wether the given number is Prime or not
    //    PrimeOrComposite objPrime = new PrimeOrComposite();
    //    objPrime.PrimeOrNot(num);
    //    Console.Read();
    //}
    #endregion

    #region Find list of Prime and composite numbers till the given number 
    public void PrimeAndComposite(int n)
    {
        Console.WriteLine("\n List of Prime Numbers are: ");
        for(int num = 2; num <= n; num++)
        {
            int count = 0;
            for(int i = 1; i<= num; i++)
            {
                if(num%i == 0)
                {
                    count++;
                }   
            }
            if (count == 2)
            {
                Console.WriteLine(num);
            }
        }
        Console.WriteLine("\n List of Composite Numbers are: ");
        for (int num = 2; num <= n; num++)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine(num);
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number: ");
        int number = int.Parse(Console.ReadLine());
        PrimeOrComposite objPrime = new PrimeOrComposite();
        objPrime.PrimeAndComposite(number);
        Console.Read();
    }

    #endregion
}