using System.Collections.Generic;
using _Scriptable_Objects.Enemies;
using UnityEngine;
using System.Linq;

namespace _Scriptable_Objects.Item_Lists
{
    [CreateAssetMenu(fileName = "new Active Dictionary", menuName = "Scriptable Object/Active Dictionary")]
    public class ActiveDictionary : ScriptableObject
    {
        public Dictionary<GameObject, Enemy> Enemies = new Dictionary<GameObject, Enemy>();

        public void Add(GameObject t, Enemy enemy)
        {
            if (Enemies.ContainsKey(t)) return;
            Enemies.Add(t, enemy);
        }

        public void Remove(GameObject t)
        {
            if (Enemies.ContainsKey(t))
            {
                Enemies.Remove(t);
            }
        }
    }
}