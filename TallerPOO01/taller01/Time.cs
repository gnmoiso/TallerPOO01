using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller01
{
    public class Time
    {
        // Camps
        private int _hour;
        private int _minute;
        private int _second;
        private int _milliseconds;

        // builders
        public Time ()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
            _milliseconds = 0;
        }
        public Time (int hour)
        {
            _hour = hour;
        }

        public Time (int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
        }

        public Time (int hour, int minute, int second)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public Time (int hour, int minute, int second, int milliseconds)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
            _milliseconds = milliseconds;
        }

        //Atributes
        public int Hour
        {
            get => _hour;
            set
            {
                Hour = ValidHour ( value );
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                Minute = ValidMinute(value);
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                Second = ValidSecond(value);
            }
        }


        public int Milliseconds
        {
            get => _milliseconds;
            set
            {
                Milliseconds = ValidMillisecond(value);
            }
        }


        //Private Methods
        private int ValidMillisecond(int milliseconds)
        {
            if (milliseconds < 0 || milliseconds > 999)
                throw new Exception($"The Miliseconds {milliseconds} isn´t valid");
            return milliseconds;
        }
        private int ValidSecond(int second)
        {
            if (second < 0 || second > 59)
                throw new Exception($"The Second {second} isn´t valid");
            return second;
        }

        private int ValidMinute(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new Exception($"The Minute {minute} isn´t valid");
            return minute;
        }

        private int ValidHour(int hour)
        {
            if (hour < 0 || hour > 23)
                throw new Exception($"The Hour {hour} isn´t valid");
            return hour;
        }

        //Public Methods
        public int ToMilliseconds()
        {
            if (Hour < 0 || Hour > 23 ||
                Minute < 0 || Minute > 59 ||
                Second < 0 || Second > 59 ||
                Milliseconds < 0 || Milliseconds > 999)
            {
                return 0;
            }

            return (Hour * 3600000) + (Minute * 60000) + (Second * 1000) + Milliseconds;
        }

        public int ToSeconds()
        {
            if (Hour < 0 || Hour > 23 ||
                Minute < 0 || Minute > 59 ||
                Second < 0 || Second > 59)
            {
                return 0;
            }
            return (Hour * 3600) + (Minute * 60) + Second;
        }

        public int ToMinutes()
        {
            if (Hour < 0 || Hour > 23 ||
                Minute < 0 || Minute > 59)
            {
                return 0;
            }

            return (Hour * 60) + Minute;
        }

        public bool IsOtherDay(Time other)
        {
            int thisTotalMs = ToMilliseconds();
            int otherTotalMs = other.ToMilliseconds();

            int oneDayMs = 24 * 60 * 60 * 1000;

            return (thisTotalMs + otherTotalMs) >= oneDayMs;
        }

        public Time Add(Time other)
        {
            int totalMs = Milliseconds + other.Milliseconds;
            int totalSec = Second + other.Second;
            int totalMin = Minute + other.Minute;
            int totalHour = Hour + other.Hour;

            if (totalMs >= 1000)
            {
                totalSec += totalMs / 1000;
                totalMs %= 1000;
            }

            if (totalSec >= 60)
            {
                totalMin += totalSec / 60;
                totalSec %= 60;
            }

            if (totalMin >= 60)
            {
                totalHour += totalMin / 60;
                totalMin %= 60;
            }

            totalHour %= 24;


            return new Time(totalHour, totalMin, totalSec, totalMs);
        }

        public override string ToString()
        {
            int displayHour = Hour;
            string tt = String.Empty;

            if (displayHour == 0)
            {
                displayHour = 12;
                tt = "AM";
            }
            else if (displayHour < 12)
            {
                tt = "AM";
            }
            else if (displayHour == 12)
            {
                tt = "PM";
            }
            else
            {
                displayHour -= 12;
                tt = "PM";
            }

            return $"{displayHour:00}:{Minute:00}:{Second:00}.{Milliseconds:000} {tt}";
        }

    }

       
    }
