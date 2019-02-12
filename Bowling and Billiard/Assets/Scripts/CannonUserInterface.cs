using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CannonUserInterface : MonoBehaviour
{
    public Text cannonballText;
    public Text powderText;
    public Text angleText;

    /// <summary>
    /// Update the UI of the cannon when the cannon gets updated
    /// </summary>
    /// <param name="angle">Angle of the cannon.</param>
    /// <param name="powder">How much powder is loaded.</param>
    /// <param name="cannonBall">What cannonball is loaded.</param>
    public void OnCannonUpdated(float angle, float powder, string cannonBall)
    {
        // Check that the reference is not missing
        if (cannonballText != null)
        {
            // If the cannonball name is missing or empty show message, else show name of the cannonball.
            if (string.IsNullOrEmpty(cannonBall))
            {
                // TO-DO!!
                // Add a special message when no cannonball
            }
            else
            {
                // TO-DO!!
                // Show the name of the cannonball if loaded
            }
        }

        // Check that the reference is not missing
        if (powderText != null)
        {
            // TO-DO!!
            // Show the ammount of powder loaded with correct units
        }

        // Check that the reference is not missing
        if (angleText != null)
        {
            // TO-DO!!
            // Show the angle of the cannon in degrees
        }
    }
}
