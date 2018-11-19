using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour
{

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Snake"))
		{
				Application.LoadLevel(Application.loadedLevel);
		}

	}
}
