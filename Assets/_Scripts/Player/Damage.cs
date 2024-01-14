using _Scriptable_Objects.Base;
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

        public GameObjectList enemyList;

        public SoCustomEvent onDamage;
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.rigidbody == null) return;

            if (!enemyList.items.Contains(other.rigidbody.gameObject)) return;

            playerHealth.soValue.value -= 10f;
            
            onDamage.Raise();
        }
    }
}