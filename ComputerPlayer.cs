﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using static PokerGame.Decision;

namespace PokerGame
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string playerName) : base(playerName)
        {

        }

        /// <summary>
        /// Maybe pass in pot, previous bets/raises
        /// </summary>
        /// <returns></returns>
        public override Decision PerformTurn()
        {
            var myBestHand = Hand.GetBestHand(new List<Card>());

            if(myBestHand == WinningHands.HighCard)
            {
                return new Decision(DecisionType.Fold);
            }

            if(myBestHand == WinningHands.Flush)
            {
                return new Decision(DecisionType.Raise);
            }

            int compChoice = 1; //Set to one [fold] as a default for now so my code compiles
            DecisionType decision = (DecisionType)compChoice;
            return new Decision(decision);
        }

        /*public int DecideToFold(List<Card> hand)
        {
            foreach(Card c in hand)
            {
                if (c.Face <= CardFace.Four)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }*/

        public override bool VerifyDecision()
        {
            int choice = 1;
            if (choice == 1)
                return true;
            else
                return false;
        }
    }
}
