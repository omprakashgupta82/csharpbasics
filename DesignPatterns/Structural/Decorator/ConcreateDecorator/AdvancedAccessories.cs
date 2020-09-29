using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar iCar)
            :base(iCar)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 8000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " -- Advanced Accessories";
        }
    }
}
