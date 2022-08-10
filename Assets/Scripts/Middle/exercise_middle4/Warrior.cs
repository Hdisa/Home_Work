using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior
{
    public string _name;
    public int _health;
    public int _minDamage;
    public int _maxDamage;

    public Warrior(string name, int health, int minDamage, int maxDamage)
    {
        _name = name;
        _health = health;
        _minDamage = minDamage;
        _maxDamage = maxDamage;
    }
    public void greetings()
    {
        Debug.Log($"Его зовут {_name}, его здоровье: {_health}, его урон достигает от {_minDamage} до {_maxDamage}");
    }
    public void attack(Warrior warrior)
    {
        Random randomDamage = new Random();
        int damage = randomDamage.Next(_minDamage, _maxDamage);
        warrior._health -= damage;
        Debug.Log($"Войн {_name}, нанёс удар по {warrior._name}, " +
                  $"нанесённый урон {damage}, оставшийся здоровье у {warrior._name}: {warrior._health}");
    }
}