using _Scriptable_Objects.Enemies;
using _Scriptable_Objects.Item_Lists;
using UnityEngine;

namespace _Scripts.Dictionaries
{
    public class BelongsToDictionary : MonoBehaviour
    {
        public ActiveDictionary dictionary;
        public Enemy enemy;

        private void OnEnable()
        {
            dictionary.Add(gameObject, enemy);
        }
        
        private void OnDisable()
        {
            dictionary.Remove(gameObject);
        }
    }
}