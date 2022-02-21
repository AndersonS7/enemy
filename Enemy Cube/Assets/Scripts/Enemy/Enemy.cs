using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 target;
    private Transform posPlayer;
    private SpriteRenderer editColorEnemy;

    void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = posPlayer.transform.position;
        editColorEnemy = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        ControllerCollision(coll.gameObject);
    }

    void ControllerCollision(GameObject coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    void FollowPlayBasic(float speed, Color color)
    {
        editColorEnemy.color = color;

        if (gameObject.transform.position == target)
        {
            target = posPlayer.transform.position;
        }

        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
        }
    }
    void FollowPlayerHard(float speed, Color color)
    {
        target = posPlayer.transform.position;
        editColorEnemy.color = color;
        
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
        }
    }
}
