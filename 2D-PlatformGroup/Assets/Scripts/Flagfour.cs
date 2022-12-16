using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flagfour : MonoBehaviour
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
            Flag.levelFour = true;
            if (Flag.levelTwo == true && Flag.levelThree == true && Flag.levelFour == true)
            {

            }
            else
            {
                SceneManager.LoadScene("Hub2");
            }
        }
    }

}
