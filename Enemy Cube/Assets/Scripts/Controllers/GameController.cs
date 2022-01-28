using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab, enemyPrefab, enemyMidlePrefab, enemyHardPrefab;
    public Transform posPplayer;

    private float time;
    private float timeSurvival;
    
    // UI
    public GameObject menu;


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
        // check player gameover
        CheckGameOver();

        //times
        timeSurvival += Time.deltaTime;
        time += Time.deltaTime;

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
    }

    // ----
    void InstantiatePlayer()
    {
        Instantiate(playerPrefab, posPplayer.transform.position, playerPrefab.transform.rotation);
    }
    void InstantiateEnemy(GameObject enemy)
    {
        float posX = Random.Range(-8, 8);
        float posY = Random.Range(-4, 4);
        Vector3 posEnemy = new Vector3(posX, posY, 0);

        if (Vector3.Distance(posEnemy, playerPrefab.transform.position) >= 3)
        {
            Instantiate(enemy, posEnemy, enemyPrefab.transform.rotation);
        }
    }
    void CheckGameOver()
    {
        if (DeathPlayer.gameOver)
        {
            menu.SetActive(true);
        }
    }
}
