using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
		
	public Transform[] SpawnPoints;
	public float spawnTime = 0.01f;

	public GameObject Star;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnStar", spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnStar(){
		foreach (Transform SpawnPoint in SpawnPoints) {
			int spawnIndex = Random.Range(1,1);
			Instantiate (Star, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
		}
	}
}
