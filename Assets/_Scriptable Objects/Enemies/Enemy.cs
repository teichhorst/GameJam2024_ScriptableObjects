using System;
using UnityEngine;

namespace _Scriptable_Objects.Enemies
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Scriptable Object/Enemy")]
    [Serializable]
    public class Enemy : ScriptableObject
    {
        public string enemyName;
        public float damage;
        public float spawnChance;
        public GameObject prefab;
    }
}