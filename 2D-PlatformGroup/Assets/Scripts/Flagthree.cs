using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flagthree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Flag.levelThree = true;
            if (Flag.levelTwo == true && Flag.levelThree == true && Flag.levelFour == true)
            {
                SceneManager.LoadScene("Level 5");
            }
            else
            {
                SceneManager.LoadScene("Hub2");
            }
        }
    }

}
