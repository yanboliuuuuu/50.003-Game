using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitReaction : MonoBehaviour {

	private IEffect flasher;
	private SpriteBehaviour renderer;
	public int delay = 3;
	public int totalFlashes = 5;


	// Use this for initialization
	private void Start () {
		renderer = GetComponent<SpriteBehaviour> ();
		flasher = new Flasher (totalFlashes, delay);
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
		if (flasher.IsRunning) {
			flasher.Update ();
			renderer.enabled = flasher.IsVisible;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.collider.tag == "Spike") {
			flasher.Start ();
		}
	}
}
