using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatArray : MonoBehaviour {

	//Deklarasi Array

	public int[] intArray;

	// Use this for initialization
	void Start () {
		
		/*
		intArray = new int[4];
		intArray[0] = 10;
		intArray[1] = 20;
		intArray[2] = 30;
		intArray[3] = 40;
		*/

		// tampilkan seluruh array		
		Debug.Log("Tampilkan Seluruh Array");
		foreach (int a in intArray)
		{
			Debug.Log(a);			
		} 

		//tampilkan array indeks tertentu
		Debug.Log("Nilai Indeks ke dua adalah : "+ intArray[2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
