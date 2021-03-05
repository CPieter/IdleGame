using Logic.Enum;
using Logic.Model.Building.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IProductionBuilding : IBuilding
    {
        Producer Producer { get; }
    }
}
