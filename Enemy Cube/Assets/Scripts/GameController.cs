using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab, enemyPrefab;
    private Transform posPplayer;

    void Start()
    {
        InstantiatePlayer();
    }

    void InstantiatePlayer()
    {
        // adiciona o player na cena
    }

    void InstantiateEnemy()
    {
        // adiciona enimigos na cena
    }
}
