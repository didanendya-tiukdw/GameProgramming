using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	Karakter player1;
	
	// Use this for initialization
	void Start () {
		player1 = new Karakter();
		player1.Name = "Ambon";
		player1.Health = 100;
		player1.Damage = 30;

		//tampilkan inisialisasi dari atrribute
		Debug.Log("Nama : "+ player1.Name + ", Health: "+ player1.Health + ", Damage: " +player1.Damage);

		//Panggil Method - Attack - Jump - MoveR - MoveL
		player1.Attack();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
