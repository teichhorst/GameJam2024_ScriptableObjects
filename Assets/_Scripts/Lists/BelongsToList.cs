using System;
using _Scriptable_Objects.Item_Lists;
using UnityEngine;

namespace _Scripts.Lists
{
    public class BelongsToList : MonoBehaviour
    {
        public GameObjectList list;

        private void OnEnable()
        {
            list.Add(gameObject);
        }
        
        private void OnDisable()
        {
            list.Remove(gameObject);
        }
    }
}