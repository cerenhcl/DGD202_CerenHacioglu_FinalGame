using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class GameManagerScript : MonoBehaviour
{
    public int Coin;

    public TextMeshProUGUI tm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tm.text = Coin.ToString();

    }
}
