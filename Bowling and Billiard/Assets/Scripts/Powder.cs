using UnityEngine;
using System.Collections;

public class Powder : Actor
{
    public Cannon cannon; // Keep a personal reference to the Cannon

    /// <summary>
    /// Loads powder into the cannon when a powder load event is triggered
    /// </summary>
    public void OnPowderLoaded()
    {
        if (cannon != null)
        {
            // TO-DO!!
            // Add powder to the cannon using its AddPowder(float) method
        }
    }
}
