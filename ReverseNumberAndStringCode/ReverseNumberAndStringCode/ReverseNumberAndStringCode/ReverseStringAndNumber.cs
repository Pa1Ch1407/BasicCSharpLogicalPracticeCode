using System;

class ReverseStringAndNumber
{
    #region Reverse String
    //public void ReverseString(string s)
    //{
    //    string reversed = "";
    //    for(int i = s.Length - 1; i>=0; i--)
    //    {
    //        reversed = reversed + s[i];
    //    }
    //    Console.WriteLine("Reverese String: "+ reversed);
    //}

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the text to be reversed: ");
    //    string value = Console.ReadLine();
    //    ReverseStringAndNumber revString = new ReverseStringAndNumber();
    //    revString.ReverseString(value);
    //}
    #endregion
    #region Reverse Number
    public void ReverseNumber(long n)
    {
        long reversed = 0;
        while(n > 0)
        {
            long digit = n % 10;
            reversed = reversed * 10 + digit;
            n = n / 10;
        }
        Console.WriteLine("Reversed Number: " + reversed);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to be reversed: ");
        long value = long.Parse(Console.ReadLine());
        ReverseStringAndNumber objReverse = new ReverseStringAndNumber();
        objReverse.ReverseNumber(value);
    }
    #endregion
}