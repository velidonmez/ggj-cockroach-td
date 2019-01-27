using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public enum EnemyType
    {
        Cockroach
    }

    [System.Serializable]
    public class EnemySpawn
    {
        public EnemyType enemyType;
        public float timeSpawnAfterLevelStarts;
    }

    public GameObject Cockroach;
    public EnemySpawn[] enemiesToSpawn;
    private int currentEnemyToSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (currentEnemyToSpawn < enemiesToSpawn.Length && Time.timeSinceLevelLoad > enemiesToSpawn[currentEnemyToSpawn].timeSpawnAfterLevelStarts)
        {
            if (enemiesToSpawn[currentEnemyToSpawn].enemyType == EnemyType.Cockroach)
            {
                Instantiate(Cockroach, transform, true);
            }

            currentEnemyToSpawn++;
        }
    }
}
