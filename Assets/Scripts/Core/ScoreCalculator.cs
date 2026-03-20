using UnityEngine;

namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        public int Multiplier { get; set; } = 1; 

        public int Calculate(int kills, int time)
        {
            return Multiplier * kills * time;
        }

        public void ApplyCombo(int comboCount)
        {
            Multiplier *= comboCount;
        }
        public void ResetMultipler()
        {
            Multiplier = 1;
        }
    }
}