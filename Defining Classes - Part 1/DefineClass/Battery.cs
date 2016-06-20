using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{   
    public class Battery
    {
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        //constructors
        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;
        }

        public Battery(string batteryModel, BatteryType batteryType)
            : this(batteryModel)
        {
            this.batteryType = batteryType;

        }

        //properties

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }  

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }

        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

    }
}
