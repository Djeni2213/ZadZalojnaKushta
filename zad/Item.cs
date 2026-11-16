using System;
using System.Collections.Generic;
using System.Text;

namespace zad
{
    public class Item
    {
        private string typeOfStock;

        public string TypeOfStock
        {
            get { return typeOfStock; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You didn't enter a type of stock!!!");
                }
                typeOfStock = value;
            }
        }

        private string material;

        public string Material
        {
            get { return material; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("You didn't enter a type of stock!!!");
                }
                material = value;
            }
            
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("That is an invalid weight!!!");
                }
                weight = value;
            }
        }

        private double stakeValue;

        public double StakeValue
        {
            get { return stakeValue; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("That is an invalid Stake value!!!");
                }
               stakeValue = value;
            }
        }

        private double sellingPrice;

        public double SellingPrice
        {
            get { return sellingPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("That is an invalid selling price!!!");
                }
                sellingPrice = value;
            }
        }

        private string nameOfOwner;

        public string NameOfOwner
        {
            get { return nameOfOwner; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You have to enter the owners name!!!");
                }
                nameOfOwner = value;
            }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("You have to enter a valid count!!!");
                }
                count = value;
            }
        }


        public Item()
        {
            this.TypeOfStock = "Unknown";
            this.Material = "Unknown";
            this.Weight = 0;
            this.StakeValue = 0;
            this.SellingPrice = 0;
            this.NameOfOwner = "Unknown";
            this.Count = 0;
        }

        public Item(string typeOfStock, string material, double weight, double stakeValue, double sellingPrice, string nameOfOwner, int count)
        {
            this.TypeOfStock = typeOfStock;
            this.Material = material;
            this.Weight = weight;
            this.StakeValue = stakeValue;
            this.SellingPrice = sellingPrice;
            this.NameOfOwner = nameOfOwner;
            this.Count = count;
        }

        public void Print()
        {
            Console.WriteLine($"\n Type of stock: {TypeOfStock}\n Material: {Material}\n Weight: {Weight}\n Stake value: {StakeValue}\n Selling price: {SellingPrice}\n Name of owner: {NameOfOwner}\n Count: {Count}");
        }

    }
}
