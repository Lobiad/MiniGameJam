using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocSpawner : MonoBehaviour {

	public Transform[] spawnpoints;
	public GameObject blocPrefab;
	void Start()
	{
		int randomIndex = Random.Range(0, spawnpoints.Length);

		for (int i = 0; i < spawnpoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blocPrefab, spawnpoints[i].position, Quaternion.identity);
			}
		}
	}
}
