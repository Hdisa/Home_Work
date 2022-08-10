using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena_start_game : MonoBehaviour
{
    public Warrior sora = new Warrior("Sora", 100, 10, 30);
    public Warrior sephiroth = new Warrior("Sephiroth", 125, 10, 20);
    public void startBattle()
    {
        sora.greetings();
        sephiroth.greetings();
        while (sephiroth._health > 0 && sora._health > 0)
        {
            sora.attack(sephiroth);
            if (sephiroth._health <= 0)
            {
                break;
            }
            sephiroth.attack(sora);
        }
        Debug.Log("Битва окончена");
    }
    void Start()
    {
        startBattle();
    }
}
