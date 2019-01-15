using System;

namespace opgave_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now; Console.WriteLine(d1);

            d1 = d1.AddDays(10); Console.WriteLine(d1);
            d1 = d1.AddMinutes(20); Console.WriteLine(d1);
            d1 = d1.AddMonths(-1); Console.WriteLine(d1);

            DateTime myBirthday = new DateTime(1967, 11, 10);
            DateTime currentDate = DateTime.Now;
            TimeSpan minAlder = currentDate - myBirthday;
            Console.WriteLine("Min alder i dage er: " + minAlder.TotalDays);        
            Console.WriteLine("Min alder i minuttter er: " + minAlder.TotalHours);
            Console.WriteLine("Min alder i år er: " + CalculateAge(myBirthday));
            
            TimeSpan t2 = new TimeSpan(16, 0, 0); Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 30, 0); Console.WriteLine(t3);
            TimeSpan t4 = t2 - t3; Console.WriteLine(t4);
            TimeSpan t5 = t2 + t3; Console.WriteLine(t5);
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int CalculateAge(DateTime BirthDate)
        {
            int YearsPassed = DateTime.Now.Year - BirthDate.Year;
            // Are we before the birth date this year? If so subtract one year from the mix
            if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
            {
                YearsPassed--;
            }
            return YearsPassed;
        }
    }
}
