using System.Collections.Generic;
using UnityEngine;

namespace _Scriptable_Objects.Enemies
{
    [CreateAssetMenu(fileName = "New Enemy List", menuName = "Scriptable Object/Enemy List")]
    public class EnemyList : ScriptableObject
    {
        public List<Enemy> enemies;

        public Enemy GetRandomEnemy()
        {
            float totalSpawnChance = 0;
            foreach (var enemy in enemies)
            {
                totalSpawnChance += enemy.spawnChance;
            }

            float random = Random.Range(0, totalSpawnChance);
            float currentSpawnChance = 0;
            foreach (var enemy in enemies)
            {
                currentSpawnChance += enemy.spawnChance;
                if (random <= currentSpawnChance)
                {
                    return enemy;
                }
            }

            return null;
        }
    }
}
