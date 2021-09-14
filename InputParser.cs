using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using CommandLine;
using Hypixel.NET.SkyblockApi.Bazaar;

namespace Bazaar_Console_Edition
{

    class Options
    {
        [Option(Group = "testVal", Default = "test", HelpText ="I have no idea what I am doing", Required = true)]
        public string testVal { get; set; }
    }


    class InputParser
    {

        public static string getHelp = "--------------Help--------------\n"
            + "1. bzr (any item) -> Retrieves current buy and sell price of item\n"
            + "2. bzr cp (1-4) -> Displays different crafting profits on items. Do 'bzr cp' for more info.\n"
            + "3. bzr ar -> toggles autorefresh of crafting profits.";
            
        // Retrieves a product from string.
        public static Product GetProduct(string product, bool logSuccessful = false)
        {
            Product gotProduct;
            // string manipulation before searching for a product.
            product = product.Trim();
            product = product.Replace(" ", "_");
            product = product.ToUpper();
            product = product.Replace("E_", "ENCHANTED_");
            if (product == "GOLD" || product == "IRON")
            {
                product = product + "_INGOT";
            }

            if (Program.bazaarProducts.TryGetValue(product, out gotProduct))
            {
                if (logSuccessful)
                {
                    Console.WriteLine("Successfully Retrieved: " + product); ;
                }
                return gotProduct;
            }
            else
            {
                if (logSuccessful)
                {
                    Console.WriteLine("Failed To Recieve: " + product);
                }
                return null;
            }
        }

        //Get buy & sell price of a product
        public static bool QuickSum(Product product)
        {
            if (product == null)
            {
                return false;
            }
            try
            {
                Console.WriteLine("Current Buy Price: " + product.BuySummary[0].PricePerUnit);
                Console.WriteLine("Current Sell Price: " + product.SellSummary[0].PricePerUnit);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void BazaarHelp()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------Help--------------");
            Console.WriteLine("--help -> Displays this help message");
            Console.WriteLine("-clear -> Clears console");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------Bazaar Commands-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. bzr (any item) -> Retrieves current buy and sell price of item");
            Console.WriteLine("2. bzr cp (1-4) -> Displays different crafting profits on items. Do 'bzr cp' for more info");
            Console.WriteLine("3. bzr ar -> toggles autorefresh of crafting profits");
            Console.WriteLine("--------------------------------");
        }
        public static void parseInput(string input)
        {
            input = input.Trim();
            string[] args = input.Split(" ");
            // Make every argument uppercase.
            for(int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToUpper();
            }
            switch(args[0])
            {
                case "BZR":
                case "BAZAAR":
                    if(args.Length < 2)
                    {
                        // Put print help message function here.
                        return;
                    }
                    switch(args[1])
                    {
                        case "CRAFTINGPROFIT":
                        case "CRAFTPROFIT":
                        case "CP":
                            if(args.Length == 2)
                            {
                                pickProfit();
                                break;
                            }
                            int chosenProfit;
                            bool successfulConversion = Int32.TryParse(args[2], out chosenProfit);
                            if (!successfulConversion || chosenProfit > 4 || chosenProfit < 0)
                            {
                                ColorfulConsole.writeRed("Command failed!");
                                pickProfit();
                                break;
                            }
                            switch(chosenProfit)
                            {
                                case 1:
                                    displayCraftingProfit(BazaarItems.getInstantProfit());
                                    break;
                                case 2:
                                    displayCraftingProfit(BazaarItems.getGradualProfit());
                                    break;
                                case 3:
                                    displayCraftingProfit(BazaarItems.getInstanttoGradualProfit());
                                    break;
                                case 4:
                                    displayCraftingProfit(BazaarItems.getGradualtoInstantProfit());
                                    break;
                                default:
                                    ColorfulConsole.writeRed("Error!");
                                    break;
                            }
                            break;
                        case "AUTOREFRESH":
                        case "AR":
                            Program.writingProfits = !Program.writingProfits;
                            break;




                        default:
                            try
                            {
                                QuickSum(GetProduct(args[1]));
                            }
                            catch 
                            {
                                ColorfulConsole.writeRed("Invalid Command!");
                            }
                            break;
                    }
                    break;
                case "--HELP":
                    BazaarHelp();
                    break;
                case "-CLEAR":
                    Console.Clear();
                    ColorfulConsole.writeGreen("Type --help for help!");
                    break;
            }





        }

        public static void displayCraftingProfit(Dictionary<Item, double> displayProfits)
        {
            List<Item> items = displayProfits.Keys.ToList();
            List<double> values = displayProfits.Values.ToList();
            Console.WriteLine("------------------------------");
            for (int i = 0; i < 20; i++)
            {
                if(values[i] > 3000)
                {
                    ColorfulConsole.writeMagenta(items[i].Item_Name + ": " + values[i]);
                }
                else if(values[i] > 0)
                {
                    ColorfulConsole.writeGreen(items[i].Item_Name + ": " + values[i]);
                }
                else
                {
                    Console.WriteLine("------------------------------");
                    break;
                }
                
            }
        }
        public static void pickProfit()
        {
            // Option to pick profit.
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Which crafting profit would you like?");
            Console.WriteLine("1. Instant.");
            Console.WriteLine("2. Gradual to Gradual");
            Console.WriteLine("3. Instant to Gradual (Buy to Sell)");
            Console.WriteLine("4. Gradual to Instant (Sell to Buy)");
            Console.WriteLine("----------------------------------------");
            string choice = Console.ReadLine();
            int intChoice;
            bool successful = Int32.TryParse(choice, out intChoice);
            switch (intChoice)
            {
                case 1:
                    displayCraftingProfit(BazaarItems.getInstantProfit());
                    break;
                case 2:
                    displayCraftingProfit(BazaarItems.getGradualProfit());
                    break;
                case 3:
                    displayCraftingProfit(BazaarItems.getInstanttoGradualProfit());
                    break;
                case 4:
                    displayCraftingProfit(BazaarItems.getGradualtoInstantProfit());
                    break;
                default:
                    ColorfulConsole.writeRed("Error!");
                    break;
            }
        }









    }
}
