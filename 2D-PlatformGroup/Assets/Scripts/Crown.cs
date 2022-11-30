using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Crown : MonoBehaviour
{
    public GameObject Player;
    public static int crowns = 0;
    Rigidbody2D rb;
    public GameObject crown;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        crowns += 1;
        Destroy(crown);   
        }
    }
}
