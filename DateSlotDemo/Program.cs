using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DateSlotDemo.Converter;

namespace DateSlotDemo
{
    class Program
    {
        private static List<string> timeSlot = new List<string>()
        {
        };
        public static void SetSlots(string value)
        {
            timeSlot.Add("12:00am - 12:30am");
            timeSlot.Add("12:30am - 1:00am");
            timeSlot.Add("1:00am - 1:30am");
            timeSlot.Add("1:30am - 2:00am");
            timeSlot.Add("2:00am - 2:30am");
            timeSlot.Add("2:30am - 3:00am");
            timeSlot.Add("3:00am - 3:30am");
            timeSlot.Add("3:30am - 4:00am");
            timeSlot.Add("4:00am - 4:30am");
            timeSlot.Add("4:30am - 5:00am");
            timeSlot.Add("5:00am - 5:30am");
            timeSlot.Add("5:30am - 6:00a");
            timeSlot.Add("6:00am - 6:30am");
            timeSlot.Add("6:30am - 7:00am");
            timeSlot.Add("7:00am - 7:30am");
            timeSlot.Add("7:30am - 8:00am");
            timeSlot.Add("8:00am - 8:30am");
            timeSlot.Add("8:30am - 9:00am");
            timeSlot.Add("9:00am - 9:30am");
            timeSlot.Add("9:30am - 10:00am");
            timeSlot.Add("10:00am - 10:30am");
            timeSlot.Add("10:30am - 11:00am");
            timeSlot.Add("11:00am - 11:30am");
            timeSlot.Add("11:30am - 12:00pm");
            timeSlot.Add("12:00pm - 12:30pm");
            timeSlot.Add("12:30pm - 1:00pm");
            timeSlot.Add("1:00pm - 1:30pm");
            timeSlot.Add("1:30pm - 2:00pm");
            timeSlot.Add("2:00pm - 2:30pm");
            timeSlot.Add("2:30pm - 3:00pm");
            timeSlot.Add("3:00pm - 3:30pm");
            timeSlot.Add("3:30pm - 4:00pm");
            timeSlot.Add("4:00pm - 4:30pm");
            timeSlot.Add("4:30pm - 5:00pm");
            timeSlot.Add("5:00pm - 5:30pm");
            timeSlot.Add("5:30pm - 6:00pm");
            timeSlot.Add("6:00pm - 6:30pm");
            timeSlot.Add("6:30pm - 7:00pm");
            timeSlot.Add("7:00pm - 7:30pm");
            timeSlot.Add("7:30pm - 8:00pm");
            timeSlot.Add("8:00pm - 8:30pm");
            timeSlot.Add("8:30pm - 9:00pm");
            timeSlot.Add("9:00pm - 9:30pm");
            timeSlot.Add("9:30pm - 10:00pm");
            timeSlot.Add("10:00pm - 10:30pm");
            timeSlot.Add("10:30pm - 11:00pm");
            timeSlot.Add("11:00pm - 11:30pm");
            timeSlot.Add("11:30am - 11:59pm");
        }

        static void Main(string[] args)
        {
            //Given: an int ranging between 1 and 48
            //Returned: The corresponging 30 min time slot.
            //(i.e 1 = 12:00 _12:30am and 11:30 - 11:59pm)
            Console.WriteLine(timeSlot[1]);
            var test1 = Converter.IntToTimeSlot(TimeSlot.one);
            Console.WriteLine(test1);

            var test2 = Converter.IntToTimeSlot(TimeSlot.two);
            Console.WriteLine(test2);

            var testX = Converter.IntToTimeSlot(TimeSlot.fortyeight);
            Console.WriteLine(testX);
        }
    }
}
