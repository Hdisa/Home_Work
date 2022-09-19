using UnityEngine;

namespace Middle
{
    public class ExerciseMiddle2 : MonoBehaviour
    {
        private void Start()
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
}
