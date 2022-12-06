using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelone()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void leveltwo()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void levelthree()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void levelfour()
    {
        SceneManager.LoadScene("Level 4");
    }
}
