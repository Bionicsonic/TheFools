using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 6;
	public float gravity = 5;
	Vector3 velocity;

	void Update() {
		Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		Vector3 direction = input.normalized;
		Vector3 velocity = direction * speed;
		Vector3 moveAmount = velocity * Time.deltaTime;
		
		transform.position += moveAmount;


	}

}