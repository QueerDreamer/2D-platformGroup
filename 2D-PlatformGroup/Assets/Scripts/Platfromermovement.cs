using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfromermovement : MonoBehaviour
{
    [SerializeField]
    public static float moveSpeed = 5.0f;
    [SerializeField]
    public static float jumpSpeed = 1.5f;
    bool grounded = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = moveSpeed + Upgrades.speedUpgrade;
        jumpSpeed = jumpSpeed + Upgrades.jumpUpgrade;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = rb.velocity;
        velocity.x = moveX * moveSpeed;
        rb.velocity = velocity;
        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
