﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_CPO8
{
    public class Cocoa : CoffeeMachine
    {
        public Cocoa()
            : base("Какао")
        { }
        public override int GetCost()
        {
            return 35;
        }
    }
}
