using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object_Oriented_Program_which_display_different_types_of_vehicles_brands
{
     class Vehicle
    {
        public virtual void Vehiclebrand()
        {
            Console.WriteLine("The vehicles have different brands");
        }
        class AudiA4 : Vehicle
        {
            public override void Vehiclebrand()
            {
                Console.WriteLine("The  audiA4 brand is : VW ");
            }
        }
            class ChevroletLacetti: Vehicle
            {
                public override void Vehiclebrand()
                {
                    Console.WriteLine("The  chevrolet lacetti brand is : General Motors ");
                }

            }
        class BMWSUV: Vehicle
        {
            public override void Vehiclebrand()
            {
                Console.WriteLine("The  bmw SUV brand is : BMW group ");
            }

        }
        class MustangCalifornia : Vehicle
        {
            public override void Vehiclebrand()
            {
                Console.WriteLine("The  mustang california brand is : Ford Motor Co. ");
            }

        }
        class Mk3POLOGTI: Vehicle
        {
            public override void Vehiclebrand()
            {
                Console.WriteLine("The  mk3 Polo GTI brand is : Volkswagen ");
            }

        }
    }
}
