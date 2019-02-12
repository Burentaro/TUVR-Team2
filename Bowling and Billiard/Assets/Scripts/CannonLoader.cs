using UnityEngine;
using System.Collections;

public class CannonLoader : MonoBehaviour
{
    public Cannon cannon;   // Reference to the Cannon

    /// <summary>
    /// Loads the cannon based on the tag of the object that triggered the event.
    /// </summary>
    /// <param name="other">Information on the object that triggered the event.</param>
    private void OnTriggerEnter(Collider other)
    {
        // Get the Actor class
        Actor actor = other.gameObject.GetComponent<Actor>();

        if (actor != null)
        {
            if (actor.gameObject.tag == "Ammo" && gameObject.tag == "Ammo")
            {
                // Check to see if the cannon is already loaded so that you don't override the current load
                if (cannon.IsCannonBallLoaded)
                {
                    // Play Wonk SE
                    return;
                }

                // Pass to the cannon the weight and ammo type
                cannon.LoadCannonBall(actor.actorName);

                // Desctory the object as it's no longer needed
                actor.RemoveObjectFromScene(0);
            }
            else if (actor.gameObject.tag == "Powder" && gameObject.tag == "Powder")
            {
                // Add the powder to the cannon
                cannon.AddPowder(actor.mass);
            }
            else
            {
                // Play Wonk SE
                return;
            }
        }

    }
}
