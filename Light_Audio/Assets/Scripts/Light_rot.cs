using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Light_rot : MonoBehaviour {
    public GameObject Light;
    private Vector3 Vec =Vector3.zero;
   
    private bool pos=false;
    // Use this for initialization
	void Start () {
       
        Vec.y = 10.0f;
        Vec.z = -5.0f;
    }
	
	// Update is called once per frame
	void Update () {


        if(!pos)
        {
            Vec.x += 0.1f;
            if (Vec.x > 100.0f) { pos = true; }
        }
        if (pos)
        {
            Vec.x -= 0.1f;
            if (Vec.x < -3.0f) { pos = false; }
        }
        Light.transform.position=Vec ;
	}
}
