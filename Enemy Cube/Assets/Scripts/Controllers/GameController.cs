using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform posPplayer;

    private float min, seg;

    // UI
    public GameObject menu;
    public Text minTxt, segTxt;

    void Start()
    {
        menu.SetActive(false);
        // ----
        InstantiatePlayer();
    }

    void Update()
    {
        CheckGameOver(); // check player gameover
        Conometer();
    }

    // ----
    void InstantiatePlayer()
    {
        Instantiate(playerPrefab, posPplayer.transform.position, playerPrefab.transform.rotation);
    }
    void CheckGameOver()
    {
        if (DeathPlayer.gameOver)
        {
            menu.SetActive(true);
        }
    }
    void Conometer()
    {
        seg += Time.deltaTime;
        if (seg > 59)
        {
            min += 1;
            seg = 0;
        }
        segTxt.text = seg.ToString("00");
        minTxt.text = min.ToString("00");
    }
}
