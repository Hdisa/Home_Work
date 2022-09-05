using UnityEngine;

namespace Easy
{
    public class ExerciseEasy5 : MonoBehaviour
    {
        void Start()
        {
            numberComparison(200, 199);
        }

        void numberComparison(int x, int y)
        {
            if (x > y)
            {
                Debug.Log($"{x} > {y}");
            }
            else if (x < y)
            {
                Debug.Log($"{x} < {y}");
            }
            else
            {
                Debug.Log($"{x} = {y}");
            }
        }
    }
}
