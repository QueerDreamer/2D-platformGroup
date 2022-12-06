using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public static float jumpUpgrade = 0f;
    public static float speedUpgrade = 0f;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void SpeedUp()
    {
      if (Crown.crowns >= 10)
        {
        Crown.crowns = Crown.crowns - 10;
        speedUpgrade = speedUpgrade + 0.6f;
        Platfromermovement.moveSpeed = Platfromermovement.moveSpeed + speedUpgrade;
        }
    }

    public void JumpUp()
    {
        if (Crown.crowns >= 10)
        {
        Crown.crowns = Crown.crowns - 10;
        jumpUpgrade = jumpUpgrade + 0.2f;
        Platfromermovement.jumpSpeed = Platfromermovement.jumpSpeed + jumpUpgrade;
        }
    }
}
