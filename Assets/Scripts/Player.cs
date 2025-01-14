using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movement;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        movement = SimpleInput.GetAxis("Horizontal");

        // Jump with K key
        if (Input.GetKeyDown(KeyCode.K))
        {
            JumpButton();
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(movement, 0f, 0f) * Time.deltaTime * speed;
    }

    //Jump with Jump Button
    public void JumpButton()
    {
        Vector2 velocity = rb.linearVelocity;
        velocity.y = jumpHeight;
        rb.linearVelocity= velocity;
    }
    
}
