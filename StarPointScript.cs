using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StarPointScript : MonoBehaviour {
	SpriteBehaviour player;
//	public int point = 1;
	public static bool haveStar = false;
	public Object star;
//	public GameObject spawnedStar;

	public Vector3 position;
	float rotSpeed = 60; // degrees per second

	public void Construct(Object Star){
		star = Star;
	}

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<SpriteBehaviour> ();
		star = GameObject.FindGameObjectWithTag ("Star");
//		spawnedStar = GameObject.FindWithTag ("Star");
//		Debug.Log (spawnedStar.GetType ());

	}

	void Update(){
		if (haveStar == false) {
			star = Spawn();

		}
		transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
//		Debug.Log (haveStar);
//		var spawnedStar = GameObject.FindWithTag ("Star");
//		var prefabOfTheSpawnedStar = PrefabUtility.GetPrefabParent (spawnedStar);
//		var starPrefab = Resources.Load ("Tests/star");

		//Debug.Log (starPrefab.GetType ());
	}

	Object Spawn(){
//		if (haveStar == false) {
		Object starInstance;
		haveStar = true;
		position = new Vector3 (Random.Range (-8.5f, 12.5f), Random.Range (-1f, 4.5f), 0);
		starInstance = Instantiate (gameObject, position, Quaternion.identity) as GameObject;
		return starInstance;
//		}
//		return null;
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Player")){
			player.points += 1;

			haveStar = false;
//			Spawn ();
//			Destroy (star);
			Destroy (gameObject);

		}
//		if (hit.CompareTag ("Platform")) {
//			haveStar = false;
//			Destroy (gameObject);
//
//			Debug.Log ("HIT PLATFORM");
//		}

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "Platform") {
			haveStar = false;
			Destroy (gameObject);

			Debug.Log ("HIT PLATFORM");
		}
	}
}