﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public class Sugar : CoffeeMachineDecorator
    {
        public Sugar(CoffeeMachine p)
            : base(p.Name + ", с сахаром", p)
        { }

        public override int GetCost()
        {
            return coffee_machine.GetCost() + 2;
        }
    }
}
