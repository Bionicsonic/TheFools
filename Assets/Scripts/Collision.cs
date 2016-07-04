using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	public float speed = 6;
	Vector3 velocity;

	Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;
	}

	void FixedUpdate() {
		myRigidbody.position += velocity * Time.deltaTime;
	}
}