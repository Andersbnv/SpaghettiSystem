using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StregSystem
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public bool CanBeBoughtOnCredit { get; set; }

        public Product(int iD, string name, double price, bool isActive, bool canBeBoughtOnCredit)
        {
            ID = iD;
            Name = name;
            Price = price;
            IsActive = isActive;
            CanBeBoughtOnCredit = canBeBoughtOnCredit;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Pris: " + Price + "ID" + ID + "Active: " + IsActive + "Credit: " + CanBeBoughtOnCredit;
        }
    }

    public class SeasonalProduct : Product
    {
        public string SeasonStart { get; set; }
        public string SeasonEndDate { get; set; }

        public SeasonalProduct(string seasonStart, string seasonEndDate, int iD, string name, double price, bool isActive, bool canBeBoughtOnCredit) 
            : base(iD, name, price, isActive, canBeBoughtOnCredit)
        {
            SeasonStart = seasonStart;
            SeasonEndDate = seasonEndDate;
        }


       


    }
}
