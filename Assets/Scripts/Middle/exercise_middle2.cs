using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_middle2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(rowOfNumbers(10, 2));   
    }
    int rowOfNumbers(int n, int x)
    {
        for (int i = 0; i <= n;)
        {
            Debug.Log(i);
            i += x;
        }
        return x;
    }
}
