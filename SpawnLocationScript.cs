using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocationScript : MonoBehaviour {

	public GameObject Star;
	public Vector3 position;

	// Use this for initialization
	void Start () {
		int spawned = 0;
		while (spawned < 1) {
			spawned++;
			Vector3 position = new Vector3 (Random.Range (-8.5f, 8.5f), Random.Range (-6.0f, 6.0f), 0);
			Instantiate (Star, position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
