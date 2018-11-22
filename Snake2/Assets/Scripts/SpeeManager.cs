using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedManager : MonoBehaviour {
    public GameObject ScrollB;
    public GameObject player;
    public float Speed = 4;
    public float speed = 0;
   
	// Use this for initialization
	void Start ()
    {
        speed = ScrollB.GetComponent<Scrollbar>().value;
        if (speed <= 0.2)
        {
            Speed= ScrollB.GetComponent<Scrollbar>().value;



        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
