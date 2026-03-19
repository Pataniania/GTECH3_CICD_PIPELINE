using UnityEngine;

namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        public int Multiplier { get; set; } = 1; 
        private Player _player;
        public void Calculate()
        {
            
        }

        public void ApplyCombo()
        {
            Multiplier *= _player.NumberOfKills;
        }
        public void ResetMultipler()
        {

        }
    }
}