using UnityEngine;
namespace Middle
{
    public class ExerciseMiddle3 : MonoBehaviour
    {
        private void Start()
        {
            int[] numArray = new int[] { 3, 1 };
            Debug.Log(EvenSum(numArray));
        }

        static int EvenSum(int[] numArray)
        {
            var result = 0;
            foreach (var x in numArray)
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
}
