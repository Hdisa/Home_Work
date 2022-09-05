using UnityEngine;

namespace Easy
{
    public class ExerciseEasy4 : MonoBehaviour
    {
        const float ConvertValue = 2.204f;
        float kilogram, pound;

        void Start()
        {
            Debug.Log(ConvertPoundToKilogam(10)); //4.53
            Debug.Log(ConvertKilogramToPound(10)); //22.04
        }

        float ConvertPoundToKilogam(float pound)
        {
            return kilogram = pound / ConvertValue;
        }

        float ConvertKilogramToPound(float kilogram)
        {
            return pound = kilogram * ConvertValue;
        }
    }
}
