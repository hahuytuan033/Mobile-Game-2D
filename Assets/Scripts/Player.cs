using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movement;
    [SerializeField] private float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        movement = SimpleInput.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(movement, 0f, 0f) * Time.deltaTime * speed;
    }
}
