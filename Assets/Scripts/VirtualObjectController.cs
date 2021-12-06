using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class VirtualObjectController : MonoBehaviour
{
    public TrackableBehaviour beh;
    public bool bTracked;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI periodText;
    public RandomButton randomButton;
  
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
            if (beh.CurrentStatus == TrackableBehaviour.Status.TRACKED && !bTracked)
            {
                //Checking if the text of the period and the tag of the card is Renaissance and if so, add 1 point to score and pick another period
               if(beh.gameObject.tag == "Renaissance" && periodText.text == "Renaissance")
               {
                bTracked = true;
                scoreText.text = "Score: " + randomButton.score++;
                randomButton.PickRandom();
                }
                //Checking if the text of the period and the tag of the card is French Revol. and if so, add 1 point to score and pick another period
            if (beh.gameObject.tag == "FrenchRev" && periodText.text == "French Revolution")
               {
                bTracked = true;
                scoreText.text = "Score: " + randomButton.score++;
                randomButton.PickRandom();
                }
                //Checking if the text of the period and the tag of the card is Egypt and if so, add 1 point to score and pick another period
            if (beh.gameObject.tag == "Egypt" && periodText.text == "Egypt")
               {
               bTracked = true;
               scoreText.text = "Score: " + randomButton.score++;
                randomButton.PickRandom();
                }
            }

            //if it is not tracked
            if (beh.CurrentStatus == TrackableBehaviour.Status.NO_POSE && bTracked)
                {
                    bTracked = false;
                    Debug.Log("No estoy siendo trackeado");
                }

        
    }
}

