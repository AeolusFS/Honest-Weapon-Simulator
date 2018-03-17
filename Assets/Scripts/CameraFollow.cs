using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform spherePos;

	private float zDistance = 10f;
	private float yDistance = 4f;

	void Awake() {
		spherePos = GameObject.Find("Sphere").transform;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x = spherePos.position.x;
		temp.y = spherePos.position.y + yDistance;
		temp.z = spherePos.position.z - zDistance;
		transform.position = temp;
	}
}
