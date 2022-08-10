using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_middle3 : MonoBehaviour
{
    void Start()
    {
        int[] numArray = new int[] {3, 1};
        Debug.Log(evenSum(numArray));
    }
    int evenSum(int[] numArray)
    {
        int result = 0;
        foreach (int x in numArray)
        {
            if (x % 2 == 0)
            {
                result += x;
            }
        }
        if (result == 0)
        {
            return -1;
        }
        return result;
    }
}