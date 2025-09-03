using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller01
{
    internal class Time
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
        private int ValidSecond(int milliseconds)
        {
            if (milliseconds < 0 || milliseconds > 999)
                throw new Exception($"The Miliseconds {milliseconds} isn´t valid");
            return milliseconds;
        }
        private int ValidMillisecond(int second)
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



    }

       
    }
