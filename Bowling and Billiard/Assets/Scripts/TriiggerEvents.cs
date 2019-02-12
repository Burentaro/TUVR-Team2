using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriiggerEvents : MonoBehaviour
{
    public string tagName = "Button";
    public UnityEvent onTriggerEvent;

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == tagName)
        {
            Debug.Log("Pizza eatan");
            onTriggerEvent.Invoke();
        }
       
    }
}
