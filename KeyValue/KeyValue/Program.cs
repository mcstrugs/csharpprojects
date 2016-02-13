using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Key Price Checker";
            Console.WriteLine("How many weapons to check?");
            String numStr = Console.ReadLine();
            int num = Int32.Parse(numStr);
            String[] names = new String[num];
            double[] mPrices = new double[num];
            double[] kPrices = new double[num];
            for(int trys = 0; trys < num; trys++)
            {
                Console.WriteLine("Enter weapon name:");
                names[trys] = Console.ReadLine();
                Console.WriteLine("Enter weapon price: ");
                mPrices[trys] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("What percentage of market price do you wish to sell them?");
            double percentUndivided = Double.Parse(Console.ReadLine());
            double percent = percentUndivided / 100;
            for(int getKeys = 0; getKeys < num; getKeys++)
            {
                kPrices[getKeys] = (mPrices[getKeys]/2.5) * percent;
            }
            for (int print = 0; print < num; print++)
            {
                Console.WriteLine(names[print] + " costs " + kPrices[print] + " keys at " + percentUndivided + "% of market price");
            }
            Console.WriteLine("Press ENTER to exit: ");
            Console.ReadKey();
        }
    }
}
