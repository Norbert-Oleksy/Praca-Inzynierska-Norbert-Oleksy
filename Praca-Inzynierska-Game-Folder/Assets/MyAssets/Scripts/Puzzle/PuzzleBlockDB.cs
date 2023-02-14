using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlockDB : PuzzleLogicBlock
{
    /*
     * Digital buffer
     * Wyjœcie = Wejœcie
     * 
     */

    public override void BlockLogic()
    {
        gateC.SetPower(NegationCheck(gateA.GetPower()));
    }

}
