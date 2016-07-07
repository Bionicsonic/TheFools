using UnityEngine;
using System.Collections;

public class BetterThirdPerson : MonoBehaviour {

	public Transform target;
	public float speed = 5f;
	public float Distance = 7f;
	public float height = 5f;
	
	// Update is called once per frame
	void Update () {

		transform.LookAt(target);
		Vector3 displacementFromTarget = target.position - transform.position;
		Vector3 directionToTarget = displacementFromTarget.normalized;
		Vector3 velocity = directionToTarget * speed;
		
		float distanceToTarget = displacementFromTarget.magnitude;

		if (distanceToTarget > 5f){
			transform.Translate(velocity * Time.deltaTime);
		}
	}
}
