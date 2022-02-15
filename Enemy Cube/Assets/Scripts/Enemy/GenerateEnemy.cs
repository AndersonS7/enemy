using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> pointEnemy;

    private float generationTime;

    void Start()
    {
        generationTime = 2;
    }

    void Update()
    {
        generationTime += Time.deltaTime;

        if (generationTime > 2)
        {
            GenerateEnemyAtPoint();
            generationTime = 0;
        }
    }

    void GenerateEnemyAtPoint()
    {
        
        Instantiate(enemyPrefab, pointEnemy[Random.Range(0, 8)].position, transform.rotation);
    }
}
