﻿using UnityEngine;
using System.Collections;

public class LavaCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy (collision.gameObject);
	}
}
