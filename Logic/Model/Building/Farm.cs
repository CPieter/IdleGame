using Logic.Enum;
using Logic.Model.Building.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model.Building
{
    public class Farm : BuildingBase, IProductionBuilding
    {
        public Producer Producer { get; private set; }

        public Farm(int count)
        {
            Count = count;
            Name = "Rat Farm";
            Producer = new Producer(Resource.Food, 1);
        }

        public override Dictionary<Resource, int> GetCost()
        {
            return new Dictionary<Resource, int>() { { Resource.Gold, 10 } };
        }
    }
}
