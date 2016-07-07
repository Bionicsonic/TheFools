using UnityEngine;
using System.Collections;

public class ThirdPersonAim : MonoBehaviour {

	public Transform target;
	public float distance = 7;
	public float height = 1f;
	public float rotateSpeed = 5;
	public float speed = 7f;
	Vector3 offset;

	private Transform _myTransform;

	// Use this for initialization
	void Start () {
		offset = target.transform.position - transform.position;
		if(target == null)
		Debug.LogWarning("No Target");
		_myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		target.transform.Rotate(0, horizontal, 0);
		
		Vector3 displacementFromTarget = target.position;
		Vector3 directionToTarget = displacementFromTarget.normalized;
		Vector3 velocity = directionToTarget * speed;
		float distanceToTarget = displacementFromTarget.magnitude;

		if (distanceToTarget > 7f){
			transform.Translate (velocity * Time.deltaTime);
		}
    }
}