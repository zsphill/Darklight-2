using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public GameObject player;
	public float speed = 2f;
	public float playerDistance;
	public bool attacking;
	public int health;
	public int damage;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		attacking = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed*Time.deltaTime);
		
		playerDistance = Vector2.Distance(player.transform.position, transform.position);
		if (playerDistance <= 2) {
			if (!attacking) {
				Invoke("ApplyDamage", 3);
				attacking = true;
			}
		}
		if (health <= 0) {
			Die();
		} 
	}
	
	void ApplyDamage() {
		player.SendMessage("SubtractHealth", damage, SendMessageOptions.RequireReceiver);
		attacking = false;
	}
	
	void Die() {
		print("EnDead");
	}
	void SubtractEnemyHealth() {

		health-=25;
	}
	
}
