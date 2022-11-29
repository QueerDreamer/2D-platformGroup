using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrownCounter : MonoBehaviour
{
    public gameObject crownText;
    public TMP_Text crownText;
    public int  currentCrowns = 0;
     public static CrownCounter instance; 
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        crownText.text = "Crowns: " + currentCrowns.ToString();
    }

    public void IncreaseCrowns(int v)
    {
        currentCrowns += v;
        crownText.text = "Crowns: " + currentCrowns.ToString();
    }


}
