using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatControler : MonoBehaviour {


    public Text _text;
    public int Count = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Snake")
        {
            
            gameObject.transform.position = new Vector2(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f));
            Count++;
             _text.text = Count.ToString();
			other.GetComponent<PlayerControler>().AddTail();
            

        }

    }
}


