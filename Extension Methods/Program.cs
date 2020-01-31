using System;
using System.IO;

namespace Extension_Methods
{

    public class Car
    {
        public bool isDriving { get; set; }
    }

    static class CarExtension
    {
        public static void Drive(this Car car, bool status)
        {
            car.isDriving = status;
        }
    }

    static class DirectoryinfoExtensions
    {
        public static void Copy(this DirectoryInfo directory, string targetPath)
        {
            Console.WriteLine($"Copy directory to {targetPath}");
        }
    }

    static class StringExtensions
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }

            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------Car example----------------");
            Car car = new Car();
            Console.WriteLine(car.isDriving);
            car.Drive(true);
            Console.WriteLine(car.isDriving);

            Console.WriteLine("--------------Directory example-------------");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp");
            directory.Copy(@"C:\NewTemp");

            Console.WriteLine("---------------String example---------------");
            string NewString = "Hello world";
            Console.WriteLine(NewString.Truncate(5));
        }
    }
}
