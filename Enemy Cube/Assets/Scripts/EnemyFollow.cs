using UnityEngine;

public class EnemyFollow : MonoBehaviour
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
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }


}
