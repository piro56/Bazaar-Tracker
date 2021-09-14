using CommandLine;
using Hypixel.NET;
using Hypixel.NET.SkyblockApi.Bazaar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Bazaar_Console_Edition
{
    class Program
    {
        private static System.Timers.Timer bzrTimer;
        public static HypixelApi hypixelAPI = new HypixelApi("23ff40ac-c332-4fcf-acc5-052baf6bee30", 10);
        public static System.Collections.Generic.Dictionary<string, Product> bazaarProducts = hypixelAPI.GetBazaarProducts().Products;
        private static string[] profitDisplays = { "Instant", "Gradual_to_Gradual", "Instant_to_Gradual", "Gradual_to_Instant" };
        private static string currentDisplay = profitDisplays[0];
        public static bool writingProfits = false;
        static void Main(string[] args)
        {
            SetTimer();
            BazaarItems allItems = new BazaarItems();
            allItems.initializeItems();
            ColorfulConsole.writeGreen("Started! Type --help for help.");
            while(true)
            {
                InputParser.parseInput(Console.ReadLine());
            }


            //keep_window_open();

        }

        public static void SetTimer()
        {
            bzrTimer = new System.Timers.Timer(10000);
            bzrTimer.Enabled = true;
            bzrTimer.Elapsed += OnTimedEvent;
        }
        public static void OnTimedEvent(System.Object Source, ElapsedEventArgs e)
        {
            Program.bazaarProducts = hypixelAPI.GetBazaarProducts().Products;
            if(writingProfits)
            {
                writeProfits();
            }
            
        }

        public static void writeProfits()
        {
            Dictionary<Item, double> displayProfits = BazaarItems.getInstantProfit();
            if (currentDisplay == "Instant")
            {
                displayProfits = BazaarItems.getInstantProfit();
            }
            else if(currentDisplay == "Gradual_to_Gradual")
            {
                displayProfits = BazaarItems.getGradualProfit();
            }

            else if (currentDisplay == "Instant_to_Gradual")
            {
                displayProfits = BazaarItems.getInstanttoGradualProfit();
            }
            else if (currentDisplay == "Gradual_to_Instant")
            {
                displayProfits = BazaarItems.getGradualtoInstantProfit();
            }
            else
            {
                displayProfits = BazaarItems.getInstantProfit();
            }

            InputParser.displayCraftingProfit(displayProfits);
            //List<Item> items = displayProfits.Keys.ToList();
            //List<double> values = displayProfits.Values.ToList();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(items[i].Item_Name + ": " + values[i]);
            //}
        }

        public static void keep_window_open()
        {
            Console.ReadLine();
        }
    }
}
