﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != gameObject.tag)
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }

        
    }
}
