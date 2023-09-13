using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list.
            
            
            
            List<string> computerBrands = new List<string>()
            { "MSI", "Gateway", "Dell", "HP", "Apple","Microsoft", "Asus", "IBM", "Toshiba", "Acer", "Intel", "Samsung", "Alienware"};

            //Order the list by the length of the name, using method syntax and the lambda expression.

          
            IEnumerable<string> orderedLength =
               computerBrands.OrderBy(brand => brand.Length);

            foreach (string brand in orderedLength)
            {
                Console.WriteLine(brand);
            }



            
            


        }
    }
}
