using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_easy4 : MonoBehaviour
{
    const float convertValue = 2.204f;
    float kilogram, pound;
    void Start()
    { 
        Debug.Log(convertPoundToKilogam(10));//4.53
        Debug.Log(convertKilogramToPound(10));//22.04
    }
    float convertPoundToKilogam(float pound)
    {
         return kilogram = pound / convertValue;
    }
    float convertKilogramToPound(float kilogram)
    {
         return pound = kilogram * convertValue;
    }
}
