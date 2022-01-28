using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    public static bool gameOver;

    void Awake()
    {
        gameOver = false;
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            gameOver = true;
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }
}
