using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private int durationInSeconds;

        public Call(int durationInSeconds)
        {
            this.durationInSeconds = durationInSeconds;
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int DurationInSeconds
        {
            get { return this.durationInSeconds; }
            set { this.durationInSeconds = value; }
        }        
    }
}
