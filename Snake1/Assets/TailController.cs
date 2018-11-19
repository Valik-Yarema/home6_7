using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailController : MonoBehaviour {

	public float speed;
	public PlayerControler snake;
	public Vector3 targetXvostElement;
	public GameObject targetXvostObj;
	public float offset;

	private Vector3 targetPos;
	private Vector3 transformPos;
	private float angle;

	void Start(){

		snake = GameObject.FindGameObjectWithTag ("Snake").GetComponent<PlayerControler> ();
		targetXvostObj = snake.tail[snake.tail.Count-2];

	
	}
	
	// Update is called once per frame
	void Update () { 
		speed = snake.speed + 2f;

		targetXvostElement = targetXvostObj.transform.position;

		targetPos = targetXvostElement;
		transformPos = transform.position;

		targetPos.x = targetPos.x - transformPos.x;
		targetPos.y = targetPos.y - transformPos.y;

		angle = Mathf.Atan2 (targetPos.y, targetPos.x) * Mathf.Rad2Deg*2;

		transform.rotation = Quaternion.Euler (new Vector3(0, 0, angle + offset));
		transform.position = Vector3.Lerp (transform.position,targetXvostElement,Time.deltaTime*speed);
		
	}
}
