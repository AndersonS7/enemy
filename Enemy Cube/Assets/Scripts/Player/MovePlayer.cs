using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    float speed;
    Vector3 direction;
    public static bool isCollider;

    void Start()
    {
        speed = 4;
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

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Gema"))
        {
            isCollider = true;
            Destroy(coll.gameObject);
        }
    }
}
