using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using Valve.VR;

public class VRInput : MonoBehaviour
{
    //Steam VR Actions
    public SteamVR_Action_Boolean upButtonAction;
    public SteamVR_Action_Boolean downButtonAction;
    public SteamVR_Action_Boolean triggerButtonAction;

    // Events
    public UnityEvent onButtonPressUp;
    public UnityEvent onButtonPressDown;
    public UnityEvent onTriggerButtonPress;

    // Update is called once per frame
    void Update()
    {
        // TO-DO!! CHALLENGE!!
        // Check that your button on Vive Controller was pressed
        // Call the event for the button if pressed
        // Repeat for all buttons and events
    }
}
