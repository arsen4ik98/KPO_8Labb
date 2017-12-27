using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public abstract class CoffeeMachineDecorator : CoffeeMachine
    {
        protected CoffeeMachine coffee_machine;
        public CoffeeMachineDecorator(string n, CoffeeMachine coffee_machine)
            : base(n)
        {
            this.coffee_machine = coffee_machine;
        }
    }
}
