using Logic.Enum;
using Logic.Model.Building.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model.Building
{
    public class Hut : BuildingBase, IBuilding
    {
        public Hut(int count)
        {
            Count = count;
            Name = "Goblin Hut";
        }

        public override Dictionary<Resource, int> GetCost()
        {
            return new Dictionary<Resource, int>() { { Resource.Gold, 10 } };
        }
    }
}
