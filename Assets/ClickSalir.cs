﻿using UnityEngine;
using System.Collections;

public class ClickSalir : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		Application.Quit();	
	}
}
