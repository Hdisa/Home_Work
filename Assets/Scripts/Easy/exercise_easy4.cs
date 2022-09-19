using UnityEngine;

namespace Easy
{
    public class ExerciseEasy4 : MonoBehaviour
    {
        private const float ConvertValue = 2.204f;
        private float _kilogram;
        private float _pound;

        private void Start()
        {
            Debug.Log(ConvertPoundToKilogram(10)); //4.53
            Debug.Log(ConvertKilogramToPound(10)); //22.04
        }

        private float ConvertPoundToKilogram(float pound)
        {
            return _kilogram = pound / ConvertValue;
        }

        private float ConvertKilogramToPound(float kilogram)
        {
            return _pound = kilogram * ConvertValue;
        }
    }
}
