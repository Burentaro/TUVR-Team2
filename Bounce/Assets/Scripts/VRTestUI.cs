using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[System.Serializable]
public class VRTestEventInt : UnityEvent<int> { }
[System.Serializable]
public class VRTestEventFloat : UnityEvent<int> { }

public class VRTestUI : MonoBehaviour
{
    // Events
    public VRTestEventInt pitchUpEvent;
    public VRTestEventInt pitchDownEvent;
    public UnityEvent fireCannonEvent;
    public VRTestEventFloat loadPowderEvent;

    // Update is called once per frame
    void Update()
    {
    }
}
