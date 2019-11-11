using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Bill
{
    class Program
    {

        static double CalculateBill(DateTime start, DateTime end)
        {
            DateTime peakTimeStart = DateTime.Parse("09:00:00 AM");
            DateTime peakTimeEnd = DateTime.Parse("22:59:00 PM");

            double totalBill = 0;

            while (start <= end)
            {
                if (DateTime.Parse(start.ToLongTimeString()) >= peakTimeStart && DateTime.Parse(start.ToLongTimeString()) <= peakTimeEnd)
                {
                    start = start.AddSeconds(20);

                    //Console.WriteLine(start);

                    totalBill += 0.3;
                }
                else
                {
                    start = start.AddSeconds(20);

                    //Console.WriteLine(start);

                    if (DateTime.Parse(start.ToLongTimeString()) >= peakTimeStart && DateTime.Parse(start.ToLongTimeString()) <= peakTimeEnd)
                    {
                        totalBill += 0.3;
                    }
                    else
                    {
                        totalBill += 0.2;
                    }

                }


            }

            return totalBill;
        }

        static void Main(string[] args)
        {
            string startTime, endTime;

            DateTime start, end;

            Console.WriteLine("Enter Start Time : ");
            startTime = Console.ReadLine();

            Console.WriteLine("Enter End Time : ");
            endTime = Console.ReadLine();



            //startTime = "2019-08-31 08:59:13 am";
            //endTime = "2019-08-31 09:00:39 am";


            start = Convert.ToDateTime(startTime);
            end = Convert.ToDateTime(endTime);


            double totalBill = CalculateBill(start, end);

            Console.WriteLine(totalBill);


            Console.ReadKey();

        }
    }
}
