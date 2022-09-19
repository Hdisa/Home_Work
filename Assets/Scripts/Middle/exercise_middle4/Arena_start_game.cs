using UnityEngine;

namespace Middle.exercise_middle4
{
    public class ArenaStartGame : MonoBehaviour
    {
        private Warrior sora = new Warrior("Sora", 100, 10, 30);
        private Warrior sephiroth = new Warrior("Sephiroth", 125, 10, 20);

        private void StartBattle()
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

        private void Start()
        {
            StartBattle();
        }
    }
}
