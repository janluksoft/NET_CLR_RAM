using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sProjFood4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _k = 14;
            string _name = "";
            Console.WriteLine("Start App, please wait ...");

            CFactory cFactoryDell = new CFactory(2, "Dell", 1985);

            CfPackage sPackMain;
            sPackMain.Id = 3;
            sPackMain.Length = 15;
            sPackMain.cPackType = 'F';


            CFood cCarrot = new CFood();
            cCarrot.Id = 1;
            cCarrot.Name = "carrot";
            cCarrot.iCalories = 420;
            cCarrot.isFluid = false;
            cCarrot.cQuality = 'W';
            cCarrot.bExpires = 14;

            int[] tmBox= new int[5] { 1, 2, 3, 4, 5 };

            //-- New instance --------------
            CFood cMilk = new CFood(4, "milk", 160, true, 'N', 67, tmBox, cFactoryDell);
            cMilk.iCalories += 20;
            _name = cMilk.Name;

            Console.WriteLine($"End app! Name:{_name}.");
            Console.WriteLine($"Press any key to exit...");
            Console.ReadKey();

            _k = 15;
        }
    }
}
