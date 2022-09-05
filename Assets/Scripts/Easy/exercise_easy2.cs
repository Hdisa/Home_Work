using UnityEngine;
namespace Easy
{
    public class ExerciseEasy2 : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(toDivisionRemainder(5, 2)); //false
        }

        bool toDivisionRemainder(int x, int y)
        {
            return x % y == 0;
        }
    }
}