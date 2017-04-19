using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int playerHealth;
	
	// Use this for initialization
	void Start () {
		playerHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0) {
			Die();
		} 
	}
	
	void Die() {
		print("Dead");
	}
	
	void SubtractHealth(int damage) {

		playerHealth -= damage;
	}
}
