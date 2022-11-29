using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    public static int crowns = 0;
    Rigidbody2D rb;
    public GameObject crown;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        crowns = crowns + 1;
        Destroy(crown);
    }
}
