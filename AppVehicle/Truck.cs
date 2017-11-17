using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehicle
{
    class Truck : Vehicle
    {

        public Truck() : base()
        {

        }

        public Truck(int year, string model) : base(year, model)
        {

        }

        public override void Beep()
        {
            Console.WriteLine("I'm a truck! Berp!");

        }
    }
}
