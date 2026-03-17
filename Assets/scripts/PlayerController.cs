using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    Rigidbody rb;
    public bool yKilitli = false;
    public float sabitY;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveY).normalized * moveSpeed;
        rb.linearVelocity = movement;
        if (yKilitli)
        {
            Vector3 pos = transform.position;
            pos.y = sabitY;
            transform.position = pos;
        }

    }
}
