using Logic.Enum;
using Logic.Model.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Factory
{
    static class BuildingFactory
    {
        private static readonly Dictionary<BuildingType, Func<IBuilding>> buildingDict = new Dictionary<BuildingType, Func<IBuilding>>()
        {
            { BuildingType.Farm, () => new Farm(0) },
            { BuildingType.Hut, () => new Hut(0) }
        };

        public static IBuilding GetBuilding(BuildingType type)
        {
            var factory = buildingDict[type];
            return factory();
        }
    }
}
