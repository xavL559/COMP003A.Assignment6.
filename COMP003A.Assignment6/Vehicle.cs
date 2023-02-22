using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6_
{
    /// <summary>
    /// 
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        private string _brand;
        private string _model;
        private int _numberOfWheels;


        /// <summary>
        /// 
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="numberOfWheels"></param>
        public Vehicle(string brand, string model, int numberOfWheels) 
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        public virtual void GetInfo ()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
        

    }
}
