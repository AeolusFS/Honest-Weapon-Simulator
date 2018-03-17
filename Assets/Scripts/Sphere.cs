using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	public float moveForce = 10f;
	public float jumpForce = 10f;
	public Transform groundCheckPosition;
	public float radius = 0.3f;
	public LayerMask LayerGround;

	private Rigidbody myBody;
	private bool isGrounded;
	private bool playerJumped = false;

	void Awake() {
		myBody = GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Called every 4th frame
	void FixedUpdate() {
		MoveSphere();
		PlayerGrounded();
		PlayerJump();
	}

	void MoveSphere() {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		//								x value     y		z
		myBody.AddForce (new Vector3(h * moveForce, 0f, v * moveForce));
	}

	void PlayerGrounded(){
		isGrounded = Physics.OverlapSphere (groundCheckPosition.position, radius, LayerGround).Length > 0;
		//Debug.Log ("Player Grounded" + isGrounded);
	}

	void PlayerJump(){
		if(Input.GetKey(KeyCode.Space) && isGrounded){
			myBody.AddForce (new Vector3(0, jumpForce, 0));
		}
	}
}
