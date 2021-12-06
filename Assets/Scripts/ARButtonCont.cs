using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class ARButtonCont : MonoBehaviour, IVirtualButtonEventHandler
{

    public VirtualButtonBehaviour vButton;
     
    
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Regist the event
        vButton.RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Activate audiosource when car button is pressed
        audioSource.enabled = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Deactivate audiosource when car button is pressed
        audioSource.enabled = false;
    }

    
}
