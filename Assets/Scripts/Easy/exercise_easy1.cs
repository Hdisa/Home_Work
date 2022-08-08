using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_easy1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(CalculateTrianglePerimeter(3, 4));
    }
    float CalculateTrianglePerimeter(float a, float b) {
        float sqrtC = a * a + b * b;
        float c = Convert.ToSingle(Math.Sqrt(sqrtC)); //c = 5
        return a + b + c;
    }
}
