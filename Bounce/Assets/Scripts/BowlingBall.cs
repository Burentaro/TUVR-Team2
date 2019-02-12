using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//            ballPool[m] = Instantiate<GameObject>(Ball, pos.position + new Vector3((float)(-1.5 * 0.06), 0.0f, 0.7f) + new Vector3((float)((j + 0.5 * i) * 0.06), (float) (0.5 * 0.06), (float) (-i* 0.5 * 0.06) * (float) Math.Sqrt(3)), pos.rotation);

public class BowlingBall : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out
    public GameObject pinPrefab;
    public GameObject bballPrefab;

    private int k = 0;

    private void BBall(GameObject BBall, Transform pos)
    {


    }

    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        GameObject[] bballPools = inventoryItems;

        if (itemNumber == 2)
        {
            k = 1;
        }
        if (itemNumber == 0 && k == 1)
        {
            k = 0;
            int m = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    bballPools[m] = Instantiate<GameObject>(pinPrefab, dispensePosition.position + new Vector3((float)(-1.5 * 0.25), 0.0f, 8.7f) + new Vector3((float)((j + 0.5 * i) * 0.25), (float)(0.5 * 0.25), (float)(-i * 0.5 * 0.25) * (float)Math.Sqrt(3)), dispensePosition.rotation);
                    m = m + 1;
                }
            }
        }
        if (itemNumber == 1 && k == 1)
        {
            bballPools[0] = Instantiate<GameObject>(bballPrefab, dispensePosition.position + new Vector3(-1.0f, (float)(0.5 * 0.5), -11.5f), dispensePosition.rotation);
            k = 0;
        }

        if (itemNumber == 3 && k == 1)
        {
             k = 0;
            for (int n = 0; n <= 11; n++)
            {
                Destroy(bballPools[n], 0.0f);
            }
        }

        Debug.Log(itemNumber);
    }
}
