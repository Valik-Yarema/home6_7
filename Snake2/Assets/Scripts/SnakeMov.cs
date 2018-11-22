using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class SnakeMov : MonoBehaviour {

   
    public float minSpeed;
    public float maxSpeed;
    public float Speed = 4;
    public float RotationSpeed;
    
    public GameObject speedBur;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;

	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
    public int Record;

	void Start () {
	tailObjects.Add(gameObject);
        //     speedchek = speedBur.GetComponent<Scrollbar>().value;
        Speed = Speed_res();
        Record = PlayerPrefs.GetInt("Record");
       
    }

   
    void Update ()
    {
        

    ScoreText.text = score.ToString();
		transform.Translate(Vector3.forward* Speed_res() * Time.deltaTime);
       
        
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up*RotationSpeed*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.up*-1*RotationSpeed*Time.deltaTime);
		}
	}
	public void AddTail()
	{	score++;
        if (score > Record)
        {
            PlayerPrefs.SetInt("Record", score);
            PlayerPrefs.Save();
        }
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
    public float Speed_res()
    {
        float S2 = 0;

        S2 = minSpeed + (maxSpeed - minSpeed) * speedBur.GetComponent<Scrollbar>().value;
        return S2;
    }

}
