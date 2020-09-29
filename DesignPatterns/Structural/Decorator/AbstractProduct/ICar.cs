using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    /*
    The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.

    The idea of the Decorator Pattern is to wrap an existing class, add other functionality to it, then expose the same interface to the outside world.
    Because of this our decorator exactly looks like the original class to the people who are using it.

    It is used to extend or alter the functionality at runtime.
    It does this by wrapping them in an object of the decorator class without modifying the original object. So it can be called a wrapper pattern.

    Advantages of Decorator Pattern

       Adds functionality to existing objects dynamically
       Alternative to sub classing
       Flexible design
       Supports Open Closed Principle

    When to use Decorator Pattern

       Legacy System
       Sealed Classes
*/

    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }
}
