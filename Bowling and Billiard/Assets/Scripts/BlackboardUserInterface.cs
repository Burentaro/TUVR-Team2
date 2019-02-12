using UnityEngine;
using UnityEngine.UI;

public class BlackboardUserInterface : MonoBehaviour
{
    public Text targetDistanceText; // Reference to the UI Text for showing distance to target
    public Text shotDistanceText;   // Reference to the UI Text for showing shot distance
    public Text cannonballText;     // Reference to the UI Text for showing what cannonball was loaded
    public Text powderText;         // Reference to the UI Text for showing how much powder was loaded
    public Text angleText;          // Reference to the UI Text for showing last angle used

    public void OnTargetMissed(ShotHistory history)
    {
        // Update Text fields
        SetTextData(SceneManager.Instance.GetTargetDistance(), history);
    }

    public void OnTargetHit(ShotHistory history)
    {
        // Update Text fields
        SetTextData(SceneManager.Instance.GetTargetDistance(), history);
    }

    private void SetTextData(float targetDistance, ShotHistory history)
    {
        // TO-DO!!
        // Update the text field in the UI Text with the ShotHistory
    }
}
