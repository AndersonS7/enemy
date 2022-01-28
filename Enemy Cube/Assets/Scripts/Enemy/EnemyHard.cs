using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHard : MonoBehaviour
{
    Transform target;
    float speed;

    void Start()
    {
        speed = 3;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.fixedDeltaTime);
        }
    }
}
