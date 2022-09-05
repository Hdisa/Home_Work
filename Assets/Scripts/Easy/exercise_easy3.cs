using UnityEngine;

namespace Easy
{
    public class ExerciseEasy3 : MonoBehaviour
    {
        enum WeekDay
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        void Start()
        {
            Debug.Log(callsWeekDay(1));
        }

        object callsWeekDay(int weekDayValue)
        {
            switch (weekDayValue)
            {
                case 1:
                    return WeekDay.Monday;
                case 2:
                    return WeekDay.Tuesday;
                case 3:
                    return WeekDay.Wednesday;
                case 4:
                    return WeekDay.Thursday;
                case 5:
                    return WeekDay.Friday;
                case 6:
                    return WeekDay.Saturday;
                case 7:
                    return WeekDay.Sunday;
                default:
                    throw new System.ArgumentException("Value isn't found, please, input value from 1 to 7");
            }
        }
    }
}