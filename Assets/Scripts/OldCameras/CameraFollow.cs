using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

//[public] [Transform] = Choosable then [name of choice]
	public Transform targetTransform;
	public float speed = 5;

	// Update is called once per frame
	void Update () {
		Vector3 displacementFromTarget = targetTransform.position - transform.position;
		Vector3 directionToTarget = displacementFromTarget.normalized;
		Vector3 velocity = directionToTarget * speed;
		
		float distanceToTarget = displacementFromTarget.magnitude;

		if (distanceToTarget > 5f){
			transform.Translate (velocity * Time.deltaTime);
		}
	}
}