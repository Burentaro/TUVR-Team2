using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoolBall : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out
    private void Ball(GameObject Ball, Transform pos)
    {
        
        for (int i = 0; i < 4; i++)
        {
            for(int j = 0; j< 4 - i; j ++)
            {
                Instantiate<GameObject>(Ball).transform.position = pos.position + new Vector3(-0.1f,0.0f, 0.75f) + new Vector3((float)((j +0.5*i)*0.015), 0.016f, (float)(-i*0.5*0.03)*(float)Math.Sqrt(3));
            }
        }
    }
    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        // Dispense an object here using the Instantiate<> function
        Ball(inventoryItems[itemNumber],dispensePosition);
        Debug.Log(itemNumber);
    }
}
