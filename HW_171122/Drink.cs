using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_171122
{
    internal class runDrink
    {
        
    }
    internal class Drink : Item
    {
        //constructor
        public Drink(int id,string _LiquidColor) :base(id)
        {
            liquidColor = _LiquidColor;
        }
        //var
        private string liquidColor;
        //props
        public string LiquidColor
        {
            get { return liquidColor; }
        }


    }
}
