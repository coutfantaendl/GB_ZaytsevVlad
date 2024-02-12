using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour, IInteractable
{
    public Light[] m_Light;
    public bool isOn;
    void Start()
    {
        foreach (Light light in m_Light)
        {
            light.enabled = isOn;
        }
    }
    public string GetDescription()
    {
        if (isOn) return "Press [E]";
        return "Press [E]";
    }
    public void Interact()
    {
        isOn = !isOn;
        foreach (Light light in m_Light)
        {
            light.enabled = isOn;
        }        
    }
}
