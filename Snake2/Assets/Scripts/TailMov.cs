using UnityEngine;
using System.Collections;

public class TailMov : MonoBehaviour {

	public float Speed;
	public Vector3 tailTarget;
	public int indx;
	public GameObject tailTargetObj;
	public SnakeMov Snake;
	void Start()
	{
		
		Snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<SnakeMov>();
		Speed = Snake.Speed+2f;
		tailTargetObj = Snake.tailObjects[Snake.tailObjects.Count-2];
		indx = Snake.tailObjects.IndexOf(gameObject);
	}
	void Update () {
	tailTarget = tailTargetObj.transform.position;
	transform.LookAt(tailTarget);
	transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
	}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Snake"))
		{
			if(indx > 2)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}

	}
	
}
