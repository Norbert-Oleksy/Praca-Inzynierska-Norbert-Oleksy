using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlockSwitch : PuzzleLogicBlock
{
    /*
     * Switch
     * Wyjœcie = Wejœcie
     * Pozwala wy³¹czyæ blok
     */
    [Header("Switch")]
    [SerializeField] private GameObject lever;
    [SerializeField] private Transform positionON;
    [SerializeField] private Transform positionOFF;

    private void Awake()
    {
        SetLeverPosition();
    }

    public override void BlockLogic()
    {
        if (blockON)
        {
            gateC.SetPower(NegationCheck(gateA.GetPower()));
        }
        else
        {
            gateC.SetPower(NegationCheck(false));
        }
    }

    public override void Interaction()
    {
        blockON = !blockON;
        SetLeverPosition();
        BlockLogic();
    }

    private void SetLeverPosition()
    {
        if (blockON)
        {
            lever.transform.position = positionON.position;
        }
        else
        {
            lever.transform.position = positionOFF.position;
        }
    }
}
