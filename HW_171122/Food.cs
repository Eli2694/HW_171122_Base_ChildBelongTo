using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_171122
{
    internal class Food : Item
    {
		public Food(int id , int _Weight):base(id)
		{
			weight = _Weight;

        }

		private int weight;
		public int Weight
        {
			get { return weight; }
		}

	}
}
