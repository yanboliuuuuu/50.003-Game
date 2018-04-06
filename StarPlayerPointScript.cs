using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPlayerPointScript : MonoBehaviour {
	SpriteBehaviour player;
	//private int point = 1;
	//public bool mapHaveStar = false;
	float rotSpeed = 60;

	public Vector3 position;
	void Start () {
		player = FindObjectOfType<SpriteBehaviour> ();	
	}

	void Update(){
		transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
	}

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("Player")) {
			Debug.Log ("collide with star");
			player.points += 2;
			//mapHaveStar = false;
			Destroy (gameObject);
		}
	}
}

