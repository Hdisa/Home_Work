using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_easy2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(toDivisionRemainder(5, 2));//false
    }
    bool toDivisionRemainder(int x, int y)
    {
            return x % y == 0;
    }
}
