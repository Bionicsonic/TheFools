using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	public Transform target;
	private float scriptDelayAmount = 0.3f;
	
	// Update is called once per frame
	void Update () {
	transform.LookAt(target);
	}
}
