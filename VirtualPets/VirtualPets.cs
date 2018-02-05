using System;

namespace VirtualPets
{
    public class VirtualPets
    {
        // Fields
        private string droidType;

        private int batteryLevel;
        private int hydraulicPressure;
        private int tuneUp;
        private bool batteryFixed;
        private bool hydraulicPressureFixed;
        private bool isTunedUp;
        

        // Properties
        public string DroidType
        {
            get { return this.droidType; }
            set { this.droidType = value; }
        }

        public int BatteryLevel
        {
            get { return this.batteryLevel; }
            set
            {
                this.batteryLevel = value;
                if (this.batteryLevel < 0)
                {
                    this.batteryLevel = 0;
                }
                if (this.batteryLevel > 100)
                {
                    this.batteryLevel = 100;
                }
            }
        }

        public int HydrolicPressure
        {
            get { return this.hydraulicPressure; }
            set
            {
                this.hydraulicPressure = value;
                if (this.hydraulicPressure < 0)
                {
                    this.hydraulicPressure = 0;
                }
                if (this.hydraulicPressure > 100)
                {
                    this.hydraulicPressure = 100;
                }
            }
        }

        public int TuneUp
        {
            get { return this.tuneUp; }
            set
            {
                this.tuneUp = value;
                if (this.tuneUp < 0)
                {
                    this.tuneUp = 20;
                }
                if (this.tuneUp > 100)
                {
                    this.tuneUp = 100;
                }
            }
        }

        public bool BatteryFixed
        {
            get { return this.batteryFixed; }
            set { this.batteryFixed = value; }
        }

        public bool HydraulicPressureFixed
        {
            get { return this.hydraulicPressureFixed; }
            set { this.hydraulicPressureFixed = value; }
        }

        public bool IsTunedUp
        {
            get { return this.isTunedUp; }
            set { this.isTunedUp = value; }
        }

        // Constructors
        public VirtualPets()
        {
            // Default
        }

        public VirtualPets(string droidType)
        {
            this.droidType = droidType;
            this.batteryLevel = 50;
            this.hydraulicPressure = 50;
            this.tuneUp = 20;
        }

        // Methods
        public void FixBattery()
        {
            this.batteryLevel += (100 - this.batteryLevel);
            Console.WriteLine("{0} battery levels have increased", droidType);
        }

        public void FixHydraulicPressure()
        {
            this.hydraulicPressure += (100 - this.hydraulicPressure);
            Console.WriteLine("{0} hydraulic pressure has increased", droidType);
        }


        public void FixTuneUp()
        {
            this.tuneUp = 100;
            this.batteryLevel = 100;
            this.hydraulicPressure = 100;
            Console.WriteLine("{0} is all tuned up", droidType);
        }

        public void Tick()
        { 
            if (this.batteryFixed == true)
            {
                this.tuneUp = (this.tuneUp > 30 ? this.tuneUp - 30 : this.tuneUp + 10);
                this.batteryFixed = false;
            }
            else if (this.hydraulicPressureFixed == true)
            {
                this.batteryLevel = (this.batteryLevel > 20 ? this.batteryLevel - 20 : this.batteryLevel + 5);
                this.hydraulicPressureFixed = false;
            }
            else
            {
                this.tuneUp = 0;
                this.batteryLevel = (this.batteryLevel > 20 ? this.batteryLevel - 20 : 10);
                this.hydraulicPressure = (this.hydraulicPressure > 40 ? this.hydraulicPressure - 40 : 40);
                this.isTunedUp = false;
            }
        }
    }
}