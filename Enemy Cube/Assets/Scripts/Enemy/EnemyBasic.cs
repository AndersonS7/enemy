using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    Vector3 target;
    Transform posPlayer;
    float speed;

    void Start()
    {
        speed = 2.5f;
        posPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = posPlayer.transform.position;
    }

    void FixedUpdate()
    {
        FollowPlay();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        ControllerCollision(coll.gameObject);
    }

    // ----
    void ControllerCollision(GameObject coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    void FollowPlay()
    {
        if (gameObject.transform.position == target)
        {
            target = posPlayer.transform.position;
        }

        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
        }
    }
}
