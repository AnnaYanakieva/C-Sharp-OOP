namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;
        private static GSM iPhone4S = new GSM("4S", "Apple");
        private List<Call> callHistory;

        //constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double? price = null, string owner = null)
            : this(model, manufacturer)
        {

          //  this.CallHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, double price , string owner):this(model,manufacturer)
    {
            this.price = price;
            this.owner = owner;
    }
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
            :this(model,manufacturer,price,owner)
        {

            this.display = display;
            this.battery = battery;
            this.CallHistory = new List<Call>();
        }

        //properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("This is not a valid model");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("This is not a valid manufacturer!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("This is not a valid price");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length > 20 && value.Length < 2)
                {
                    throw new ArgumentException("This is not a valid owner!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }

                this.battery = value;
            }
        }

        public Display Display
        {
            get { return display; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }

                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }

        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { callHistory = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("Model {0}, manufacturer {1}, price {2}, owner {3}",
                this.model, this.manufacturer, this.price, this.owner);
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCalls(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double CalculateTotalPriceOfCalls()
        {
            double price = 0.37;
            double totalPrice = 0;
            foreach (var call in callHistory)
            {
                totalPrice += call.DurationInSeconds;
            }
            return (totalPrice / 60) * price;
        }
    }
}
