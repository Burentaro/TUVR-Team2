using UnityEngine;

public class Actor : MonoBehaviour
{
    public string actorName;    // Unique name to identify the actor or share data
    public float mass;          // Mass in of the object
    public bool isAlive;        // A flag to let us know if the object is alive or not

    /// <summary>
    /// A method used to let us customize how the object will be removed from the scene
    /// </summary>
    /// <param name="delay">How long to wait till the object is removed.</param>
    public virtual void RemoveObjectFromScene(int delay)
    {
        // Only remove is not alize
        if (!isAlive)
        {
            // Remove from the scene with a delay
            Destroy(gameObject, delay);
        }
    }
}
