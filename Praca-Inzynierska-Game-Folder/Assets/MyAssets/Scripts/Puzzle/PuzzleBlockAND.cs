using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlockAND : PuzzleLogicBlock
{
    /*
     * AND
     * Wyjœcie = WejœcieA * WejœcieB
     * 
     */

    public override void BlockLogic()
    {
        if (gateA.GetPower() && gateB.GetPower())
        {
            gateC.SetPower(NegationCheck(true));
        }
        else
        {
            gateC.SetPower(NegationCheck(false));
        }
    }
}
