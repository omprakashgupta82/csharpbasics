using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private ICar _iCar;

        public CarAccessoriesDecorator(ICar iCar)
        {
            _iCar = iCar;
        }

        public virtual double GetCost()
        {
            return _iCar.GetCost();
        }

        public virtual string GetDescription()
        {
            return _iCar.GetDescription();
        }
    }
}
