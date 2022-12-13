using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfromermovement : MonoBehaviour
{
    [SerializeField]
    public static float moveSpeed = 500.0f; //240
    [SerializeField]
    public static float jumpSpeed = 3f;
    bool grounded = false;
    bool dash = false;
    Rigidbody2D rb;
    public Animator animator;
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
        rb.AddForce(new Vector2(moveX * Time.deltaTime * moveSpeed, 0));
        animator.SetFloat("xInput", moveX);
        //rb.velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            animator.SetTrigger("Jumping");
        }
        if (Input.GetButtonDown("Dash"))
        {
            if (dash == true)
            {
            if (moveX > 0)
            {
            rb.AddForce(new Vector2(1.05f * moveSpeed, 100));
            dash = false;
            }
            else
            {
            rb.AddForce(new Vector2(-1.05f * moveSpeed, 100));
            dash = false;
            }
            }
        }
        float moveY = Input.GetAxis("Vertical");
        if (moveY < 0)
        {
        //GetComponent<Animator>()
        animator.SetBool("Falling",true);
        }
        else
        {
            animator.SetBool("Falling", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
            dash = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        dash = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
