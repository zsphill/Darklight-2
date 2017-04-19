using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	public GameObject attack;
	public bool attacking;
	public GameObject enemy;
	public float enemyDistance;
	public float cooldown = 0.3f;
	
	// Use this for initialization
	void Start () {
		attacking = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("z")) {
			enemyDistance = Vector2.Distance(enemy.transform.position, transform.position);
			if (enemyDistance <= 2) {
				if (!attacking) {
					Invoke("ApplyDamage", 3);
					attacking = true;
				}
			}
		}
	}
	
	void ApplyDamage() {
		enemy.SendMessage("SubtractEnemeyHealth", SendMessageOptions.RequireReceiver);
		attacking = false;
	}
}
