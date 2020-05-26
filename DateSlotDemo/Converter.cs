using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSlotDemo
{
    class Converter
    {

        public enum TimeSlot 
        {
            one = 1,
	        two,
	        three,
	        four,
	        five,
	        six,
	        seven,
	        eight,
	        nine,
	        ten,
	        eleven,
	        twelve,
	        thirteen,
	        fourteen,
	        fifteen,
	        sixteen,
	        seventeen,
	        eighteen,
	        nineteen,
	        twenty,
	        twentyone,
	        twentytwo,
	        twentythree,
	        twentyfour,
	        twentyfive,
	        twentysix,
	        twentyseven,
	        twentyeight,
	        twentynine,
	        thirty,
	        thirtyone,
	        thirtytwo,
            thirtythree,
	        thirtyfour,
	        thirtyfive,
	        thirtysix,
	        thirtyseven,
	        thirtyeight,
	        thirtynine,
	        forty,
	        fortyone,
	        fortytwo,
	        fortythree,
	        fortyfour,
	        fortyfive,
	        fortysix,
	        fortyseven,
	        fortyeight

        }
        public static string IntToTimeSlot(TimeSlot slot)
        {              
            var today = DateTime.Now;
            var initialSlot = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);

            var minutes = 30 * ((int)slot - 1);
            var startingTime = initialSlot.AddMinutes((int)slot - 1 * 30);

            var endingTime = startingTime.AddMinutes(30);
            if (endingTime.Date == initialSlot.AddDays(1))
                endingTime = endingTime.AddSeconds(-1);

            return $"{startingTime} - {endingTime}";            
        }

        public static string IntToTimeSlotV2(TimeSlot slot)
        {
            var today = DateTime.Now;
            var initialSlot = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);

            var minutes = 30 * ((int)slot - 1);
            var startingTime = initialSlot.AddMinutes((int)slot - 1 * 30);

            var endingTime = startingTime.AddMinutes(30);
            if (endingTime.Date == initialSlot.AddDays(1))
                endingTime = endingTime.AddSeconds(-1);

            return $"{startingTime.ToString().Split(' ')} - {endingTime}";
        }
    }
}
