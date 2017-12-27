using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public class Coffee : CoffeeMachine
    {
        public Coffee()
            : base("Кофе")
        { }
        public override int GetCost()
        {
            return 50;
        }
    }
}
