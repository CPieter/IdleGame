using Logic.Enum;
using Logic.Factory;
using Logic.Model.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model
{
    public class Settlement
    {
        public List<IBuilding> Buildings { get; private set; }

        //FILTEREN OP INTERFACE
        public Settlement(List<IBuilding> buildings)
        {
            Buildings = buildings;
        }

        public int AddBuilding(BuildingType type)
        {
            if (BuildingExists(type))
            {
                return GetBuilding(type).AddBuilding(1);
            }
            IBuilding newBuilding = BuildingFactory.GetBuilding(type);
            Buildings.Add(newBuilding);
            return newBuilding.Count;
        }

        public bool BuildingExists(BuildingType type)
        {
            return Buildings.Exists(b => b.Type == type);
        }

        public IBuilding GetBuilding(BuildingType type)
        {
            return Buildings.Find(b => b.Type == type);
        }
    }
}
