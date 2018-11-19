using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Контролер і поведінка гравця
/// </summary>
public class PlayerControler : MonoBehaviour
{
	public float speed;
	public float rotateSpeed;
	public float y_offset = 0.3f;

	public GameObject tailPref;

	[HideInInspector]
	public List<GameObject> tail = new List<GameObject>();

	void Start(){
		
		tail.Add(gameObject);
	}

    void Update()
    {
		transform.Translate (Vector3.up * speed * Time.deltaTime);

		if (Input.GetKey (KeyCode.W) & speed == 0.5f)
			speed += 0.3f;
		
		if (Input.GetKeyUp (KeyCode.W))
			speed = 0.5f;

		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.forward* -1 * rotateSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.A))
			transform.Rotate (Vector3.forward * rotateSpeed * Time.deltaTime);
    }

	public void AddTail(){

		Vector3 newXvostElem = tail [tail.Count - 1].transform.position;
		newXvostElem.y -= y_offset;
		tail.Add(GameObject.Instantiate(tailPref,newXvostElem,Quaternion.identity) as GameObject);
	
	}
		
   


}
