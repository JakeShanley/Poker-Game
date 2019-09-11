﻿using System;
namespace PokerGame
{
    public class Decision
    {
        public DecisionType SelDecisionType { get; }
        public double Amount { get; }

        public enum DecisionType
        {
            Fold = 1,
            Call,
            Raise
        }

        public Decision(DecisionType selDecisionType)
        {
            SelDecisionType = selDecisionType;            
        }
    }
}   


