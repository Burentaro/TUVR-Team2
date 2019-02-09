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
                Instantiate<GameObject>(Ball).transform.position = pos.position + new Vector3((float)(-1.5*0.06),0.0f, 0.7f) + new Vector3((float)((j +0.5*i)*0.06), (float)(0.5*0.06), (float)(-i*0.5*0.06)*(float)Math.Sqrt(3));
            }
        }
    }

    private int k = 0;
    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        if(itemNumber == 2)
        {
            k = 1;
        }
        if (itemNumber == 0 && k == 1)
        {
            // Dispense an object here using the Instantiate<> function
            Ball(inventoryItems[itemNumber], dispensePosition);
            k = 0;
        }
        if(itemNumber == 1 && k == 1)
        {
            Instantiate<GameObject>(inventoryItems[itemNumber]).transform.position = dispensePosition.position + new Vector3(0.0f, (float)(0.5 * 0.06), -0.7f);
            k = 0;
        }
       
        Debug.Log(itemNumber);
    }
}
