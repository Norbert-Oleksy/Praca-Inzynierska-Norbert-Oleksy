using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGateScript : MonoBehaviour
{
    [SerializeField] private Transform gate;
    [SerializeField] private float speed;
    [SerializeField] private float closeHight;
    [SerializeField] private float openHight;
    private Vector3 target;

    private void Start()
    {
        target = gate.position;
    }

    private void Update()
    {
        if (gate.position.y != target.y)
        {
            gate.position = Vector3.MoveTowards(gate.position, target, speed * Time.deltaTime);
            if(gate.position.y == target.y)
            {
                gate.position = target;
            }
        }
    }

    public void OpenGate()
    {
        target = new Vector3(gate.position.x, openHight, gate.position.z);
    }

    public void CloseGate()
    {
        target = new Vector3(gate.position.x, closeHight, gate.position.z);
    }
}
