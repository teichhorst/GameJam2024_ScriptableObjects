using _Scripts.Base_References;
using UnityEngine;

namespace _Scripts.Enemies
{
    public class EnemyDamagePlayer : MonoBehaviour
    {
        public FloatReference playerHealth;
        public FloatReference enemyDamage;
        
        private void OnCollisionEnter(Collision other)
        {
            //check if we hit the player
            
            playerHealth.soValue.value -= enemyDamage.Value;
        }
    }
}