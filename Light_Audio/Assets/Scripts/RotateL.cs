using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateL : MonoBehaviour {

    public GameObject GObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GObject.transform.Rotate(new Vector3(0, 1, 0));
	}
}
