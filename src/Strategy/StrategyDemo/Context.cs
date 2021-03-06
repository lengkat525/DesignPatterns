﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context
    {
        private readonly Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}