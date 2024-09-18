using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Dto;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Common.Utlities
{
    public static class Utlities
    {
        public const string DriverPhoto = "DriverPhoto";
        public const string KSATimeZone = "Asia/Riyadh";

        #region Status Lookup
        public const string Approved = "Approved";
        public const string Pending = "Pending";
        #endregion
        public const int AdminRole = 1;
        public const int UserRole = 2;
        public const int DriverRole = 3;


        public static List<int> OrdersNotTaken = new List<int>();

        public static string ConvertToHijri(DateTime gregorianDate)
        {
            // Create a new instance of the HijriCalendar
            HijriCalendar hijriCalendar = new HijriCalendar();

            // Convert the Gregorian date to Hijri
            int hijriYear = hijriCalendar.GetYear(gregorianDate);
            int hijriMonth = hijriCalendar.GetMonth(gregorianDate);
            int hijriDay = hijriCalendar.GetDayOfMonth(gregorianDate);

            // Format the Hijri date string
            string hijriDate = $"{hijriYear:0000}/{hijriMonth:00}/{hijriDay:00}";

            return hijriDate;
        }

        public static DateTime ConvertToGregorianDate(string hijiraDate)
        {
            try
            {
                var hijriDates = hijiraDate.Split("/");
                int hijriYear = int.Parse(hijriDates[0]);
                int hijriMonth = int.Parse(hijriDates[1]);
                int hijriDay = int.Parse(hijriDates[2]);
                // Create a new instance of the HijriCalendar
                HijriCalendar hijriCalendar = new HijriCalendar();

                // Convert the Hijri date to Gregorian date
                DateTime gregorianDate = hijriCalendar.ToDateTime(hijriYear, hijriMonth, hijriDay, 0, 0, 0, 0);

                return gregorianDate;
            }
            catch (Exception) { return DateTime.Now; }

        }

        public static string ConvertMinutesToHoursAndMinutes(int totalMinutes)
        {
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            return $"{hours} hours and {minutes} minutes.";
        }


        public static string SetError(this string errorMessage)
        {
            var error = new Error();
            error.SetError(errorMessage);
            string formattedJson = error.ToJsonString(); ;
            return formattedJson;
        }

        public static string SetPageination(int totalPages, int currentPage, int TotalCount)
        {
            var pagenation = new Pagenation()
            {
                TotalPages = totalPages,
                CurrentPage = currentPage,
                TotalCount = TotalCount,
            };

            string formattedJson = pagenation.ToJsonString();
            return formattedJson;
        }



        public static string GenerateUniqueId()
        {
            // Get current date and time
            Random random = new Random();
            DateTime now = DateTime.Now;

            // Extract components of date and time to create a unique long value
            long uniqueValue = now.Year * 10000000000 +
                               now.Month * 100000000 +
                               now.Day * 1000000 +
                               now.Hour * 10000 +
                               now.Minute * 100 +
                               now.Second;

            // Use the uniqueValue as seed for the random number generator
            random.Next(); // Ensure the seed is different for each call
            int randomNumber = random.Next(10000000, 100000000); // Generate random number between 10000000 and 99999999

            // Combine the unique value and random number to ensure uniqueness
            int uniqueId = (int)(uniqueValue + randomNumber);

            return uniqueId.ToString();
        }
    }
}
