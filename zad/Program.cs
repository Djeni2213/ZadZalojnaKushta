using System.Transactions;

namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many items are there in the Pawn Shop: ");
                int num = int.Parse(Console.ReadLine());

                List<Item> items = new List<Item>();

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter the info of item{i + 1} (Type of stock/material/weight/stake value/selling price/name of owner/count):");
                    List<string> itemInfo = Console.ReadLine().Split(' ').ToList();
                    Item item = new Item(itemInfo[0], itemInfo[1], double.Parse(itemInfo[2]), double.Parse(itemInfo[3]), double.Parse(itemInfo[4]), itemInfo[5], int.Parse(itemInfo[6]));
                    items.Add(item);
                }
                Console.WriteLine();
                Console.WriteLine("===================================================================================================================================================================");
                int choise = 0;
                while (choise != 6)
                {
                    Console.WriteLine("What do you want to do now (answer 1-5):");
                    Console.WriteLine();

                    Console.WriteLine("1. Print all the info of all the items");
                    Console.WriteLine("2. Print the info of a searched item by it's name");
                    Console.WriteLine("3. Calculate the sum of every sold item");
                    Console.WriteLine("4. Print the info of the most expensive item");
                    Console.WriteLine("5. Sort the items by the name of their owner (and by type)");
                    Console.WriteLine("6. Exit");
                    choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            foreach (var item in items)
                            {
                                item.Print();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the type of stock you are looking for:");
                            string searchedName = Console.ReadLine();

                            var found = items.Where(x => x.TypeOfStock.ToLower() == searchedName.ToLower()).ToList();
                            if (found.Count > 0)
                            {
                                foreach (var item in found)
                                {
                                    item.Print();
                                }
                            }
                            else
                            {
                                Console.WriteLine("There isn't an item with that name!");
                            }
                            break;
                        case 3:
                            double totalSum = items.Sum(x => x.SellingPrice * x.Count);
                            Console.WriteLine($"The total sum of the items is: {totalSum:f2}");
                            break;
                        case 4:
                            var mostExpencive = items.OrderByDescending(x => x.SellingPrice).FirstOrDefault();
                            if (mostExpencive != null)
                            {
                                Console.WriteLine($"The most expencive item is \n {mostExpencive.Print}");
                            }
                            break;
                        case 5:
                            var sortedItems = items.OrderBy(x => x.NameOfOwner).ThenBy(x => x.TypeOfStock).ToList();
                            foreach (var item in sortedItems)
                            {
                                item.Print();
                            }
                            break;
                        case 6:
                            Console.WriteLine("Exiting......");
                            break;
                        default:
                            Console.WriteLine("Invalid option entered!!! Enter 1-6!!!");
                            break;
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
