using UnityEngine;
using System.Collections;

public class Target : Actor
{
    public GameObject explodingObject;  // A reference to the object that we will use to show an explosion.
    public Animator explodingAnimator;  // Animator that controls the explosion animation

    private void Awake()
    {
        // TO-DO!!
        // Hide all objects by disabling all MeshRenders
    }

    /// <summary>
    /// Called when you want to replace this object with another one
    /// </summary>
    public void Replace()
    {
        // TO-DO!!
        // Hide this object

        // TO-DO!!
        // Show the expoloding object

        // TO-DO!! CHALLENGE!!!
        // Start the exploding animation by playing the explosion state on the object

        // TO-DO!!
        // Remove this from the scene with 2 second delay
    }

    /// <summary>
    /// Shows or hides an object by enabling or disabling the MeshRender component on all child objects
    /// </summary>
    /// <param name="value">True to show. False to hide.</param>
    /// <param name="target">Object you want to hide.</param>
    private void SetMeshRenderer(bool value, GameObject target)
    {
        // Get all of the MeshRenderes on the object's children
        MeshRenderer[] meshRenderers = target.GetComponentsInChildren<MeshRenderer>();
        
        // Only continue if there are any MeshRenderes on the children
        if (meshRenderers != null && meshRenderers.Length > 0)
        {
            // Go through all MeshRenderes in the array and set their values
            foreach (MeshRenderer meshRenderer in meshRenderers)
            {
                meshRenderer.enabled = value;
            }
        }
    }
}
