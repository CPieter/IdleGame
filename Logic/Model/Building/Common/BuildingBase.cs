using Logic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model.Building.Common
{
    public abstract class BuildingBase
    {
        public BuildingType Type { get; protected set; }
        public string Name { get; protected set; }
        public int Count { get; protected set; }

        public abstract Dictionary<Resource, int> GetCost();
        public int AddBuilding(int count = 0)
        {
            return Count += count;
        }
    }
}
