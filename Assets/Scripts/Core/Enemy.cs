using UnityEngine;


namespace SpaceDefender.Core
{
    public class Enemy
    {
        //Test comment for commit
        public int Health { get; private set; } = 100;
        int pointValue = 2;

        public int Reward { get; private set; } = 10;
        public bool IsAlive => Health > 0;

        public void TakeDamage(int amount)
        {
            Health -= Mathf.Abs(amount);

            if (Health < 0) Health = 0;
        }

        public int GetReward()
        {
            return Reward;
        }
    }
}

