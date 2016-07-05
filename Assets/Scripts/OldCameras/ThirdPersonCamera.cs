using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	public Transform target;
	public float Distance = 7f;
	public float height = 1f;

	private Transform _myTransform;

// Just a notifier best to ignore
	void Start () {
		if(target == null)
			Debug.LogWarning("No Target");
		_myTransform = transform;
	}

	void Update () {
		_myTransform.position = new Vector3(target.position.x, target.position.y + height, target.position.z - Distance);
		_myTransform.LookAt(target);
	}
}
