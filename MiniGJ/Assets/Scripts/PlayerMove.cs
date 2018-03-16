﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector2.left * 4f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * 4f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.back * 4f * Time.deltaTime);
		}


	}

}
