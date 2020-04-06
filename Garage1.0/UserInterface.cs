using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Garage1._0
{
    class UserInterface
    {
        string[] vehicleTypes = { "Car", "Bus", "Boat","Airplane", "Motorcykle" };
                    
        Console.WriteLine("1. Lista samtliga parkerade fordon \n "+
           "2. Lista fordonstyper och hur många av varje som står i garaget \n"+
           " 3. Lägga till fordon \n "+
           " 4. ta bort fordon ur garaget  \n "+
           " 5. Sätta en kapacitet(antal parkeringsplatser) vid instansieringen av ett nytt garage  \n"+
           " 6. Hitta ett specifikt fordon via registreringsnumret.  \n"+
           "  7. Söka efter fordon utifrån en egenskap eller flera. \n"+
            " 0. Avsluta" );

            char input = ' ';

                try

                {

                    input = Console.ReadLine()[0]; 

                }

                catch (IndexOutOfRangeException) 
                {

                    Console.Clear();

                    Console.WriteLine("Please enter some input!");

                }

                switch (input)

                {
                    
                    case '1':

                        NumbOfVehicles();

                        break;

                    case '2':

                        VehicleTypes();

                        break;

                    case '3':

                        Add();

                        break;

                    case '4':

                       Remove();

                        break;

                    
                     case '5':

                       public int capacity= Console.ReadLine( );

                        break;

                     case '6':

                        FindByRegNum();

                        break;

                     case '7':

                        //FindByProperty();
                        Console.WriteLine( "write color of vehicle You want to find: " );
                        string input = Console.ReadLine();

                        for (input ==Vehicle.color)
                        {
                           if (vehicles.Length > 0)

                              foreach (Vehicle v in vehicles)

                              Console.WriteLine(v);
                        }
                        break;

                    case '0':

                        Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7 )");

                        break;

                }

            

    }
    
}
