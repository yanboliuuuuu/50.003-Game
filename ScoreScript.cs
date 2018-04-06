using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour {
	SpriteBehaviour player;
	public Text pointsText;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<SpriteBehaviour> ();
	}

	// Update is called once per frame
	void Update () {
		pointsText.text = "Star Count: " + player.points;
	}
}
