using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlockOR : PuzzleLogicBlock
{
    /*
     * OR
     * Wyj�cie = Wej�cieA + Wej�cieB
     * 
     */

    public override void BlockLogic()
    {
        if (gateA.GetPower() || gateB.GetPower())
        {
            gateC.SetPower(NegationCheck(true));
        }
        else
        {
            gateC.SetPower(NegationCheck(false));
        }
    }
}
