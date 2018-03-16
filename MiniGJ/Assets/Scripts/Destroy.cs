using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if(tag == "Player")
		{
			Destroy(gameObject);
		}
		
	}
}
