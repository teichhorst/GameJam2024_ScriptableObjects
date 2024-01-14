using System.Collections.Generic;
using UnityEngine;

namespace _Scriptable_Objects.Item_Lists
{
    [CreateAssetMenu(fileName = "new GameObject List", menuName = "Scriptable Object/GameObject List")]
    public class GameObjectList : ScriptableObject
    {
        public List<GameObject> items;

        public void Add(GameObject t)
        {
            if (!items.Contains(t)) items.Add(t);
        }

        public void Remove(GameObject t)
        {
            if (items.Contains(t)) items.Remove(t);
        }
    }
}