using System;

namespace Army_Hierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            string b = Console.ReadLine();
            double a = double.Parse(b);
            Console.WriteLine(1+a);
        }
    }
}
