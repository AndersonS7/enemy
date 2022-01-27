using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    public static bool gameOver;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            gameOver = true;
            Destroy(this.gameObject);
        }
    }
}
