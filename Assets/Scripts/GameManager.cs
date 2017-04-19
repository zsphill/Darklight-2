using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public TileManager tileScript;
	public WaveManager waveScript;
	//public GameObject player;
	
	private int wave = 1;
	
	void Awake() {
		if (instance == null) {
			instance = this;
		} else {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		tileScript = GetComponent<TileManager>();
		waveScript = GetComponent<WaveManager>();
		InitGame();
	}
	
	void InitGame() {
		//player = Instantiate(player, new Vector2(24,24), Quaternion.identity) as GameObject;
		waveScript.setupWave(wave);
		tileScript.SetupScene(wave);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
