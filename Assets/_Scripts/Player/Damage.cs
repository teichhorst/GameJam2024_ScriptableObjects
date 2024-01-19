using System.Linq;
using _Scriptable_Objects.Base;
using _Scriptable_Objects.Enemies;
using _Scriptable_Objects.Events;
using _Scriptable_Objects.Item_Lists;
using _Scripts.Base_References;
using Unity.VisualScripting;
using UnityEngine;

namespace _Scripts.Player
{
    public class Damage : MonoBehaviour
    {
        public FloatReference playerHealth;

        public ActiveDictionary enemyList;

        public SoCustomEvent onDamage;
        public SoCustomEvent onGameOver;
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.rigidbody == null) return;

            Enemy enemy = enemyList.Enemies.FirstOrDefault(x => x.Key == other.rigidbody.gameObject).Value;
            
            if (enemy == null) return;

            playerHealth.soValue.value -= enemy.damage;

            if (playerHealth.Value <= 0f) onGameOver.Raise();
            
            onDamage.Raise();
        }
    }
}