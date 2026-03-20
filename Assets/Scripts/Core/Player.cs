using UnityEngine;

namespace SpaceDefender.Core
{
    public class Player
    {
        public int Health { get; private set; } = 100;
        public int Lives { get; private set; } = 3;
        public int Score { get; private set; } = 0;
        public bool IsAlive => Health > 0 && Lives > 0;

        public int NumberOfKills { get; set; } = 1;

        public void TakeDamage(int amount)
        {
            Health -= Mathf.Abs(amount);

            if (Health < 0) Health = 0;
        }

        public void Heal(int amount)
        {
            Health += amount;

            if (Health > 100) Health = 100;
        }
        public void AddScore(int points)
        {
            Score += points;
        }
        public void LoseLife()
        {
            Lives -= 1;

            if (Lives < 0) Lives = 0;

        }
    }
}

