namespace Shopping_list_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> groceryItemsAndPrices= new Dictionary<string, double>();

            groceryItemsAndPrices.Add("BANNANA", 5.25);
            groceryItemsAndPrices.Add("MILK", 7.00);
            groceryItemsAndPrices.Add("CEREAL", 12.50);
            groceryItemsAndPrices.Add("APPLE", 3.75);
            groceryItemsAndPrices.Add("CHICKEN", 8.75);
            groceryItemsAndPrices.Add("GROUND BEEF", 9.00);
            groceryItemsAndPrices.Add("STEAK", 25);
            groceryItemsAndPrices.Add("COLD BREW", 7.50);

            foreach (var item in groceryItemsAndPrices)
            {
                Console.WriteLine(item);
            }

            List<string> items = new List<string>();
            List<double> price = new List<double>();
            

            while (true)
            {
                Console.WriteLine("Pick an item to add to your cart! ");
                string groceryItem = Console.ReadLine().ToUpper().Trim();
                if (groceryItemsAndPrices.ContainsKey(groceryItem))
                {
                    items.Add(groceryItem);
                    groceryItemsAndPrices.TryGetValue(groceryItem, out double groceryPrice);
                    price.Add(groceryPrice);
                    
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                    Console.WriteLine("Add another item? yes/no");

                    string anwser = Console.ReadLine().ToUpper().Trim();
                    if (anwser.Equals("YES"))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
            }

            Console.Clear();
            Console.WriteLine("Heres your cart!");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            
            foreach (var prices in price)
            {
                Console.WriteLine(prices);
            }

            double pricesSum = 0;

            foreach(double prices  in price)
            {
                pricesSum += prices;
                
            }
            Console.WriteLine($"The total of your items is ${pricesSum}");
        }
    }
}