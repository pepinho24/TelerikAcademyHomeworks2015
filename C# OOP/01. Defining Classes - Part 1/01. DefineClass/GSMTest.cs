/* Problem 7. GSM test

   Write a class GSMTest to test the GSM class:
   Create an array of few instances of the GSM class.
   Display the information about the GSMs in the array.
   Display the information about the static property IPhone4S.
*/
namespace _01.DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMTest
    {
        public static void TestGSMCreation()
        {
            Console.WriteLine("The static property IPhone 4S:");
            Console.WriteLine(GSM.IPhone4S);

            var phones = new List<GSM>();

            phones.Add(new GSM("One M7", "HTC")); 
            phones.Add(new GSM("One", "Testing Co.",1299.99));
            phones.Add(new GSM("Two", "Testing Co.",999.99, new Human("Pesho","Peshev")));
            phones.Add(new GSM("Three", "Testing Co.",789.99, new Human("Pesho","Goshov"), new Battery("BatMod",24,15,BatteryType.NiCd)));
            phones.Add(new GSM("Four", "Testing Co.", 2009.99, new Human("Pesho", "Ivanov"), new Battery("BatMod", 240, 150, BatteryType.LiIon),new Display(new Size(4.7), 546315)));
            phones.Add(new GSM("Five", "Testing Co.", display: new Display(new Size(4.7), 778994)));
            phones.Add(new GSM("Six", "Testing Co.", owner: new Human("Gosho","Shakov")));
            phones.Add(new GSM("Seven", "Testing Co.", battery: new Battery("Panascanic", 240, 150, BatteryType.LiIon), display: new Display(new Size(4.7), 54632)));

            Console.WriteLine("All the phones: ");

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

        }
    }
}
