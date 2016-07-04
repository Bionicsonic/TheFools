using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

//[public] [Transform] = Choosable then [name of choice]
	public Transform target;

	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
