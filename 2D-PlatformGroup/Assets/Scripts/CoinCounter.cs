using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int value;
    public TMP_Text coinText;
     public static CoinCounter instance; 
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Crowns: " + Crown.crowns.ToString();
    }

    //public void IncreaseCoins()
    //{
    //    coinText.text = "Crowns: " + Crown.crowns.ToString();
    //}
    void Update()
    {
        coinText.text = "Crowns: " + Crown.crowns.ToString();
        value = Crown.crowns;
    }

}
