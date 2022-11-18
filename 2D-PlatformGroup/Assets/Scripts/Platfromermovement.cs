using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfromermovement : MonoBehaviour
{
    [SerailizeField]
    float moveSpeed = 1.0f;
    [SerializeField]
    float jumpSpeed = 1.0f;
    bool grounded = false;
    RigidBody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = rb.veloctiy;
        velocity.x = moveX * moveSpeed;
        rb.velocity = velocity;
        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collisison.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collison)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
