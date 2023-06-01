using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            
            Beverage Mochalatte1 = new Milk(new Mocha(espresso));
            Beverage Mochalatte2 = new Mocha(new Milk(espresso));

            Console.WriteLine("성분: " + Mochalatte1.GetDescription());
            Console.WriteLine("가격: " + Mochalatte1.GetCost());

            Console.WriteLine("성분: " + Mochalatte2.GetDescription());
            Console.WriteLine("가격: " + Mochalatte2.GetCost());

            Beverage MilkMix = new Milk(new SoyMilk(espresso));
            Console.WriteLine("성분: " + MilkMix.GetDescription());
            Console.WriteLine("가격: " + MilkMix.GetCost());

            Beverage DecoMix = new Cinnamon(new Mocha(espresso));
            Console.WriteLine("성분: " + DecoMix.GetDescription());
            Console.WriteLine("가격: " + DecoMix.GetCost());
        }
    }
}
