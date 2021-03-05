using Logic.Enum;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IBuilding
    {
        BuildingType Type { get; }
        string Name { get; }
        int Count { get; }
        Dictionary<Resource, int> GetCost();
        int AddBuilding(int count = 0);
    }
}
