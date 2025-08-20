using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3rdOOPtasks
{
    internal class Duration
    {
        public int hours {  get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }


        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            Normalize();
        }
        public Duration (int s)
        { this.hours = s / 3600;
            this.minutes = (s % 3600) / 60;
            this.seconds = s % 60;
        }

        private void Normalize()
        {
            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds %= 60;
            }

            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }
        }
        public override string ToString()
        {
            if (hours > 0)
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
            else if (minutes > 0)
                return $"Minutes: {minutes}, Seconds: {seconds}";
            else
                return $"Seconds: {seconds}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Duration other = obj as Duration;
            if (other.hours == this.hours && other.minutes == this.minutes && other.seconds == this.seconds)
                return true;
            else
                return false;
        }
        // to use in comparisons (easier )
        private int ToTotalSeconds() => hours * 3600 + minutes * 60 + seconds;

        public static Duration operator + (Duration d1 , Duration d2)
        {
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);
        }
        public static Duration operator +(Duration d1, int x)
        {
            
            return new Duration(d1.ToTotalSeconds()+x);
       }
        public static Duration operator +(int x, Duration d1)
        {

            return new Duration( x+ d1.ToTotalSeconds());
        }

        public static Duration operator ++ (Duration d1)
        {
            return new Duration(d1.hours, d1.minutes + 1, d1.seconds);
        }
        public static Duration operator --(Duration d1)
        {
            return new Duration(d1.hours, d1.minutes - 1, d1.seconds);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds()>d2.ToTotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }
        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today.AddHours(d.hours).AddMinutes(d.minutes).AddSeconds(d.seconds);
        }
    }
}
