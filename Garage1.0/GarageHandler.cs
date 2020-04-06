using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class GarageHandler 
    {
        Garage<Vehicle> garage;


        public Garage<Vehicle> Garage { get; set; }

        public GarageHandler(int capacity)

        {

            garage = new Garage<Vehicle>(capacity);

        }
        public bool ParkIn(Vehicle vehicle)

        {

            return garage.Add(vehicle);

        }


        public bool ParkOut(string regNum)

        {

            return garage.Remove(regNum);

        }

        //must to do
        public Vehicle[] FindByProperty(string proper)

        {

            return garage.FindByProperty(proper);

        }



        public Vehicle FindByRegNum(string regNum)

        {

            return garage.FindByRegNum(regNum);

        }

    }
}
