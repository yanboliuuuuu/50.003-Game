using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteBehaviour : MonoBehaviour {
	public Rigidbody2D rb;
	public Animator anim;

	public float XSpeed;
	public float YSpeed;
	public float dashDuration;
	public float dashStatus = 0;
	public float jumpStatus;
	public int directionStatus;
	public int facingStatus;
	public bool facingRight;

	public int points = 0;
	SpikeScript spike;
	StarPointScript star;

	void Constructor(){

	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		spike = GameObject.FindGameObjectWithTag ("Spike").GetComponent<SpikeScript> ();
		star = GameObject.FindGameObjectWithTag ("Star").GetComponent<StarPointScript> ();
		anim = GetComponent<Animator> ();
		facingRight = true;
	}

	void Update () {
		rb.freezeRotation = true;
	}

	void FixedUpdate(){
		AnimPlayer (facingStatus);
		Flip ();

		if (dashDuration > 0.07 && dashStatus == 1){
			dashDuration = 0;
			dashStatus = 0;
			SetVelocityZero ();
		}
		if (dashStatus == 1) {
			dashDuration += Time.deltaTime;
		}

		rb.velocity = new Vector2 (XSpeed, rb.velocity.y);
	}

	void AnimPlayer(float playerSpeed){
		if (playerSpeed == 0 && rb.velocity.y == 0) {
			anim.SetFloat ("Speed", 0);
			anim.SetFloat ("NoJump", 1);
		}
		if (playerSpeed != 0 && rb.velocity.y == 0) {
			anim.SetFloat ("Speed", 1);
			anim.SetFloat ("NoJump", 1);
		}
		if (rb.velocity.y > 0) {
			anim.SetFloat ("Jump", 1);
			anim.SetFloat ("NoJump", 0);

		}
		if (rb.velocity.y < 0) {
			anim.SetFloat ("Jump", 0);
		}
	}

	void Flip(){
		if (!facingRight && XSpeed > 0 || facingRight && XSpeed < 0){
			facingRight = !facingRight;

			Vector3 temp = transform.localScale;
			temp.x *= -1;
			transform.localScale = temp;
		}
	}

	public void MoveLeft(){
		XSpeed = -5f;
		YSpeed = 0;
		directionStatus = -1;
		facingStatus = -1;
	}

	public void MoveRight(){
		XSpeed = 5f;
		YSpeed = 0;
		directionStatus = 1;
		facingStatus = 1;
	}

	public void SetVelocityZero(){
		XSpeed = 0;
		YSpeed = 0;
		facingStatus = 0;
	}

	public void Dash(){
		if (dashStatus == 1) {
			dashStatus = 0;
		}

		if (directionStatus == 1 && dashStatus == 0) {
			directionStatus = 0;
			XSpeed = 5f * 6;
			YSpeed = 0;
			dashStatus = 1;
			dashDuration += Time.deltaTime;
		}
		else if (directionStatus == -1 && dashStatus == 0) {
			directionStatus= 0;
			XSpeed = -5f * 6;
			YSpeed = 0;
			dashStatus = 1;
			dashDuration += Time.deltaTime;
		}
	}

	public void Jump(){
		if (rb.velocity.y == 0) {
			YSpeed = 9;
			rb.velocity = new Vector2 (rb.velocity.x, YSpeed);
			jumpStatus = 1;
		}
	}

	public void setVelocity(){
		rb.velocity = new Vector2 (0,0);
	}

	public float getVelocity(){
		return rb.velocity.y;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "Platform") {
			jumpStatus = 0;
		}
	}


//	void OnCollisionEnter2D(Collision2D col){
//		if (col.gameObject.tag == "Star") {
//			Debug.Log ("Hit");
//			Destroy (col.gameObject);
////			starCount = starCount + 1;
// 		}

//	}

	public IEnumerator Knockback(float kbDuration,float kbPower,Vector3 kbDirection){
		float timer = 0;

		while (kbDuration > timer) {
			timer += Time.deltaTime;
			rb.AddForce (new Vector3 (kbDirection.x * -150, kbDirection.y * kbPower, transform.position.z));
		}
		yield return 0;
	}
		
}
	



