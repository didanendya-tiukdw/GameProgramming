using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove2D : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 move;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        move = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
}
