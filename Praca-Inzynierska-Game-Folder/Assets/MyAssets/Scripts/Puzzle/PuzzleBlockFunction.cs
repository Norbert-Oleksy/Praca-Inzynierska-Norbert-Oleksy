using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleBlockFunction : PuzzleLogicBlock
{
    [Header("Required input")]
    //Które wejœcia s¹ wymagane
    [SerializeField] private bool a;
    [SerializeField] private bool b;
    [SerializeField] private bool c;
    [SerializeField] private bool d;
    [Header("Materials")]
    [SerializeField] private Material[] materials = new Material[2];
    [SerializeField] private Renderer symbol;
    [Header("Action")]
    public UnityEvent onActionEvent = new UnityEvent();
    public UnityEvent offActionEvent = new UnityEvent();

    public override void BlockLogic()
    {
        if (PowerCheck())
        {
            TurnOn();
        }
        else
        {
            TurnOFF();
        }
    }

    private void TurnOn()
    {
        onActionEvent?.Invoke();
        symbol.material = materials[1];
    }
    private void TurnOFF()
    {
        offActionEvent?.Invoke();
        symbol.material = materials[0];
    }

    private bool PowerCheck()
    {
        if (a && !gateA.GetPower()) return false;
        if (b && !gateB.GetPower()) return false;
        if (c && !gateC.GetPower()) return false;
        if (d && !gateD.GetPower()) return false;
        return true;
    }
}
