using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {
    public GameObject soundS;
    public GameObject soundE;
    public GameObject ScrolBsound;
    public GameObject ScrolBefect;
    
    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
        soundS.GetComponent<AudioSource>().volume= ScrolBsound.GetComponent<Scrollbar>().value;
        soundE.GetComponent<AudioSource>().volume = ScrolBefect.GetComponent<Scrollbar>().value;
    }
}
