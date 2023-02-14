using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLogicBlock : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] public bool blockON;
    [SerializeField] public bool negation;
    [Header("IN/OUT")]
    //A lewo B dol C prawo D gora
    [SerializeField] public PuzzlePowerPathScript gateA;
    [SerializeField] public PuzzlePowerPathScript gateB;
    [SerializeField] public PuzzlePowerPathScript gateC;
    [SerializeField] public PuzzlePowerPathScript gateD;

    public virtual void BlockLogic()
    {

    }

    public virtual void Interaction()
    {

    }

    public bool CheckGates(bool a = false, bool b = false, bool c = false, bool d = false)
    {
        if (a && gateA == null) return false;
        if (b && gateB == null) return false;
        if (c && gateC == null) return false;
        if (d && gateD == null) return false;
        return true;
    }

    public bool NegationCheck(bool vl)
    {
        if (negation) return !vl;
        return vl;
    }
}
