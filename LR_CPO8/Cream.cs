using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public class Cream : CoffeeMachineDecorator
    {
        public Cream(CoffeeMachine p)
            : base(p.Name + ", со сливками", p)
        { }

        public override int GetCost()
        {
            return coffee_machine.GetCost() + 7;
        }
    }
}
