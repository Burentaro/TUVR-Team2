using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;   // Add UnityEngine.Events library to use UnityEvents

public class TriggerEvents : MonoBehaviour
{
    public string tagName = "Button";   // Use tag name filter out only the objects that we want
    public UnityEvent onTriggerEvent;   // Event to tell GameObjects listening that a Collider event was triggered

    /// <summary>
    /// This method is called when an object enter a Collider trigger
    /// </summary>
    /// <param name="other">Collider of GameObject that collided with me</param>
    public void OnTriggerEnter(Collider other)
    {
        // Check that the object collided with is a button
        if (other.gameObject.tag == tagName)
        {
            Debug.Log(other.gameObject.tag + " triggered me!");
            // Let all listeners know that the button has been triggered
            onTriggerEvent.Invoke();
        }
        
    }
}
