using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TileManager : MonoBehaviour {
	
	[Serializable]
	public class Count {
		public int minimum;
		public int maximum;
            
		public Count (int min, int max) {
			minimum = min;
			maximum = max;
		}
	}
	
	public int rows = 48;
	public int columns = 48;
	public Count floorCount = new Count(230, 460);
	public GameObject stone;
	public GameObject leftWall;
	public GameObject rightWall;
	public GameObject topWall;
	public GameObject bottomWall;
	public GameObject topLeftWall;
	public GameObject topRightWall;
	public GameObject bottomLeftWall;
	public GameObject bottomRightWall;
	public GameObject[] floorTiles;
	
	private Transform boardHolder;
	private List <Vector2> gridPositions = new List<Vector2>();
	
	void InitializeList() {
		gridPositions.Clear();
		
		for (int x = 0; x < columns; x += 1) {
			for (int y = 0; y < rows; y += 1) {
				gridPositions.Add(new Vector2(x, y));
			}
		}
	}
	
	void BoardSetup() {
		boardHolder = new GameObject ("Board").transform;
		
		GameObject toInstantiate;
		GameObject tileToInstantiate;
		for (int x = -1; x < columns + 1; x += 1) {
			for (int y = -1; y < rows + 1; y += 1) {
				if (x == -1 && y == -1) {
					toInstantiate = bottomLeftWall;
				} else if (x == rows && y == -1) {
					toInstantiate = bottomRightWall;
				} else if (x == -1 && y == columns) {
					toInstantiate = topLeftWall;
				} else if (x == rows && y == columns) {
					toInstantiate = topRightWall;
				} else if (x == -1) {
					toInstantiate = leftWall;
				} else if (x == rows) {
					toInstantiate = rightWall;
				} else if (y == -1) {
					toInstantiate = bottomWall;
				} else if (y == columns) {
					toInstantiate = topWall;
				} else {
					toInstantiate = stone;				
					if (Random.value > 0.95) {
						tileToInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];
						GameObject tileInstance = Instantiate(tileToInstantiate, new Vector2 (x, y), Quaternion.identity) as GameObject;
						tileInstance.transform.SetParent(boardHolder);
					}
				}
				
				GameObject instance = Instantiate(toInstantiate, new Vector2 (x, y), Quaternion.identity) as GameObject;
				instance.transform.SetParent(boardHolder);
			}
		}
	}
	
	public void SetupScene(int wave) {
		BoardSetup();
		InitializeList();
	}
}
