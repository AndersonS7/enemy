using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float speed;
    Vector3 direction;
    void Start()
    {
        speed = 3.5f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += speed * direction * Time.fixedDeltaTime;
    }
}
