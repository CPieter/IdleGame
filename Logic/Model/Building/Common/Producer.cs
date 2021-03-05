using Logic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model.Building.Common
{
    public class Producer
    {
        public Resource ProductionResource { get; private set; }
        public int ProductionAmount { get; private set; }

        public Producer(Resource productionResource, int productionAmount)
        {
            ProductionResource = productionResource;
            ProductionAmount = productionAmount;
        }

        public (Resource?, float) GetYield(float dTime)
        {
            float yield = dTime * ProductionAmount;
            return (ProductionResource, yield);
        }
    }
}
