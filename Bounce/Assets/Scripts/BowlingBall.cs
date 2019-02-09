using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BowlingBall : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out
    private void BBall(GameObject BBall, Transform pos)
    {

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4 - i; j++)
            {
                Instantiate<GameObject>(BBall).transform.position = pos.position + new Vector3((float)(-1.5 * 0.25), 0.0f, 8.7f) + new Vector3((float)((j + 0.5 * i) * 0.25), (float)(0.5 * 0.25), (float)(-i * 0.5 * 0.25) * (float)Math.Sqrt(3));
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
        if (itemNumber == 2)
        {
            k = 1;
        }
        if (itemNumber == 0 && k == 1)
        {
            BBall(inventoryItems[itemNumber], dispensePosition);
            k = 0;
        }
        if (itemNumber == 1 && k == 1)
        {
            Instantiate<GameObject>(inventoryItems[itemNumber]).transform.position = dispensePosition.position + new Vector3(-1.0f, (float)(0.5 * 0.5), -11.5f);
            k = 0;
        }

        Debug.Log(itemNumber);
    }
}
