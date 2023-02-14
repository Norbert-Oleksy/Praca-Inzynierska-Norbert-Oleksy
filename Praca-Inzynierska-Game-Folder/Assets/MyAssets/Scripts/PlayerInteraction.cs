using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionRange;
    private float timer = 1f;
    private float delayTime = 1f;
    private InteractableObject _selectedObject;
    public InteractableObject CurrentSelectedObject => _selectedObject;

    void Update()
    {
        if (timer >= delayTime)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (CkeckRey())
                {
                    timer = 0;
                    DoInteraction();
                }
            }
        }
        timer += Time.deltaTime;
    }

    private bool CkeckRey()
    {
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward * interactionRange));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance <= interactionRange)
            {
                GameObject hitObject = hit.transform.gameObject;
                InteractableObject intObject = hitObject.GetComponent<InteractableObject>();
                if (intObject != null)
                {
                    _selectedObject = intObject;
                    return true;
                }
            }
        }
        return false;
    }

    private void DoInteraction()
    {
        _selectedObject.StartAction();
    }
}
