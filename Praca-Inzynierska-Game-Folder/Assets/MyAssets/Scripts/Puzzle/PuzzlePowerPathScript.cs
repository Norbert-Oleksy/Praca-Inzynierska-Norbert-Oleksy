using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePowerPathScript : MonoBehaviour
{
    [SerializeField] private bool power;
    [SerializeField] private List<PuzzleLogicBlock> endBlocks = new List<PuzzleLogicBlock>();
    [SerializeField] private List<GameObject> blocks;

    private void Start()
    {
        blocks = new List<GameObject>();
        for (int i = 0; i < this.transform.childCount; i++)
        {
            blocks.Add(this.transform.GetChild(i).gameObject);
        }
        PowerPatch();
    }

    public void SetPower(bool t)
    {
        power = t;
        PowerPatch();
        foreach (var b in endBlocks)
        {
            if(b!=null) b.BlockLogic();
        }
    }

    public bool GetPower()
    {
        return power;
    }

    private void PowerPatch()
    {
        foreach(var b in blocks)
        {
            if(b!=null) b.SetActive(power);
        }
    }
}
