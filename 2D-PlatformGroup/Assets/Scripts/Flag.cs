using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public static bool levelTwo = false;
    public static bool levelThree = false;
    public static bool levelFour = false;
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
            if (levelTwo == true && levelThree == true && levelFour == true)
            {

            }
            else
            {
            SceneManager.LoadScene("Hub2");
            }
        }
    }

}
