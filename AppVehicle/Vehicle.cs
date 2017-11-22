using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehicle
{
    public abstract class Vehicle
    {
        protected int year = 0;
        protected string model = "";
        private string make = "";

        public Vehicle()
        {

        }

        public Vehicle(int year, string model)
        {
            this.year = year;
            this.model = model;

        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public virtual void SeatBeltAnnouncement()

        {
            Console.WriteLine("Please plug in your seatbelt!");

        }

        public override string ToString()
        {
            return (model);

        }

        public void CalcSpeed(double distance, double time)
        {
            double speed = 0.00;

            speed = (distance / time);

            Console.WriteLine(speed);

        }

        public abstract void Beep();

    }
}
