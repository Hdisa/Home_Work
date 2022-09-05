using System;
using UnityEngine;

namespace Easy
{
    public class ExerciseEasy1 : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(CalculateTrianglePerimeter(3, 4));
        }

        float CalculateTrianglePerimeter(float a, float b)
        {
            float sqrtC = a * a + b * b;
            float c = Convert.ToSingle(Math.Sqrt(sqrtC)); //c = 5
            return a + b + c;
        }
    }
}
