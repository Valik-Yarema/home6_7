using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
   
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Snake"))
        {
            
            other.GetComponent<SnakeMov>().AddTail();
			Destroy(gameObject);
           
        }
	}

}
