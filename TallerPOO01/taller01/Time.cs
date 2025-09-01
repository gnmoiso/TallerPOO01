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
        private int _millisecond;

        // builders
        public Time ()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
            _millisecond = 0;
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
            _millisecond = milliseconds;
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

        public int second
        {
            get => _second;
            set
            {
                second = ValidSecond(value);
            }
        }


        public int Millisecond
        {
            get => _millisecond;
            set
            {
                Millisecond = ValidMillisecond(value);
            }
        }


        private int ValidSecond(int value)
        {
            throw new NotImplementedException();
        }
        private int ValidMillisecond(int value)
        {
            throw new NotImplementedException();
        }

        private int ValidMinute(int value)
        {
            throw new NotImplementedException();
        }

        private int ValidHour(int value)
        {
            throw new NotImplementedException();
        }
    }

       
    }
