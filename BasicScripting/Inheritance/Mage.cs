using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Manusia
{

	// Use this for initialization
	void Start () {
		Debug.Log("Seorang Mage dapat : ");
		Makan();
		Tidur();
		Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Magic()
	{
		Debug.Log("Magic");
	}
}
