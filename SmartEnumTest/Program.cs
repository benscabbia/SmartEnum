using System;
using System.Linq;

namespace SmartEnumTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // Original
            Console.WriteLine(CryptoEnum.Bitcoin.GetShortName());
            Console.WriteLine(CryptoEnum.Bitcoin.GetDisplayName());

            // Smart Enum
            Console.WriteLine(SmartCryptoEnum.Bitcoin.ShortName);
            Console.WriteLine(SmartCryptoEnum.Bitcoin.Name);

            Console.WriteLine(SmartCryptoEnum.Bitcoin.WebsiteURL);
            Console.WriteLine(SmartCryptoEnum.Bitcoin == SmartCryptoEnum.Dogecoin);
            
            // Get all registered coins
            SmartCryptoEnum.List.OrderBy(x=> x.Value).ToList().ForEach(x => Console.WriteLine($"{x.Name} : {x.Value}"));

            Console.ReadKey();
        }
    }
}
