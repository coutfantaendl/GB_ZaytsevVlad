using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDoor : MonoBehaviour,IInteractable
{
    public Animator m_Animator;
    public bool isOpen;
    void Start()
    {
        if (isOpen)
        {
            m_Animator.SetBool("isOpen", true);
        }
    }
    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
        else
            m_Animator.SetBool("isOpen", false);
    }

    public string GetDescription()
    {
        if (isOpen) return "Press [E]";
        return "Press [E]";
    }
}
