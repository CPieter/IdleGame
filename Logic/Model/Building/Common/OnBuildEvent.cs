using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model.Building.Common
{
    public abstract class OnBuildEvent : BuildingBase
    {
        protected abstract void OnBuild();
    }
}
