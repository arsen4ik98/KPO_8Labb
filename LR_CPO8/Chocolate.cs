using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public class Chocolate : CoffeeMachine
    {
        public Chocolate()
            : base("Шоколад")
        { }
        public override int GetCost()
        {
            return 20;
        }
    }
}
