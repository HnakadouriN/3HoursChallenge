﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionExit(Collision other)
	{
        Destroy(other.gameObject);
	}
}
