using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This is a custom UnityEvent that shares a number with GameObjects that are listening
/// </summary>
[System.Serializable]
public class ButtonPressedEvent : UnityEvent<int> { }

public class Button : MonoBehaviour
{
    public int itemNumber;                          // Inventory Id for the item that this button will dispense
    public ButtonPressedEvent buttonPressedEvent;   // Custom event to send a message to the dispenser to dispense an item

    /// <summary>
    /// Attach this method to a TriggerEvent's OnTriggerEvent.
    /// Then call this method to tell the dispenser to dispense an item.
    /// </summary>
    public void OnButtonPressed()
    {
        // Let the dispenser/listener know that it should dispense an item
        buttonPressedEvent.Invoke(itemNumber);
    }
}
