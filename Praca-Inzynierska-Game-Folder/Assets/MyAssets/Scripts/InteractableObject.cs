using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private bool canInteract;
    public UnityEvent startActionEvent = new UnityEvent();

    public virtual void StartAction()
    {
        if (!canInteract) return;
        startActionEvent?.Invoke();
    }
}
