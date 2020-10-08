using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        public string name;
        public int statIncrease;
        public int cost;

        public Item(string tempName,int tempStatIncrease,int tempCost)//Gives item stats
        {
            name = tempName;
            statIncrease = tempStatIncrease;
            cost = tempCost;
            
        }


    }

    
}
