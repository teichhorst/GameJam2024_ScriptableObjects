using _Scripts.Base_References;
using UnityEngine;

namespace _Scripts.Player
{
    public class Health : MonoBehaviour
    {
        public FloatReference hp;
        public FloatReference maxHp;
        
        private void Awake()
        {
            hp.soValue.value = maxHp.Value;
        }
    }
}