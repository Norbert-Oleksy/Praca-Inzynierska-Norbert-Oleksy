using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePowerSourceScript : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private bool power;
    [Header("Objects")]
    [SerializeField] private GameObject orb;
    [SerializeField] private List<PuzzlePowerPathScript> powerPaths = new List<PuzzlePowerPathScript>();

    private void Awake()
    {
        SetPowerPaths();
    }

    private void SetPowerPaths()
    {
        foreach(var patch in powerPaths)
        {
            if (patch == null) continue;
            patch.SetPower(power);
        }
    }

    public void SetPower(bool p)
    {
        power = p;
        SetPowerPaths();
    }
}
