using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	Karakter player2;
	// Use this for initialization
	void Start () {
		player2 = new Karakter();
		player2.Name = "Dino";
		player2.Health = 1000;
		player2.Damage = 300;

		//tampilkan inisialisasi dari atrribute
		Debug.Log("Nama : "+ player2.Name + ", Health: "+ player2.Health + ", Damage: " +player2.Damage);

		//Panggil Method - Attack - Jump - MoveR - MoveL
		player2.Attack();
		player2.Jump();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
