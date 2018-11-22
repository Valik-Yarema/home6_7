using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordSave : MonoBehaviour {

    // Use this for initialization
    public GameObject recordSlider;
    public GameObject player;
   
    private int zmin=0;
	void Start ()
    {
        zmin = PlayerPrefs.GetInt("Record");
    
    }
	
	// Update is called once per frame
	void Update () {
        recordSlider.GetComponent<Slider>().value = (float)(player.GetComponent<SnakeMov>().score) / (float)(zmin);
    }
}
