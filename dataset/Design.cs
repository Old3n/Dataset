using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace dataset
{
    public class Design
    {
        public void Appdesign()
        {
            string path = @"C:\Users\ho3in\source\repos\dataset\data\orders.csv";
            var csvread = new Csvfileprocess();
            var data = csvread.Readcsvfile(path);
            var op = new Dataoperation(data);
            translateprocess tr = new translateprocess(data);
            Console.WriteLine("Hello Please type the number of the operation u want to do : ");
            Console.WriteLine("[0] Translate cities from fa to en");
            Console.WriteLine("[1] Find which  Customer ID is Odd  ");
            Console.WriteLine("[2] Find which  Customer ID is Prime  ");
            Console.WriteLine("[3] Find which  Customer ID is Mirror  ");
            Console.WriteLine("[4] Find which  Customer ID is both Odd and Prime  ");
            int Userawnser = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Userawnser)
            {
                case 0: Console.WriteLine("Plz w8"); tr.translatecity(); break;
                case 1: Console.WriteLine("Plz w8"); op.Oddnumber(); break;
                case 2: Console.WriteLine("Plz w8"); op.Primenumber(); break;
                case 3: Console.WriteLine("Plz w8"); op.Mirrornumber(); break;
                case 4: Console.WriteLine("Plz w8"); op.OddAndPrime(); break;
                default:
                    throw new Exception("Wrong awnser");
                

            }
        }
    }
}
