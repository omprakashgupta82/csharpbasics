using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar iCar)
            : base(iCar)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 15000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " -- Sports Accessories";
        }
    }
}
