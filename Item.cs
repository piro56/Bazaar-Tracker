using System;
using System.Collections.Generic;
using System.Text;
using Hypixel.NET.SkyblockApi.Bazaar;

namespace Bazaar_Console_Edition
{
    class Item
    {
        Product productItem;
        public string Item_Name;
        public List<string> components = new List<string>();
        public List<int> componentAmt = new List<int>();
        // Constructor for the class. Returns a product from the input item.
        public Item(string item)
        {
            Item_Name = item;
            Program.bazaarProducts.TryGetValue(item, out productItem);
        }
        // Adds components to this item.
        public void addComponent(string component_name, int amount)
        {
            components.Add(component_name);
            componentAmt.Add(amount);
        }

        public double craftingCostfromInstant()
        {
            double totalCost = 0;
            for (int i = 0; i < components.Count; i++)
            {
                Product componentProduct;
                Program.bazaarProducts.TryGetValue(components[i], out componentProduct);
                totalCost += componentProduct.BuySummary[0].PricePerUnit * componentAmt[i];
            }
            totalCost = Math.Round(totalCost, 2);
            return totalCost;
        }
        public double craftingCostfromGradual()
        {
            double totalCost = 0;
            for (int i = 0; i < components.Count; i++)
            {
                Product componentProduct;
                Program.bazaarProducts.TryGetValue(components[i], out componentProduct);
                totalCost += componentProduct.SellSummary[0].PricePerUnit * componentAmt[i];
            }
            totalCost = Math.Round(totalCost, 2);
            return totalCost;
        }

        public double InstantProfits()
        {
            Product thisProduct;
            Program.bazaarProducts.TryGetValue(Item_Name, out thisProduct);
            double profit = thisProduct.SellSummary[0].PricePerUnit - craftingCostfromInstant();
            profit = Math.Round(profit, 2);
            return profit;
        }

        public double GradualToGradualProfits()
        {
            Product thisProduct;
            Program.bazaarProducts.TryGetValue(Item_Name, out thisProduct);
            double profit = thisProduct.BuySummary[0].PricePerUnit - craftingCostfromGradual();
            return Math.Round(profit, 2);
        }

        public double InstantToGradualProfits()
        {
            Product thisProduct;
            Program.bazaarProducts.TryGetValue(Item_Name, out thisProduct);
            double profit = thisProduct.BuySummary[0].PricePerUnit - craftingCostfromInstant();
            return Math.Round(profit, 2);
        }

        public double GradualToInstantProfits()
        {
            Product thisProduct;
            Program.bazaarProducts.TryGetValue(Item_Name, out thisProduct);
            double profit = thisProduct.SellSummary[0].PricePerUnit - craftingCostfromGradual();
            return Math.Round(profit, 2);
        }
    }
}
