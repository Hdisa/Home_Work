using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_easy3 : MonoBehaviour
{
    enum weekDay
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
                return weekDay.Monday;
            case 2:
                return weekDay.Tuesday;
            case 3:
                return weekDay.Wednesday;
            case 4:
                return weekDay.Thursday;
            case 5:
                return weekDay.Friday;
            case 6:
                return weekDay.Saturday;
            case 7:
                return weekDay.Sunday;
            default:
                throw new System.ArgumentException("Value isn't found, please, input value from 1 to 7");
        }
    }
}