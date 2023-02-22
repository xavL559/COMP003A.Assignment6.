using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6_
{
    /// <summary>
    /// Making the truck = vehicle
    /// </summary>
    internal class Truck : Vehicle
    {
        private double _sizeofTruckBed;





         
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base (truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        public double SizeOfTruckBed
        {
            get { return _sizeofTruckBed;}
            set { _sizeofTruckBed = value;}
        }

        /// <summary>
        /// Displaying the information of the truck
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.");
            base.GetInfo(); 
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }
    }
}
