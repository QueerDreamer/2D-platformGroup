using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flagtwo : MonoBehaviour
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
            Flag.levelTwo = true;
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
