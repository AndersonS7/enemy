using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab, enemyPrefab, enemyMidlePrefab, enemyHardPrefab, gemaPrefab;
    public Transform posPplayer;
    public List<GameObject> posEnemy;

    private float time;
    private float timeSurvival;
    private float timeGema;
    private int coutGema;

    // UI
    public GameObject menu;
    public Text gema;

    void Start()
    {
        time = 0;
        timeSurvival = 0;
        menu.SetActive(false);

        // ----
        InstantiatePlayer();
    }

    void Update()
    {

        addGema();
        // check player gameover
        CheckGameOver();

        //times
        timeSurvival += Time.deltaTime;
        time += Time.deltaTime;
        timeGema += Time.deltaTime;

        // enemy instantiate
        if (time >= 1 && !DeathPlayer.gameOver)
        {
            InstantiateEnemy(enemyPrefab); //enemy comum
            if (timeSurvival >= 8)
            {
                InstantiateEnemy(enemyMidlePrefab);
            }
            if (timeSurvival >= 10)
            {
                InstantiateEnemy(enemyHardPrefab);
            }
            time = 0;
        }

        // gema instantiate
        if (timeGema >= 2)
        {
            InstantiateGema();
            timeGema = 0;
        }
    }

    // ----
    void InstantiatePlayer()
    {
        Instantiate(playerPrefab, posPplayer.transform.position, playerPrefab.transform.rotation);
    }
    void InstantiateEnemy(GameObject enemy)
    {
        int drawPos = Random.Range(0, 8);
        Instantiate(enemy, posEnemy[drawPos].transform.position, enemyPrefab.transform.rotation);
    }
    void CheckGameOver()
    {
        if (DeathPlayer.gameOver)
        {
            menu.SetActive(true);
        }
    }
    void addGema()
    {
        if (MovePlayer.isCollider)
        {
            coutGema += 1;
            gema.text = coutGema.ToString();
            MovePlayer.isCollider = false;
        }
    }
    void InstantiateGema()
    {
        float posX = Random.Range(-7, 7);
        float posY = Random.Range(-4, 4);
        Vector3 posGema = new Vector3(posX, posY, 0);
        Instantiate(gemaPrefab, posGema, gemaPrefab.transform.rotation);
    }
}
