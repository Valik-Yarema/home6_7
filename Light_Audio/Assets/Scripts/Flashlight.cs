using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
    public Light Flight;
    public AudioClip soundOnOff;  
 


    // Use this for initialization
    void Start () {
        Flight.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F)) {
            Flight.enabled = !(Flight.enabled);
            GetComponent<AudioSource>().PlayOneShot(soundOnOff);
            } 
       
	}

   
}
