using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {
	SpriteBehaviour player;
	StarPlayerPointScript star1;

	public Vector3 position;
	public float x;
	public float y;

	void Start () {
		//player = FindObjectOfType<SpriteBehaviour> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<SpriteBehaviour>();
		star1 = GameObject.FindGameObjectWithTag ("StarPlayer").GetComponent<StarPlayerPointScript> ();
	}

	public void Respawn(){
		//x = GameObject.FindGameObjectWithTag ("Player").transform.position.x + 0.1f;
		//y = GameObject.FindGameObjectWithTag ("Player").transform.position.y + 0.1f;
		//position = new Vector3 (x, y, 0);
		position = new Vector3 (Random.Range (-2.5f, 7.0f), Random.Range (-5.8f, 5.8f), 0);
		Instantiate (star1,position, Quaternion.identity);
	}

	public void OnCollisionEnter2D(Collision2D hit){
		if (hit.collider.tag == "Player") {
			Debug.Log ("collide with spike");
//			StartCoroutine (player.Knockback (0.02f, 350, player.transform.position));
			player.GetComponent<Animation>().Play("P1_RedFlash");

			if (player.points >= 2) {
				player.points -= 2;
				Respawn ();
			} else if (player.points == 1) {
				player.points -= 1;
				Respawn ();
			}
		}
	}
}
