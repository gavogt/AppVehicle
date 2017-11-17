using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehicle
{
    class Car : Vehicle
    {

        public Car() : base()
        {

        }

        public Car(int year, string model) : base(year, model)
        {

        }

        public override void Beep()
        {
            Console.WriteLine("Beep beep! I'm a car!");

        }
    }
}
