using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour {

	public float Xsize = 8.0f;
	public float Ysize = 8.0f;
	public GameObject foodPref;
	public Vector3 Pos;
	public GameObject Food;
    public AudioClip sound;
    void AddNewFood()
	{
	RandomPos();
	Food = GameObject.Instantiate(foodPref,Pos,Quaternion.identity) as GameObject;
	}
	void RandomPos()
	{
    Pos = new Vector3(Random.Range(Xsize*-1,Xsize),0.25f,Random.Range(Ysize*-1,Ysize));
	}

	void Update()
	{
		if(!Food)
		{
            GetComponent<AudioSource>().PlayOneShot(sound);
            AddNewFood();
		}
		else
		{
			return;
		}
	}
}
