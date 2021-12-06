using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomButton : MonoBehaviour
{

    public TextMeshProUGUI period;
    public string[] periods;
    public int score;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   //Pick random period when the button is clicked of the Array
    public void PickRandom()
    {
        string randomPeriod = periods[Random.Range(0, periods.Length)];
        period.text = randomPeriod;
    }
}
