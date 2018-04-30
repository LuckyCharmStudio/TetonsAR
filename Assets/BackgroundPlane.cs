using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPlane : MonoBehaviour {
    public GameObject backgroundPlane;

	// Use this for initialization
	void Start () {
        backgroundPlane = GameObject.Find("ARCamera/BackgroundPlane");
        backgroundPlane.layer = 8;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
