using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WaveManager : MonoBehaviour {

	public GameObject[] enemies;
	private Transform enemyHolder;
	
	void waveSetup(int wave) {
		enemyHolder = new GameObject("Enemies").transform;
		GameObject toInstantiate;
		int enemyCount = (wave % 10 == 0) ? 100 : (wave % 10) * 10;
		for (int i = 0; i < enemyCount; i++) {
			toInstantiate = enemies[Random.Range(0,enemies.Length)];	
			GameObject enemyInstance = Instantiate(toInstantiate, new Vector2(Random.value*48, Random.value*48), Quaternion.identity) as GameObject;
			enemyInstance.transform.SetParent(enemyHolder);
		}
	}

	public void setupWave(int wave) {
		waveSetup(wave);
	}
}
