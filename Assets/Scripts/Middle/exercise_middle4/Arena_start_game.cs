using Middle.exercise_middle4;
using UnityEngine;

public class ArenaStartGame : MonoBehaviour
{
    public Warrior sora = new Warrior("Sora", 100, 10, 30);
    public Warrior sephiroth = new Warrior("Sephiroth", 125, 10, 20);
    public void StartBattle()
    {
        sora.Greetings();
        sephiroth.Greetings();
        while (sephiroth._health > 0 && sora._health > 0)
        {
            sora.Attack(sephiroth);
            if (sephiroth._health <= 0)
            {
                break;
            }
            sephiroth.Attack(sora);
        }
        Debug.Log("Битва окончена");
    }
    void Start()
    {
        StartBattle();
    }
}
