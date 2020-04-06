
using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
using System.Collections;
using lib.common.Contract.Delivery;

namespace Garage1._0
{
    class Garage<T>:IEnumerable<T>​​where T : Vehicle 
    {
       private Vehicle[T] ​vehicles = new Vehicle[T];
     T[] places;//= new T[];
    int numOfVeh = 0;
    public int Capacity { get; set; } = 100;
    public Garage(int capacity)
    {
            Capacity = capacity;
        places = new T[capacity];
    }

        //Add vehicle
        public bool Add(T vehicles)

        {
            if (vehicles.RegNum) != null)

                return false;
            for (int i = 0; i < places.Length; i++)

            {

                if (places[i] == null)

                {

                    places[i] = vehicles;

                    numOfVeh++;
                    return true;
                }
            }
            return false;
        }

        internal Vehicle[] FindByProperty(string keyword)
        {
            throw new NotImplementedException();
        }



        //Remove vehicle
        public bool Remove(string regNum)

        {
            for (int i = 0; i < places.Length; i++)

            {

                if (places[i] != null)

                {
                    if (places[i].RegNum == regNum)

                    {
                        places[i] = null;

                        numOfVeh--;
                        return true;
                    }
                }

            }


            return false;
        }

        public int NumbOfVehicles()

        {

            int count = 0;


            for (int i = 0; i < places.Length; i++)

            {

               if (places[i] != null)

                    count++;

            }


            return count;

        }

        public string VehicleTypes()
        {
            Console.WriteLine(vehicleTypes);
        }

        public T FindByRegNum(string regNum)

        {

            for (int i = 0; i < places.Length; i++)

            {

                if (places[i] != null)

                    if (places[i].RegNum == regNum)

                        return places[i];

            }



            return null;

        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                 throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                  throw new NotImplementedException();
            }


    }
}