using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoolBall : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out

    private int k = 0;
    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        GameObject[] ballPools = inventoryItems;

        if (itemNumber == 2)
        {
            k = 1;
        }
        if (itemNumber == 0 && k == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                { 
                    ballPools[i*4 +j +1] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((j + 0.5 * i) * 0.06), (float)(0.5 * 0.06), (float)(-i * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
                }
            }
         //   ballPools[1] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((0 + 0.5 * 0) * 0.06), (float)(0.5 * 0.06), (float)(-0 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[2] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((1 + 0.5 * 0) * 0.06), (float)(0.5 * 0.06), (float)(-0 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[3] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((2 + 0.5 * 0) * 0.06), (float)(0.5 * 0.06), (float)(-0 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[4] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((3 + 0.5 * 0) * 0.06), (float)(0.5 * 0.06), (float)(-0 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[5] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((0 + 0.5 * 1) * 0.06), (float)(0.5 * 0.06), (float)(-1 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[6] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((1 + 0.5 * 1) * 0.06), (float)(0.5 * 0.06), (float)(-1 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[7] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((2 + 0.5 * 1) * 0.06), (float)(0.5 * 0.06), (float)(-1 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[8] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((0 + 0.5 * 2) * 0.06), (float)(0.5 * 0.06), (float)(-2 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[9] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((1 + 0.5 * 2) * 0.06), (float)(0.5 * 0.06), (float)(-2 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
         //   ballPools[10] = Instantiate<GameObject>(inventoryItems[0], dispensePosition.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((0 + 0.5 * 3) * 0.06), (float)(0.5 * 0.06), (float)(-3 * 0.5 * 0.06) * (float)Math.Sqrt(3)), dispensePosition.rotation);
            k = 0;

            // Dispense an object here using the Instantiate<> function
            // Ball(inventoryItems[0], dispensePosition, ballPools);

        }
        if (itemNumber == 1 && k == 1)
        {
            ballPools[0] = Instantiate<GameObject>(inventoryItems[1], dispensePosition.position + new Vector3(0.0f, (float)(0.5 * 0.06), -0.7f), dispensePosition.rotation);
            //ballPool[0].transform.position = dispensePosition.position + new Vector3(0.0f, (float)(0.5 * 0.06), -0.7f);
            k = 0;
        }
        if (itemNumber == 3 && k == 1)
        {
            for (int n = 0; n <= 14; n++)
            {
                Destroy(ballPools[n], 0.0f);
            }
            k = 0;
        }

        Debug.Log(itemNumber);
    }
}
