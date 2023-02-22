using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6_
{
    internal class Truck : Vehicle
    {
        private double _sizeofTruckBed;





         
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base (truckBrand, truckModel, truckNumberOfWheels 
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

    }
}
